using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.ObserverPatternDemo.Weather
{
    public interface Subject
    {
        //注册观察者
        void RegisterObserver(Observer o);
        //删除观察者
        void RemoveObserver(Observer o);
        //当主题改变时，调用它，会通知所有观察者
        void NotifyObservers();
    }
}
