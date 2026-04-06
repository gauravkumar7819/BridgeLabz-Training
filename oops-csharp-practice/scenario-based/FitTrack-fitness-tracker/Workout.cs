using System;
using System.Collections.Generic;
using System.Text;

namespace FitTrack_fitness_tracker
{
		internal class Workout
		{
			private string workoutName;

			public string WorkoutName
			{
				get { return workoutName; }
				set { workoutName = value; }
			}

			public override string ToString()
			{
				return "Workout: " + workoutName;
			}
		}
	}


