using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.ObserverPatternDemo.Weather
{
    public class WeatherData : Subject
    {
        private IList _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new ArrayList();
        }

        //注册
        public void RegisterObserver(Observer o)
        {
            _observers.Add(o);
        }

        //取消注册
        public void RemoveObserver(Observer o)
        {
            int i = _observers.IndexOf(o);
            if (i >= 0)
            {
                _observers.Remove(i);
            }
        }

        //通知每一个观察者
        public void NotifyObservers()
        {
            foreach (Observer observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            MeasurementsChanged();
        }
    }
}
