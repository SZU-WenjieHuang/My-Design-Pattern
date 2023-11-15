//-------------------------------------------------------------------------------------
//	StatePatternExample5.cs
//
//-------------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePatternExample5
{

    public class StatePatternExample5 : MonoBehaviour
    {
        void Start()
        {
            UnitTest();
        }

        void UnitTest()
        {
            Context theContext = new Context();
            theContext.SetState(new ConcreteStateA(theContext));
            theContext.Request(5);
            theContext.Request(15);
            theContext.Request(25);
            theContext.Request(35);

        }
    }

    /// <summary>
    /// Context类-持有目前的状态,并将相关信息传给状态
    /// </summary>
    public class Context
    {
        State m_State = null;

        public void Request(int Value)
        {
            m_State.Handle(Value);
        }

        public void SetState(State theState)
        {
            Debug.Log("Context.SetState:" + theState);
            m_State = theState;
        }
    }

    /// <summary>
    /// 状态的抽象基类
    /// </summary>
    public abstract class State
    {
        protected Context m_Context = null;

        public State(Context theContext)
        {
            m_Context = theContext;
        }
        public abstract void Handle(int Value);
    }

    /// <summary>
    /// 状态A
    /// </summary>
    public class ConcreteStateA : State
    {
        public ConcreteStateA(Context theContext) : base(theContext)
        { }

        public override void Handle(int Value)
        {
            Debug.Log("ConcreteStateA.Handle");
            if (Value > 10)
                m_Context.SetState(new ConcreteStateB(m_Context));
        }

    }

    /// <summary>
    /// 状态B
    /// </summary>
    public class ConcreteStateB : State
    {
        public ConcreteStateB(Context theContext) : base(theContext)
        { }

        public override void Handle(int Value)
        {
            Debug.Log("ConcreteStateB.Handle");
            if (Value > 20)
                m_Context.SetState(new ConcreteStateC(m_Context));
        }

    }

    /// <summary>
    /// 状态C
    /// </summary>
    public class ConcreteStateC : State
    {
        public ConcreteStateC(Context theContext) : base(theContext)
        { }

        public override void Handle(int Value)
        {
            Debug.Log("ConcreteStateC.Handle");
            if (Value > 30)
                m_Context.SetState(new ConcreteStateA(m_Context));
        }
    }
}

/*
 这段代码也实现了一个状态模式,主要包含以下几点:

Context类维护当前状态,并根据状态处理请求。

State抽象类定义了状态的基类。

ConcreteStateA、B、C三个具体状态类,继承自State。

每个状态类实现了Handle方法,包含状态转移判断逻辑。

Context的SetState方法用于设置当前状态。

运行流程:

初始化Context,设置初始状态为ConcreteStateA。

Context的Request方法会调用当前状态的Handle处理请求。

在Handle里判断状态转移条件,如果满足则设置Context新的状态。

这样当状态变化时,Context会基于新的状态处理请求。
*/


