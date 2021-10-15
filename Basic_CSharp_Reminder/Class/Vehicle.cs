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
        private int _maxSpeed;
        public int MaxSpeed
        {
            get { return _maxSpeed; }
        }
        public int VehicleWeight
        {
            get { return _vehicleWeight; }
            set { if (value > 0) _vehicleWeight = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { if (value != null) engine = value;
           
            }
        }

        public Vehicle(Engine engine, string vehicleBrand, int vehicleWeight)
        {
            Engine = engine;
            _vehicleBrand = vehicleBrand;
            VehicleWeight = vehicleWeight;
            CalculateMaxSpeed();
        }

        public void Move()
        {
            Console.WriteLine("I am geting to {0}",_vehicleBrand);
            engine.TurnOn();
            Console.WriteLine("I am driving with {0} max speed",_maxSpeed);
        }

        public void Stop()
        {
            Console.WriteLine("I am slowing down");
            Engine.TurnOff();
            Console.WriteLine("I Leave my Vehicle");
        }
        private void CalculateMaxSpeed()
        {
             _maxSpeed = (Engine.NumberOfHorseMechanical * 4) - (int)((VehicleWeight+Engine.Weight) / 4.5);
            if (_maxSpeed > 2.2 * Engine.NumberOfHorseMechanical) _maxSpeed = (int)(2.2 * Engine.NumberOfHorseMechanical);
        }

    }
    class Engine
    {
        public readonly string _name;
        private int _numerOfHorseMechanical;
        private int _weight;
       


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
     
    }
}
