using PatternDemos.ObserverPatternDemo.LocationTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.ObserverPatternDemo.LocationTracker
{
    //观察者
    public class LocationReporter : IObserver<Location>
    {
        private IDisposable unsubscriber;
        private string instName;

        public LocationReporter(string name)
        {
            this.instName = name;
        }

        public string Name
        {
            get
            {
                return this.instName;
            }
        }
        //通知提供者：某观察者将要接收通知。
        public virtual void Subscribe(IObservable<Location> provider)
        {
            if (provider != null)
            {
                unsubscriber = provider.Subscribe(this);
            }
        }
        //通知观察者，提供程序已完成发送基于推送的通知。
        public void OnCompleted()
        {
            Console.WriteLine("位置追踪者已经完成广播数据给 {0}.", this.Name);
            this.Unsubscribe();
        }

        //通知观察者，提供程序遇到错误情况。
        public void OnError(Exception error)
        {
            Console.WriteLine("{0}: 位置无法确定。", this.Name);
        }

        //向观察者提供新数据。
        public void OnNext(Location value)
        {
            Console.WriteLine("{2}: 当前位置是 is {0}, {1}", value.Latitude, value.Longitude, this.Name);
        }

        //某观察者将要取消接收通知。
        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
