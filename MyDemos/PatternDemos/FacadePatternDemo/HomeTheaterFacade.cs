using PatternDemos.FacadePatternDemo.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.FacadePatternDemo
{
    public class HomeTheaterFacade
    {
        Amplifier _amp;
        Tuner _tuner;
        DvdPlayer _dvd;
        CdPlayer _cd;
        Projector _projector;
        TheaterLights _lights;
        Screen _screen;
        PopcornPopper _popper;

        public HomeTheaterFacade(Amplifier amp, Tuner tuner,
            DvdPlayer dvd, CdPlayer cd, Projector projector,
            TheaterLights lights, Screen screen, PopcornPopper popper)
        {
            this._amp = amp;
            this._tuner = tuner;
            this._dvd = dvd;
            this._cd = cd;
            this._projector = projector;
            this._lights = lights;
            this._screen = screen;
            this._popper = popper;
        }

        public void wacthMovie(String movie)
        {
            Console.WriteLine("开始观看电影 " + movie + "...");
            //_popper.
        }
    }
}
