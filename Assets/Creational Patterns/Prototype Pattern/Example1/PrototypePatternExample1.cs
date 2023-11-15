//-------------------------------------------------------------------------------------
//	PrototypePatternExample1.cs
//-------------------------------------------------------------------------------------

using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//This real-world code demonstrates the Prototype pattern in which new Color objects are created by copying pre-existing, user-defined Colors of the same type.

namespace PrototypePatternExample1
{
    public class PrototypePatternExample1 : MonoBehaviour
    {
        void Start()
        {
            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors
            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            // User clones selected colors
            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["peace"].Clone() as Color;
            Color color3 = colormanager["flame"].Clone() as Color;

        }
    }

    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }

    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>
    class Color : ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;

        // Constructor
        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        // Create a shallow copy
        public override ColorPrototype Clone()
        {
            Debug.Log("Cloning color RGB: (" + _red + " ," + _green + "," + _blue + ")");

            return this.MemberwiseClone() as ColorPrototype;
        }
    }

    /// <summary>
    /// Prototype manager
    /// </summary>
    class ColorManager
    {
        private Dictionary<string, ColorPrototype> _colors = new Dictionary<string, ColorPrototype>();

        // Indexer
        public ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}
/*
 * 这段代码实现了原型模式,主要包含以下类:

ColorPrototype:定义了克隆自身的接口Clone()。

Color:具体的原型类,实现了Clone()方法,实现了对自身的拷贝。

ColorManager:原型管理器,用于存储原型实例。

主要逻辑:

创建ColorManager,并初始化一些标准颜色原型对象,如红色、绿色、蓝色。

用户可以新增自定义颜色,如愤怒的红色、平静的绿色等。

用户可以通过ColorManager的indexer访问原型对象,并调用Clone()方法拷贝原型对象获取新的Color实例。

Color的Clone方法使用MemberwiseClone进行浅拷贝来复制自身并返回。

用户拷贝了红色、平静的绿色和火焰红原型,获得了3个新的Color实例。

这样通过原型模式复用了标准颜色和自定义颜色,避免了重复创建颜色对象,并且隐藏了复杂的创建逻辑。

主要优点是在运行时动态地获得对象,而不需要知道具体的类。并且可以避免重复创建对象。

这实现了原型模式的典型应用场景。
 */
