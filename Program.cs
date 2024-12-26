using System;

class Program
{
    static void Main()
    {
        void DisplayMenu() {
            Console.WriteLine("Welcome to C# quiz!\nPlease select an option from the menu:\n1. Pass the quiz\n2. Exit");
        }
        
        string[] questions = {
            "Which of the following are valid variable types in C#? (Select two)",
            "Which operators are used for logical comparisons in C#? (Select two)",
            "The switch statement in C# can handle multiple cases for the same condition.",
            "What keyword is used to declare a constant in C#?"
        };

        string[] answers =
        {
            "a) int\nb) float\nc) boolean\nd) string\ne) char",
            "a) &&\nb) ||\nc) ^^\nd) &\ne) !",
            "True \n False",
            ""
        };
        
        string AskQuestion(int question_number) {
            Console.WriteLine(questions[question_number - 1]);
            Console.WriteLine(answers[question_number - 1]);
            
            string user_answer = Console.ReadLine();
            return user_answer;
        }

        void CheckAnswer(int question_number, string answer) {
            if (question_number == 1) {
                
            } else if (question_number == 2) {
                
            } else if (question_number == 3) {
                
            } else if (question_number == 4) {
                
            } else {

            }
        }

        void DisplayScore() {
            
        }
        
        int score = 0;
        
        // while (true)
        // {
            DisplayMenu();
            int menu_selection = Convert.ToInt16(Console.ReadLine());
            switch (menu_selection) {
                case 1: 
                    Console.Clear();
                    Console.WriteLine("Welcome to the C# quiz.\n" +
                                      "You are about to start the quiz covering all basic C# topics\n" +
                                      "Please be carefull while answering and pay attention to any instructions\n");
                    string user_answer = AskQuestion(1);
                    CheckAnswer(1, user_answer);
                    Console.ReadLine();
                    break;
                case 2: 
                    Environment.Exit(5); 
                    break;
                default: 
                    Console.WriteLine("Invalid input. Please try again.\n"); 
                    break; 
            // }
        }
    }
}
