using System;

class Person
{
    string name;
    int age;

    // Parameterized constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Copy constructor
    public Person(Person p)
    {
        this.name = p.name;
        this.age = p.age;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person("Rahul", 22);
        Person p2 = new Person(p1);   // copy constructor

        p1.Display();
        p2.Display();
    }
}

