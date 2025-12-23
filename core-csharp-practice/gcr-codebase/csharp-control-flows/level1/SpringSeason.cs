using System;
class SpringSeason{
static void Main(){
    int month=Convert.ToInt32(Console.ReadLine());
    int day=Convert.ToInt32(Console.ReadLine());
    //Spring Season is from March 20 to June 20
bool isSpring= (month == 3 && day >= 20 && day <= 31) ||
                (month == 4 && day >= 1 && day <= 30) ||
                (month == 5 && day >= 1 && day <= 31) ||
                (month == 6 && day >= 1 && day <= 20);
    Console.WriteLine("Is the date in spring season: " + isSpring);
    
}}