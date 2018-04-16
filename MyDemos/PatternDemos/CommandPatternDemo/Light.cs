using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CommandPatternDemo
{
    public class Light
    {
        string _name;


        public Light(string name) {
            this._name = name;
        }
        public void On() {
            Console.WriteLine(_name+"在执行On...");
        }
        public void Off() {
            Console.WriteLine(_name + "在执行Off...");
        }
    }
}
