using System;

namespace Inheritance
{
    class Person
    {
        public string name;
    }

    interface Branchable
    {
        string getBranch();
    }

    class Student: Person, Branchable
    {
        string branch;

        public Student(string name, string branch)
        {
            this.name = name;
            this.branch = branch;
        }

        public string getBranch()
        {
            return branch;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student("Hemanth", "CSE");
            Console.WriteLine($"Student Name: {std.name}");
            Console.WriteLine($"Branch: {std.getBranch()}");
        }
    }
}
