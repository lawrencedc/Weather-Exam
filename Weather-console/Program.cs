using System;
using System.Threading.Tasks;
using Weather_console.Services;

namespace Weather_console
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Exam - Applicant Name: Lawrence\n");
            await Query.ConnectWeather();
            StartQuestionnaire();
        }

        public static void StartQuestionnaire()
        {
            Question1();
            Question2();
            Question3();
        }

        public static void Question1()
        {
            Console.WriteLine("Should I go outside?");
            AnswerSelection.Selections();
            var comment = Validation.ValidateAnswer1();
            Console.WriteLine($"{comment}\n");
        }

        public static void Question2()
        {
            Console.WriteLine("Should I wear sunscreen?");
            AnswerSelection.Selections();
            var comment = Validation.ValidateAnswer2();
            Console.WriteLine($"{comment}\n");                   
        }

        public static void Question3()
        {
            Console.WriteLine("Can I fly my kite?");
            AnswerSelection.Selections();
            var comment = Validation.ValidateAnswer3();
            Console.WriteLine($"{comment}\n");
        }

        


    }
}
