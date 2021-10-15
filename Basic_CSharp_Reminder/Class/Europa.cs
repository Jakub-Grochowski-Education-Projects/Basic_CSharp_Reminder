using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp_Reminder.Class
{
    class Europa
    {
    }

    public class TV
    {
        private string _programName;
        private readonly float _size;

        public string ProgramName {
            get { return _programName; }
            set { _programName = value; }
        }

        public float Size
        {
            get { return _size; }
        }
        public TV(float size)
        {
            _size = size;
        }

        public void TurnOn(string programName)
        {
            _programName = programName;
            Console.WriteLine("Tv is running, program set: {0}", programName);
        }
        public void ChangeProgram(string programName)
        {
            _programName = programName;
            Console.WriteLine("Program change to: {0}", programName);
        }
        public void TurnOff()
        {
            Console.WriteLine("Tv is off");
        }

    }

    public class Chair
    {
        private bool _isFree;
        public bool IsFree
        {
            get { return _isFree; }
            set { _isFree = value; }
        }
        public Chair()
        {
            _isFree = true;
        }
    }

    public class Table
    {
        private List<Chair> _chairs;
        private readonly int _size;

        public List<Chair> Chairs { get { return _chairs; } }
        private Table()
        {
            _chairs = new List<Chair>();
        }

        public Table(int size)
        : this()
        {
            _size = size;
        }

        public void AddChair(Chair chair)
        {
            if (_chairs.Count + 1 < _size)
                Chairs.Add(chair);
        }
        public void AddChairs(List<Chair> chairs)
        {
            foreach (var c in chairs)
            {
                if (_chairs.Count + 1 < _size) Chairs.Add(c);
                else
                {
                    Console.WriteLine("There is no more space for new chairs");
                    //i can throw exception here but for this example there is no need to complicated it
                }
            }
        }
        public Chair RemoveChair()
        {
            Chair c;
            if (Chairs.Count > 0)
            {
                c = Chairs.ElementAt(0);
                Chairs.RemoveAt(0);
            }
            else
            {
                throw new Exception("There is 0 Chairs!");
            }
            return c;
        }

        public List<Chair> RemoveChairs(int number)
        {
            List<Chair> lc = new List<Chair>();
            if (Chairs.Count < number) throw new Exception("There is no " + number + "  Chairs in this table");
            else
            {
                for (int i = 0; i < number; i++)
                {
                    lc.Add(Chairs.ElementAt(i));
                    Chairs.RemoveAt(i);
                }
                return lc;
            }

        }

        public int FreeSeats()
        {
            int fs;
            fs = _size - Chairs.Count();
            return fs;
        }
    }

    public class Guest
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
    }

    public class Snooker
    {
        public bool _occupied;
    }

    public class Room
    {
        private TV _tV;
        private List<Table> _tables;
        private List<Guest> _guests;
        private List<Chair> _chairs;
        private List<Snooker> _snookers;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //private readonly int _seats;
        //public int Seats
        //{
        //    get { return _seats; }
        //}
        public List<Guest> Guests 
        { 
            get { return _guests; }
            set { _guests = value; } 
        }

        public List<Table> Tables
        {
            get { return _tables; }
            set { _tables = value; }
        }

        public List<Chair> Chairs
        {
            get { return _chairs; }
            set { _chairs = Chairs; }
        }
        public List<Snooker> Snookers
        {
            get { return _snookers; }
            set { _snookers = value; }
        }

        private Room()
        {
            Guests = new List<Guest>();
            Chairs = new List<Chair>();
            Tables = new List<Table>();
            Snookers = new List<Snooker>();
        }
        public Room(TV tv,string name)
        :this()
        {
            _tV = tv;
            Name = _name;
        }

        public void AssignChairs()
        {
            int pom = 0;
            int i = 0;

            foreach(var t in Tables)
            {
                pom = t.FreeSeats();
                pom = pom + i;
                while (i < pom && i<Chairs.Count)
                {
                    t.AddChair(Chairs.ElementAt(i));
                    i++;
                }

                if (i >= Chairs.Count)
                {
                    break;
                }
            }

        }
    }
    public class Restaurant
    {
        private List<Room> _rooms;
    }

}
