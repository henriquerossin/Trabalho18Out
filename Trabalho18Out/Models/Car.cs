using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho18Out.Abstracts;
using Trabalho18Out.Enums;

namespace Trabalho18Out.Models
{
    internal class Car : Vehicle
    {
        private bool ManualGearbox { get; set; }
        private int NumberOfPassengers { get; set; }

        public Car
            (
            string model,
            string brand,
            string licensePlate,
            Kind kind,
            string color,
            int year,
            double dailyCost,
            bool manualGearbox,
            int numberOfPassengers
            )
            : base(model, brand, licensePlate, kind, color, year, dailyCost)
        {
            this.ManualGearbox = manualGearbox;
            this.NumberOfPassengers = numberOfPassengers;
        }
    }
}
