using Lesson_21_Collection.Utils;
using System;

namespace Lesson_21_Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sections = new CustomSections();

            sections.Add(new Section() { Cost = 10, Name = "Volleyball" });
            sections.Add(new Section() { Cost = -10, Name = "Football" });
            sections.Add(new Section() { Cost = 100, Name = "Ragby" });

            Console.WriteLine(sections["Ragby"]);

            sections.ForEach(Console.WriteLine);
            //sections.ForEach(WriteToFile);
        }

        static void WriteToFile(string data)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("D:\\Test.txt");
        }
    }
}
