//-------------------------------------------------------------------------------------
//	FlyweightPatternExample1.cs
//-------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//This real-world code demonstrates the Flyweight pattern in which a relatively small number of Character objects is shared many times by a document that has potentially many characters.

namespace FlyweightPatternExample1
{
    public class FlyweightPatternExample1 : MonoBehaviour
    {
        void Start()
        {
            // Build a document with text
            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            // extrinsic state
            int pointSize = 10;

            // For each character use a flyweight object
            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }
        }
    }

    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    class CharacterFactory
    {
        private Dictionary<char, Character> _characters =
          new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            // Uses "lazy initialization"
            Character character = null;
            if (_characters.ContainsKey(key))
            {
                character = _characters[key];
            }
            else
            {
                switch (key)
                {
                    case 'A': character = new CharacterA(); break;
                    case 'B': character = new CharacterB(); break;
                    //...
                    case 'Z': character = new CharacterZ(); break;
                }
                _characters.Add(key, character);
            }
            return character;
        }
    }

    /// <summary>
    /// The 'Flyweight' abstract class
    /// </summary>
    abstract class Character
    {
        // 内部状态
        protected char symbol;
        protected int width;
        protected int height;
        protected int ascent;
        protected int descent;
        protected int pointSize;

        public abstract void Display(int pointSize);
    }

    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    class CharacterA : Character
    {
        // Constructor
        // 每个具体的实例对象，定义自己的内部状态，就是实例化之后的每一个A，都会共享这些内部状态
        public CharacterA()
        {
            this.symbol = 'A';
            this.height = 100;
            this.width = 120;
            this.ascent = 70;
            this.descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Debug.Log(this.symbol +
              " (pointsize " + this.pointSize + ")");
        }
    }

    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    class CharacterB : Character
    {
        // Constructor
        public CharacterB()
        {
            this.symbol = 'B';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Debug.Log(this.symbol +
              " (pointsize " + this.pointSize + ")");
        }

    }

    // ... C, D, E, etc.

    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    class CharacterZ : Character
    {
        // Constructor
        public CharacterZ()
        {
            this.symbol = 'Z';
            this.height = 100;
            this.width = 100;
            this.ascent = 68;
            this.descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Debug.Log(this.symbol + " (pointsize " + this.pointSize + ")");
        }
    }
}

/*
 * 这段代码是一个使用C#（在Unity环境中）实现的享元模式（Flyweight Pattern）的例子。

代码的主要构成部分是：

CharacterFactory（享元工厂）：这个类的作用是创建并管理Character对象。它使用一个字典（Dictionary）来存储已经创建的Character对象，其中字典的键是字符（char）类型，值是Character对象。当需要一个特定的Character对象时，它首先检查字典中是否已经存在这个对象。如果存在，就直接返回这个对象；否则，就创建一个新的对象，将其添加到字典中，然后返回。

Character（享元类）：这是一个抽象类，定义了一个接口，用于显示字符。它有一些字段（symbol, width, height, ascent, descent, pointSize）来存储字符的内部状态。

CharacterA, CharacterB, ... CharacterZ（具体享元类）：这些都是Character类的子类，每个类代表一个特定的字符。它们在构造函数中设置字符的内部状态，并实现了Display方法来显示字符。

在这个例子中，每个字符的字母（A, B, ..., Z）和各种尺寸参数（width, height, ascent, descent）是内部状态，它们是在对象构造时决定的，并且不会改变。而字体大小（pointSize）是外部状态，它是在调用Display方法时传入的。

在FlyweightPatternExample1类的Start方法中，它创建了一个CharacterFactory对象，并使用它来创建并显示文档中的所有字符。这里的文档是简单的字符串"AAZZBBZB"。每个字符的字体大小（pointSize）是递增的，从10开始。

总的来说，这个例子展示了如何使用享元模式来共享Character对象，以减少内存使用。在实际的文档渲染中，可能需要创建大量的Character对象，如果每个字符都有一个独立的对象，将会消耗大量的内存。而通过享元模式，我们只需要为每个不同的字符创建一个对象，然后通过改变字体大小（外部状态）来显示不同的字符，从而大大减少了内存使用。

*/