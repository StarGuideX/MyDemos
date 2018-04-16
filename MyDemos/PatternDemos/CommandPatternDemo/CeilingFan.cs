using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CommandPatternDemo
{
    public class CeilingFan
    {
        public enum CeilingFanType
        {
            OFF,
            LOW,
            MEDIUM,
            HIGH
        }
        string _location;
        int _speed;

        public CeilingFan(string location)
        {
            this._location = location;
            _speed = (int)CeilingFanType.OFF;
        }

        public void High()
        {
            _speed = (int)CeilingFanType.HIGH;
        }
        public void Medium()
        {
            _speed = (int)CeilingFanType.MEDIUM;
        }
        public void Low()
        {
            _speed = (int)CeilingFanType.LOW;
        }
        public void Off()
        {
            _speed = (int)CeilingFanType.OFF;
        }

        public int GetSpeed()
        {
            return _speed;
        }
    }
}
