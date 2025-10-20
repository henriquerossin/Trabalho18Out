using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho18Out.Abstracts;
using Trabalho18Out.Enums;

namespace Trabalho18Out.Models
{
    internal class Truck : Vehicle
    {
        private int LoadCapacity { get; set; }
        private int Axles { get; set; }

        public Truck
            (
            string model,
            string brand,
            string licensePlate,
            Kind kind,
            string color,
            int year,
            double dailyCost,
            int loadCapacity,
            int axles
            )
            : base(model, brand, licensePlate, kind, color, year, dailyCost)
        {
            this.LoadCapacity = loadCapacity;
            this.Axles = axles;
        }
    }
}
