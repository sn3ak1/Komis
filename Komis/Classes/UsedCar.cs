using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Serialization;

namespace Komis
{
    [Serializable]
    public class UsedCar
    {
        [Serializable]
        public class Reservation
        {
            public DateTime Date { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }

            public Reservation(DateTime date, string name, string surname)
            {
                Date = date;
                Name = name;
                Surname = surname;
            }

            public Reservation()
            {
            }
        }
        
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public int Mileage { get; set; }
        public int ProductionYear { get; set; }
        public string Color { get; set; }

        public List<Reservation> Reservations { get; set; }

        public UsedCar(string brand, string model, string engine, int mileage, int productionYear, string color)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Mileage = mileage;
            ProductionYear = productionYear;
            Color = color;
            Reservations = new List<Reservation>();
        }

        public UsedCar()
        {
        }

        public override string ToString()
        {
            return $"{Brand} - {Model} - {Engine} - {Mileage} - {ProductionYear} - {Color}";
        }
    }
}