using System;

namespace Komis
{
    [Serializable]
    public class UsedCar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public int Mileage { get; set; }
        public int ProductionYear { get; set; }
        public string Color { get; set; }

        public UsedCar(string brand, string model, string engine, int mileage, int productionYear, string color)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Mileage = mileage;
            ProductionYear = productionYear;
            Color = color;
        }

        public UsedCar()
        {
        }
    }
}