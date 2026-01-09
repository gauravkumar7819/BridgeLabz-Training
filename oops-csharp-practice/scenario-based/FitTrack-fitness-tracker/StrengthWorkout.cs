using System;
using System.Collections.Generic;
using System.Text;

namespace FitTrack_fitness_tracker
{
    internal class StrengthWorkout : Workout, IWorkout
    {
        public void EndWorkout()
        {
            Console.WriteLine(" End strengthWorkout");
        }

        public void StartWorkout()
        {
			Console.WriteLine("Start strengthWorkout");
		}
    }
}
