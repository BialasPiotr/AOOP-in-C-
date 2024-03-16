using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task;
using static Task.Car;

public class Car
{
    public string Manual { get; init; }
    public string Engine { get; init; }
    public string Seats { get; init; }
    public string TripComputer { get; init; }
    public string Gps { get; init; }

    private Car() { }

    public class CarBuilder : ICarBuilder
    {
        private string _seats;
        private string _engine;
        private string _tripComputer;
        private string _gps;
        private string _manual;

        public CarBuilder Reset()
        {
            _seats = _engine = _tripComputer = _gps = _manual = string.Empty;
            return this;
        }

        public CarBuilder SetEngine(string engine)
        {
            _engine = engine;
            return this;
        }

        public CarBuilder SetSeats(string seats)
        {
            _seats = seats;
            return this;
        }

        public CarBuilder SetTripComputer(string tripComputer)
        {
            _tripComputer = tripComputer;
            return this;
        }

        public CarBuilder SetGps(string gps)
        {
            _gps = gps;
            return this;
        }

        public CarBuilder SetManual(string manual)
        {
            _manual = manual;
            return this;
        }

        public Car Build()
        {
            return new Car
            {
                Engine = _engine,
                Seats = _seats,
                TripComputer = _tripComputer,
                Gps = _gps,
                Manual = _manual
            };
        }
    }
}

public interface ICarBuilder
{
    CarBuilder Reset();
    CarBuilder SetEngine(string engine);
    CarBuilder SetSeats(string seats);
    CarBuilder SetTripComputer(string tripComputer);
    CarBuilder SetGps(string gps);
    CarBuilder SetManual(string manual);
    Car Build();
}


