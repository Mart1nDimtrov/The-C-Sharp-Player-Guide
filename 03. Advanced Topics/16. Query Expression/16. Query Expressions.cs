/*
BMI.  In the world of health, a number called a Body Mass Index (BMI) can be calculated for a 
person given their height and weight. While not perfect, this gives people an idea of how much 
they weigh compared to their “ideal weight.” Using the Person class defined earlier in this 
chapter, and assuming that Height is measured in inches and Weight is measured in pounds, 
the formula for BMI is this:
𝐶𝑀𝐼 = (703 ∗ weight) / (height * height);
1.  Write a query expression to find all people in a list who are overweight, defined by a BMI 
higher than 25.
2.  Write another query expression to find all people who are in their ideal weight, defined 
by a BMI > 20 and < 25.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Query_Expression
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
                Age = 25
            });
            people.Add(new Person()
            {
                FirstName = "Carrie",
                LastName = "Stevens",
                Weight = 80,
                Height = 60,
                Age = 25
            });
            List<Person> overweightPeople = (from person in people
                                                    where (703 * person.Weight) / (person.Height * person.Height) > 25
                                                    select person)
                                                    .ToList();
            foreach (Person person in overweightPeople)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
     

        }
    }
}
