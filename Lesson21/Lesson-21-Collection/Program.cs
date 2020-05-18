using Lesson_21_Collection.Utils;
using System;

namespace Lesson_21_Collection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var testSections = new CustomSections();

            testSections.Add(new Section { Price = 100, Name = "Volleyball" });
            testSections.Add(new Section { Price = -100, Name = "Football" });
            testSections.Add(new Section { Price = 10, Name = "Ragby" });

            testSections.ForEach(Console.WriteLine);

            Console.WriteLine("========================");

            var sections = new CustomCollectionFromZero<Section>();

            sections.Add(new Section { Price = 100, Name = "Volleyball" });
            sections.Add(new Section { Price = -100, Name = "Football" });
            sections.Add(new Section { Price = 10, Name = "Ragby" });

            foreach (var item in sections)
            {
                Console.WriteLine($"Name = {item.Name}, price = {item.Price}");
            }

        }
    }
}
