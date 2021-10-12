using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp_Reminder.Class
{
    class Vehicle
    {
        private Engine engine;
        public readonly string _vehicleBrand;
        private int _vehicleWeight;

        public int VehicleWeight
        {
            get { return _vehicleWeight; }
            set { if (value > 0) _vehicleWeight = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { if (value != null) engine = value;
                engine.CalculateMaxSpeed(VehicleWeight + engine.Weight);
                }
        }

        public Vehicle(Engine engine, string vehicleBrand, int vehicleWeight)
        {
            Engine = engine;
            _vehicleBrand = vehicleBrand;
            VehicleWeight = vehicleWeight;
            Engine.CalculateMaxSpeed(VehicleWeight + Engine.Weight);
        }

        public void Move()
        {
            Console.WriteLine("I am geting to {0}",_vehicleBrand);
            engine.TurnOn();
            Console.WriteLine("I am driving with {0} max speed",Engine.MaxSpeed);
        }

        public void Stop()
        {
            Console.WriteLine("I am slowing down");
            Engine.TurnOff();
            Console.WriteLine("I Leave my Vehicle");
        }
    }
    class Engine
    {
        public readonly string _name;
        private int _numerOfHorseMechanical;
        private int _weight;
        private int _maxSpeed;


        public int Weight
        {
            get { return _weight; }
            set { if (value > 0) _weight = value;
                 }
        }
        public int NumberOfHorseMechanical
        {
            get { return _numerOfHorseMechanical; }
            set { _numerOfHorseMechanical = value; }
        }
        public int MaxSpeed
        {
            get { return _maxSpeed; }
        }

        private Engine(string name)
        {
            _name = name;
        }
        public Engine(string name,int weight,int numberOfHorseMechanical)
        :this(name)
        {
            Weight = weight;
            NumberOfHorseMechanical = numberOfHorseMechanical;
        }

        public void TurnOn()
        {
            if (_numerOfHorseMechanical < 40) Console.WriteLine("*Engine working quite*");
            if (_numerOfHorseMechanical > 40 && _numerOfHorseMechanical < 110) Console.WriteLine("vroom vroom");
            if (_numerOfHorseMechanical > 110) Console.WriteLine("VROOOM VROOM");
        }

        public void TurnOff()
        {
            Console.WriteLine("Engine just stop wroking");
        }
        public void CalculateMaxSpeed(int carWeight)
        {
            if (carWeight > 0)_maxSpeed = (_numerOfHorseMechanical * 4) - (carWeight/9);
            if (_maxSpeed > 3 * _numerOfHorseMechanical) _maxSpeed = 3 * _numerOfHorseMechanical;
        }

    }
}
