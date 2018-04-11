using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.ObserverPatternDemo.Weather
{
    public class StatisticsDisplay : Observer, DisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        private WeatherData weatherData;

        //构造器需要weatheData对象（或主题）作为注册用。
        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        //当Update调用时，计算最大温度和最小温度
        public void Update(float temp, float humidity, float pressure)
        {
            tempSum += temp;
            numReadings++;

            if (temp > maxTemp)
            {
                maxTemp = temp;
            }

            if (temp < minTemp)
            {
                minTemp = temp;
            }

            Display();
        }
        //显示平均/最大/最小 温度
        public void Display()
        {
           Console.WriteLine("平均/最大/最小 温度 ： " + (tempSum / numReadings)
                + "/" + maxTemp + "/" + minTemp);
        }
    }
}
