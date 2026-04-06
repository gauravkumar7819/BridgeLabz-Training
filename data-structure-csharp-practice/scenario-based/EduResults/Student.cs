namespace EduResults
{
    class Student
    {
        public string Name { get; set; }
        public string District { get; set; }
        public int Score { get; set; }

        public Student(string name, string district, int score)
        {
            Name = name;
            District = district;
            Score = score;
        }

        public override string ToString()
        {
            return $"{Name} | {District} | {Score}";
        }
    }
}
