using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.ObserverPatternDemo.Weather
{
    public interface Observer
    {
        //当气温观测值改变时，主题会把这些状态值当做方法的参数，传送给观察者。
        void Update(float temp, float humidity, float pressure);
    }
}
