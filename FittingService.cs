using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Services
{
    class FittingService
    {
        public bool IsVehicleAbleToFitIntoSpace(S vehicleSize, Size spaceSize)
        {
            if (vehicleSize.Height < spaceSize.Height || vehicleSize.Width < spaceSize.Width ||
                vehicleSize.Length < spaceSize.Length)
            {
                return false;
            }
            return true;
        }
    }

}
