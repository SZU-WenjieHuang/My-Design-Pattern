![](Media/repo-cover.jpg)

# Design Patterns Written in Unity3D
This repository is about cool design patterns written in Unity3D C#. 
* Now 23 [Gang of Four Patterns] have all been finished in Unity3D in this repository.
* Each pattern contains the corresponding structure implementations, application examples and diagrams. Same way with [Naphier/unity-design-patterns], in this repository each pattern is contained in a separate folder. Inside these are a folder ("Structure") to show what classes are used in the pattern's structure in Unity3D(with a scene) and a folder or folders ("Example") showing one or more real-world example of using the pattern in Unity3D along with a scene showing it in action. Each pattern folder may contain one or more Example.
* Game design patterns from book [Game Programming Patterns] have been partially implemented.

此repo为Unity3D中各种设计模式的实践与运用。
* 目前已经在Unity中实现了《[设计模式:可复用面向对象软件的基础]》一书中提出的23种设计模式。
* 每种模式都包含对应的结构实现、应用示例以及图示介绍。类似[Naphier/unity-design-patterns]的结构，此repo中的每种模式用单独的文件夹分开。每种模式对应的文件夹中包含了名为“Structure”的子文件夹，里面存放的是此模式在Unity中的使用代码的基本框架实现，而另外包含的Example子文件夹中存放的是此模式在Unity中使用的实际示例。每种框架实现或实例示例实现都包含对应的场景，每种模式文件夹中可能包含一个或者多个Example。
* 《[游戏编程模式]》一书中介绍的常用游戏设计模式的Unity版实现也有部分实现。

这一个markdown也会记录我自己对于设计模式的认知和笔记，希望能有帮助:)

# Contents
## I、Gang of Four Patterns in Unity （23种GOF设计模式的Unity实现）
### Behavioral Patterns 行为型模式
* [Command Pattern 命令模式]
* [State Pattern 状态模式]
* [Observer Pattern 观察者模式]
* [Chain of Responsibility Pattern 责任链模式]
* [Mediator Pattern 中介者模式]
* [Interpreter Pattern 解释器模式]
* [Iterator Pattern 迭代器模式]
* [Memento Pattern 备忘录模式]
* [Strategy Pattern 策略模式]
* [Template Method Pattern 模板方法模式]
* [Visitor Pattern 访问者模式]


### Structural Patterns 结构型模式
* [Adapter Pattern 适配器模式]
* [Bridge Pattern 桥接模式]
* [Composite Pattern 组合模式]
* [Decorator Pattern 装饰模式]
* [Facade Pattern 外观模式]
* [Flyweight Pattern 享元模式]
* [Proxy Pattern 代理模式]


### Creational Patterns 创建型模式
* [Prototype Pattern 原型模式]
* [Singleton Pattern 单例模式]
* [Abstract Factory Pattern 抽象工厂模式]
* [Builder Pattern 建造者模式]
* [Factory Method Pattern 工厂方法模式]

<br> 

## II、Game Programming Patterns in Unity （《游戏编程模式》的Unity实现）
* [Subclass Sandbox Pattern 子类沙盒模式]
* [Type Object Pattern 类型对象模式]
* [Component Pattern 组件模式]
* [Event Queue Pattern 事件队列模式]
* [Game Loop Pattern 游戏循环模式]
* [Service Locator Pattern 服务定位器模式]
* [Data Locality Pattern 数据局部性模式]
* [Dirty Flag Pattern 脏标记模式]
* [Object Pool Pattern 对象池模式]
<br> 

# Reference resources(参考)

* http://gameprogrammingpatterns.com/
* https://www.youtube.com/playlist?list=PLF206E906175C7E07
* https://github.com/Naphier/unity-design-patterns
* http://www.dofactory.com/net/design-patterns
* https://sourcemaking.com/design_patterns
* http://www.habrador.com/tutorials/programming-patterns/
* [Gang of Four Patterns]
* [Head First Design Patterns]
* [设计模式与游戏完美开发]

[State Pattern 状态模式]:https://github.com/QianMo/Unity3D-Design-Patterns/tree/master/Assets/Behavioral%20Patterns/State%20Pattern
[Command Pattern 命令模式]: https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Behavioral%20Patterns/Command%20Pattern
[Observer Pattern 观察者模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Behavioral%20Patterns/Observer%20Pattern
[Chain of Responsibility Pattern 责任链模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Behavioral%20Patterns/Chain%20of%20Responsibility%20Pattern
[Mediator Pattern 中介者模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Behavioral%20Patterns/Mediator%20Pattern
[Interpreter Pattern 解释器模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Behavioral%20Patterns/Interpreter%20Pattern
[Iterator Pattern 迭代器模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Behavioral%20Patterns/Iterator%20Pattern
[Memento Pattern 备忘录模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Behavioral%20Patterns/Memento%20Pattern
[Strategy Pattern 策略模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Behavioral%20Patterns/Strategy%20Pattern
[Template Method Pattern 模板方法模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Behavioral%20Patterns/Template%20Method%20Pattern
[Visitor Pattern 访问者模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Behavioral%20Patterns/Visitor%20Pattern
[Adapter Pattern 适配器模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Structural%20Patterns/Adapter%20Pattern
[Bridge Pattern 桥接模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Structural%20Patterns/Bridge%20Pattern
[Composite Pattern 组合模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Structural%20Patterns/Composite%20Pattern
[Decorator Pattern 装饰模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Structural%20Patterns/Decorator%20Pattern
[Facade Pattern 外观模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Structural%20Patterns/Facade%20Pattern
[Flyweight Pattern 享元模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Structural%20Patterns/Flyweight%20Pattern
[Proxy Pattern 代理模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Structural%20Patterns/Proxy%20Pattern
[Abstract Factory Pattern 抽象工厂模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Creational%20Patterns/Abstract%20Factory%20Pattern
[Builder Pattern 建造者模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Creational%20Patterns/Builder%20Pattern
[Factory Method Pattern 工厂方法模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Creational%20Patterns/Factory%20Method%20Pattern
[Prototype Pattern 原型模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Creational%20Patterns/Prototype%20Pattern
[Singleton Pattern 单例模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Creational%20Patterns/Singleton%20Pattern

[Subclass Sandbox Pattern 子类沙盒模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Game%20Programming%20Patterns/SubclassSandbox%20Pattern
[Type Object Pattern 类型对象模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Game%20Programming%20Patterns/Type%20Object%20Pattern
[Component Pattern 组件模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Game%20Programming%20Patterns/Component%20Pattern
[Event Queue Pattern 事件队列模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Game%20Programming%20Patterns/Event%20Queue%20Pattern
[Game Loop Pattern 游戏循环模式]:https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Game%20Programming%20Patterns/Game%20Loop%20Pattern
[Service Locator Pattern 服务定位器模式]:
https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Game%20Programming%20Patterns/Service%20Locator%20Pattern
[Data Locality Pattern 数据局部性模式]:
https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Game%20Programming%20Patterns/Data%20Locality%20Pattern
[Dirty Flag Pattern 脏标记模式]:
https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Game%20Programming%20Patterns/Dirty%20Flag%20Pattern
[Object Pool Pattern 对象池模式]:
https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Game%20Programming%20Patterns/Object%20Pool%20Pattern



[Gang of Four Patterns]:https://www.amazon.com/Design-Patterns-Elements-Reusable-Object-Oriented/dp/0201633612/ref=sr_1_1?ie=UTF8&qid=1476338345&sr=8-1&keywords=design+patterns
[Game Programming Patterns]:http://gameprogrammingpatterns.com/
[设计模式:可复用面向对象软件的基础]:https://www.amazon.cn/%E8%AE%A1%E7%AE%97%E6%9C%BA%E7%A7%91%E5%AD%A6%E4%B8%9B%E4%B9%A6-%E8%AE%BE%E8%AE%A1%E6%A8%A1%E5%BC%8F-%E5%8F%AF%E5%A4%8D%E7%94%A8%E9%9D%A2%E5%90%91%E5%AF%B9%E8%B1%A1%E8%BD%AF%E4%BB%B6%E7%9A%84%E5%9F%BA%E7%A1%80-Erich-Gamma/dp/B001130JN8/ref=sr_1_1?ie=UTF8&qid=1476338390&sr=8-1&keywords=%E8%AE%BE%E8%AE%A1%E6%A8%A1%E5%BC%8F
[游戏编程模式]:http://gameprogrammingpatterns.com/
[Head First Design Patterns]:https://www.amazon.com/dp/0596007124//ref=cm_sw_su_dp?tag=nethta-20
[Naphier/unity-design-patterns]:https://github.com/Naphier/unity-design-patterns
[设计模式与游戏完美开发]:https://www.amazon.cn/dp/B01N9GO0ZC

# 游戏设计模式 Game Programming Patterns

## Base Knowledge

### Behaviour类与MonoBehaviour类
Behaviour是一个继承自Component的基础类，它是所有在GameObjects上附加的行为组件的基类。这个类本身不能被实例化，
但它提供了一些基础的功能和生命周期事件（例如启用和禁用行为）。

MonoBehaviour是继承自Behaviour的一个类，它添加了许多常用的生命周期事件（例如Start，Update，FixedUpdate等），
以及许多处理用户输入和协程的功能。在Unity中，大部分自定义的游戏脚本都应该继承自MonoBehaviour。

## Part1 - Design Patterns Revisited 重访设计模式

### 1-Command Patterns 命令模式

前置概念:第一公民函数

"第一公民函数"（First-class functions）是函数式编程的一个概念，它指的是在一个编程语言中，函数被当作一等公民（first-class citizens）。这意味着函数可以像其他任何数据类型一样被使用和操作，包括：

1-能够被赋值给变量或数据结构中的元素。</br>
2-能够作为参数传递给其他函数。</br>
3-能够作为函数的返回结果。</br>
4-在运行时能够创建和修改。</br>

例子如下:
```cpp
#include <iostream>

// 一个函数，接受两个int类型的参数
int add(int x, int y) {
    return x + y;
}

// 另一个函数，接受两个int和一个函数指针
int apply_func(int x, int y, int (*func)(int, int)) {
    return func(x, y);
}

int main() {
    // 调用函数，将add函数作为参数传递
    std::cout << apply_func(5, 7, add) << std::endl;  // 输出 12
    return 0;
}
```

***理解:***
命令模式将“请求”封装成对象，以便使用不同的请求、队列或者日志来参数化其他对象，
同时支持可撤消的操作。

优势在于: </br>

1-解耦 </br>
比如一些对按键输入的回调函数，我们在把Command 抽象成对象之后，可以把它与具体的按键解耦，
即这个按键的函数我们可以重新定义。同时，我们也可以进一步把命令的执行和使用者解耦。


2-支持撤销 / 重做 / 重放

***例子01 解耦***
01
```cpp
void InputHandler::handleInput()
{
  if (isPressed(BUTTON_X)) jump();
  else if (isPressed(BUTTON_Y)) fireGun();
  else if (isPressed(BUTTON_A)) swapWeapon();
  else if (isPressed(BUTTON_B)) lurchIneffectively();
}
```

02
```cpp
void InputHandler::handleInput()
{
  if (isPressed(BUTTON_X)) buttonX_->execute();
  else if (isPressed(BUTTON_Y)) buttonY_->execute();
  else if (isPressed(BUTTON_A)) buttonA_->execute();
  else if (isPressed(BUTTON_B)) buttonB_->execute();
}
```

在这里，有一个基类Command，然后子类XYAB，分别继承基类并实现自己的方法。
同时定义一个InputHandler类来管理这些Command的实例化指针。

```cpp
class InputHandler
{
public:
  void handleInput();

  // 绑定命令的方法……

private:
  Command* buttonX_;
  Command* buttonY_;
  Command* buttonA_;
  Command* buttonB_;
};

```

这样我们就能实现每个按键和具体命令实现之间的解耦。

03

```cpp
Command* InputHandler::handleInput()
{
  if (isPressed(BUTTON_X)) return buttonX_;
  if (isPressed(BUTTON_Y)) return buttonY_;
  if (isPressed(BUTTON_A)) return buttonA_;
  if (isPressed(BUTTON_B)) return buttonB_;

  // 没有按下任何按键，就什么也不做
  return NULL;
}
```

更进一步，要是希望把执行的角色和和执行时间与command解耦，我们也可以这样操作；命令与角色和
执行的时间分开。

```cpp
Command* command = inputHandler.handleInput();
if (command)
{
  command->execute(actor);
}
```

***例子02 撤销 重做 重放***

撤销与重做的精髓在于两点:</br>
1-将每一个命令都一次性实例化，并配有execute() 和 undo() 两个函数。</br>
2-将连续的命令用一个列表记录。</br>

```cpp
Command* handleInput()
{
  Unit* unit = getSelectedUnit();

  if (isPressed(BUTTON_UP)) {
    // 向上移动单位
    int destY = unit->y() - 1;
    return new MoveUnitCommand(unit, unit->x(), destY);
  }

  if (isPressed(BUTTON_DOWN)) {
    // 向下移动单位
    int destY = unit->y() + 1;
    return new MoveUnitCommand(unit, unit->x(), destY);
  }

  // 其他的移动……

  return NULL;
}
```

这里, 向上移动和向下移动这些command，每次触发时都会返回一个实例化之后的对象。

```cpp
class MoveUnitCommand : public Command
{
public:
  MoveUnitCommand(Unit* unit, int x, int y)
  : unit_(unit),
    xBefore_(0),
    yBefore_(0),
    x_(x),
    y_(y)
  {}

  virtual void execute()
  {
    // 保存移动之前的位置
    // 这样之后可以复原。

    xBefore_ = unit_->x();
    yBefore_ = unit_->y();

    unit_->moveTo(x_, y_);
  }

  virtual void undo()
  {
    unit_->moveTo(xBefore_, yBefore_);
  }

private:
  Unit* unit_;
  int xBefore_, yBefore_;
  int x_, y_;
};
```

这样子，执行的时候就调用execute(), 撤销的时候就调用undo(); 我们需要有一个列表，记录玩家的一系列命令；
这样就可以实现连续的重做和撤销。

回放的功能，其实就是用不同角度的camera，把某一时间段的一些列操作按照时间点重新回放了一遍。

### 2-Flyweight Pattern 享元模式

***理解:***

享元模式（Flyweight Pattern）是一种结构型设计模式，其主要目的是通过共享大量精细粒度的对象来减少应用程序的内存使用。这是通过将对象的内部状态（intrinsic state）和外部状态（extrinsic state）分离达成的。

在享元模式中：

内部状态是对象的固有属性，它不会随环境改变。例如，在字体渲染的例子中，字体的字符、大小、颜色等可以被视为内部状态。

外部状态是对象的变化属性，它可以随环境改变。例如，字体在文档中的位置就是一个外部状态。

享元模式通过共享包含相同内部状态的对象来减少内存使用。当需要一个对象时，享元工厂会检查是否已经有一个具有相同内部状态的对象存在。如果存在，就直接返回这个对象；否则，就创建一个新的对象。

在C#和其他支持引用语义的语言中，这种共享是通过使用对象的引用（或指针）实现的。因此，你可以说享元模式是通过创建一个对象，并在多个地方使用它的引用，来实现对象的共享。

享元模式的关键是如何将对象的状态分解为内部状态和外部状态，以便可以有效地共享具有相同内部状态的对象！

### 3-Observer Pattern 观察者模式

***理解***
在观察者模式中，被观察者（也被称为主题，Subject）确实会维护一个观察者（Observer）的列表。
当被观察者的状态发生改变时，它会遍历这些观察者并通知他们（通常是通过调用某个特定的方法，如update）。
这样，所有的观察者都可以得知被观察者的状态改变。

这种模式通常用于实现事件驱动的系统，它允许对象之间的松散耦合，
因为被观察者并不需要知道观察者的具体实现，它只需要知道观察者有一个可以被调用的update方法。

被观察者(Subject)可以用链表存储观察者, 也可以用列表，他们的区别如下:

内存分配：

链表：链表中的元素在内存中不是顺序存储的，而是通过指针连接在一起。
链表的优势在于，插入和删除元素是O(1)的操作，因为你只需要改变一些指针就可以了。

列表：列表中的元素在内存中是顺序存储的。这意味着列表在访问元素时速度更快，
因为它可以利用内存缓存。然而，插入和删除元素（尤其是在列表的中间）可能需要移动大量的元素，因此操作时间复杂度为O(n)。

访问元素：

链表：链表不支持随机访问，如果你想访问链表中的某个元素，你需要从头开始遍历链表，
直到找到你想要的元素。所以在链表中访问元素的时间复杂度是O(n)。

列表：列表支持随机访问，你可以直接通过索引在O(1)的时间内访问任何元素。

在观察者模式的上下文中，通常使用列表来存储观察者，因为一般而言，
我们关心的是能够快速地遍历和访问所有的观察者，而不是在列表中间插入或删除观察者。
然而，如果你的需求是频繁地在观察者列表中添加或删除观察者，链表可能会是一个更好的选择。

***补充知识，C#里的抽象类***
```cpp
/// 在C#里的interface，就相当于其他语言里的抽象类
interface IInvestor
{
    void Update(Stock stock);
}W

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
```
在C#里的interface，就相当于其他语言里的抽象类, 可以起到接口的作用，要是在cpp里，可以用纯虚函数和模板实现类似的接口功能；

纯虚函数
```cpp
class IObserver {
public:
  virtual void Update() = 0;
};
```

模板
```cpp
template<typename T>
using Observer = std::function<void(T)>;
```

### 4-Prototype Pattern 原型模式 

***理解***
原型模式是一种比较简单的模式，也非常容易理解，实现一个接口，重写一个方法即完成了原型模式。
在实际应用中，原型模式很少单独出现。经常与其他模式混用，
他的原型类Prototype也常用抽象类来替代。

***在JSON上的应用***
在JSON上的应用，一般是通过重复使用一些数据来实现:
```json
{
  "name": "goblin grunt",
  "minHealth": 20,
  "maxHealth": 30,
  "resists": ["cold", "poison"],
  "weaknesses": ["fire", "light"]
}

{
  "name": "goblin wizard",
  "prototype": "goblin grunt",
  "spells": ["fire ball", "lightning bolt"]
}

{
  "name": "goblin archer",
  "prototype": "goblin grunt",
  "attacks": ["short bow"]
}
```
像以上的，wizard和archer，都会以grunt作为原型。所以这样就能简化和抽象其逻辑。

