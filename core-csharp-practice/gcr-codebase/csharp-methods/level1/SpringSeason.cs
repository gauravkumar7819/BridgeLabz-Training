using System;
class SpringSeason{
static void Main(){
    int month=Convert.ToInt32(Console.ReadLine());
    int day=Convert.ToInt32(Console.ReadLine());
    //Spring Season is from March 20 to June 20
    string result=CheckSpringSeason(month,day);
    Console.WriteLine(result);
}
public static string CheckSpringSeason(int month,int day){
    if((month==3 && day>=20 && day<=31) || (month==4 && day>=1 && day<=30) || (month==5 && day>=1 && day<=31) || (month==6 && day>=1 && day<=20)){
        return "True";
    }
    else{
        return "False";
    }   
}   
}