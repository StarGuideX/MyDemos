﻿using PatternDemos.CommandPatternDemo;
using PatternDemos.CommandPatternDemo.Commands;
using PatternDemos.FactoryPatternDemo.Pizzas;
using PatternDemos.FactoryPatternDemo.Store;
using PatternDemos.ObserverPatternDemo.LocationTracker;
using PatternDemos.ObserverPatternDemo.Weather;
using PatternDemos.StrategyPatternDemo;
using oa = PatternDemos.AdapterPatternDemo.ObjectaAdapter;
using ca = PatternDemos.AdapterPatternDemo.ClassAdapter;
using System;
using PatternDemos.FacadePatternDemo;
using PatternDemos.FacadePatternDemo.Model;
using PatternDemos.TemplateMethodDemo;
using PatternDemos.TemplateMethodDemo.Hook;
using PatternDemos.IteratorPatternDemo;
using System.Collections;
using BI = PatternDemos.IteratorPatternDemo.BuiltIn;
using md = PatternDemos.IteratorPatternDemo.MenuDemo;
using PatternDemos.StatePatternDemo;
using PatternDemos.CompoundPatternDemo.Entity;
using PatternDemos.CompoundPatternDemo.Factory;
using PatternDemos.CompoundPatternDemo.Adapter;
using PatternDemos.CompoundPatternDemo.CompositeIterator;
using PatternDemos.CompoundPatternDemo.Observer;

namespace PatternDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 策略模式验证
            //Duck mallardDuck = new MallardDuck();
            //mallardDuck.PerformFly();
            //mallardDuck.PerformQuack();
            //mallardDuck.SetFlyBehavior(new FlyWithWings());
            //mallardDuck.SetQuackBehavior(new Quack());
            //mallardDuck.PerformFly();
            //mallardDuck.PerformQuack();
            #endregion

            #region 观察者模式验证
            //WeatherData weatherData = new WeatherData();
            //CurrentConditionDialpay currentConditionDialpay = new CurrentConditionDialpay(weatherData);
            //StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            //ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            //HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);
            //weatherData.SetMeasurements(80, 65, 30.4f);
            //weatherData.SetMeasurements(82, 70, 29.2f);
            //weatherData.SetMeasurements(78, 90, 29.2f);
            #endregion

            #region C#观察者模式验证
            //LocationTracker provider = new LocationTracker();
            //LocationReporter reporter1 = new LocationReporter("FixedGPS");
            //reporter1.Subscribe(provider);
            //LocationReporter reporter2 = new LocationReporter("MobileGPS");
            //reporter2.Subscribe(provider);
            //provider.TrackLocation(new Location(47.6456, -122.1312));
            //reporter1.Unsubscribe();
            //provider.TrackLocation(new Location(47.6677, -122.1199));
            //provider.TrackLocation(null);
            //provider.EndTransmission();
            #endregion

            #region 装饰者模式验证
            //Beverage beverage = new Espresso();
            //Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost());

            //Beverage beverage3 = new HouseBlend();
            //beverage3 = new Mocha(beverage3);
            //beverage3 = new Whip(beverage3);
            //Console.WriteLine(beverage3.GetDescription() + " $" + beverage.cost());
            #endregion

            #region 
            //PizzaStore nyPizzaStore = new NYStylePizzaStore();
            //Pizza pizza = nyPizzaStore.OrderPizza("Cheese");
            #endregion

            #region 命令模式验证
            //RemoteControl rc = new RemoteControl();
            //Light livingRoomLight = new Light("livingRoom");
            //Light kitchenLight = new Light("kitchenLight");
            //Stereo stereo = new Stereo("livingRoom");
            //CeilingFan ceilingFan = new CeilingFan("livingRoom");
            //LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            //LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            //LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            //LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);
            //StereoOnCommand stereoOn = new StereoOnCommand(stereo);
            //StereoOffCommand stereoOff = new StereoOffCommand(stereo);
            //CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
            //CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            //CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            //CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
            //rc.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            //rc.SetCommand(1, kitchenLightOn, kitchenLightOff);
            //rc.SetCommand(2, stereoOn, stereoOff);
            //rc.SetCommand(3, ceilingFanLow, ceilingFanOff);
            //rc.SetCommand(4, ceilingFanMedium, ceilingFanOff);
            //rc.SetCommand(5, ceilingFanHigh, ceilingFanOff);
            //Console.WriteLine(rc.ToString());
            //rc.OnButtonWasPushed(0);
            //rc.OffButtonWasPushed(0);
            //rc.OnButtonWasPushed(1);
            //rc.OffButtonWasPushed(1);
            //rc.OnButtonWasPushed(2);
            //rc.OffButtonWasPushed(2);
            //rc.OnButtonWasPushed(3);
            //rc.OffButtonWasPushed(3);
            //rc.OnButtonWasPushed(4);
            //rc.OffButtonWasPushed(4);
            //rc.OnButtonWasPushed(5);
            //rc.OffButtonWasPushed(5);
            //Console.WriteLine("------使用宏命令------");
            ////使用宏命令
            //Light marcoLight = new Light("marcoLight");
            //Stereo marcoStereo = new Stereo("marcoStereo");
            //CeilingFan marcoCeilingFan = new CeilingFan("marcoCeilingFan");
            //LightOnCommand marcoLightOn = new LightOnCommand(marcoLight);
            //LightOffCommand marcoLightOff = new LightOffCommand(marcoLight);
            //StereoOnCommand marcoStereoOn = new StereoOnCommand(marcoStereo);
            //StereoOffCommand marcoStereoOff = new StereoOffCommand(marcoStereo);
            //CeilingFanLowCommand marcoCeilingFanLow = new CeilingFanLowCommand(marcoCeilingFan);
            //CeilingFanOffCommand marcoCeilingFanOff = new CeilingFanOffCommand(marcoCeilingFan);

            //Command[] partOn = { marcoLightOn, marcoStereoOn, marcoCeilingFanLow };
            //Command[] partOff = { marcoLightOff, marcoStereoOff, marcoCeilingFanOff };

            //MacroCommand marcoOn = new MacroCommand(partOn);
            //MacroCommand marcoOff = new MacroCommand(partOff);
            //RemoteControl rc2 = new RemoteControl();
            //rc2.SetCommand(0, marcoOn, marcoOff);
            //rc2.OnButtonWasPushed(0);
            //rc2.OffButtonWasPushed(0);
            #endregion

            #region 适配器模式
            //oa.MallardDuck duck = new oa.MallardDuck();
            //oa.WildTurkey turkey = new oa.WildTurkey();
            //oa.Duck turkeyAdaper = new oa.TurkeyAdapter(turkey);
            //Console.WriteLine("------火鸡------");
            //turkey.Gobble();
            //turkey.Fly();
            //Console.WriteLine("------鸭子------");
            //testDuck(duck);
            //Console.WriteLine("------火鸡适配器（对象）------");
            //testDuck(turkeyAdaper);
            //Console.WriteLine("------火鸡适配器（类）------");
            //ca.Duck x = new ca.TurkeyAdapter();
            //x.Fly();
            //x.Quack();
            #endregion

            #region 外观模式
            //HomeTheaterFacade htf = new HomeTheaterFacade(new Amplifier(), new Tuner(), new DvdPlayer(),
            //    new CdPlayer(), new Projector(), new TheaterLights(),
            //    new Screen(), new PopcornPopper());

            //htf.WacthMovie("变形金刚");
            //htf.EndMovie();
            #endregion

            #region 模板方法模式
            //CaffeineBeverage tea = new Tea();
            //tea.PrepareRecipe();

            //CaffeineBeverage coffee = new Coffee();
            //coffee.PrepareRecipe();
            //Console.WriteLine("------带Hook的------");
            //CaffeineBeverageWithHook coffeewh = new CoffeeWithHook();
            //coffeewh.PrepareRecipe();
            #endregion

            #region 迭代器验证
            //md.MenuItem mdItem1 = new md.MenuItem("mdName1", "des1", true, 0.1);
            //md.MenuItem mdItem2 = new md.MenuItem("mdName2", "des2", false, 0.2);
            //md.MenuItem mdItem3 = new md.MenuItem("mdName3", "des3", true, 0.3);
            //md.MenuItem mdItem4 = new md.MenuItem("mdName4", "des4", false, 0.4);

            //md.MenuItem[] menu1 = { mdItem1, mdItem2, mdItem3, mdItem4 };

            //md.MenuItem dinerItem1 = new md.MenuItem("dinerName1", "des1", true, 0.1);
            //md.MenuItem dinerItem2 = new md.MenuItem("dinerName2", "des2", false, 0.2);
            //md.MenuItem dinerItem3 = new md.MenuItem("dinerName3", "des3", true, 0.3);
            //md.MenuItem dinerItem4 = new md.MenuItem("dinerName4", "des4", false, 0.4);
            //md.MenuItem[] menu2 = { dinerItem1, dinerItem2, dinerItem3, dinerItem4 };
            //md.Waitress waitress = new md.Waitress(new md.PancakeHouseMenu(menu1), new md.DinerMenu(menu2));
            //waitress.PrintMenu();

            #endregion

            #region C#迭代器验证
            //BI.MenuItem item1 = new BI.MenuItem("name1", "des1", true, 0.1);
            //BI.MenuItem item2 = new BI.MenuItem("name2", "des2", false, 0.2);
            //BI.MenuItem item3 = new BI.MenuItem("name3", "des3", true, 0.3);
            //BI.MenuItem item4 = new BI.MenuItem("name4", "des4", false, 0.4);


            //BI.MenuItem[] sharpEnum = { item1, item2, item3, item4 };
            //IEnumerator sharpEnumer = new BI.Menu(sharpEnum).GetEnumerator();
            //WriteMenu(sharpEnumer);
            #endregion

            #region 状态模式验证
            //GumballMachine gumballMachine = new GumballMachine(5);
            //Console.WriteLine(gumballMachine);

            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //Console.WriteLine(gumballMachine);

            //gumballMachine.InsertQuarter();
            //gumballMachine.EjectQuarter();
            //gumballMachine.TurnCrank();
            //Console.WriteLine(gumballMachine);

            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.EjectQuarter();
            //Console.WriteLine(gumballMachine);

            //gumballMachine.InsertQuarter();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //gumballMachine.InsertQuarter();
            //gumballMachine.TurnCrank();
            //Console.WriteLine(gumballMachine);
            #endregion

            #region 复合模式验证
            //DuckSimuLator duckSimuLator = new DuckSimuLator();
            //AbstractDuckFactory duckFactory = new CountingDuckFactory();
            //duckSimuLator.Simnulate(duckFactory);
            #endregion
            Console.ReadLine();
        }
        static void WriteMenu(IEnumerator iEnumerator)
        {
            while (iEnumerator.MoveNext())
            {
                Console.WriteLine(iEnumerator.Current.ToString());
            }
        }
        static void testDuck(oa.Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }

        /// <summary>
        /// 复合模式用
        /// </summary>
        internal class DuckSimuLator
        {
            internal void Simnulate(AbstractDuckFactory duckFactory)
            {
                //1.使用工厂创建鸭子
                //2.使用装饰者，创建被装饰的鸭子
                IQuackable blueheadDuck = duckFactory.CreateBlueheadDuck();
                IQuackable pinkheadDuck = duckFactory.CreatePinkheadDuck();
                IQuackable duckCall = duckFactory.CreateDuckCall();
                IQuackable rubberDuck = duckFactory.CreateRubberDuck();
                //使用适配器模式创建一个会鹅叫的鸭子。
                IQuackable gooseDuck = new GooseAdapter(new Goose());
                IQuackable[] quacks = { blueheadDuck, pinkheadDuck, duckCall, rubberDuck, gooseDuck };
                //使用组合模式和迭代器模式
                Flock flockOfDucks = new Flock(quacks);

                Console.WriteLine("------鸭子模拟器-------");
                Simnulate(flockOfDucks);

                Console.WriteLine("------观察开始-------");
                //使用观察者模式
                IQuackableObservable provider = new IQuackableObservable();
                IQuackableObserver reporter1 = new IQuackableObserver();
                reporter1.Subscribe(provider);
                provider.Notify(duckFactory.CreateRubberDuck());
                Console.WriteLine("------观察结束-------");

                Console.WriteLine("鸭子叫的次数为：" + QuackCounter.NumberOfQuacks);
            }

            void Simnulate(IQuackable duck)
            {
                duck.Quack();
            }
        }


    }
}
