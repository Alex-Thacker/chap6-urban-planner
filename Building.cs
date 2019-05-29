using System;

namespace urban_planner
{
    public class Business {
        public Business(string address) {
            _address = address;
        }
        private string _designer = "Alex";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume {
            get {
                return Width * Depth * (3 * Stories);
            }
        }
        public DateTime dateConstructed () {
           return _dateConstructed = DateTime.Now;
        }
        public string purchase (string name) {
            return _owner = name; 
        }
        public void display () {
            Console.WriteLine(_address);
            Console.WriteLine("-------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }
    }
}
