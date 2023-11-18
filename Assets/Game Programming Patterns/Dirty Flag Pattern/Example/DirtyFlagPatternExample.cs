//-------------------------------------------------------------------------------------
//	DirtyFlagPatternExample.cs
//-------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;
using System;

namespace DirtyFlagPatternExample
{
    public class DirtyFlagPatternExample : MonoBehaviour
    {
        GraphNode graphNode = new GraphNode(new MeshEX());
        TransformEX parentWorldTransform = new TransformEX();
        void Start()
        {
            //初始化子节点
            for (int i = 0; i < graphNode.NumChildren; i++)
            {
                graphNode.Children[i] = new GraphNode(new MeshEX());
            }
            //进行渲染
            graphNode.render(TransformEX.origin, true);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                //修改位置,触发脏标记
                TransformEX newLocalTransform = new TransformEX();
                newLocalTransform.Position = new Vector3(2, 2, 2);
                graphNode.setTransform(newLocalTransform);

                //再次进行渲染
                graphNode.render(parentWorldTransform, false);
            }
        }
    }

    /// <summary>
    /// 网格类
    /// </summary>
    class MeshEX
    {

    }

    /// <summary>
    /// 位置类
    /// </summary>
    class TransformEX
    {
        private Vector3 position = new Vector3(1, 1, 1);
        public Vector3 Position
        {
            get { return position; }
            set { position = value; }
        }

        public static TransformEX origin = new TransformEX();

        public TransformEX combine(TransformEX other)
        {

            TransformEX trans = new TransformEX();
            if (other != null)
            {
                trans.Position = Position + other.Position;
            }
            return trans;
        }

    };

    /// <summary>
    /// 场景图节点
    /// </summary>
    class GraphNode
    {
        //脏标记 dirty flag
        private bool dirty_;

        private MeshEX mesh_;
        private TransformEX local_;
        private TransformEX world_ = new TransformEX();
        const int MAX_CHILDREN = 100;

        /// <summary>
        /// 子节点
        /// </summary>
        private GraphNode[] children_ = new GraphNode[MAX_CHILDREN];
        public GraphNode[] Children
        {
            get { return children_; }
            set { children_ = value; }
        }

        /// <summary>
        /// 子节点
        /// </summary>
        private int numChildren_ = 88;
        public int NumChildren
        {
            get { return numChildren_; }
            set { numChildren_ = value; }
        }

        public GraphNode(MeshEX mesh)
        {
            mesh_ = mesh;
            local_ = TransformEX.origin;
            dirty_ = true;

        }

        /// <summary>
        /// 设置局部坐标位置
        /// </summary>
        public void setTransform(TransformEX local)
        {
            local_ = local;
            dirty_ = true;
        }

        /// <summary>
        /// 渲染
        /// </summary>
        public void render(TransformEX parentWorld, bool dirty)
        {
            //如果父链中它之上的任何物体标记为脏，则它将被置为true
            dirty |= dirty_;

            //而当节点没有改动时（dirty=false），跳过combine的过程，否则，表示此链为脏，进行combine
            if (dirty)
            {
                //Debug.Log("this node is dirty,combine it!");
                world_ = local_.combine(parentWorld);
                dirty_ = false;
            }
            else
            {
                Debug.Log("this node is not dirty, dont need combine it!");
            }

            //渲染mesh
            if (mesh_ != null)
            {
                renderMesh(mesh_, world_);
            }

            for (int i = 0; i < numChildren_; i++)
            {
                if (children_[i] != null)
                {
                    children_[i].render(world_, dirty);
                }

            }
        }

        /// <summary>
        /// 网格的渲染
        /// </summary>
        private void renderMesh(MeshEX mesh_, TransformEX world_)
        {
            Debug.Log("renderMesh!");
        }
    }

}
/*
 * 这段代码是在 Unity 中使用 "Dirty Flag" 模式实现的一个场景图节点渲染的例子。主要包含了以下几个部分：

DirtyFlagPatternExample 是主类，它在 Start 和 Update 中调用 render 方法来渲染场景图。

MeshEX 是一个空类，代表一个场景图节点可以包含的网格对象。

TransformEX 是一个包含位置（Position）的类，它有一个 combine 方法，可以将自身的位置和另一个 TransformEX 对象的位置相加。

GraphNode 是一个场景图节点类，它包含一个 MeshEX 对象、一个 local_ 变换、一组子节点以及一个 dirty_ 标志。它的 render 方法是主要的渲染函数，如果 dirty_ 或父节点传递下来的 dirty 参数为 true，则会计算 world_ 变换并重置 dirty_ 标志，然后渲染网格并递归渲染所有子节点。

该代码的主要工作流程如下：

在 Start 方法中，首先初始化场景图节点以及它的子节点，然后调用 render 方法进行渲染。

在 Update 方法中，如果按下数字键1（KeyCode.Alpha1），则改变场景图节点的位置，触发 "dirty" 标志，并再次调用 render 方法。
*/

// 这个demo不是很好，因为我们传入的是true，所以所有的都会被标记为dirty
// graphNode.render(TransformEX.origin, true);。在这里，dirty 参数被设置为 true。这意味着渲染场景图的根节点时，无论根节点的 dirty_ 的值是多少，dirty 参数的值都会被设置为 true，导致根节点及其所有子节点的 dirty 都是 true。

