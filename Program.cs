using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace quiz1
{
    internal class Program
    {
        static void Main()
        {
            StreamReader fileReader = new StreamReader("QUIZ1 name.txt");
            int correctAnswers = 0;
            int totalQuestions = 0;
            Console.WriteLine("Welcome to Yazdan's Trivia!, Enter your username below");
            string userName = Console.ReadLine();
            Console.WriteLine("Hey there " + userName + ", There will be a list of 10 questions, if you guess correctly, you recieve 1 point.\nGoodluck!\n\n");
            while (!fileReader.EndOfStream)
            {
                string data = fileReader.ReadLine();
                string[] stringsplit = data.Split(',');

                string question = stringsplit[0] + "\n" + stringsplit[1] + "\n" + stringsplit[2] + "\n" + stringsplit[3] + "\n" + stringsplit[4];
                Console.WriteLine(question);
                {
                    string answer = Console.ReadLine().ToUpper();
                    while (answer != "A" && answer != "B" && answer != "C" && answer != "D")
                    {
                        Console.WriteLine("Invalid, Try again");
                        answer = Console.ReadLine().ToUpper();
                    }
                    if (answer == stringsplit[5])
                    {
                        Console.WriteLine("Correct!\n");
                        correctAnswers++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! The Correct answer is " + stringsplit[5] + "\n");
                    }

                    totalQuestions++;
                }
            }
            Console.WriteLine("Quiz completed!");
            Console.WriteLine($"You answered {correctAnswers} out of {totalQuestions} questions correctly.\nPlay Again? (y/n)");
            string userChoice = Console.ReadLine().ToLower();
            if (userChoice == "Y" || userChoice == "y")
            {
                Main();
            }
            else if (userChoice == "N" || userChoice == "n")
            {
                Console.WriteLine("Thanks for playing " + userName + "!");
            }
            else if (userChoice != "Y" || userChoice != "y" || userChoice != "n" || userChoice != "N")
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
