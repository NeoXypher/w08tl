using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w08tl
{
	class Calculator
	{
		public static void Main1(string[] args)
		{
			Console.WriteLine("~~~~~~ Acme Calculator-o-Matic ~~~~~~");
			Console.WriteLine("Enter two integers to add...");
			int number1 = Convert.ToInt32(Console.ReadLine());
			int number2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Answer: {0}", Calculator.add(number1, number2));
			Console.ReadLine();
		}
		private static int add(int a, int b)
		{
			return (a + b);
		}

		private static double add(double a, double b)
		{
			return (a + b);
		}
	}
}
