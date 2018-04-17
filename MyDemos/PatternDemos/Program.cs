using PatternDemos.CommandPatternDemo;
using PatternDemos.CommandPatternDemo.Commands;
using PatternDemos.FactoryPatternDemo.Pizzas;
using PatternDemos.FactoryPatternDemo.Store;
using PatternDemos.ObserverPatternDemo.LocationTracker;
using PatternDemos.ObserverPatternDemo.Weather;
using PatternDemos.StrategyPatternDemo;
using oa = PatternDemos.AdapterPatternDemo.ObjectaAdapter;
using ca = PatternDemos.AdapterPatternDemo.ClassAdapter;
using System;

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

            #region
            oa.MallardDuck duck = new oa.MallardDuck();
            oa.WildTurkey turkey = new oa.WildTurkey();
            oa.Duck turkeyAdaper = new oa.TurkeyAdapter(turkey);
            Console.WriteLine("------火鸡------");
            turkey.Gobble();
            turkey.Fly();
            Console.WriteLine("------鸭子------");
            testDuck(duck);
            Console.WriteLine("------火鸡适配器------");
            testDuck(turkeyAdaper);
            Console.WriteLine("------火鸡适配器1111------");
            ca.Duck x = new ca.TurkeyAdapter();
            x.Fly();
            x.Quack();


            #endregion

            Console.ReadLine();
        }

        static void testDuck(oa.Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
