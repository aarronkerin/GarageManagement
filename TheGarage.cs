using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
   public class TheGarage
    {
        public List<Floor> ListOfFloors;
        public FittingService fittingService = new FittingService();

        public TheGarage()
        {
            ListOfFloors = new List<Floor>();
        }

        public Space FindASpace(Size size)
        {
            foreach (var floor in ListOfFloors)
            {
                foreach (var space in floor.ParkingSpaces)
                {
                    if (fittingService.IsVehicleAbleToFitIntoSpace(size, space.Size))
                    {
                        return space;
                    }
                }
            }
            return null;
        } 
    }
}