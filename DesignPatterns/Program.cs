using DesignPatterns.Behavoural.ChainOfResponsibility;
using DesignPatterns.Behavoural.Observer.Observer;
using DesignPatterns.Behavoural.Observer.Subject;
using DesignPatterns.Behavoural.Strategy;
using DesignPatterns.Behavoural.Strategy.FlyStrategy;
using DesignPatterns.Behavoural.TemplateMethod;
using DesignPatterns.Creational;
using DesignPatterns.Creational.AbstractFactory.PizzaStore;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Factory.Pizza;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Adapter.Legacy;
using DesignPatterns.Structural.Adapter.LegacySystem;
using DesignPatterns.Structural.Adapter.Vendor;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using System;
using System.Collections.Generic;
using static DesignPatterns.Creational.Builder.Vehicle;

namespace DesignPatterns
{
    class Program
    {
        // Singleton client 
        static void Main(string[] args)
        {
            //// The Singleton client code
            //Singleton s1 = Singleton.GetInstance();
            //Singleton s2 = Singleton.GetInstance();
            //Singleton s3 = Singleton.GetInstance();

            //s1.SendPrintRequest("Command1");
            //s2.SendPrintRequest("Command2");
            //s3.SendPrintRequest("Command3");

            //if (s1 == s2 && s1 == s3)
            //{
            //    Console.WriteLine("Singleton works, All variables contain the same instance.");
            //}
            //else
            //{
            //    Console.WriteLine("Singleton failed, variables contain different instances.");
            // }


            //// The simple factory client code.
            //PizzaFactory factory = new PizzaFactory();
            //IMyPizza pizza = factory.CreatePizza("ny");
            //pizza.Prepare();

            // The abstract factory code
            PizzaStore store1 = new NYPizzaStore();
            store1.OrderPizza("cheeze");

            PizzaStore store2 = new ChicagoPizzaStore();
            store2.OrderPizza("cheeze");


            //// Builder pattern
            //Vehicle car = new Vehicle.VehicleBuilder().SetEngineAndWheel("Car", 4).SetAirBags(1).Build();
            //Vehicle scooter = new Vehicle.VehicleBuilder().SetEngineAndWheel("Scooter", 2).Build();
            //Console.WriteLine(car.GetEngine() + " " + car.GetWheel() + " " + car.GetAirBags());
            //Console.WriteLine(scooter.GetEngine() + " " + scooter.GetWheel() + " " + scooter.GetAirBags());

            //// Prototype
            //Prototype prototype = new ConcretePrototype1("I", 11111);
            //Prototype copy = (ConcretePrototype1)prototype.Clone();
            //Console.WriteLine("Cloned Id: {0} and additionalProperty {1}", copy.Id, copy.additionalProperty);
            //copy.additionalProperty = 55555;

            //Console.WriteLine("Cloned Changed Id: {0} and additionalProperty {1}", copy.Id, copy.additionalProperty);
            //Console.WriteLine("prototype Id: {0} and additionalProperty {1}", prototype.Id, prototype.additionalProperty);




            // Adapter
            //// Old system integrated
            //CityDuck duck = new CityDuck();
            //TurkeyUser firstTurkeyUser = new TurkeyUser(duck);
            //firstTurkeyUser.UseTurkey();

            //// New system integrated using Adapter
            //WildTurkey turkey = new WildTurkey();
            //TurkeyAdapter turkeyAdapterDuck = new TurkeyAdapter(turkey);
            //TurkeyUser secondTurkeyUser = new TurkeyUser(turkeyAdapterDuck);
            //secondTurkeyUser.UseTurkey();

            //// Bridge 
            //Payment payment = new NetBankingPayment();
            //IPaymentSystem paymentSystem = new IDBIPaymentSystem();
            //payment._PaymentSystem = paymentSystem;
            //payment.MakePayment();

            //// Composite 
            //IEmployee employee1 = new Employee("Ashish", "Infosec");
            //IEmployee employee2 = new Employee("Vicky", "Infosec");
            //IEmployee employee3 = new Employee("James", "Infosec");

            //IEmployee employee4 = new Employee("Vinod", "Sales");
            //IEmployee employee5 = new Employee("Vikram", "sales");

            //IEmployee manager1 = new Manager("Mahendra", "Infosec", new List<IEmployee> { employee1, employee2, employee3 });
            //manager1.Getdetails();

            ////IEmployee manager2 = new Manager("Kevin", "Infosec", new List<IEmployee> { employee4, employee5});
            ////manager2.Getdetails();



            //// Decorator
            //Pizza pizza = new PlainPizza();

            //ToppingDecorator toppingDecorator = new Mozzarella(pizza);
            //toppingDecorator = new Tomato(pizza);

            //Console.WriteLine(toppingDecorator.GetDescription());
            //Console.WriteLine(toppingDecorator.GetCost());

            ////Pizza pizza = new Mozzarella( new Tomato( new PlainPizza()));

            ////Console.WriteLine(pizza.GetDescription());
            ////Console.WriteLine(pizza.GetCost());



            //// Facade
            //IUserOrder userOrder = new UserOrder();
            //userOrder.AddToCart(3132, 1, 99889);
            //userOrder.PlaceOrder(99889, 888833);


            //// Behavoural

            //// Observer
            //IObserver observer1 = new Seller();
            //IObserver observer2 = new User();

            //DeliveryData subject = new DeliveryData();

            //subject.register(observer1);
            //subject.register(observer2);

            //subject.SetLocation("Antarctica");
            //subject.notifyObservers();

            //// Strategy pattern
            //Animal bird = new Bird();
            //bird.TryToFly();

            //Animal dog = new Dog();
            //dog.TryToFly();


            ////Chain of responsibility
            //IChain chainCalc1 = new AddNumbers();
            //IChain chainCalc2 = new SubtractNumbers();
            //IChain chainCalc3 = new MultiplyNumber();

            //chainCalc1.SetNextChain(chainCalc2);
            //chainCalc2.SetNextChain(chainCalc3);

            //Numbers request = new Numbers(4, 2, "Mul");
            //chainCalc1.Calculate(request);



            //// Template method
            //CaffeineBeverage coffee = new Coffee();
            //coffee.prepareRecipe();

            //CaffeineBeverage tea = new Tea();
            //tea.prepareRecipe();
        }






    }
}
