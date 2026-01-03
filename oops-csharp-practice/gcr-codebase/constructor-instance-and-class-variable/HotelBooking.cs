using System;

class HotelBooking
{
    string guestName;
    string roomType;
    int nights;

    // Default constructor
    public HotelBooking()
    {
        guestName = "Guest";
        roomType = "Standard";
        nights = 1;
    }

    // Parameterized constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    // Copy constructor
    public HotelBooking(HotelBooking hb)
    {
        this.guestName = hb.guestName;
        this.roomType = hb.roomType;
        this.nights = hb.nights;
    }

    public void Display()
    {
        Console.WriteLine("Guest: " + guestName +
                          ", Room: " + roomType +
                          ", Nights: " + nights);
    }
}

class Program
{
    static void Main()
    {
        HotelBooking b1 = new HotelBooking(); // default
        HotelBooking b2 = new HotelBooking("Rahul", "Deluxe", 3); // parameterized
        HotelBooking b3 = new HotelBooking(b2); // copy

        b1.Display();
        b2.Display();
        b3.Display();
    }
}
