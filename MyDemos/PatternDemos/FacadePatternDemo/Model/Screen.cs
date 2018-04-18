using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.FacadePatternDemo.Model
{
    public class Screen
    {
        internal void Dowm()
        {
            Console.WriteLine("调用了Screen的Dowm方法...");
        }

        internal void Up()
        {
            Console.WriteLine("调用了Screen的Up方法...");
        }
    }
}
