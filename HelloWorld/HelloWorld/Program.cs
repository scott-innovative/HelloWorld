using System;

namespace HelloWorld
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person employee = new Person();
            employee.Name = "Scott Walker";
        }
    }
}
