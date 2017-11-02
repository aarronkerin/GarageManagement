using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Garage.Vehicles
{
	public abstract class Vehicle
	{
		public string Registration;
		public Size Size;

		protected Vehicle(string reg, Size size)
		{
			Registration = reg;
			Size = size;
		}

	}
	
}
