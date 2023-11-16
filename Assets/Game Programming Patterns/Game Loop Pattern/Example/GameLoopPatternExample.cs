//-------------------------------------------------------------------------------------
//	GameLoopPatternExample.cs
//-------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

/*
    这段代码实现了一个基本的游戏循环模式,主要内容包括:

    定义了一个固定的逻辑更新间隔时间MS_PER_UPDATE,通常会设置为大约16毫秒左右,对应60FPS。

    在循环中计算两帧之间的实际流逝时间elapsed。

    通过lag变量累积流逝时间,当lag达到或超过MS_PER_UPDATE时,执行一次逻辑更新Update()。

    每帧都执行渲染函数Render(),与逻辑更新脱钩。

    ProcessInput()处理输入消息。

    Update()执行游戏状态逻辑更新。

    用while(true)实现一个无限循环。

    这样可以使游戏内部的逻辑更新定时稳定执行,与图形渲染的帧率变化解耦合,防止帧率波动导致游戏速度异常。

    lag变量起到调节作用,在帧率不均时动态调整逻辑更新次数,来维持内部时间流逝的稳定。

    整体上实现了一个基本的游戏循环核心逻辑,适合不同的游戏开发需要。
 */

namespace GameLoopPatternExample
{

    public class GameLoopPatternExample : MonoBehaviour
    {
        GameLoopManager GameLoop = new GameLoopManager();

        void Start()
        {
            //进行游戏循环
            //DoGameLoop();
            Debug.Log("Unity已经内建了游戏循环模式，即Update( )，按《游戏编程模式》书中的原版实现会导致卡死。这边仅保留代码框架，不作调用。");
        }

        void Update()
        {

        }

        /// <summary>
        /// 进行游戏循环
        /// </summary>
        void DoGameLoop()
        {
            if (GameLoop==null)
            {
                GameLoop = new GameLoopManager();
            }

            GameLoop.DoGameLoop();
        }
    }


    /// <summary>
    /// 游戏循环manager
    /// </summary>
    public class GameLoopManager
    {

        /// <summary>
        /// 游戏更新的粒度 大概60fps
        /// </summary>
       public const float MS_PER_UPDATE = 0.06F;
       
        /// <summary>
        /// 进行游戏循环
        /// </summary>
       public  void DoGameLoop()
        {
            double previous = Time.realtimeSinceStartup;
            double lag = 0.0;
            if (Time.realtimeSinceStartup==0f)
            {
                return;
            }
            while (true)
            {
                //当前时间
                double current = Time.realtimeSinceStartup;
                //消逝的时间

                double elapsed = current - previous;
                previous = current;
                lag += elapsed;
                ProcessInput();

                //游戏逻辑与渲染解耦
                while (lag >= MS_PER_UPDATE)
                {
                    Update();
                    lag -= MS_PER_UPDATE;
                }

                Render();
            }
        }


        /// <summary>
        /// 处理按键消息
        /// </summary>
        void ProcessInput()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Debug.Log("[GameLoopManager]你按下了键盘1键！");
            }
        }

       /// <summary>
       /// 进行渲染
       /// </summary>
        void Render()
        {
            //do render
        }

        /// <summary>
        /// 处理更新
        /// </summary>
        void Update()
        {
            //do update
        }

    }



}
