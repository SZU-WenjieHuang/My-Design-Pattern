//-------------------------------------------------------------------------------------
//	CommandExample1.cs
//-------------------------------------------------------------------------------------

//This real-world code demonstrates the Command pattern used in a simple calculator with unlimited number of undo's and redo's.
//Note that in C#  the word 'operator' is a keyword. Prefixing it with '@' allows using it as an identifier.

using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CommandExample1
{
    // 一个具体的例子模拟用户输入
    public class CommandExample1 : MonoBehaviour
    {
	    void Start ( )
        {
            // Create user and let her compute
            User user = new User();

            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);
        }
    }

    /// <summary>
    /// The 'Command' abstract class  Command的抽象类，分成Execute() 和 UnExecute()
    /// </summary>
    abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }

    /// <summary>
    /// The 'ConcreteCommand' class
    /// 定义Caculate的命令类
    /// </summary>
    class CalculatorCommand : Command
    {
        private char _operator;
        private int _operand;
        private Calculator _calculator;

        // Constructor
        public CalculatorCommand(Calculator calculator,
          char @operator, int operand)
        {
            this._calculator = calculator;
            this._operator = @operator;
            this._operand = operand;
        }

        // Gets operator
        public char Operator
        {
            set { _operator = value; }
        }

        // Get operand
        public int Operand
        {
            set { _operand = value; }
        }

        // Execute new command
        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        // Unexecute last command
        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        // Returns opposite operator for given operator
        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default:
                    throw new
            ArgumentException("@operator");
            }
        }
    }

    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    class Calculator
    {
        private int _curr = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': _curr += operand; break;
                case '-': _curr -= operand; break;
                case '*': _curr *= operand; break;
                case '/': _curr /= operand; break;
            }
            Debug.Log("Current value = " + _curr+ " ( following "+ @operator+operand+" )");
        }
    }

    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    class User
    {
        // Initializers
        private Calculator _calculator = new Calculator();
        private List<Command> _commands = new List<Command>();  // 用于记录命令的列表
        private int _current = 0;

        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    Command command = _commands[_current++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Debug.Log("\n---- Undo "+ levels + " levels");
            // Perform undo operations
            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    Command command = _commands[--_current] as Command;
                    command.UnExecute();
                }
            }
        }

        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            Command command = new CalculatorCommand(
              _calculator, @operator, operand);
            command.Execute();

            // Add command to undo list
            _commands.Add(command);
            _current++;
        }
    }
}

// 通篇读完，精妙绝伦，谢谢浅墨大佬

/*
这段代码是一个实现了命令模式（Command Pattern）的示例，它用于实现一个简单的计算器应用。在这个应用中，用户的每一个操作（如加、减、乘、除）都被包装成一个命令对象，并且可以被撤销和重做。

这段代码中的主要类和它们的作用如下：

Calculator：这是一个执行操作的类，也被称为接收者类（Receiver）。它提供了一个Operation方法，该方法根据输入的操作符和操作数执行相应的操作。

Command：这是一个命令的抽象类，它定义了所有命令必须实现的接口，包括Execute和UnExecute方法。Execute方法用于执行命令，UnExecute方法用于撤销命令。

CalculatorCommand：这是Command类的一个具体实现，它包装了一个计算器操作。它的Execute方法调用Calculator的Operation方法来执行操作，而它的UnExecute方法则执行相反的操作以撤销之前的操作。

User：这是一个调用者类（Invoker），它维护了一个命令的列表，并提供了Undo和Redo方法来撤销和重做命令。它还提供了一个Compute方法，该方法创建一个新的CalculatorCommand，执行它，并将它添加到命令列表中。

CommandExample1：这是一个使用了上述所有类的示例类。它创建一个User对象，然后调用其Compute方法来执行一系列的计算器操作。然后，它调用Undo和Redo方法来撤销和重做这些操作。
*/