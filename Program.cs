using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        void DisplayMenu() {
            Console.WriteLine("Welcome to C# quiz!\nPlease select an option from the menu:\n1. Pass the quiz\n2. Exit");
        }
        
        string[] questions = {
            "Which of the following are valid variable types in C#? (Select two)\n",
            "Which operators are used for logical comparisons in C#? (Select two)\n",
            "The switch statement in C# can handle multiple cases for the same condition.\n",
            "What keyword is used to declare a constant in C#?"
        };

        string[] answers_options =
        {
            "a) int\nb) float\nc) boolean\nd) string\ne) char\n",
            "a) &&\nb) ||\nc) ^^\nd) &\ne) !\n",
            "True \nFalse\n",
            ""
        };
        
        string[] correct_answers =
        {
            "a,d",
            "a,b",
            "false",
            "const"
        };
        
        int score;
        
        // Function to ask question and get user answer
        string AskQuestion(int question_number) {
            Console.WriteLine(questions[question_number - 1]);
            Console.WriteLine(answers_options[question_number - 1]);
            
            string user_answer = Console.ReadLine();
            return user_answer;
        }

        // Function to check whether user's answer was correct or not and also add score if answer is correct
        void CheckAnswer(int question_number, string answer) {
            string correct_answer = correct_answers[question_number - 1];
            string cleaned_answer = answer.ToLower().Trim().Replace(" ", string.Empty);

            if (cleaned_answer == correct_answer) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Correct answer for question {question_number}");
                Console.ResetColor();
                score += 5;
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Wrong answer for question {question_number}");
                Console.ResetColor();
            }
        }

        // Function to Display the total score to user with feedback
        void DisplayScore()
        {
            Console.WriteLine($"\nYour total score is: {score} out of 20.");
            double percentage = (double)score / 20 * 100;

            if (percentage >= 80)
                Console.WriteLine("Excellent!");
            else if (percentage >= 60)
                Console.WriteLine("Good!");
            else if (percentage >= 40)
                Console.WriteLine("Satisfactory (-)__(-)");
            else if (percentage >= 20)
                Console.WriteLine("Poor :(");
            else
                Console.WriteLine("Failed X(");
        }
        
        bool keepPlaying = true;
        
        while (keepPlaying)
        {
            score = 0;
            
            DisplayMenu();
            int menu_selection = Convert.ToInt16(Console.ReadLine());
            switch (menu_selection) {
                case 1: 
                    Console.Clear();
                    Console.WriteLine("1You are about to start the quiz covering all basic C# topics\n" +
                                      "Please be carefull while answering and pay attention to any instructions\n");
                    for (int i = 1; i < questions.Length + 1; i++) {
                        string user_answer = AskQuestion(i);
                        CheckAnswer(i, user_answer);
                        
                        Thread.Sleep(3000);
                        Console.Clear();
                    }

                    DisplayScore();
                    Console.WriteLine("\nDo you want to restart the quiz? (y/n)");
                    string restart = Console.ReadLine().Trim().ToLower();
                    if (restart != "y")
                    {
                        keepPlaying = false;
                    }
                    break;
                case 2: 
                    Environment.Exit(5); 
                    break;
                default: 
                    Console.WriteLine("Invalid input. Please try again.\n"); 
                    break; 
            }
        }
    }
}
