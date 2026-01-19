namespace ParcelTracker
{
    class Parcel
    {
        public string ProductName;
        public ParcelStage Head;

        public Parcel(string productName)
        {
            ProductName = productName;

            // Default stages
            Head = new ParcelStage("Packed");
            Head.Next = new ParcelStage("Shipped");
            Head.Next.Next = new ParcelStage("In Transit");
            Head.Next.Next.Next = new ParcelStage("Delivered");
        }
    }
}
