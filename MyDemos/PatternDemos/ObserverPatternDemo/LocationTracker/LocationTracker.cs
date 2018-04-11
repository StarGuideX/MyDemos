using PatternDemos.ObserverPatternDemo.LocationTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.ObserverPatternDemo.LocationTracker
{
    //提供者
    public class LocationTracker : IObservable<Location>
    {
        private List<IObserver<Location>> observers;

        public LocationTracker()
        {
            observers = new List<IObserver<Location>>();
        }
        //将观察者对象的引用分配给一个泛型的 List<T> 对象(observers)，从而注册并接收来自 LocationTrack 对象的通知。
        public IDisposable Subscribe(IObserver<Location> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new Unsubscriber(observers, observer);
        }

        //可让观察程序停止接收通知的 IDisposable 实现。
        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Location>> _observers;
            private IObserver<Location> _observer;

            public Unsubscriber(List<IObserver<Location>> observers, IObserver<Location> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
        //调用每个观察者的OnNext方法  
        public void TrackLocation(Nullable<Location> loc)
        {
            foreach (var item in observers)
            {
                if (!loc.HasValue)
                {
                    //通知观察者，提供程序遇到错误情况。
                    item.OnError(new LocationUnknownException());
                }
                else
                {
                    //向观察者提供新数据。
                    item.OnNext(loc.Value);
                }

            }
        }
        //当未提供更多位置数据时，该方法将调用各观察者的 OnCompleted 方法，然后再清除观察者内部列表。
        public void EndTransmission()
        {
            foreach (var item in observers.ToArray())
            {
                if (observers.Contains(item))
                {
                    //通知观察者，提供程序已完成发送基于推送的通知。
                    item.OnCompleted();
                }
            }
            observers.Clear();
        }
    }
}
