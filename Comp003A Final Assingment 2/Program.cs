using System.ComponentModel;

namespace Comp003A_Final_Assingment_2
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> questionarre = new List<string>(new string[] {
                "What is your full First name?",
                "What is your Last name?",
                "What year were you born in?", 
                "Are you Male (M), Female(F), or another option (O)",
                "How tall are you (In Inches)",
                "On a sclae from 1-10, what is your combat experience?", 
                "Are you willing to put your life on the line for Super Earth?\n(Yes/No)", 
                "What is your shoe size?",
                "In the event of a horific, sudden, potential, and unavoidable death by galactic entity, can your body be used for science?\n(Yes/No)",
                "How fast can you run 100 meters (In seconds)?", 
                "Do you have previous Super Earth regulated firearm training?\n(Yes/No)",
                "Have you or a loved one been previously diagnosed with death by terminid mutilation?\n(Yes/No)",
                "How much weight (In pounds) do you believe you could carry for 100 meters continously?",
                "Will you be needing any additional medical treatments/ supplies?\n(Yes/No)",
                "Which body part would you least want rennovated with bionic enhancements?"});
            List<string> userAnswers = new List<string>();




            Console.WriteLine("Hello, and welcome to Helldiver enlistment! Below are a few short questions we need you to answer truthfully.");
            Console.WriteLine("Question1: How Tal are you (In Inches)?");
            string userHeight = Console.ReadLine();
            HeightValidation(userHeight);
            userAnswers.Add(userHeight);
            Console.WriteLine("Question2: What year were you born in?");
            string birthYear= Console.ReadLine();
            YearValidation(birthYear); 
            userAnswers.Add(birthYear);
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            StringValidation(firstName);
            userAnswers.Add(firstName);



            for(int i = 0; i < userAnswers.Count; i++)            
            {
                
                Console.WriteLine(questionarre[i]);
                Console.WriteLine(userAnswers[i]);
                

            }



        }
        static bool CheckInt(string userInput)
            ///<summary> Int Validation sending a boolean to make sure it is a number </summary>
        {

            int result;
            return int.TryParse(userInput, out result);
           

        }
        static int CreateInt(string userInput) 
            /// <summary> This is taking the same input as CheckInt and turning it into a usable int if calculations are needed </summary>
        {
            int useResult = Convert.ToInt32(userInput);
            return useResult;
        }
       
        static string HeightValidation(string userHeight) 
            ///<summary> Validate my Int for asking someone's height</summary>
        {
            if (CheckInt(userHeight))
            {
               
                if (userHeight.Length <= 3 && userHeight.Length>=1)
                {
                  
                    Console.WriteLine("A bonified walking streetlight");

                }
                else
                {
                    Console.WriteLine("You want to try that again, but with your real height?");
                    userHeight = Console.ReadLine();
                    HeightValidation(userHeight);
                    //Internal loop smoothly allows the user to continue trying to enter data until it is the right data type
                }
            }
            else
            {
                Console.WriteLine("Try that one more time, I need a number!");
                userHeight = Console.ReadLine();
                HeightValidation(userHeight);
            }

            return userHeight;
        }
        
        static string YearValidation(string birthYear)
        {
            
            if (CheckInt(birthYear))
            {
                int userYear = Convert.ToInt32(birthYear);

                if (userYear < 1900)
                {
                    Console.WriteLine("Please re-enter birth year. You're not that old.");
                    birthYear = Console.ReadLine();
                    YearValidation(birthYear);
                }
                else if (userYear > 2024)
                {
                    Console.WriteLine("Please re-enter birth year. That's too young, even for us!");
                    birthYear = Console.ReadLine();
                    YearValidation(birthYear);
                }
                else if (userYear > 1900 && userYear < 2024)
                {
                    Console.WriteLine("Welcome aboard soldier!");
                    
                }
            }
            else 
            {
                Console.WriteLine("Try that one more time, I need a number!");
                birthYear = Console.ReadLine();
                YearValidation(birthYear);
            }
            return birthYear;
        }

        static string StringValidation(string userInput)
        {
            if (CheckInt(userInput))
            {
                Console.WriteLine("Give me a real answer, no need for numbers here");
                userInput = Console.ReadLine();
                StringValidation(userInput);
            }
            else if (!CheckInt(userInput))
            {
                
            }
            return userInput;
        }
    }
}
