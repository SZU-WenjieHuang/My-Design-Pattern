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

***原型模式浅拷贝***
原型模式利用浅拷贝主要有以下几个目的:

1-性能考虑</br>
浅拷贝只复制值类型字段,对引用类型只拷贝引用,不拷贝对象本身。
这可以提高拷贝性能,节省时间和空间资源。深拷贝需要递归复制对象,当对象较大时,复制成本会很高。

2-共享对象状态</br>
很多时候,我们需要clone一个对象来改变其部分状态,但仍希望它共享原有对象的一些状态。
比如一个包含子对象的对象,我们希望clone后这个子对象实例不变。这就需要浅拷贝来实现。

3-避免修改原型状态</br>
如果使用深拷贝,那么修改克隆对象不会影响到原型对象。
但有时我们需要修改原型也能反映到克隆上,那么可以使用浅拷贝来实现这个目的。

### 5-Singleton Pattern 单例模式
单例模式，应该是被回避使用的；

```cpp
class RenderManager {

public:
  static RenderManager* GetInstance() {
    if (_instance == nullptr) {
      _instance = new RenderManager(); 
    }
    return _instance;
  }

private:
  static RenderManager* _instance;
  
  RenderManager() {
    // 构造函数 
  }
};

// 在cpp文件中初始化静态成员变量
RenderManager* RenderManager::_instance = nullptr; 
```

哪怕是在多线程情况下，C++11标准也保证了本地静态变量只会初始化一次。
这里是构造函数放在private，然后唯一的对象放在public；这种是懒汉式，没人用就不运行，
有人用就在在运行的时候实例化。

构造函数是private，和唯一实例是static选一个就好；</br>
构造函数private + 唯一实例非static / 构造函数public + 唯一实例static与定义的获取方法，这两个组合都能保证全局唯一实例。

***单例模式应该在游戏设计中被回避的理由***

1-单例会引入全局状态,增加代码之间的耦合。这会导致游戏中对象间的依赖关系更加复杂。

2-单例模式不利于测试。单例类难以模拟和存根,会使得测试过程更加困难。

3-单例会掩盖类之间的依赖关系。这使得调试和理解关系链更加困难。

4-单例会发生线程锁竞争。当多个线程同时访问单例时,需要加锁同步,可能导致性能问题。

5-在热重载系统中,单例会导致问题。热重载需要能完整卸载类,单例无法释放。

6-不利于开发者之间的协作。单例将全局状态局限于单一位置,开发者之间互相干扰的可能性加大。

7-单例难以扩展和维护。因为它承载了全局状态和责任,继承和扩展都会比较困难。

8-携带了不必要的状态。单例频繁使用会让类承载更多状态。

### 6-State Pattern 状态模式(重点)
这一节，感觉是为了解决游戏玩法AI里，每个角色会有的各种状态而产生的一种很有用的设计模式；

首先最重要的是，有限状态机；可以处理复杂的状态，但是每一次只能处于一个状态，这个可以简单的用枚举来实现:

枚举状态的集合
```cpp
enum State
{
  STATE_STANDING,
  STATE_JUMPING,
  STATE_DUCKING,
  STATE_DIVING
};
```

用switch，case来切换状态
```cpp
void Heroine::handleInput(Input input)
{
  switch (state_)
  {
    case STATE_STANDING:
      if (input == PRESS_B)
      {
        state_ = STATE_JUMPING;
        yVelocity_ = JUMP_VELOCITY;
        setGraphics(IMAGE_JUMP);
      }
      else if (input == PRESS_DOWN)
      {
        state_ = STATE_DUCKING;
        setGraphics(IMAGE_DUCK);
      }
      break;

    case STATE_JUMPING:
      if (input == PRESS_DOWN)
      {
        state_ = STATE_DIVING;
        setGraphics(IMAGE_DIVE);
      }
      break;

    case STATE_DUCKING:
      if (input == RELEASE_DOWN)
      {
        state_ = STATE_STANDING;
        setGraphics(IMAGE_STAND);
      }
      break;
  }
}
```

但这种用枚举和用Switch case切换的有限状态机是不够好的，因为需要处理复杂的功能，比如每个状态需要有自己的计时器，
所以状态模式的精髓就是：把每一个状态抽象成一个类，如下：

最基础的基类里，需要有handleInput和update这两个方法；
```cpp
class HeroineState
{
public:
  virtual ~HeroineState() {}
  virtual void handleInput(Heroine& heroine, Input input) {}
  virtual void update(Heroine& heroine) {}
};
```

然后每一个派生类都可以有自己的内容，比如这里的chargeTime_;

```cpp
class DuckingState : public HeroineState
{
public:
  DuckingState()
  : chargeTime_(0)
  {}

  virtual void handleInput(Heroine& heroine, Input input) {
    if (input == RELEASE_DOWN)
    {
      // 改回站立状态……
      heroine.setGraphics(IMAGE_STAND);
    }
  }

  virtual void update(Heroine& heroine) {
    chargeTime_++;
    if (chargeTime_ > MAX_CHARGE)
    {
      heroine.superBomb();
    }
  }

private:
  int chargeTime_;
};
```

然后角色，可以通过委托的方法，调用这些状态的方法去执行handleInput() 和 update()这两个函数

```cpp
class Heroine
{
public:
  virtual void handleInput(Input input)
  {
    state_->handleInput(*this, input);
  }

  virtual void update()
  {
    state_->update(*this);
  }

  // 其他方法……
private:
  HeroineState* state_;
};
```

那我们怎么切换状态呢？ 两种方法，单人的时候可以用静态状态，多人的时候，因为多个用户需要有多个独一无二的状态，所以需要用
实例化状态；

静态状态如下:

```cpp
class HeroineState
{
public:
  static StandingState standing;
  static DuckingState ducking;
  static JumpingState jumping;
  static DivingState diving;

  // 其他代码……
};
```

这样可以直接切换另一个静态的状态；

```cpp
if (input == PRESS_B)
{
  heroine.state_ = &HeroineState::jumping;
  heroine.setGraphics(IMAGE_JUMP);
}
```

实例化状态如下:

每次指派新的state的时候都需要把旧的state删了，再换成新的。
```cpp
void Heroine::handleInput(Input input)
{
  HeroineState* state = state_->handleInput(*this, input);
  if (state != NULL)
  {
    delete state_;
    state_ = state;
  }
}
```

然后每次指派新的state的时候，就New一个

```cpp
HeroineState* StandingState::handleInput(Heroine& heroine,
                                         Input input)
{
  if (input == PRESS_DOWN)
  {
    // 其他代码……
    return new DuckingState();
  }

  // 保持这个状态
  return NULL;
}
```

***并发状态机***

更复杂的情况，就需要并发状态机了，比如一个英雄拿着枪跑动。

像这样，使用两个状态；
```cpp
class Heroine
{
  // 其他代码……

private:
  HeroineState* state_;
  HeroineState* equipment_;
};
```

然后两个状态都分别进行委托；

```cpp
void Heroine::handleInput(Input input)
{
  state_->handleInput(*this, input);
  equipment_->handleInput(*this, input);
}
```

***分层状态机***

分层状态机就是，父类可以定义子类统一都有的状态。
比如"On Ground" 是一个状态，然后 "Ducking" 等都是基础 On Ground 的状态，然后可以通过在父类里定义Jump，这样
子类继承之后就不需要重复定义了；

```cpp
class OnGroundState : public HeroineState
{
public:
  virtual void handleInput(Heroine& heroine, Input input)
  {
    if (input == PRESS_B)
    {
      // 跳跃……
    }
    else if (input == PRESS_DOWN)
    {
      // 俯卧……
    }
  }
};
```

子类继承

```cpp
class DuckingState : public OnGroundState
{
public:
  virtual void handleInput(Heroine& heroine, Input input)
  {
    if (input == RELEASE_DOWN)
    {
      // 站起……
    }
    else
    {
      // 没有处理输入，返回上一层
      OnGroundState::handleInput(heroine, input);
    }
  }
};
```


### 7-Double Buffer 双缓冲模式
双缓冲模式一般用于图形显示里的帧缓冲，或者需要整块读取写入，不希望被中断破坏的过程；

最经典的就是有一个swap的原子操作，可以避免图像撕裂等情况。

举个例子，这里有一个Frame
```cpp
生了什么。首先是缓冲区本身：

class Framebuffer
{
public:
  Framebuffer() { clear(); }

  void clear()
  {
    for (int i = 0; i < WIDTH * HEIGHT; i++)
    {
      pixels_[i] = WHITE;
    }
  }

  void draw(int x, int y)
  {
    pixels_[(WIDTH * y) + x] = BLACK;
  }

  const char* getPixels()
  {
    return pixels_;
  }

private:
  static const int WIDTH = 160;
  static const int HEIGHT = 120;

  char pixels_[WIDTH * HEIGHT];
};
```

然后要是不适用Double Buffering绘制，会如下:
```cpp
class Scene
{
public:
  void draw()
  {
    buffer_.clear();

    buffer_.draw(1, 1);
    buffer_.draw(4, 1);
    buffer_.draw(1, 3);
    buffer_.draw(2, 4);
    buffer_.draw(3, 4);
    buffer_.draw(4, 3);
  }

  Framebuffer& getBuffer() { return buffer_; }

private:
  Framebuffer buffer_;
};
```
要是从中间读取的话，就会出现图像不完整的情况；

```cpp
buffer_.draw(1, 1);
buffer_.draw(4, 1);
// <- 图形驱动从这里读取像素！
buffer_.draw(1, 3);
buffer_.draw(2, 4);
buffer_.draw(3, 4);
buffer_.draw(4, 3);
```
所以我们使用doube buffering整块绘制，然后整块读取

```cpp
class Scene
{
public:
  Scene()
  : current_(&buffers_[0]),
    next_(&buffers_[1])
  {}

  void draw()
  {
    next_->clear();

    next_->draw(1, 1);
    // ...
    next_->draw(4, 3);

    swap();
  }

  Framebuffer& getBuffer() { return *current_; }

private:
  void swap()
  {
    // 只需交换指针
    Framebuffer* temp = current_;
    current_ = next_;
    next_ = temp;
  }

  Framebuffer  buffers_[2];
  Framebuffer* current_;
  Framebuffer* next_;
};
```

同理的，要是希望在游戏里面整块更新状态，也可以这样操作。

### 8-Game Loop 游戏循环模式

游戏循环模式，实现游戏运行过程中对用户输入处理和时间处理的解耦。

游戏循环模式：游戏循环在游戏过程中持续运转。每循环一次，它非阻塞地处理用户的输入，更新游戏状态，
并渲染游戏。它跟踪流逝的时间并控制游戏的速率。

游戏循环将游戏的处理过程和玩家输入解耦，和处理器速度解耦，实现用户输入和处理器速度在游戏行进时间上的分离。

游戏循环也许需要与平台的事件循环相协调。如果在操作系统的高层或有图形UI和内建事件循环的平台上构建游戏， 
那就有了两个应用循环在同时运作，需要对他们进行相应的协调

***在游戏循环模式中，我们怎么保持帧率的稳定***

1-使用固定时间步长(fixed timestep) - 每一帧更新逻辑和渲染使用固定的时间步长,例如每帧16.6ms(大约60FPS)。这可以避免帧率波动影响游戏逻辑更新。

2-间隔渲染(interpolate rendering) - 根据固定逻辑更新间隔来渲染,但允许渲染帧率波动。这可以平滑视觉效果。可以使用线性插值在逻辑更新间隔内渲染额外的帧。

3-时间流逝管理(time warp management) - 如果渲染时间超过了逻辑更新的时间步长,那么就压缩接下来的更新使其“赶上”当前时间。反之,如果渲染太快,可以通过往复重复同一逻辑状态来填充时间。

4-动态时间步长(dynamic timestep) - 允许逻辑更新的时间步长动态变化,但要确保时间流逝总速度保持一致。这更灵活但更难管理。

5-限制帧率(frame rate capping) - 如果硬件支持,可以限制渲染帧率不超过显示器刷新率,避免浪费资源渲染额外的帧。

6-优化游戏代码和资源 - 查找并优化游戏循环中的瓶颈可以提高平均帧率。比如减少游戏对象、降低多边形等

以下是一个最简单没有事件控制的游戏循环:

```cpp
while (true)
{
  processInput();
  update();
  render();
}
```

增加了一个等待，让运算太快的帧可以等到稳定的帧率再渲染下一帧,
但是这样解决不了某一帧渲染过慢导致的问题；

```cpp
while (true)
{
  double start = getCurrentTime();
  processInput();
  update();
  render();

  sleep(start + MS_PER_FRAME - getCurrentTime());
}
```


理解成在恒定帧率的前提下，这一帧要是计算久了，下一帧就快一点

于是就有了动态步长管理，这一帧计算的慢了，下一帧计算的就快一点；

update()根据传入的elapsed时间参数来调整每帧的更新量,保证游戏内部逻辑连贯流畅。

```cpp
double lastTime = getCurrentTime();
while (true)
{
  double current = getCurrentTime();
  double elapsed = current - lastTime;
  processInput();
  update(elapsed);
  render();
  lastTime = current;
}
```

但是还会有问题就是，游戏逻辑的更新和渲染同步的话，会导致一些浮点数运算的误差，
比如在性能好的电脑上，一秒50帧，性能差的电脑上，一秒5帧，要是游戏逻辑和渲染同步更新的话，误差就会很大。

所以我们需要把游戏逻辑和渲染解耦，游戏逻辑根据恒定时间去tick，然后渲染根据硬件性能去tick

这样可以很好地兼顾逻辑精度和渲染流畅度。

```cpp
double previous = getCurrentTime();
double lag = 0.0;
while (true)
{
  double current = getCurrentTime();
  double elapsed = current - previous;
  previous = current;
  lag += elapsed;

  processInput();

  while (lag >= MS_PER_UPDATE)
  {
    update();
    lag -= MS_PER_UPDATE;
  }

  render();
}
```

在Unity里的game loop逻辑就是
先physical，再到input，再到game logic，再到rendering；

### 9-Update Method 更新方法
更新方法，通过每次处理一帧的行为来模拟一系列独立对象。

更新方法模式：在游戏中保持游戏对象的集合。每个对象实现一个更新方法，以处理对象在一帧内的行为。每一帧中，游戏循环对集合中的每一个对象进行更新。
当离开每帧时，我们也许需要存储下状态，以备不时之需。

我对更新方法的概念就是，每一个游戏的Entity，都随着游戏Loop而更新自己的状态。
在游戏循环的更新逻辑Update()中,会遍历所有的Entity,并调用每个Entity的更新方法,让它们更新自身的状态。
每个Entity会在游戏循环的更新阶段更新自身,从而实现整个游戏世界状态的更新。

这是传统的entity类
这里的=0，表示一个纯虚函数(pure virtual function)，是一个接口。

这样声明纯虚函数的目的是为了让这个类成为一个抽象类(abstract class)。
抽象类不能够被实例化,只能被继承。类中含有一个或多个纯虚函数的类就是抽象类。

在C++中,类中包含纯虚函数(至少一个virtual函数被声明为=0),那么这个类就是抽象类,
不需要额外使用abstract关键字声明。在C++中明确使用abstract关键字标记抽象类,可以使抽象类的定义更加严格和明确。

```cpp
class Entity
{
public:
  Entity()
  : x_(0), y_(0)
  {}

  virtual ~Entity() {}
  virtual void update() = 0;

  double x() const { return x_; }
  double y() const { return y_; }

  void setX(double x) { x_ = x; }
  void setY(double y) { y_ = y; }

private:
  double x_;
  double y_;
};
```

这是世界类，里面有gameLoop的函数，和Entity的集合，我们的目标就是遍历这个集合
来更新世界状态.

```cpp
class World
{
public:
  World()
  : numEntities_(0)
  {}

  void gameLoop();

private:
  Entity* entities_[MAX_ENTITIES];
  int numEntities_;
};
```

像这样

```cpp
void World::gameLoop()
{
  while (true)
  {
    // 处理用户输入……

    // 更新每个实体
    for (int i = 0; i < numEntities_; i++)
    {
      entities_[i]->update();
    }

    // 物理和渲染……
  }
}
```

然后我们每一个实例化的实体，都可以自己定义自己的update类
```cpp
class Skeleton : public Entity
{
public:
  Skeleton()
  : patrollingLeft_(false)
  {}

  virtual void update()
  {
    if (patrollingLeft_)
    {
      setX(x() - 1);
      if (x() == 0) patrollingLeft_ = false;
    }
    else
    {
      setX(x() + 1);
      if (x() == 100) patrollingLeft_ = true;
    }
  }

private:
  bool patrollingLeft_;
};
```

我们要是希望在里面加入时间，让这个骷髅随着帧率移动，就可以把之前再gameloop里
的时间传入每个实体的update()函数，比如这里的骷髅

```cpp
void Skeleton::update(double elapsed)
{
  if (patrollingLeft_)
  {
    x -= elapsed;
    if (x <= 0)
    {
      patrollingLeft_ = false;
      x = -x;
    }
  }
  else
  {
    x += elapsed;
    if (x >= 100)
    {
      patrollingLeft_ = true;
      x = 100 - (x - 100);
    }
  }
}
```

### 10- Bytecode 字节码模式

字节码模式的核心思想是:

1-将游戏对象的行为逻辑定义在外部的字节码文件中,比如文本文件、二进制文件等,里面保存了行为的字节码。

2-游戏引擎提供解释器,可以加载并解析这些字节码文件,得到游戏对象的行为定义。

3-在游戏运行时,引擎使用解释器来解释执行字节码,使得游戏对象产生相应的行为和结果。

4-可以动态加载或切换字节码文件,修改游戏对象行为,而无需重新编译游戏代码。

字节码通常采用一种自定义的指令集和文件格式,它更高级与硬编码,但比机器码低级和抽象。
这样游戏逻辑可以脱离代码存在,使得游戏行为更容易定制和扩展。
这种模式解耦了游戏逻辑和引擎,提高了灵活性。

***代码demo***
比如以下的几个函数，是定义了游戏里法师角色的行为

```cpp
void setHealth(int wizard, int amount);
void setWisdom(int wizard, int amount);
void setAgility(int wizard, int amount);
void playSound(int soundId);
void spawnParticles(int particleType);
```

然后我们可以吧这些行为枚举成一些指令

```cpp
enum Instruction
{
  INST_SET_HEALTH      = 0x00,
  INST_SET_WISDOM      = 0x01,
  INST_SET_AGILITY     = 0x02,
  INST_PLAY_SOUND      = 0x03,
  INST_SPAWN_PARTICLES = 0x04
};
```

然后我们传入instruction，使用switch case，就可以来解决这些指令

```cpp
switch (instruction)
{
  case INST_SET_HEALTH:
    setHealth(0, 100);
    break;

  case INST_SET_WISDOM:
    setWisdom(0, 100);
    break;

  case INST_SET_AGILITY:
    setAgility(0, 100);
    break;

  case INST_PLAY_SOUND:
    playSound(SOUND_BANG);
    break;

  case INST_SPAWN_PARTICLES:
    spawnParticles(PARTICLE_FLAME);
    break;
}
```

我们输入的是一些列byteode，就像0x00，0x01这些，然后就可以在虚拟机里遍历这些bytecode。

```cpp
class VM
{
public:
  void interpret(char bytecode[], int size)
  {
    for (int i = 0; i < size; i++)
    {
      char instruction = bytecode[i];
      switch (instruction)
      {
        // 每条指令的跳转分支……
      }
    }
  }
};
```

然后也可以像Java虚拟机那样，栈来表示，把一堆operand和operator压入栈内，然后遇到operand就
继续压入，遇到operator就把栈顶的两个operand去除计算(具体去除多少要看这个行为的需要)；

这就是一个栈的命令都压进去了，就非常像Java的虚拟机；
```cpp
LITERAL 0    [0]            # 巫师索引
LITERAL 0    [0, 0]         # 巫师索引
GET_HEALTH   [0, 45]        # 获取血量()
LITERAL 0    [0, 45, 0]     # 巫师索引
GET_AGILITY  [0, 45, 7]     # 获取敏捷()
LITERAL 0    [0, 45, 7, 0]  # 巫师索引
GET_WISDOM   [0, 45, 7, 11] # 获取智慧()
ADD          [0, 45, 18]    # 将敏捷和智慧加起来
LITERAL 2    [0, 45, 18, 2] # 被除数：2
DIVIDE       [0, 45, 9]     # 计算敏捷和智慧的平均值
ADD          [0, 54]        # 将平均值加到现有血量上。
SET_HEALTH   []             # 将结果设为血量
```

### 11-Subclass Sandbox 子类沙箱模式

用一系列由基类提供的操作定义子类中的行为。</br>

子类沙箱模式：基类定义抽象的沙箱方法和几个提供操作的实现方法，
将他们设为protected，表明它们只为子类所使用。</br>
每个推导出的沙箱子类用提供的操作实现了沙箱方法。</br>

***理解***
1-在基类中使用protected方法定义核心功能,而不是public方法。</br>
2-这些protected方法为子类提供基础能力,子类可以灵活调用和组合这些方法。</br>
3-子类可以方便地通过继承复用基类的核心功能代码。</br>
4-这样可以最大限度地减少子类之间及对外的耦合。</br>
5-基类如同一个沙箱,为子类提供安全可控的空间探索和扩展。</br>

所以,沙箱模式通过protected方法提供一个基础代码框架,在此基础上构建子类,
可获得高内聚低耦合的效果。

***个人更通俗的理解***
1-基类就像一个超市的货架,货架上摆放了各种protected方法(商品)。</br>
2-这些方法是基础通用能力,可被灵活调用和组合。</br>
3-子类就像超市顾客,可以来选择需要的方法(商品)。</br>
4-子类根据自己的目的,从货架上选取方法并组合,封装成自己的public方法。</br>
5-不同子类可选择不同的基础方法,搭建出适合自己的功能。</br>
6-子类之间不会互相影响,只基于基类的货架。</br>

***代码demo***
基类定义了一个超级英雄能力的类，有各种实现方法；
```cpp
class Superpower
{
public:
  virtual ~Superpower() {}

protected:
  virtual void activate() = 0;

  void move(double x, double y, double z)
  {
    // 实现代码……
  }

  void playSound(SoundId sound, double volume)
  {
    // 实现代码……
  }

  void spawnParticles(ParticleType type, int count)
  {
    // 实现代码……
  }
    double getHeroX()
  {
    // 实现代码……
  }

  double getHeroY()
  {
    // 实现代码……
  }

  double getHeroZ()
  {
    // 实现代码……
  }

};
```

派生类就像挑选物品一样从基类定义的各种protected方法里挑选货品, 自由组合
```cpp
class SkyLaunch : public Superpower
{
protected:
  virtual void activate()
  {
    if (getHeroZ() == 0)
    {
      // 在地面上，冲向空中
      playSound(SOUND_SPROING, 1.0f);
      spawnParticles(PARTICLE_DUST, 10);
      move(0, 0, 20);
    }
    else if (getHeroZ() < 10.0f)
    {
      // 接近地面，再跳一次
      playSound(SOUND_SWOOP, 1.0f);
      move(0, 0, getHeroZ() + 20);
    }
    else
    {
      // 正在空中，跳劈攻击
      playSound(SOUND_DIVE, 0.7f);
      spawnParticles(PARTICLE_SPARKLES, 1);
      move(0, 0, -getHeroZ());
    }
  }
};
```

我们要挑选复用率比较高的函数方法放在基类中作为“货物”；

### 12-Type Object 类型对象模式
创造一个类A来允许灵活的创造新的类，而类A的每个实例都代表了不同类型的对象。

举个例子，本来我们有各种monster，传统的面向对象的方案是创建一个monster的基类，然后各种monster
比如Dragon，Troll，都会派生自这个monster基类。

这个是Monster的基类

```cpp
class Monster
{
public:
  virtual ~Monster() {}
  virtual const char* getAttack() = 0;

protected:
  Monster(int startingHealth)
  : health_(startingHealth)
  {}

private:
  int health_; // 当前血值
};
```

然后Dragon和Troll的派生类派生自Monster

```cpp
class Dragon : public Monster
{
public:
  Dragon() : Monster(230) {}

  virtual const char* getAttack()
  {
    return "The dragon breathes fire!";
  }
};

class Troll : public Monster
{
public:
  Troll() : Monster(48) {}

  virtual const char* getAttack()
  {
    return "The troll clubs you!";
  }
};
```

但这样有一个很不好的是，我们要是有一万个monster类型，就需要一万个类，这是我们不希望看到的。

所以Type Object 类型对象模式提出了，我们可以仅有两个类：Monster类和Breed类(种类)，Dragon和
Troll这些具体的类就不新建一个派生类了，用Monster实例化一个对象就ok。那具体的数值，就是通过Breed
这个类来传入。

例子：

Breed类，定义了每个具体Monster类型所需的一切

```cpp
class Breed
{
public:
  Breed(int health, const char* attack)
  : health_(health),
    attack_(attack)
  {}

  int getHealth() { return health_; }
  const char* getAttack() { return attack_; }

private:
  int health_; // 初始血值
  const char* attack_;
};
```

那Monster的基类呢，就是用Breed类来初始化。
```cpp
class Monster
{
public:
  Monster(Breed& breed)
  : health_(breed.getHealth()),
    breed_(breed)
  {}

  const char* getAttack()
  {
    return breed_.getAttack();
  }

private:
  int    health_; // 当前血值
  Breed& breed_;
};
```
以上就是Type Object的核心，这样不管再多的monster类型，一直都是只有两个类，Monster和Breed；
只不过每一个新的怪物类型，如Dragon，就需要一个Monster的实例，和一个Breed的实例？

对于新的怪物类型Dragon:

1-只需要一个DragonBreed类,包含数据

2-创建一个Monster实例,传入DragonBreed实例

3-Monster根据Breed执行不同的功能


## 解耦型模式 Decoupling Patterns

这一部分的三种模式，专注于解耦。
我们说两块代码“解耦”时，是指修改一块代码一般不会需要修改另一块代码。 当我们修改游戏中的特性时，需要修改的代码越少，就越容易。

1-组件模式将一个实体拆成多个，解耦不同的领域。</br>
2-事件队列解耦了两个互相通信的事物，稳定而且实时。</br>
3-服务定位器让代码使用服务而无需绑定到提供服务的代码上。</br>

### 13-Component 组件模式 (非常重要！)
单一实体跨越了多个领域。为了保持领域之间相互分离，将每部分代码放入各自的组件类中。 
实体被简化为组件的容器。

特别重要，要理解“实体是组件的容器”。这样的好处是避免在一个类逐渐变得庞大，复杂，冗余;

比如我们有一个面包师Bjorn的类
```cpp
class Bjorn
{
public:
  Bjorn()
  : velocity_(0),
    x_(0), y_(0)
  {}

  void update(World& world, Graphics& graphics);

private:
  static const int WALK_ACCELERATION = 1;

  int velocity_;
  int x_, y_;

  Volume volume_;

  Sprite spriteStand_;
  Sprite spriteWalkLeft_;
  Sprite spriteWalkRight_;
};
```

他需要每帧都update自己的状态，包括处理input，解决世界里的物理碰撞，和graphics渲染
这三种

```cpp
void Bjorn::update(World& world, Graphics& graphics)
{
  // 根据用户输入修改英雄的速度
  switch (Controller::getJoystickDirection())
  {
    case DIR_LEFT:
      velocity_ -= WALK_ACCELERATION;
      break;

    case DIR_RIGHT:
      velocity_ += WALK_ACCELERATION;
      break;
  }

  // 根据速度修改位置
  x_ += velocity_;
  world.resolveCollision(volume_, x_, y_, velocity_);

  // 绘制合适的图形
  Sprite* sprite = &spriteStand_;
  if (velocity_ < 0)
  {
    sprite = &spriteWalkLeft_;
  }
  else if (velocity_ > 0)
  {
    sprite = &spriteWalkRight_;
  }

  graphics.draw(*sprite, x_, y_);
}
```

但在此处我们就能看到冗余的情况，每一项更新都需要在update函数里写自己的逻辑在调用
world 和 graphics模块去处理碰撞与渲染，
随着功能日益增长，这个update函数也会变得越累越复杂；所以这里我们希望能不能把更新每一个
功能的逻辑封装成一个组件类；

比如下面这里，就把根据input改变位置的逻辑分离出来了；
```cpp
class InputComponent
{
public:
  void update(Bjorn& bjorn)
  {
    switch (Controller::getJoystickDirection())
    {
      case DIR_LEFT:
        bjorn.velocity -= WALK_ACCELERATION;
        break;

      case DIR_RIGHT:
        bjorn.velocity += WALK_ACCELERATION;
        break;
    }
  }

private:
  static const int WALK_ACCELERATION = 1;
};
```

再把Physical Component 和 Graphics Component分离出来后

```cpp
class PhysicsComponent
{
public:
  void update(Bjorn& bjorn, World& world)
  {
    bjorn.x += bjorn.velocity;
    world.resolveCollision(volume_,
        bjorn.x, bjorn.y, bjorn.velocity);
  }

private:
  Volume volume_;
};
```

```cpp
class GraphicsComponent
{
public:
  void update(Bjorn& bjorn, Graphics& graphics)
  {
    Sprite* sprite = &spriteStand_;
    if (bjorn.velocity < 0)
    {
      sprite = &spriteWalkLeft_;
    }
    else if (bjorn.velocity > 0)
    {
      sprite = &spriteWalkRight_;
    }

    graphics.draw(*sprite, bjorn.x, bjorn.y);
  }

private:
  Sprite spriteStand_;
  Sprite spriteWalkLeft_;
  Sprite spriteWalkRight_;
};
```

这时候我们的Bjorn类，只需要包含这三个Component，就可以直接调用他们各自的update()函数去
update，此时的update类就非常简洁了;

```cpp
class Bjorn
{
public:
  int velocity;
  int x, y;

  void update(World& world, Graphics& graphics)
  {
    input_.update(*this);
    physics_.update(*this, world);
    graphics_.update(*this, graphics);
  }

private:
  InputComponent input_;
  PhysicsComponent physics_;
  GraphicsComponent graphics_;
};
```

不过这个时候，我们还是需要有一个Bjorn类并且为它创建特定的各自component；

不如换一种逻辑，我们没有Bjorn类，只有一个GameObject类。再用各种组件去初始化它让他
变成一个Bjorn类；

然后各种Component，就可以定义为一个抽象类，然后我根据需要去实例化与继承他们；

比如：
各个Component的抽象类，我们需要去实例化他们;

```cpp
class InputComponent
{
public:
  virtual ~InputComponent() {}
  virtual void update(Bjorn& bjorn) = 0;
};

class PhysicsComponent
{
public:
  virtual ~PhysicsComponent() {}
  virtual void update(GameObject& obj, World& world) = 0;
};

class GraphicsComponent
{
public:
  virtual ~GraphicsComponent() {}
  virtual void update(GameObject& obj, Graphics& graphics) = 0;
};
```

此时的Game Object类，需要各个Component去实例化；
```cpp
class GameObject
{
public:
  int velocity;
  int x, y;

  GameObject(InputComponent* input,
             PhysicsComponent* physics,
             GraphicsComponent* graphics)
  : input_(input),
    physics_(physics),
    graphics_(graphics)
  {}

  void update(World& world, Graphics& graphics)
  {
    input_->update(*this);
    physics_->update(*this, world);
    graphics_->update(*this, graphics);
  }

private:
  InputComponent* input_;
  PhysicsComponent* physics_;
  GraphicsComponent* graphics_;
};
```
然后我们像新建一个Bjorn的时候，首先需要定制我们的Component

```cpp
class PlayerInputComponent : public InputComponent
{
public:
  virtual void update(Bjorn& bjorn)
  {
    // 自动控制Bjorn的AI……
  }
};

class BjornPhysicsComponent : public PhysicsComponent
{
public:
  virtual void update(GameObject& obj, World& world)
  {
    // 物理代码……
  }
};

class BjornGraphicsComponent : public GraphicsComponent
{
public:
  virtual void update(GameObject& obj, Graphics& graphics)
  {
    // 图形代码……
  }
};
```

然后再用他们实例化一个GameObject：
```
GameObject* createBjorn()
{
  return new GameObject(new PlayerInputComponent(),
                        new BjornPhysicsComponent(),
                        new BjornGraphicsComponent());
}
```

### 14-Event Queue 事件队列模式 
 
事件队列模式，对消息或事件的发送与处理进行时间上的解耦。

要点

1-事件队列：在先入先出的队列中存储一系列通知或请求。发送通知时，将请求放入队列并返回。处理请求的系统在稍晚些的时候从队列中获取请求并进行处理。 这样就解耦了发送者和接收者，既静态又及时。</br>
2-事件队列很复杂，会对游戏架构引起广泛影响。中心事件队列是一个全局变量。这个模式的通常方法是一个大的交换站，游戏中的每个部分都能将消息送过这里。</br>
3-事件队列是基础架构中很强大的存在，但有些时候强大并不代表好。事件队列模式将状态包裹在协议中，但是它还是全局的，仍然存在全局变量引发的一系列危险。</br>
4-很大程度上，事件队列模式就是广为人知的GOF设计模式中观察者模式的异步实现。</br>

使用场合

1-如果你只是想解耦接收者和发送者，像观察者模式和命令模式都可以用较小的复杂度来进行处理。在需要解耦某些实时的内容时才建议使用事件队列。</br>
2-不妨用推和拉来的情形来考虑。有一块代码A需要另一块代码B去做些事情。对A自然的处理方式是将请求推给B。
同时，对B自然的处理方式是在B方便时将请求拉入。当一端有推模型另一端有拉模型时，你就需要在它们间放一个缓冲的区域。 
这就是队列比简单的解耦模式多出来的那一部分。队列给了代码对拉取的控制权——接收者可以延迟处理，合并或者忽视请求。
发送者能做的就是向队列发送请求然后就完事了，并不能决定什么时候发送的请求会受到处理。
3-而当发送者需要一些回复反馈时，队列模式就不是一个好的选择。</br>


举个例子，我们希望能有一个播放声音的功能PlaySound
```cpp
class Audio
{
public:
  static void playSound(SoundId id, int volume);
};
```

要是不解耦的话，是直接一个函数可以解决，发送方和接收方在一起
```cpp
void Audio::playSound(SoundId id, int volume)
{
  ResourceId resource = loadSound(id);
  int channel = findOpenChannel();
  if (channel == -1) return;
  startSound(resource, channel, volume);
}
```

但是这样有两个问题:

1-在接收方处理完一个需求的之前，发送方都不能再发送新的需求。</br>
2-无法合并多个请求

于是我们需要在发送方和接收方之间新建一个缓存来做消息队列；

消息的struct
```cpp
struct PlayMessage
{
  SoundId id;
  int volume;
};
```

Audio类里，我们要新建一个数组，来保存
```cpp
class Audio
{
public:
  static void init()
  {
    numPending_ = 0;
  }

  // 其他代码……
private:
  static const int MAX_PENDING = 16;

  static PlayMessage pending_[MAX_PENDING];
  static int numPending_;
};
```

playSound函数作为发送方
```cpp
void Audio::playSound(SoundId id, int volume)
{
  assert(numPending_ < MAX_PENDING);

  pending_[numPending_].id = id;
  pending_[numPending_].volume = volume;
  numPending_++;
}
```

然后Audio里的upfate()作为接受方
```cpp
class Audio
{
public:
  static void update()
  {
    for (int i = 0; i < numPending_; i++)
    {
      ResourceId resource = loadSound(pending_[i].id);
      int channel = findOpenChannel();
      if (channel == -1) return;
      startSound(resource, channel, pending_[i].volume);
    }

    numPending_ = 0;
  }

  // 其他代码……
};
```

不过我们希望它是一个环状列表，我们不用动态分配内存；

于是我们可以有两个指针，一快一慢;

```cpp
class Audio
{
public:
  static void init()
  {
    head_ = 0;
    tail_ = 0;
  }

  // 方法……
private:
  static int head_;
  static int tail_;

  // 数组……
};
```

然后发送方就这样，每次都用求余数的方法来实现复用，但是要加一个判断就是tail不能超车一圈之后
追上head

```cpp
void Audio::playSound(SoundId id, int volume)
{
  assert((tail_ + 1) % MAX_PENDING != head_);

  // 添加到列表的尾部
  pending_[tail_].id = id;
  pending_[tail_].volume = volume;
  tail_ = (tail_ + 1) % MAX_PENDING;
}
```

然后update()也是这样

```cpp
void Audio::update()
{
  // 如果没有待处理的请求，就啥也不做
  if (head_ == tail_) return;

  ResourceId resource = loadSound(pending_[head_].id);
  int channel = findOpenChannel();
  if (channel == -1) return;
  startSound(resource, channel, pending_[head_].volume);

  head_ = (head_ + 1) % MAX_PENDING;
}
```

每次调用 Audio::update() 时，都只处理队列中的一个请求。
如果你想在一个更新周期内处理多个音频请求，你可以将 Audio::update()
的这部分逻辑包装在一个循环中，直到队列为空或者达到你设定的处理请求的最大数量。

我们还可以有一个小技巧来合并请求，在发出的时候；
```cpp
void Audio::playSound(SoundId id, int volume)
{
  // 遍历待处理的请求
  for (int i = head_; i != tail_;
       i = (i + 1) % MAX_PENDING)
  {
    if (pending_[i].id == id)
    {
      // 使用较大的音量
      pending_[i].volume = max(volume, pending_[i].volume);

      // 无需入队
      return;
    }
  }

  // 之前的代码……
}
```
准备发出一个id = id的音频请求的时候，去遍历队列里有没有一样id的，
如果有的话，那就去他们的最大音量，然后自身这个请求就不加入消息队列了，因为前面已经有了;

### 15-Service Locator 服务定位器
提供服务的全局接入点，而不必让用户和实现它的具体类耦合。

服务定位模式：服务类定义了一堆操作的抽象接口。具体的服务提供者实现这个接口。 
分离的服务定位器提供了通过查询合适的提供者， 获取服务的方法，
同时隐藏了提供者的具体细节和需要定位它的进程。

一般通过使用单例或者静态类来实现服务定位模式，提供服务的全局接入点。

服务定位模式可以看做是更加灵活，更加可配置的单例模式。
如果用得好，它能以很小的运行时开销，换取很大的灵活性。
相反，如果用得不好，它会带来单例模式的所有缺点以及更多的运行时开销。

***我的理解***
一个很好的比喻，就是在需求和服务中间加上一个定位器；

需要耦合到某些东西上来播放声音， 但是直接接触到具体的音频实现，就好像给了一百个陌生人你家的地址，
只是为了让他们在门口放一封信。 这不仅仅是隐私问题，在你搬家后，
需要告诉每个人新地址是个更加痛苦的问题。
有个更好的解决办法：一本电话薄。 需要联系我们的人可以在上面查找并找到现在的地址。 
当我们搬家时，我们通知电话公司。 他们更新电话薄，每个人都知道了新地址。 
事实上，我们甚至无需给出真实的地址。 我们可以列一个转发信箱或者其他“代表”我们的东西。 
通过让调用者查询电话薄找我们，我们获得了一个控制找我们的方法的方便地方。

***代码Demo***

比如我们这里有一个服务，都是关于Audio的；我们首先暴露一些接口，这里是音频接口
```cpp
class Audio
{
public:
  virtual ~Audio() {}
  virtual void playSound(int soundID) = 0;
  virtual void stopSound(int soundID) = 0;
  virtual void stopAllSounds() = 0;
};
```
然后有服务提供者，去实现具体的方法：

```cpp
class ConsoleAudio : public Audio
{
public:
  virtual void playSound(int soundID)
  {
    // 使用主机音频API播放声音……
  }

  virtual void stopSound(int soundID)
  {
    // 使用主机音频API停止声音……
  }

  virtual void stopAllSounds()
  {
    // 使用主机音频API停止所有声音……
  }
};
```

然后在这里就是有一个简单的定位器，每当geitAudio()的时候就可以返回服务
```cpp
class Locator
{
public:
  static Audio* getAudio() { return service_; }

  static void provide(Audio* service)
  {
    service_ = service;
  }

private:
  static Audio* service_;
};
```
getAudio()被声明为static静态函数,这样它可以通过类名直接调用,目的是不需要实例化Locator对象。

其他模块可以通过Locator::getAudio()获得这个全局的Audio服务。

所以可以全局访问Locator提供的Audio服务,实现了解耦和全局访问.

```cpp
Audio *audio = Locator::getAudio();
audio->playSound(VERY_LOUD_BANG);
```

然后我们也可以注册成为服务提供者

```cpp
ConsoleAudio *audio = new ConsoleAudio();
Locator::provide(audio);
```

更万无一失，我们需要提供一个空服务，以避免我们在服务提供者注册前使用服务，
它会返回NULL。 如果调用代码没有检查，游戏就崩溃了。

```cpp
class NullAudio: public Audio
{
public:
  virtual void playSound(int soundID) { /* 什么也不做 */ }
  virtual void stopSound(int soundID) { /* 什么也不做 */ }
  virtual void stopAllSounds()        { /* 什么也不做 */ }
};
```

然后来检查，要是service == NULL的话，那就返回空服务；

```cpp
class Locator
{
public:
  static void initialize() { service_ = &nullService_; }

  static Audio& getAudio() { return *service_; }

  static void provide(Audio* service)
  {
    if (service == NULL)
    {
      // 退回空服务
      service_ = &nullService_;
    }
    else
    {
      service_ = service;
    }
  }

private:
  static Audio* service_;
  static NullAudio nullService_;
};
```

另一个作用是日志装饰器，因为我们不能遇到问题就直接输出log，我们需要定义一个专门输出日志的服务；
```cpp
class LoggedAudio : public Audio
{
public:
  LoggedAudio(Audio &wrapped)
  : wrapped_(wrapped)
  {}

  virtual void playSound(int soundID)
  {
    log("play sound");
    wrapped_.playSound(soundID);
  }

  virtual void stopSound(int soundID)
  {
    log("stop sound");
    wrapped_.stopSound(soundID);
  }

  virtual void stopAllSounds()
  {
    log("stop all sounds");
    wrapped_.stopAllSounds();
  }

private:
  void log(const char* message)
  {
    // 记录日志的代码……
  }

  Audio &wrapped_;
};
```

然后我们可以注册这个服务，来使用它;
```
void enableAudioLogging()
{
  // 装饰现有的服务
  Audio *service = new LoggedAudio(Locator::getAudio());

  // 将它换进来
  Locator::provide(service);
}
```

## 优化模式

1-数据局部性介绍了计算机的存储层次以及如何使用其以获得优势。 </br>
2-脏标识帮你避开不必要的计算。 </br>
3-对象池帮你避开不必要的内存分配。 </br>
4-空间分区加速了虚拟世界和其中元素的空间布局。</br>

### 16-Data Locality 数据局部性模式

合理组织数据，充分使用CPU的缓存来加速内存读取。

要仔细阅读这里提出的例子: https://gpp.tkchu.me/data-locality.html

关键是提高缓存命中率，现代的CPU有缓存来加速内存读取，其可以更快地读取最近访问过的内存毗邻的内存。
基于这一点，我们通过保证处理的数据排列在连续内存上，以提高内存局部性，从而提高性能。

为了保证数据局部性，就要避免的缓存不命中。也许你需要牺牲一些宝贵的抽象。
你越围绕数据局部性设计程序，就越放弃继承、接口和它们带来的好处。没有银弹，只有权衡。

使用数据局部性的第一准则是在遇到性能问题时使用。不要将其应用在代码库不经常使用的角落上。 
优化代码后其结果往往更加复杂，更加缺乏灵活性。

***数据结构的例子**

vector等连续线性存储的数据结构由于内存地址连续,比链表这种链式存储的数据结构有更高的内存读取效率。
主要原因如下:

vector中的元素存储是连续的,充分利用了CPU的预取机制,读取一个元素后很可能下一个元素已经加载到缓存中了。

而链表中的元素在内存中是离散分布的,读取一个节点的下一节点信息时很可能不在缓存中,需要重新加载。

vector可以直接用下标随机访问任意元素,链表需要从头节点逐步遍历。

vector内存访问模式更加线性和可预测,对CPU缓存更友好。

链表需要存储更多的指针信息,数据密度较低。

说到底还是连续的内存可以让CPU读取数据的命中率更高。

接下来的三个例子都是围绕这一点展开的;

***方法1 连续数组***
就是把尽量多的内容放在连续数组内;

举个例子，之前component模式内的内容;

这是entity;
```cpp
class GameEntity
{
public:
  GameEntity(AIComponent* ai,
             PhysicsComponent* physics,
             RenderComponent* render)
  : ai_(ai), physics_(physics), render_(render)
  {}

  AIComponent* ai() { return ai_; }
  PhysicsComponent* physics() { return physics_; }
  RenderComponent* render() { return render_; }

private:
  AIComponent* ai_;
  PhysicsComponent* physics_;
  RenderComponent* render_;
};
```

然后这些是component;
```cpp
class AIComponent
{
public:
  void update() { /* 处理并修改状态…… */ }

private:
  // 目标，情绪，等等……
};

class PhysicsComponent
{
public:
  void update() { /* 处理并修改状态…… */ }

private:
  // 刚体，速度，质量，等等……
};

class RenderComponent
{
public:
  void render() { /* 处理并修改状态…… */ }

private:
  // 网格，纹理，着色器，等等……
};
```

当我们在gameloop里更新每一个entity的时候，会是这样的
```cpp
while (!gameOver)
{
  // 处理AI
  for (int i = 0; i < numEntities; i++)
  {
    entities[i]->ai()->update();
  }

  // 更新物理
  for (int i = 0; i < numEntities; i++)
  {
    entities[i]->physics()->update();
  }

  // 绘制屏幕
  for (int i = 0; i < numEntities; i++)
  {
    entities[i]->render()->render();
  }

  // 其他和时间有关的游戏循环机制……
}
```
会在不同entity的component种反复横跳，游戏实体的数组存储的是指针，所以为了获取游戏实体，我们得转换指针。缓存不命中。
游戏实体的数组存储的是指针，所以为了获取游戏实体，我们得转换指针。缓存不命中。

所以我们可以新建一个大的数组来存放这些component，这些都是组件的数组，而不是指向组件的指针。

```cpp
AIComponent* aiComponents =
    new AIComponent[MAX_ENTITIES];
PhysicsComponent* physicsComponents =
    new PhysicsComponent[MAX_ENTITIES];
RenderComponent* renderComponents =
    new RenderComponent[MAX_ENTITIES];
```

然后这样子更新，就可以在内存地址上非常连续了

```cpp
while (!gameOver)
{
  // 处理AI
  for (int i = 0; i < numEntities; i++)
  {
    aiComponents[i].update();
  }

  // 更新物理
  for (int i = 0; i < numEntities; i++)
  {
    physicsComponents[i].update();
  }

  // 绘制屏幕
  for (int i = 0; i < numEntities; i++)
  {
    renderComponents[i].render();
  }

  // 其他和时间有关的游戏循环机制……
}
```
***方法2 打包数据***
我们也可以把所有的粒子系统里的粒子都打包在巨大的连续数组种，用管理类封装；
```cpp
class Particle
{
public:
  void update() { /* 重力，等等…… */ }
  // 位置，速度，等等……
};

class ParticleSystem
{
public:
  ParticleSystem()
  : numParticles_(0)
  {}

  void update();
private:
  static const int MAX_PARTICLES = 100000;

  int numParticles_;
  Particle particles_[MAX_PARTICLES];
};
```

这样子更新
```cpp
void ParticleSystem::update()
{
  for (int i = 0; i < numParticles_; i++)
  {
    particles_[i].update();
  }
}
```

***方法3 冷热分割***
简单的思想理解是 把每帧都需要更新的直接用数据存，然后用的少的，用指针存;

1-将频繁访问或更新的组件设计为"热"组件,直接以数据成员的形式包含在对象中。</br>
2-将不常访问的组件设计为"冷"组件,以指针成员的形式包含在对象中。</br>
3-"热"组件直接内嵌,可以提高访问性能,但是会增加对象大小。</br>
4-"冷"组件以指针形式包含,可以按需加载,减少对象大小。</br>
5-根据不同组件的访问热度,进行分割设计,实现性能和尺寸的平衡。</br>
6-一般将每帧都需要访问的组件设计为"热",偶尔访问的设计为"冷"。</br>

像下文代码这样，不常用的打包成以恶搞LootDrop结构，用一个指针存，这样能最大程度保证常用
的变量的缓存命中;
```cpp
class AIComponent
{
public:
  // 方法……
private:
  Animation* animation_;
  double energy_;
  Vector goalPos_;

  LootDrop* loot_;
};

class LootDrop
{
  friend class AIComponent;
  LootType drop_;
  int minDrops_;
  int maxDrops_;
  double chanceOfDrop_;
};
```

### 17-Dirty Flag 脏标记模式
脏标记模式,是一种用于延迟计算和提高效率的设计模式,其核心思想是:

1-在数据对象上引入一个"脏"标记,当对象数据发生变化时,设置标记为"脏"。</br>
2-当需要读访问脏对象时,先进行必要的计算或更新,再清除脏标记,然后返回新的对象。</br>
3-当有读请求时,重新计算标记为脏的对象,避免不必要的重复计算。</br>
4-当有写请求时,只需设置脏标记,不立即执行计算,延迟到之后的读请求时再计算。</br>
5-这样可以大大减少冗余计算,降低每次写请求带来的计算性能损耗。</br>
6-特别适合读请求远远大于写请求的场景。</br>

所以,可以总结为:

1-使用脏标记延迟写时的计算到读时再执行。</br>
2-只对有变动的脏数据重新计算,大幅减少冗余计算。</br>
3-脏标记模式广泛应用于渲染、数据库缓存、文件系统等需要频繁读写同一数据集的场景。</br>

举个例子

想象游戏世界中有一艘海上的海盗船。 桅杆的顶端有瞭望塔，瞭望塔中有海盗，海盗肩上有鹦鹉。 船本身的变换定位船在海上的位置。瞭望塔的变换定位它在船上的位置，诸如此类。

那我们更新物体的世界坐标的时候，比如我们更新了船，船的所有子类也要更新，再更新海盗，海盗肩膀上的鹦鹉也要更新，此时鹦鹉就重复了，我们引入脏标识就是为了不要重复计算；

最基础的，我们给出了一个Transform的类，和一个GrapNode表示我们准备更新的世界；

```cpp
class Transform
{
public:
  static Transform origin();

  Transform combine(Transform& other);
};
```

这是GraphNode, 目前只有local变化，和mesh这两个成员；
```cpp
class GraphNode
{
public:
  GraphNode(Mesh* mesh)
  : mesh_(mesh),
    local_(Transform::origin())
  {}

private:
  Transform local_;
  Mesh* mesh_;

  GraphNode* children_[MAX_CHILDREN];
  int numChildren_;
};
```

我们尚未优化的递归遍历方法如下，这样会引入很多重复计算；

```cpp
void GraphNode::render(Transform parentWorld)
{
  Transform world = local_.combine(parentWorld); //local的乘上parentWorld的

  if (mesh_) renderMesh(mesh_, world); //渲染Mesh

  for (int i = 0; i < numChildren_; i++)
  {
    children_[i]->render(world);
  }
}
```

我们可以使用脏标识, 关键是引入两个新的变量，一个是把Transform World单独拎出来了，另一个就是dirty字段

```cpp
class GraphNode
{
public:
  GraphNode(Mesh* mesh)
  : mesh_(mesh),
    local_(Transform::origin()),
    dirty_(true)
  {}

  // 其他方法……

private:
  Transform world_;
  bool dirty_;
  Transform local_;
  Mesh* mesh_;
};
```

当我们设置一个新的节点的时候，就去更新它的local矩阵和dirty变量

```cpp
void GraphNode::setTransform(Transform local)
{
  local_ = local;
  dirty_ = true;
}
```

然后我们render的时候，
根据这个 render 函数的实现，当父节点调用 render 函数时，
它会首先检查自身和父节点是否需要更新（通过 dirty 变量），
然后可能会更新自己的状态（比如 world_ 变量）。然后，如果父节点有网格，它会渲染自己的网格。

接下来，父节点会遍历所有的子节点，对每个子节点调用 render 函数。
这是一个递归的过程，因此，如果一个子节点也有自己的子节点，
那么这个子节点的子节点也会被渲染。

```
void GraphNode::render(Transform parentWorld, bool dirty)
{
  dirty |= dirty_; // 要是两个都为false，才为false

  // 如果是dirty，它就会用 local_.combine(parentWorld) 来更新 world_
  if (dirty)
  {
    world_ = local_.combine(parentWorld);
    dirty_ = false;
  }

  // 有mesh的话就渲染
  if (mesh_) renderMesh(mesh_, world_);

  // 遍历子节点
  for (int i = 0; i < numChildren_; i++)
  {
    children_[i]->render(world_, dirty);
  }
}
```

当一个节点及其所有父节点都没有被标记为 "dirty"（即它们的状态没有改变）时，
该节点的 world 变换就不需要重新计算。
因为 dirty 标志会在节点自身或任何父节点的状态改变时被设置为 true，
所以只有当节点和所有父节点的状态都没有改变时，
这个节点的 dirty 标志才会是 false。在这种情况下，
if (dirty) {...} 这个判断会跳过，从而避免了不必要的 world 变换的计算。