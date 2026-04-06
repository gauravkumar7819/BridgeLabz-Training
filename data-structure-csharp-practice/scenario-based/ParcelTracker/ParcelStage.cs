namespace ParcelTracker
{
    class ParcelStage
    {
        public string StageName;
        public ParcelStage Next;

        public ParcelStage(string name)
        {
            StageName = name;
            Next = null;
        }
    }
}
