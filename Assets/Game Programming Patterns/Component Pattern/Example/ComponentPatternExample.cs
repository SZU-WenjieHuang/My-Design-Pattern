//-------------------------------------------------------------------------------------
//	ComponentPatternExample.cs
//-------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace ComponentPatternExample
{

    public class ComponentPatternExample : MonoBehaviour
    {
        RPGGame rpgGame = new RPGGame();

        void Start()
        {
            rpgGame.Start();
        }

        void Update()
        {
            rpgGame.Update();
        }
    }

    /// <summary>
    /// 游戏类
    /// </summary>
    class RPGGame
    {
        public int velocity;
        public int x = 0, y = 0;

        //辅助类对象
        public WorldX worldX = new WorldX();
        public GraphicsX graphicsX = new GraphicsX();

        //组件
        private InputComponent inputComponent;
        private PhysicsComponent physicsComponent;
        private GraphicsComponent graphicsComponent;

        //组件List
        public List<BaseComponent> ComponentList = new List<BaseComponent>();
        //组件List容量
        int componentAmount = -1;

        public void Start()
        {
            inputComponent = new PlayerInputComponent();
            physicsComponent = new PlayerPhysicsComponent();
            graphicsComponent = new PlayerGraphicsComponent();

            ComponentList.Add(inputComponent);
            ComponentList.Add(physicsComponent);
            ComponentList.Add(graphicsComponent);

            Debug.Log("Game Components Initialization Finish...");
            Debug.Log("Please enter LeftArrow or RightArrow button to play...");
        }

        public void Update()
        {
            if (ComponentList == null)
            {
                return;
            }
            componentAmount = ComponentList.Count;
            for (int i = 0; i < componentAmount; i++)
            {
                ComponentList[i].Update(this);
            }
        }
    };

    /// <summary>
    /// 输入组件
    /// </summary>
    class PlayerInputComponent : InputComponent
    {
        public void Update(RPGGame game)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                game.velocity -= WALK_ACCELERATION;
                Debug.Log(" game velocity= " + game.velocity.ToString());
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                game.velocity += WALK_ACCELERATION;
                Debug.Log(" game velocity= " + game.velocity.ToString());
            }
        }

        private int WALK_ACCELERATION = 1;
    }


    /// <summary>
    /// 物理组件
    /// </summary>
    class PlayerPhysicsComponent : PhysicsComponent
    {
        public void Update(RPGGame game)
        {
            game.x += game.velocity;

            //Handle Physics...

        }
    }


    /// <summary>
    /// 图形组件
    /// </summary>
    class PlayerGraphicsComponent : GraphicsComponent
    {
        public void Update(RPGGame game)
        {
            //Handle Graphics...

            if (game == null || game.graphicsX == null)
            {
                return;
            }

            Sprite sprite = spriteStand;
            if (game.velocity < 0)
            {
                sprite = spriteWalkLeft;
            }
            else if (game.velocity > 0)
            {
                sprite = spriteWalkRight;
            }
            game.graphicsX.Draw(sprite, game.x, game.y);


        }

        private Sprite spriteStand;
        private Sprite spriteWalkLeft;
        private Sprite spriteWalkRight;
    }

    #region interfaces

    interface BaseComponent
    {
        void Update(RPGGame game);
    }

    interface GraphicsComponent : BaseComponent
    {
        new void Update(RPGGame game);
    }

    interface PhysicsComponent : BaseComponent
    {
        new void Update(RPGGame game);
    }

    interface InputComponent : BaseComponent
    {
        new void Update(RPGGame game);
    }

    #endregion

    #region 辅助类

    class WorldX
    {

    }

    class GraphicsX
    {
        public void Draw(Sprite sprite, float x, float y) { }
    }
}

# endregion

/*
    Component类是一个抽象基类,它定义了通用的Update接口方法。

    不同的Component类(如InputComponent、PhysicsComponent等)继承自BaseComponent,实现具体的游戏功能。

    每个具体的Component表示游戏对象的一个部分或功能模块。

    游戏类RPGGame包含一个Component列表,存储不同的组件对象。

    在游戏循环里,遍历所有组件并调用其Update方法,使每个组件更新自身的逻辑。

    thus,组件模式实现了高内聚、低耦合的模块化设计。

    游戏对象的不同功能区分开来,便于单独开发调试。

    可以动态组合不同的组件,构建出整体游戏行为。

    组件之间通过游戏类对象解耦合,不直接交互。
 */
