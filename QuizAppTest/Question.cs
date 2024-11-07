using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppTest
{
    // Class representing a question in the quiz
    internal class Question
    {
        // Property to store the text of the question
        public string QuestionText { get; set; }

        // Property to store the possible answers for the question
        public string[] Answers { get; set; }

        // Property to store the index of the correct answer in the Answers array
        public int CorrectAnswerIndex { get; set; }

        // Constructor to initialize the Question object with text, answers, and correct answer index
        public Question(string questionText, string[] answers, int correctAnswerIndex)
        {
            QuestionText = questionText;  // Assign the question text
            Answers = answers;            // Assign the array of possible answers
            CorrectAnswerIndex = correctAnswerIndex;  // Assign the index of the correct answer
        }

        // Method to check if a selected answer is correct
        public bool IsCorrectAnswer(int choice)
        {
            // Returns true if the choice matches the correct answer's index
            return CorrectAnswerIndex == choice;
        }

    }
}
