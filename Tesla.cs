using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public double CurrentChargePercentage {get; set;} = 64;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives by. bzzzzzzzzzzz");
        }
    }
}