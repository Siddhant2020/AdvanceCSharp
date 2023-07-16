using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomNumberDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Random random = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //Console.WriteLine(random.Next(5,11));
            //SimpleMethod(random);
            //}

            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{FirstName = "Siddhant"},
                new PersonModel{FirstName = "Tim"},
                new PersonModel{FirstName = "Sue"},
                new PersonModel{FirstName = "Jim"},
                new PersonModel{FirstName = "Ben"},
                new PersonModel{FirstName = "Dom"},
                new PersonModel{FirstName = "Sarah"}
            };

            var sortedPeople = people.OrderBy(x => random.Next());

            foreach (PersonModel person in sortedPeople)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }

        private static void SimpleMethod(Random random)
        {
            byte[] buffer = new byte[1024];
            random.NextBytes(buffer);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(buffer[i]);
            }
        }

    }

    public class PersonModel
    {
        public string FirstName { get; set; }
    }
}
