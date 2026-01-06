using System;
namespace Bird_Sanctuary_System
{
	internal class Program
	{
static void Main(string[] args)
		{

			Bird[] birds =
		{
			new Eagle { Name = "Eagle", Color = "Brown" },
			new Sparrow { Name = "Sparrow", Color = "Gray" },
			new Duck { Name = "Duck", Color = "White" },
			new Penguin { Name = "Penguin", Color = "Black" },
			new Seagull { Name = "Seagull", Color = "White" }
		};
			Console.WriteLine(birds[0].ToString());

			foreach (Bird bird in birds)
			{
				bird.Eat();

				if (bird is IFlyable)
				{
					((IFlyable)bird).Fly();
				}

				if (bird is ISwimmable)
				{
					((ISwimmable)bird).Swim();
				}

				Console.WriteLine("-------------------");
			}
		}
	}
}