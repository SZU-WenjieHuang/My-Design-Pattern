//-------------------------------------------------------------------------------------
//	ObserverExample1.cs
//-------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//This real-world code demonstrates the Observer pattern in which registered investors are notified every time a stock changes value.

namespace ObserverExample1
{
    public class ObserverExample1 : MonoBehaviour
    {
        void Start()
        {
            // Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));      // 添加观察者
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

        }
    }

    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    abstract class Stock
    {
        private string _symbol;
        private double _price;
        private List<IInvestor> _investors = new List<IInvestor>();

        // Constructor
        public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        //逐个通知观察者
        public void Notify()
        {
            foreach (IInvestor investor in _investors)
            {
                investor.Update(this);
            }

            Debug.Log("Stock Notify( ) called");
        }

        // Gets or sets the price
        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        // Gets the symbol
        public string Symbol
        {
            get { return _symbol; }
        }
    }

    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    class IBM : Stock
    {
        // Constructor
        public IBM(string symbol, double price)
          : base(symbol, price)
        {
        }
    }

    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    /// 在C#里的interface，就相当于其他语言里的抽象类
    interface IInvestor
    {
        void Update(Stock stock);
    }

    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    class Investor : IInvestor
    {
        private string _name;
        private Stock _stock;

        // Constructor
        public Investor(string name)
        {
            this._name = name;
        }

        public void Update(Stock stock)
        {
            //Debug.Log("Notified {0} of {1}'s " +"change to {2:C}", _name, stock.Symbol, stock.Price);
            Debug.Log("Notified "+ _name+" of "+ stock+"'s " + "change to "+stock.Price);
        }

        // Gets or sets the stock
        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}

/*

这段代码实现了观察者设计模式,主要包含以下几个类:

Stock:抽象主题类,维护一个观察者列表,并定义添加、删除、通知观察者的接口。属性price和symbol。

IBM:具体主题类,继承自Stock类,实现了股价变化时通知观察者的功能。

IInvestor:抽象观察者接口,定义了更新接口。

Investor:具体观察者类,实现了IInvestor接口,在得到通知时将具体的更新操作打印出来。

主要的逻辑在Start函数中:

创建IBM股票对象并传入初始价格

添加两个投资者Sorros和Berkshire到IBM股票的观察者列表

改变IBM股票价格,这会触发通知机制,调用股票的Notify方法

Notify方法遍历观察者列表,调用每个投资者的Update方法

在Update方法中打印更新信息

这样当股票价格改变时,注册在其上的观察者都会得到通知并做出响应的操作。这实现了一个典型的观察者模式。

 */