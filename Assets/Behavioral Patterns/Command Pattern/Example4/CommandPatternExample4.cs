//-------------------------------------------------------------------------------------
//	CommandPatternExample4.cs
//-------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CommandPatternExample4
{
    public class CommandPatternExample4 : MonoBehaviour
    {
        void Start()
        {
            Invoker theInvoker = new Invoker();

            Command theCommand = null;

            // 结合命令与执行者
            theCommand = new ConcreteCommand1(new Receiver1(), "hi");
            theInvoker.AddCommand(theCommand);

            theCommand = new ConcreteCommand2(new Receiver2(), 666);
            theInvoker.AddCommand(theCommand);

            // 进行执行
            theInvoker.ExecuteCommand();
        }

    }


    /// <summary>
    /// 命令抽象类
    /// </summary>
    public abstract class Command
    {
        public abstract void Execute();
    }

    /// <summary>
    /// 实际命令1-绑定命令和receiver
    /// </summary>
    public class ConcreteCommand1 : Command
    {
        Receiver1 m_Receiver = null;
        string m_Command = "";

        public ConcreteCommand1(Receiver1 Receiver, string param)
        {
            m_Receiver = Receiver;
            m_Command = param;
        }

        public override void Execute()
        {
            m_Receiver.Action(m_Command);
        }
    }

    /// <summary>
    /// 实际命令2-绑定命令和receiver
    /// </summary>
    public class ConcreteCommand2 : Command
    {
        Receiver2 m_Receiver = null;
        int m_Param = 0;

        public ConcreteCommand2(Receiver2 Receiver, int Param)
        {
            m_Receiver = Receiver;
            m_Param = Param;
        }

        public override void Execute()
        {
            m_Receiver.Action(m_Param);
        }
    }

    /// <summary>
    /// 功能执行者1
    /// </summary>
    public class Receiver1
    {
        public Receiver1() { }
        public void Action(string param)
        {
            Debug.Log("Receiver1.Action:Command[" + param + "]");
        }
    }

    /// <summary>
    /// 功能执行者2
    /// </summary>
    public class Receiver2
    {
        public Receiver2() { }
        public void Action(int Param)
        {
            Debug.Log("Receiver2.Action:Param[" + Param.ToString() + "]");
        }
    }


    /// <summary>
    /// 命令管理者
    /// </summary>
    public class Invoker
    {
        List<Command> m_Commands = new List<Command>();

        // 加入命令
        public void AddCommand(Command theCommand)
        {
            m_Commands.Add(theCommand);
        }

        /// <summary>
        /// 执行命令
        /// </summary>
        public void ExecuteCommand()
        {
            // 执行
            foreach (Command theCommand in m_Commands)
                theCommand.Execute();
            // 清空 
            m_Commands.Clear();
        }
    }
}

/*
 *  这里的Command1 是由 Receiver1处理的， Command2 是由 Receiver2处理的
 
    这段代码是命令模式（Command Pattern）的一个实例，用于将请求者（Invoker）和接收者（Receiver）解耦。在这个示例中，每个操作（例如Receiver1的操作或Receiver2的操作）被封装为一个命令对象。然后，这些命令对象可以由Invoker执行。

    下面是这段代码中的主要类和它们的作用：

    Command：这是一个抽象类，代表一个命令。它有一个抽象方法Execute，需要在具体的命令类中实现。

    ConcreteCommand1 和 ConcreteCommand2：这些是Command的具体实现。每个命令类都有一个接收者（Receiver1或Receiver2）和一个参数，这个参数在执行命令时会传递给接收者。

    Receiver1 和 Receiver2：这些是执行命令的类。每个接收者类都有一个Action方法，这个方法会接收一个参数并对其执行操作。

    Invoker：这是一个调用者类。它有一个命令列表，并可以执行这些命令（通过调用ExecuteCommand方法）。新的命令可以通过AddCommand方法添加到命令列表中。

    CommandPatternExample4：这是一个使用上述所有类的示例类。在这个类的Start方法中，创建了一个调用者，然后创建了两个命令（每个命令都有一个接收者和一个参数），并将这些命令添加到调用者的命令列表中。最后，调用者执行了它的所有命令。
 */