using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.StrategyPatternDemo
{
    // 所有飞行行为类必须实现的接口
    public interface FlyBehavior
    {
        void Fly();
    }
}
