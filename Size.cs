using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Size
    {
        public int Height;
        public int Lenght;
        public int Width;

        public Size(int height, int width, int lenght)
        {
            Height = height;
            Width = width;
            Lenght = lenght;
        }

        public int Length { get; internal set; }
    }
}
