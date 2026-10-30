using System;

namespace _30_10_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Tien", 175, 65, true);
            Console.WriteLine(person1.name + "\t" + person1.height + "\t" + person1.weight + "\t" + person1.ismale);
            Console.ReadLine();
        }
    }
