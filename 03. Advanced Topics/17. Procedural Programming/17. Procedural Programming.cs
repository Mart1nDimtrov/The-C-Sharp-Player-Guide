/*
Back to Procedural Programming.  Take the query statement to find all parents of teenagers 
just presented and rewrite it without using query syntax. This will probably require a couple of 
loops and an if statement. Compare which of the two is easier to understand at first glance.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Procedural_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person()
            {
                FirstName = "Peter",
                LastName = "Carrot",
                Weight = 150,
                Height = 60,
                Age = 25,
                Children = new List<Person>()
            });
            people.Add(new Person()
            {
                FirstName = "Carrie",
                LastName = "Stevens",
                Weight = 80,
                Height = 60,
                Age = 25,
                Children = new List<Person>() { new Person()
            {
                FirstName = "Bob",
                LastName = "Stew",
                Weight = 150,
                Height = 60,
                Age = 17
            },
            new Person()
            {
                FirstName = "Bibbie",
                LastName = "Potter",
                Weight = 150,
                Height = 60,
                Age = 15
            } }
            });
            people.Add(new Person()
            {
                FirstName = "Peter",
                LastName = "Rabbit",
                Weight = 80,
                Height = 60,
                Age = 25,
                Children = new List<Person>() { new Person()
            {
                FirstName = "Bob",
                LastName = "Stew",
                Weight = 150,
                Height = 60,
                Age = 12
            },
            new Person()
            {
                FirstName = "Bibbie",
                LastName = "Potter",
                Weight = 150,
                Height = 60,
                Age = 18
            } }
            });

            /* List<Person> parentsOfTeenagers =
                   (from person in people
                    from child in person.Children
                    where child.Age >= 13 && child.Age < 20
                    select person)
                   .ToList(); */

            List<Person> parentsOfTeenagers = new List<Person>();
            foreach (Person person in people)
            {
                foreach (Person Child in person.Children)
                {
                    if (Child.Age >= 13 && Child.Age < 20)
                    {
                        parentsOfTeenagers.Add(person);
                        break;
                    }
                }
            }

            foreach (Person person in parentsOfTeenagers)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }

        }
    }
}
