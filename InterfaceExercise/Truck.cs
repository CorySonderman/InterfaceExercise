using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string EngineSize { get; set; } 
        public string Make { get; set; } 
        public string Model { get; set; } 
        public int Year { get; set; } 
        public string CompanyName { get; set; } 
        public string Logo { get; set; } 
        public bool HasChangedGears { get; set; }
        //Create 2 members that are specific to each class *Done

        public bool HasFourWheelDrive { get; set; } = true;
        public double TowCapacityTon { get; set; } 
        public void Drive()
        {
            if (HasFourWheelDrive == true) 
            {
                Console.WriteLine($"It's snowing out... Better kick my {GetType().Name} into 4 wheel drive.");            
            }    
            else
            {
            Console.WriteLine($"Today I think I'll drive my {GetType().Name}.");
            }
        }
 
        

    }
}
