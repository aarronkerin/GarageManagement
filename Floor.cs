using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Floor
    {
        public List<Space> ParkingSpaces;

        public Floor(List<Space>spaces)
        {
            ParkingSpaces = spaces;
        }
    }
}
