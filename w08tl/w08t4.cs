using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w08tl
{
	class Program
	{
		public static void Main(string[] args)
		{
			int radius1, radius2;
			ring newRing = new ring();
			do
			{
				Console.WriteLine("Enter the Inner Radius: ");
				radius1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter the Outer Radius: ");
				radius2 = Convert.ToInt32(Console.ReadLine());
			} while (radius1 > radius2);	
			Console.WriteLine(newRing.ringArea(radius1, radius2));
			Console.ReadLine();
		}
	}

	class ring
	{
		public double circleArea(int radius)
		{
			return (Math.PI * radius * radius);
		}

		public double ringArea(int radius1, int radius2)
		{
			return (circleArea(radius2) - circleArea(radius1));
		}
	}
}
