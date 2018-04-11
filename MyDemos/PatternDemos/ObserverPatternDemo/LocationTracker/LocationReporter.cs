using PatternDemos.ObserverPatternDemo.LocationTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.ObserverPatternDemo.LocationTracker
{
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

        public virtual void Subscribe(IObservable<Location> provider)
        {
            if (provider != null)
            {
                unsubscriber = provider.Subscribe(this);
            }
        }

        public void OnCompleted()
        {
            Console.WriteLine("位置追踪者已经完成广播数据给 {0}.", this.Name);
            this.Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("{0}: 位置无法确定。", this.Name);
        }

        public void OnNext(Location value)
        {
            Console.WriteLine("{2}: 当前位置是 is {0}, {1}", value.Latitude, value.Longitude, this.Name);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
