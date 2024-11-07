using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppTest
{
    internal class Quiz
    {
        private Question[] _questions; // Array to hold quiz questions.
        private int _score; // Variable to keep track of the user's score.

        // Constructor that initializes the quiz with an array of questions.
        // When a new Quiz object is created, it will require an array of Question objects as a parameter.
        public Quiz(Question[] questions)
        {
            // The 'this' keyword specifies the instance field _questions (not the constructor parameter).
            this._questions = questions;
            _score = 0; // Score starts at 0 when the quiz begins.
        }

        // Method to start the quiz and handle user interactions.
        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");
            int questionNumber = 1; // To keep track of the question number being displayed.

            // Loop through each question in the _questions array.
            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}:"); // Display current question number.
                DisplayQuestion(question); // Show the question and answer choices.
                int userChoice = GetUserChoice(); // Get the user's answer choice.

                // Check if the user's choice is correct.
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct!");
                    _score++; // Increment score if answer is correct.
                }
                else
                {
                    // Show the correct answer if the user's choice was wrong.
                    Console.WriteLine($"Wrong! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
            DisplayResults(); // Display the final score and performance feedback.
        }

        // Method to display the user's quiz results and provide feedback based on score.
        private void DisplayResults()
        {
            // Display styled results header.
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Results                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            // Display the user's final score.
            Console.WriteLine($"Quiz finished. Your score is: {_score} out of {_questions.Length}");

            // Calculate the percentage of correct answers and give performance feedback.
            double percentage = (double)_score / _questions.Length;
            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent Work!");
            }
            else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good effort!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep practicing");
            }
            Console.ResetColor();
        }

        // Method to display a question and its answer choices.
        private void DisplayQuestion(Question question)
        {
            // Display styled question header.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText); // Display the question text.

            // Loop to display each answer choice with a number (1-based indexing).
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("   ");
                Console.Write(i + 1); // Display option number.
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}"); // Display the answer text.
            }
        }

        // Method to get the user's answer choice as a number and validate it.
        private int GetUserChoice()
        {
            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;

            // Validate input to ensure it's a number within the valid range.
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4: ");
                input = Console.ReadLine();
            }

            return choice - 1; // Adjust user's input to 0-indexed array.
        }
    }
}
