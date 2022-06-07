using System;

namespace Garage
{
    public interface IGasVehicles
    {
        double CurrentTankPercentage {get;}
        void RefuelTank();
    }
}