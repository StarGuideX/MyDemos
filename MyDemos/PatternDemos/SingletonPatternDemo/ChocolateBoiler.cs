﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.SingletonPatternDemo
{
    public class ChocolateBoiler
    {
        private bool _empty;
        private bool _boiled;
        private static ChocolateBoiler _ChocolateBoiler;

        //处理多线程
        public static ChocolateBoiler GetInstance()
        {
            lock (_ChocolateBoiler.GetType())
            {
                if (_ChocolateBoiler == null)
                {
                    _ChocolateBoiler = new ChocolateBoiler();
                }
                return _ChocolateBoiler;
            }

        }

        //开始，锅炉是空的
        private ChocolateBoiler()
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
