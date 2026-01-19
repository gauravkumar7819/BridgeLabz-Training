using System;

namespace FitnessApp
{
    class User
    {
        private string name;
        private int steps;

        public User(string name, int steps)
        {
            this.name = name;
            this.steps = steps;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Steps
        {
            get { return steps; }
            set { steps = value; }
        }
    }
}
