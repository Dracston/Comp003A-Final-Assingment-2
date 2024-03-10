using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace Comp003A_Final_Assingment_2
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> questionarre = new List<string>(new string[] {
                "What is your First name?", //1
                "What is your Last name?", //2
                "What year were you born in?", //3 
                "Are you Male (M), Female (F), or another option (O)?", //4
                "How tall are you (In Inches)?", //5
                "On a scale from 1-10, what is your combat experience?", //6 
                "Are you willing to put your life on the line for Super Earth?\n(Yes/No)", //7 
                "What is your shoe size?", //8
                "In the event of a horific, sudden, potential, and unavoidable death by galactic entity, can your body be used for science?\n(Yes/No)", //9
                "How fast can you run 100 meters (In seconds)?", //10
                "Do you have previous Super Earth regulated firearm training?\n(Yes/No)", //11
                "Have you or a loved one been previously diagnosed with death by Terminid mutilation?\n(Yes/No)", //12
                "How much weight (In pounds) do you believe you could carry for 100 meters continously?", //13
                "Will you be needing any additional medical treatments/ supplies?\n(Yes/No)", //14
                "Which body part would you least want rennovated with bionic enhancements?"}); //15
            List<string> userAnswers = new List<string>();




            Console.WriteLine("Hello, and welcome to Helldiver enlistment! Below are a few short questions we need you to answer truthfully.");

            Console.WriteLine($"{questionarre[1]}");
            string firstName = Console.ReadLine();
            StringValidation(firstName);
            userAnswers.Add(firstName);

            Console.WriteLine($"{questionarre[2]}");
            string lastName = Console.ReadLine();
            StringValidation(lastName);
            userAnswers.Add(lastName);

            Console.WriteLine($"[{questionarre[3]}");
            string birthYear = Console.ReadLine();
            YearValidation(birthYear);
            userAnswers.Add(birthYear);

            Console.WriteLine($"{questionarre[4]}");
            char gender=Convert.ToChar(Console.ReadLine());
            GenderValidation(gender);
            userAnswers.Add(GenderValidation(gender));

            Console.WriteLine($"{questionarre[5]}");
            string userHeight = Console.ReadLine();
            HeightValidation(userHeight);
            userAnswers.Add(userHeight);

            Console.WriteLine($"{questionarre[6]}");
            string combatReady = Console.ReadLine();
            HeightValidation(combatReady);
            userAnswers.Add(combatReady);

            Console.WriteLine($"{questionarre[7]}");
            string questionSevenAnswer = Console.ReadLine();
            StringValidation(questionSevenAnswer);
            userAnswers.Add(questionSevenAnswer);

            Console.WriteLine($"{questionarre[8]}");
            string shoeSize = Console.ReadLine();
            HeightValidation(shoeSize);
            userAnswers.Add(shoeSize);

            Console.WriteLine($"{questionarre[9]}");
            string questionNineAnswer = Console.ReadLine();
            StringValidation(questionNineAnswer);
            userAnswers.Add(questionNineAnswer);

            Console.WriteLine($"{questionarre[10]}");
            string userSpeed = Console.ReadLine();
            HeightValidation(userSpeed);
            userAnswers.Add(userSpeed);

            Console.WriteLine($"{questionarre[11]}");
            string questionElevenAnswer = Console.ReadLine();
            StringValidation(questionElevenAnswer);
            userAnswers.Add(questionElevenAnswer);

            Console.WriteLine($"{questionarre[12]}");
            string questionTwelveAnswer = Console.ReadLine();
            StringValidation(questionTwelveAnswer);
            userAnswers.Add(questionTwelveAnswer);

            Console.WriteLine($"{questionarre[13]}");
            string carryWeight = Console.ReadLine();
            HeightValidation(carryWeight);
            userAnswers.Add(carryWeight);

            Console.WriteLine($"{questionarre[14]}");
            string questionFourteenAnswer = Console.ReadLine();
            StringValidation(questionFourteenAnswer);
            userAnswers.Add(questionFourteenAnswer);

            Console.WriteLine($"{questionarre[15]}");
            string questionFifteenAnswer = Console.ReadLine();
            StringValidation(questionFifteenAnswer);
            userAnswers.Add(questionFifteenAnswer);



            for (int i = 0; i < userAnswers.Count; i++)            
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
                  
                    

                }
                else
                {
                    Console.WriteLine("You want to try that again, too many numbers?");
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

        static string GenderValidation(char userInput)
        {
            
            
                char.ToUpper(userInput);
            
                if (userInput == 'M')
                {
                   string genderAnswer ="Male";
                    return genderAnswer; 
                }
                else if (userInput == 'F')
                {
                   string genderAnswer = "Female";
                    return genderAnswer;
                }
                else if (userInput == 'O')
                {
                    string genderAnswer = "Other";
                    return genderAnswer;
                }
            
                else 
                {
                Console.WriteLine("Please select 'M', 'F', or 'O'");
                return userInput.ToString();
                userInput =Convert.ToChar(Console.ReadLine());
                GenderValidation(userInput);
            
                } 
            
        }

    }
}
