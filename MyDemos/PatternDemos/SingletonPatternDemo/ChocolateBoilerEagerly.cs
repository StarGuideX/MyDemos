using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.SingletonPatternDemo
{
    public class ChocolateBoilerEagerly
    {
        private bool _empty;
        private bool _boiled;
        private static ChocolateBoilerEagerly _uniqueChocolateBoiler = new ChocolateBoilerEagerly();

        //应用程序总是创建并使用单例实例，或者在创建和运行是方面的负担不太繁重。
        //C#保证，在任何线程访问_uniqueChocolateBoiler静态变量之前，一定先创建此实例。
        public static ChocolateBoilerEagerly GetInstance()
        {
            return _uniqueChocolateBoiler;
        }

        //开始，锅炉是空的
        private ChocolateBoilerEagerly()
        {
            _empty = true;
            _boiled = true;
        }

        //锅炉为空，填充巧克力和牛奶
        public void fill()
        {
            if (IsEmpty())
            {
                _empty = false;
                _boiled = false;
            }
        }

        //锅炉不空，且没有煮，开始煮
        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                _boiled = true;
            }
        }

        //锅炉不空，且煮完了，锅炉空
        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                _empty = true;
            }
        }

        public bool IsEmpty()
        {
            return _empty;
        }

        public bool IsBoiled()
        {
            return _boiled;
        }
    }
}
