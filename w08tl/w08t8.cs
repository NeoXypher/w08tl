using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w08tl
{
	class w08t8
	{
		
		public static void Main5()
		{
			Employee Zero = new Employee("Bob", "Jones", 34500);
			Employee One = new Employee("Susan", "Baker", 37809);
			Console.WriteLine("Employee 1: {0} {1}; Yearly Salary: {2}", Zero.First, Zero.Last, Zero.Salary);
			Console.WriteLine("Employee 2: {0} {1}; Yearly Salary: {2}", One.Last, One.Last, One.Salary);
			Zero.IncreaseSalary(10);
			One.IncreaseSalary(10);
			Console.WriteLine("Employee 1: {0} {1}; Yearly Salary: {2}", Zero.First, Zero.Last, Zero.Salary);
			Console.WriteLine("Employee 2: {0} {1}; Yearly Salary: {2}", One.Last, One.Last, One.Salary);
			Console.ReadLine();
		}
		
	}

	class Employee
	{
		string first, last;
		double salary;

		public Employee(string NewFirst, string NewLast, double NewSalary)
		{
			First = NewFirst;
			Last = NewLast;
			Salary = NewSalary;
		}

		public string First
		{
			get { return first; }
			set { first = value; }
		}

		public string Last
		{
			get { return last; }
			set { last = value; }
		}

		public double Salary
		{
			get { return salary; }
			set { if (value > 0)
				{
					salary = value;
				}
				else
					salary = 0;
			}
		}

		public void IncreaseSalary(double Percentage)
		{
			Salary = Salary * (1 + (Percentage / 100));
		}
	}
}
