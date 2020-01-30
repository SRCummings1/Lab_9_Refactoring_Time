using System;
using System.Collections;
using System.Collections.Generic;
namespace Lab_9_Refactoring_Time

{
    class Program
    {

        //public static string[] Student = new string[] { "Sean", "James", "Geralt", "Kyle", "Blake" };
        //public static string[] HomeTown = new string[] { "Alexander", "Andalusia", "Anniston", "Athens", "Atmore" };
        //public static string[] FavoriteFood = new string[] { "Ice Cream", "Pizza", "Bacon", "Sushi", "Steak" };
        static void Main(string[] args)
        {

                //variables and my lists    
                string input;
                int studentNumber;
                var Student = new List<string>() { "Sean", "James", "Geralt", "Kyle", "Blake" };
                var HomeTown = new List<string>() { "Alexander", "Andalusia", "Anniston", "Athens", "Atmore" };
                var FavoriteFood = new List<string>() { "Sean", "James", "Geralt", "Kyle", "Blake" };
                
                //begin program 
                Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about?(enter a number 1-5)");
                studentNumber = int.Parse(Console.ReadLine());
                // if else statements to determine student information and then close application after answered

                if (studentNumber >= 1 && studentNumber <= 5)
                {
                    Console.WriteLine("Student {0} is {1}. Would you like to know about {2}'s \"hometown\" and \"favorite food\")? (y/n)", studentNumber, Student[studentNumber - 1], Student[studentNumber - 1]);
                    // get input from user
                    input = Console.ReadLine();
              
                    //nested if statements
                    if (input == "y")
                {
                    Console.WriteLine("Students Hometown is:{0}", HomeTown[studentNumber - 1]);
                    Console.WriteLine("Students Favorite food is:{0} ", FavoriteFood[studentNumber - 1]);
                }
                else
                {
                    Console.WriteLine("Thanks, goodbye");
                }
                }

                else
                {
                    Console.WriteLine("That student does not exist. Please try again.(enter a number 1-5)");
                    studentNumber = int.Parse(Console.ReadLine());

                }



        }
    }
}
