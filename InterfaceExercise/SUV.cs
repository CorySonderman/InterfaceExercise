using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int Year { get; set; } 
        public string Make { get; set; } 
        public string Model { get; set; } 
        public string EngineSize { get; set; } 
        public string CompanyName { get; set; } 
        public string Logo { get; set; } 
        public bool HasChangedGears { get; set; }
        //Create 2 members that are specific to each class *Done

        public double CargoSizeCbFt { get; set; } 
        public bool EconomyMode { get; set; } = false;
        public void Drive()
        {
            Console.WriteLine($"The news said the native's are restless! Today I think better take my bullet proof {GetType().Name}.");

        }
    
        
    }
}
