using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w08tl
{
	class Calculator2
	{
		public static void Main2(string[] args)
		{
			Console.WriteLine("~~~~~~ Acme Calculator-o-Matic ~~~~~~");
			Console.WriteLine("Enter two integers to add...");
			int number1 = Convert.ToInt32(args[0]);
			int number2 = Convert.ToInt32(args[1]);
			Console.WriteLine("Answer: {0}", Calculator2.add(number1, number2));
			Console.WriteLine("Average = {0}", Calculator2.average(args));
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

		private static double average(string[] args)
		{
			double total = 0;
			for (int i = 0; i < args.Length; i++)
			{
				total += Convert.ToDouble(args[i]);
			}
			return (total / args.Length);
		}
	}

	class Numbers
	{
		private int MyNumber;

		public int myNumber
		{
			get { return (MyNumber / 100); }
			set { MyNumber = value * 100; }
		}
	}
}
