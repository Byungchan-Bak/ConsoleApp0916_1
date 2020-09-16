using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp0916_1
{
    public class Person
    {
        string name;
        int age;
        double height;
        double weight;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] arr = new Person[3];

            for (int i = 0; i < arr.Length; i++)
            {
                Person p1 = new Person();

                Console.Write("이름 : ");
                p1.Name = Console.ReadLine();
                Console.Write("나이 : ");
                p1.Age = Utility.ConvertInt(Console.ReadLine());
                Console.Write("키 : ");
                p1.Height = Utility.ConvertDouble(Console.ReadLine());
                Console.Write("몸무게 : ");
                p1.Weight = Utility.ConvertDouble(Console.ReadLine());

                arr[i] = p1;
            }

            foreach (Person per in arr)
            {
                Console.WriteLine($"{per.Name}, {per.Age}, {per.Height}, {per.Weight}");
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i].Name}");
            }
        }
    }
}
