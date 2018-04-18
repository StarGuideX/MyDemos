using PatternDemos.FacadePatternDemo.Model;
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

        public void WacthMovie(String movie)
        {
            Console.WriteLine("开始观看电影 " + movie + "...");
            _popper.On();
            _popper.Pop();
            _lights.Dim(10);
            _screen.Dowm();
            _projector.On();
            _projector.WideScreenMode();
            _amp.On();
            _amp.SetDvd(_dvd);
            _amp.SetSurroundSound();
            _amp.SetVolume(5);
            _dvd.On();
            _dvd.Play(movie);
        }

        public void EndMovie() {
            Console.WriteLine("结束电影...");
            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _dvd.Stop();
            _dvd.Eject();
            _dvd.Off();
        }
    }
}
