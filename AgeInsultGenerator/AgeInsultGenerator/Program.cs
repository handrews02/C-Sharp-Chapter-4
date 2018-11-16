using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AgeInsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string ageString;
            int yes;
            string yesString;
            Write("Welcome to the famous Age Insult Generator!!!!");
            Write("Please enter your supposed age >> ");
            ageString = ReadLine();
            age = Convert.ToInt32(ageString);

            if(age < 18)
            {
                Write("You are a minor go back home before your mom yells at you for missing your bedtime!");
            }
            else if (age>=18 && age < 25)
            {
                Write("You should be starting your life off right now but instead you are a dead beat still living off their parents.");
            }
            else if(age >=25 && age< 32)
            {
                Write("Do you have a job? 1 for yes, 2 for no");
                yesString = ReadLine();
                yes = Convert.ToInt32(yesString);
                if (yes == 1)
                    Write("Good for you.");
                else
                    Write("Get off the couch and stop being a slob.");
            }
            else if(age>=32 && age<42)
            {
                Write("How does it feel to be a single loser living at home with your mommy?");
            }
            else if (age >=42 && age < 52)
            {
                Write("No spouse, no kids, no pets just you.");
            }
            else if (age >= 52 && age < 62)
            {
                Write("Not only are you alone but you are OLDDDDDD and alone! Nothing more sad than that");
            }
            else if(age >= 62)
            {
                Write("RIP you lived a long and boring life thank goodness it's almost over");
            }
        }
    }
}
