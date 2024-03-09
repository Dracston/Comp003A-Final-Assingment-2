namespace Comp003A_Final_Assingment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, and welcome to Helldiver enlistment! Below are a few short questions we need you to answer truthfully.");
            Console.WriteLine("Question1: What is your full name?");
            string userInput = Console.ReadLine();
            IntValidation(userInput);
            
            
        }
        static bool CheckInt(string userInput) ///<summary> Int Validation sending a boolean to make sure it is a number </summary>
        {
        
            try
            {
                int useResult = Convert.ToInt32(userInput);
            }
            catch (FormatException) { 
            }

        }
        static int CreateInt(string userInput) /// <summary> This is taking the same input as CheckInt and turning it into a usable int if calculations are needed </summary>
        {
            int useResult = Convert.ToInt32(userInput);
            return useResult;
        }
        static void IntValidation(string userInput) ///<summary> Validate my Int without making my program end just because of a bad int (currently stackoverflow)</summary>
        {
            if (CheckInt(userInput))
            {
                Console.WriteLine("These kids get younger by the batch!");
            }
            else
            {
                Console.WriteLine("Try that one more time, I need a number!");
                IntValidation(userInput);
            }

        }
    }
}
