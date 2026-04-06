using System;
using System.Collections.Generic;
using System.Text;

namespace Line_comparison_system
{
    internal class CalculateIMPL:ICalculate
    {
		public double CalculateLength()
		{
			//formula for 
			double square1 = Math.Pow((x1Coordinate - x2Coordinate), 2);
			double square2 = Math.Pow((y1Coordinate - y2Coordinate), 2);

			double length = Math.Sqrt(square2 + square1);



			return length;
		}


	}
}
