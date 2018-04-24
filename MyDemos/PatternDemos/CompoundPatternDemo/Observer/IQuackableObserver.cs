using PatternDemos.CompoundPatternDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CompoundPatternDemo.Observer
{
    public class IQuackableObserver : IObserver<IQuackable>
    {
        private IDisposable unsubscriber;


        //通知提供者：某观察者将要接收通知。
        public virtual void Subscribe(IObservable<IQuackable> provider)
        {
            if (provider != null)
            {
                unsubscriber = provider.Subscribe(this);
            }
        }
        public void OnCompleted()
        {
            Console.WriteLine("观察员：OnCompleted");
            this.Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("观察员：OnError");
        }

        public void OnNext(IQuackable value)
        {
            //调用鸭子叫
            value.Quack();
        }

        //某观察者将要取消接收通知。
        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
