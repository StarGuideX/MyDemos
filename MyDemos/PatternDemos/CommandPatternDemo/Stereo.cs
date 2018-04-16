using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CommandPatternDemo
{
    public class Stereo
    {
        string _name;
        public Stereo(string name)
        {
            this._name = name;
        }

        public void On()
        {
            Console.WriteLine(_name + "在执行On...");
        }

        public void Off()
        {
            Console.WriteLine(_name + "在执行Off...");
        }

        public void SetCD()
        {
            Console.WriteLine(_name + "在执行SetCd...");
        }

        public void SetDVD()
        {
            Console.WriteLine(_name + "在执行SetDVD...");
        }

        public void SetRadio()
        {
            Console.WriteLine(_name + "在执行SetRadio...");
        }

        public void SetVolume(int value)
        {
            Console.WriteLine(_name + "在执行SetVolume...音量：" + value + "...");
        }
    }
}
