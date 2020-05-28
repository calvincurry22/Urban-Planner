using System.Collections.Generic;

namespace Planner
{
    class City
    {
        private string _mayor;
        private int _yearEstablished;

        public string Name { get; }
        public string State { get; }
        public List<Building> Buildings { get; set; } = new List<Building>();
        public City(string name, string state)
        {
            Name = name;
            State = state;
        }

        public void Mayor(string mayorName)
        {
            _mayor = mayorName;
        }

        public void YearEstablished(int year)
        {
            _yearEstablished = year;
        }

        public string ProvideMayor()
        {
            return _mayor;
        }

        public int ProvideYearEstablished()
        {
            return _yearEstablished;
        }

        public void AddBuilding(Building newBuilding)
        {
            Buildings.Add(newBuilding);
        }

    }
}