using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Space
    {
        public bool Occupied;
        public Size Size;

        public Space(bool occupied, Size size)
        {
            Size = size;
            Occupied = occupied;
        }
    }
}
