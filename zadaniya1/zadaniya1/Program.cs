using System;
using System.Collections;

namespace zadaniya1
{
	class MainClass
	{
		public class Rectangle
		{
			double side1, side2;
			public Rectangle(double side1, double side2)
			{
				this.side1 = side1;
				this.side2 = side2;
			}

			public double AreaCalculator(double side1, double side2)
			{
				return side1 * side2;
			}
			public double PerimeterCalculator(double side1, double side2)
			{
				return (side1 + side2) * 2;
			}
			public double Area
			{
				get { return AreaCalculator(side1,side2); }
			}
			public double Perimetr
			{
				get { return PerimeterCalculator(side1,side2); }
			}
		}

			static void Main(string[] args)
			{
			double sd1, sd2;
			double.TryParse(Console.ReadLine(), out  sd1);
			double.TryParse(Console.ReadLine(), out  sd2);
			var rectangle = new Rectangle(sd1, sd2);
			Console.WriteLine("Area: {0}, Perimeter: {1}", rectangle.Area, rectangle.Perimetr);
			Console.ReadLine();
			}
	}
	



	}
