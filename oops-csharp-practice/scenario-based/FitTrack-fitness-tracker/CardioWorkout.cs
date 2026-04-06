using System;
using System.Collections.Generic;
using System.Text;

namespace FitTrack_fitness_tracker
{
    internal class CardioWorkout: Workout, IWorkout
    {
        public void EndWorkout()
        {
            Console.WriteLine("end Cardioworkout");
        }
        public void StartWorkout()
        {
                    Console.WriteLine("start Cardioworkout");

        }
	}
    
}
