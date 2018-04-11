using System;
using System.Runtime.Serialization;

namespace PatternDemos.ObserverPatternDemo.LocationTracker
{
    internal class LocationUnknownException : Exception
    {
        public LocationUnknownException()
        {
        }
    }
}