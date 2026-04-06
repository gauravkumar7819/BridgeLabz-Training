using System;
namespace Line_comparison_system
{
	class Program
	{
		static void Main(string[] args)
		{
			Line l1 = new Line();
			Line l2 = new Line();

			l1.X1Coordinate=1; l1.Y1Coordinate=2;
			l1.X2Coordinate=3; l1.Y2Coordinate=4;
			l2.X1Coordinate=5; l2.Y1Coordinate=6;
			l2.X1Coordinate = 23;l2.Y1Coordinate = 24;
			double lengthofl1 = l1.CalculateLength();
			double lengthofl2 = l1.CalculateLength();
			//ICalculate c = new Line();
			//double lengthofl1 = c.CalculateLength();
			//			double lengthofl2 = c.CalculateLength();
			//         Console.WriteLine(lengthofl2+""+lengthofl1);

		CalculateIMPL c
			if (lengthofl1 > lengthofl2)
			{
				Console.WriteLine("line 1 is bigger than line 2 with length:" + lengthofl1);
			}
			else {
				Console.WriteLine("line 2 is bigger than line1 with length:" + lengthofl2);
			}
				Console.WriteLine("this");
		}
	}
}