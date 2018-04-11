using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.ObserverPatternDemo.Weather
{
    public class ForecastDisplay : Observer, DisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            Display();
        }

        public void Display()
        {
            Console.WriteLine("预测: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("将会是很好的天气");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("将会是平常的天气");
            }
            else if (currentPressure < lastPressure)
            {
                Console.WriteLine("将会变冷，阴天");
            }
        }
    }
}
