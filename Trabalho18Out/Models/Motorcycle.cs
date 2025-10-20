using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho18Out.Abstracts;
using Trabalho18Out.Enums;

namespace Trabalho18Out.Models
{
    public class Moto : Vehicle
    {
        private int EngineCapacity { get; set; }
        private int NumberOfPassengers { get; set; }

        public Moto
            (
            string model, 
            string brand, 
            string licensePlate, 
            Kind kind, 
            string color, 
            int year, 
            double dailyCost,
            int engineCapacity,
            int numberOfPassengers
            ) 
            : base(model, brand, licensePlate, kind, color, year, dailyCost)
        {
            this.EngineCapacity = EngineCapacity;
            this.NumberOfPassengers = NumberOfPassengers;
        }
    }
}
