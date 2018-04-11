using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.ObserverPatternDemo.Weather
{
    public class CurrentConditionDialpay : Observer, DisplayElement
    {
        private float _temperature;
        private float _humidity;
        private Subject _weatherData;

        //构造器需要weatheData对象（或主题）作为注册用。
        public CurrentConditionDialpay(Subject weatherData)
        {
            this._weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        //当Update调用时，把温度和湿度保存起来，然后调用display();
        public void Update(float temp, float humidity, float pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;
            Display();
        }
        //将温度和湿度显示出
        public void Display()
        {
            Console.WriteLine("当前状况：温度" + _temperature + "F 度、湿度" + _humidity + "%");
        }
    }
}
