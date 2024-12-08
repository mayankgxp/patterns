//Factory Pattern...
using patterns;

var result = FactoryPattern.GetProduct("A").GetName();
Console.WriteLine(result);

var car = new CarBuilder().SetName("Baleno").SetEngine("TFV").BuildCar();
Console.WriteLine(car);

IClientRequest clientRequest = new RequestAdapter();
clientRequest.ProcessRequst();


IComponent component = new ConcreteComponent();
IComponent decorator = new Decorator(component);
decorator.Execute();


var context = new Context();
context.SetStrategy(new StrategyA());
context.Execute();
context.SetStrategy(new StrategyB());
context.Execute();


var light = new Light();
var command = new LightCommand(light);
command.Execute();

var facadeObject = new Facade();
facadeObject.Operation();

IRequest proxyObject = new Proxy();
proxyObject.Reqest();

Subject subject = new Subject();
Observer observer = new Observer();
subject.Notify += observer.Notified;
subject.TriggerEvent();
