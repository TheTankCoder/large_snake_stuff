﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace large_snake_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            string PersonResponse;
            int age=0;
            Console.WriteLine("Hello! What is your name?");
            PersonResponse = Console.ReadLine();
            Console.WriteLine("Hi {0}, how old are you?", PersonResponse);
            age = int.Parse(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("You are young!");
            }

            if (age > 25)
            {
                Console.WriteLine("You are getting old!");
            }

            if (age <= 25)
            {
                Console.WriteLine("Your gonna get old after a long time! Enjoy your youth!");
            }

            Console.WriteLine("");
            Console.WriteLine("So anyway, how are you doing? Busy lately?");
            PersonResponse = Console.ReadLine();
            Console.WriteLine("Same here... wanna play a game? C'mon, computers arn't that boring! :) ");
            PersonResponse = Console.ReadLine();
            Console.WriteLine("");
            if(PersonResponse == "sure")
            {
                Console.WriteLine("Awesome! Think of a number 1-5");
            }

            if(PersonResponse == "yes")
            {
                Console.WriteLine("Awesome! Think of a number 1-5");
            }

            if (PersonResponse == "yeah")
            {
                Console.WriteLine("Awesome! Think of a number 1-5");
            }

            int guess_number=0;
            guess_number = int.Parse(Console.ReadLine());

            if (guess_number == 3)
            {
                Console.WriteLine("Woah! You got it!");
            }

            if (guess_number!=3)
            {
                Console.WriteLine("Good guess. It was 3.");
            }
            Console.WriteLine("");
            Console.WriteLine("What computer do you think is best? Windows or Mac?");
            PersonResponse = Console.ReadLine();
            if (PersonResponse == "Windows")
            {
                Console.WriteLine("Why thank you! I am in fact running on Windows right now!");
            }

            if (PersonResponse == "Mac")
            {
                Console.WriteLine("Macs are good, they are efficient. I agree.");
            }
            if (PersonResponse == "Linux")
            {
                Console.WriteLine("I knew it!!! I just knew that someone would say Ubuntu!");
            }
            
            if (PersonResponse == "neither")
            {
                Console.WriteLine("Wow, you must hate computers!");
            }
            Console.WriteLine("Well. You are fun! I'm usually lonely.. but you really made my day.", PersonResponse);
            Console.WriteLine("");
            Console.WriteLine("'Til next time", PersonResponse);

            
            Console.ReadKey();
        }
    }
}
