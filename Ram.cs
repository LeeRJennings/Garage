using System;

namespace Garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives by playing music obnoxiously loud. 'some overplayed pop country song'");
        }

        public override void Turn(string direction)
        {
           Console.WriteLine($"The {MainColor} Ram turned {direction} without using their blinker. Classic.");
        }
    }
}