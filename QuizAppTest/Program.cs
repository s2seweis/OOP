using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppTest
{
    // Main program class for the quiz application
    internal class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            // Define an array of Question objects
            Question[] questions = new Question[]
            {
                // Create a new Question object for the first question
                new Question(
                    "What is the capital of Germany?",  // Question text
                    new string[] {"Paris", "Berlin", "London", "Madrid"}, // Array of possible answers
                    1 // Index of the correct answer (Berlin is the correct answer)
                ),
                // Create a new Question object for the second question
                new Question(
                    "What is 2+2?",  // Question text
                    new string[] {"3", "4", "5", "6"}, // Array of possible answers
                    1 // Index of the correct answer (4 is the correct answer)
                ),
                // Create a new Question object for the third question
                new Question(
                    "Who wrote 'Hamlet'?",  // Question text
                    new string[] {"Goethe", "Austen", "Shakespeare", "Dickens"}, // Array of possible answers
                    2 // Index of the correct answer (Shakespeare is the correct answer)
                )
            };

            // Create an instance of the Quiz class and pass the array of questions
            Quiz myQuiz = new Quiz(questions);

            // Start the quiz
            myQuiz.StartQuiz();

            // Wait for the user to press Enter before closing the application
            Console.ReadLine();
        }
    }
}
