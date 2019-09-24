# PureMVC
源码来源于官方网站[PureMVC](www.puremvc.org)

### 应用于Unity的PureMVC框架。
PureMVC在MVC的基础上又增加了Facade模式(外观模式)、Mediator模式(中介者模式)、Observer模式(观察者模式)、Proxy模式(代理模式)和Command模式(命令模式)

### 关于Proxy(model)
Proxy模式为代理模式，为其他对象提供一种代理，并以控制对这个对象的访问。
Proxy负责收发服务端的消息，也可以在其中写少量逻辑。收到消息后发送Notification到Mediator(view部分)，在Mediator可以实例化Proxy发送消息到服务端。

### 关于Mediator(view)
Mediator模式是中介者模式，用一个中介对象来封装一系列的对象交互。中介者使各对象不需要显式地相互引用，从而使其耦合松散，而且可以独立地改变它们之间的交互。
Mediator是直接处理UI显示部分的逻辑，包括事件监听，发送与接收Notification(通过Proxy发送， Notify接受)，把UI部分的逻辑写在这里，然后UI部分view类直接负责显示，这也解决了视图与视图控制逻辑的分离，减少耦合。

### 关于Command(command)
Command模式是命令模式，将一个请求封装为一个对象，从而使我们可用不同的请求对客户进行参数化；对请求排队或者记录请求日志，以及支持可撤销的操作。Command模式解耦了发送者与接收者之间的联系。
在PureMVC中，Controller保存了所有Command的映射。Command是无状态且惰性的，只有在需要的时候才被创建。

### 关于Facade(core)
PureMVC中的model、view、controller的调用是基于Facade模式的。 为子系统中的一组接口提供一个一致的界面， Facade模式定义了一个高层接口，这个接口使得这一子系统更加容易使用。引入外观角色之后，用户只需要直接与外观角色交互，用户与子系统之间的复杂关系由外观角色来实现，从而降低了系统的耦合度。
在PureMVC中，Facade是与核心层（Model,View,Controller）进行通信的唯一接口，目的是简化开发复杂度。实际编码过程中，不需要手动实现这三类文件，Facade类在构造方法中已经包含了对这三类单例的构造。
Facade是一个单例，以接口的形式来实现注册与删除Mediator、Command、Proxy(他们也都是单例)。

### 关于Observer(notification)
Observer模式是观察者模式， 定义对象间的一种一对多的依赖关系,当一个对象的状态发生改变时, 所有依赖于它的对象都得到通知并被自动更新。
PureMVC之间的通信是通过观察者模式发送通知来实现的，是一种松耦合的方法，Proxy向Mediator, Facade向Command发送通知Notification。
