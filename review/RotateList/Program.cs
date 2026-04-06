using System;
namespace RotateList{
class Program
{
  
       public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.AddLast(10);
        list.AddLast(20);  
        list.AddLast(30);  
        list.AddLast(40);  
       
        Console.WriteLine("Original List:");
        list.PrintList();
        list.ReverseKNodes(3);
        list.PrintList();
        // list.PrintList();

      
      
    }
    }
    
}