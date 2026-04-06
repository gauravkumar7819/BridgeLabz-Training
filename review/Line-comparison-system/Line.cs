using System;
using System.Collections.Generic;
using System.Text;

namespace Line_comparison_system
{
    internal sealed class Line:ICalculate
    {
      private  int x1Coordinate;
		private int y1Coordinate;
		private int x2Coordinate;
		private int y2Coordinate;
        public int X1Coordinate
        {
            get
            {
                return x1Coordinate;
            }
            set { x1Coordinate = value; }
        }
		
		public int X2Coordinate
		{
			get
			{
				return x2Coordinate;
			}
			set { x2Coordinate = value; }
		}
		public int Y1Coordinate
		{
			get
			{
				return y1Coordinate;
			}
			set { y1Coordinate = value; }
		}
		public int Y2Coordinate
		{
			get
			{
				return y2Coordinate;
			}
			set { y2Coordinate = value; }
		}
		public  double CalculateLength()
		{
			//formula for 
		double square1=Math.Pow((x1Coordinate-x2Coordinate), 2);
			double square2 = Math.Pow((y1Coordinate - y2Coordinate), 2);

			double length = Math.Sqrt(square2 + square1);



return length;
		}


	}
}
