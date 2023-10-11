using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public string EngineSize { get; set; } 
        public string Make { get; set; } 
        public string Model { get; set; } 
        public int Year { get; set; } 
        public string CompanyName { get; set; } 
        public string Logo { get; set; } 
        
        //Create 2 members that are specific to each class *Done
        public int Horsepower { get; set; } 
        public bool SportMode {  get; set; } = true;

        public void Drive()
        {
            Console.WriteLine($"It's a beautiful day! Today I think I'll drive my {GetType().Name}.");
        }     

       
    }
}
