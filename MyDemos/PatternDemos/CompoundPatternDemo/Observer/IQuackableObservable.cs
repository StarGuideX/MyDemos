using PatternDemos.CompoundPatternDemo.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CompoundPatternDemo.Observer
{
    public class IQuackableObservable : IObservable<IQuackable>
    {
        private List<IObserver<IQuackable>> observers;

        public IQuackableObservable()
        {
            observers = new List<IObserver<IQuackable>>();
        }

        public IDisposable Subscribe(IObserver<IQuackable> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<IQuackable>> _observers;
            private IObserver<IQuackable> _observer;

            public Unsubscriber(List<IObserver<IQuackable>> observers, IObserver<IQuackable> observer)
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

        public void Notify(IQuackable value)
        {
            IEnumerator items = observers.GetEnumerator();

            while (items.MoveNext())
            {
                IObserver<IQuackable> item = (IObserver<IQuackable>)items.Current;
                item.OnNext(value);
                //item.OnNext();
            }



        }
    }
}
