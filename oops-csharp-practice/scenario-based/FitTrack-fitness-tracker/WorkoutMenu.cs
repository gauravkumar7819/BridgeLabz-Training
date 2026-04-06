using System;

namespace FitTrack_fitness_tracker
{
	internal class WorkoutMenu
	{
		public void ChoiceMenu()
		{
			Console.WriteLine("=== Workout Menu ===");

			// User Profile
			UserProfile user = new UserProfile();

			Console.Write("Enter your Name: ");
			user.UserName = Console.ReadLine();

			Console.Write("Enter your Age: ");
			user.Age = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter your Weight: ");
			user.Weight = Convert.ToInt32(Console.ReadLine());

			// Choose workout type
			Console.WriteLine("\nChoose Workout Type:");
			Console.WriteLine("1. Strength Workout");
			Console.WriteLine("2. Cardio Workout");

			string choice = Console.ReadLine();
			IWorkout workout = null;

			switch (choice)
			{
				case "1":
					workout = new StrengthWorkout();
					Console.WriteLine("Strength Workout Selected");
					break;

				case "2":
					workout = new CardioWorkout();
					Console.WriteLine("Cardio Workout Selected");
					break;

				default:
					Console.WriteLine("Invalid choice");
					return;
			}

			// Ask exercise AFTER workout type
			Console.Write("\nEnter Exercise Name: ");
			string exerciseName = Console.ReadLine();

			Workout w = (Workout)workout;
			w.WorkoutName = exerciseName;

			Console.WriteLine("Selected Workout: " + w);

			// Action
			Console.WriteLine("\n1. Start Workout");
			Console.WriteLine("2. End Workout");

			string action = Console.ReadLine();

			if (action == "1")
				workout.StartWorkout();
			else if (action == "2")
				workout.EndWorkout();
			else
				Console.WriteLine("Invalid action");
		}
	}
}
