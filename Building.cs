using System;

namespace Planner
{
    // Define class here

    public class Building
    {
        private string _designer = "Calvin Curry";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name)
        {
            _owner = name;
        }

        public string ProvideAddress()
        {
            return _address;
        }

        public string ProvideDesigner()
        {
            return _designer;
        }

        public DateTime ProvideBuildDate()
        {
            return _dateConstructed;
        }

        public string ProvideOwner()
        {
            return _owner;
        }
    }
}