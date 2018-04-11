using PatternDemos.ObserverPatternDemo.LocationTracker;
using PatternDemos.ObserverPatternDemo.Weather;
using PatternDemos.StrategyPatternDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.ReadLine();
        }
    }
}
