namespace movies_scheduler_manager
{
    class Movie
    {
        private string movieName;
        private string showTime;

        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }

        public string ShowTime
        {
            get { return showTime; }
            set { showTime = value; }
        }

        // Constructor (FIXES WARNING)
        public Movie()
        {
            movieName = "";
            showTime = "";
        }

        public override string ToString()
        {
            return "Name: " + movieName + ", ShowTime: " + showTime;
        }
    }
}
