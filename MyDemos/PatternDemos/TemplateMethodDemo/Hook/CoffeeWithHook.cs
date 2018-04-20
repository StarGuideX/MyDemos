using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.TemplateMethodDemo.Hook
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        internal override void AddCondiments()
        {
            Console.WriteLine("加入奶糖");
        }

        internal override void Brew()
        {
            Console.WriteLine("加入咖啡");
        }

        internal override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();

            if (answer.ToLower().Equals("y"))
            {
                return true;
            }

            return false;
        }

        private string GetUserInput()
        {
            string answer = null;

            Console.WriteLine("你想要加点牛奶或者糖么？（y/n）");
            try
            {
                answer = Console.ReadLine();
            }
            catch (IOException ioe)
            {
                Console.WriteLine("IO 错误" + ioe.InnerException);
            }
            if (answer == null)
            {
                return "n";
            }

            return answer;
        }
    }
}
