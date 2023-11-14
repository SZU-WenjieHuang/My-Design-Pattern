//-------------------------------------------------------------------------------------
//	TestCommandPattern.cs
//-------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestCommandPattern : MonoBehaviour
{
    void Start()
    {
        Debug.Log("------------------Command Pattern--------------");
        IElectronicDevice device = TVRemove.GetDevice();

        TurnTVOn onCommand = new TurnTVOn(device);
        DeviceButton onPressed = new DeviceButton(onCommand);
        onPressed.Press();

        // -----------------------

        TurnTVOff offCommand = new TurnTVOff(device);
        onPressed = new DeviceButton(offCommand);
        onPressed.Press();

        TurnVolumeUp volUpCommand = new TurnVolumeUp(device);
        onPressed = new DeviceButton(volUpCommand);
        onPressed.Press();
        onPressed.Press();
        onPressed.Press();

        TurnVolumeDown volDownCommand = new TurnVolumeDown(device);
        onPressed = new DeviceButton(volDownCommand);
        onPressed.Press();

        // -----------------------
        Television tv = new Television();
        Radio radio = new Radio();

        List<IElectronicDevice> allDevices = new List<IElectronicDevice>();
        allDevices.Add(tv);
        allDevices.Add(radio);

        TurnItAllOff turnOffDevices = new TurnItAllOff(allDevices);
        DeviceButton turnThemOff = new DeviceButton(turnOffDevices);
        turnThemOff.Press();

        // -----------------------
        turnThemOff.PressUndo();

    }
}
/*
 这段代码也是一个实现了命令模式（Command Pattern）的示例，这次是用于控制电子设备（如电视和收音机）。在这个示例中，每一个操作（如打开电视、关闭电视、调高音量等）都被封装成一个命令对象。然后，这些命令对象可以被一个设备按钮（DeviceButton）执行。

这段代码中的主要类和它们的作用如下：

IElectronicDevice：这是一个接口，表示一个电子设备。具体的电子设备（如电视和收音机）需要实现这个接口。

TVRemove：这是一个工厂类，用于获取一个电子设备（在这个示例中是电视）。

TurnTVOn, TurnTVOff, TurnVolumeUp, TurnVolumeDown: 这些都是命令类，分别表示打开电视、关闭电视、调高音量和调低音量的操作。每一个命令类都有一个IElectronicDevice对象，代表被控制的设备。

DeviceButton：这是一个调用者类（Invoker）。它有一个命令对象，并且可以执行这个命令（通过调用Press方法）。

TestCommandPattern：这是一个使用了上述所有类的示例类。在这个类的Start方法中，创建了一个电视设备和一个设备按钮，然后执行了一系列的操作。最后，所有设备都被关闭，并且可以撤销这个操作（通过调用PressUndo方法）。

这个示例展示了命令模式的两个主要优点：

命令模式将操作的请求者（DeviceButton）和执行者（IElectronicDevice）解耦，使得请求者不需要知道执行者的任何信息，只需要知道如何发送请求。

由于每一个操作都被封装成一个命令对象，所以可以很容易地实现操作的撤销和重做。在这个示例中，通过调用PressUndo方法，可以撤销关闭所有设备的操作。
 */

/*
 
这里精妙在，把 每一个Command都单独抽象成了一个类，每次调用命令都通过实例化它来实现。
 */