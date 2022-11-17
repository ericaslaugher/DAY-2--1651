using System;


namespace DemoStatic
{
    public class Student
    {
        public string Name {get; set;}

        public int Age {get; set;}

        public static string School = "GreenWich";
         
        public Student (String name , int age)
        {
        Name = name;
        Age = age;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Name: " + Name);
            System.Console.WriteLine("Age: " + Age);
            System.Console.WriteLine("School: " + School);
        }

    }

}