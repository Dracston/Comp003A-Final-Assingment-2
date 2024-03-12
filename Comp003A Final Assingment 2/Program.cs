﻿using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace Comp003A_Final_Assingment_2
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> questionarre = new List<string>(new string[] {
                "What is your First name?", //0
                "What is your Last name?", //1
                "What year were you born in?", //2
                "Are you Male (M), Female (F), or another option (O)?", //3
                "How tall are you (In Inches)?", //4
                "On a scale from 1-10, what is your combat experience?", //5
                "Are you willing to put your life on the line for Super Earth?\n(Yes/No)", //6
                "What is your shoe size?", //7
                "In the event of a horific, sudden, potential, and unavoidable death by galactic entity, can your body be used for science?\n(Yes/No)", //8
                "How fast can you run 100 meters (In seconds)?", //9
                "Do you have previous Super Earth regulated firearm training?\n(Yes/No)", //10
                "Have you or a loved one been previously diagnosed with death by Terminid mutilation?\n(Yes/No)", //11
                "How much weight (In pounds) do you believe you could carry for 100 meters continously?", //12
                "Will you be needing any additional medical treatments/ supplies?\n(Yes/No)", //13
                "Which body part would you least want rennovated with bionic enhancements?"}); //14
            List<string> userAnswers = new List<string>(); //This empty list will hold all of the answers given



             
            //Each question was written individually, as each question needed different validation types
           
            
            Console.WriteLine("Hello, and welcome to Helldiver enlistment! Below are a few short questions we need you to answer truthfully.");

            StringQuestion(questionarre[0], userAnswers);

            Console.WriteLine($"{questionarre[0]}");  
            string firstName = Console.ReadLine();     
            StringValidation(firstName);               
            userAnswers.Add(firstName);               

            Console.WriteLine($"{questionarre[1]}");
            string lastName = Console.ReadLine();
            StringValidation(lastName);
            userAnswers.Add(lastName);

            Console.WriteLine($"{questionarre[2]}");
            string birthYear = Console.ReadLine();
            YearValidation(birthYear);
            userAnswers.Add(birthYear);

            
            
            Console.WriteLine($"{questionarre[3]}");
            char gender = Convert.ToChar(Console.ReadLine());
            GenderValidation(gender);
            userAnswers.Add(GenderValidation(gender));
            
            


            Console.WriteLine($"{questionarre[4]}");
            string userHeight = Console.ReadLine();
            HeightValidation(userHeight);
            userAnswers.Add(userHeight);

            Console.WriteLine($"{questionarre[5]}");
            string combatReady = Console.ReadLine();
            HeightValidation(combatReady);
            userAnswers.Add(combatReady);

            Console.WriteLine($"{questionarre[6]}");
            string questionSevenAnswer = Console.ReadLine();
            StringValidation(questionSevenAnswer);
            userAnswers.Add(questionSevenAnswer);

            Console.WriteLine($"{questionarre[7]}");  // Because HeightValidation allows for any int between 1-3 digits. O re-use it for all int validations.
            string shoeSize = Console.ReadLine();     // I just found it simple to keep the name as is. But HeightValidation = Validator for ant 1-3 digit number 
            HeightValidation(shoeSize);
            userAnswers.Add(shoeSize);

            Console.WriteLine($"{questionarre[8]}");
            string questionNineAnswer = Console.ReadLine();
            StringValidation(questionNineAnswer);
            userAnswers.Add(questionNineAnswer);

            Console.WriteLine($"{questionarre[9]}");
            string userSpeed = Console.ReadLine();
            HeightValidation(userSpeed);
            userAnswers.Add(userSpeed);

            Console.WriteLine($"{questionarre[10]}");
            string questionElevenAnswer = Console.ReadLine();
            StringValidation(questionElevenAnswer);
            userAnswers.Add(questionElevenAnswer);

            Console.WriteLine($"{questionarre[11]}");
            string questionTwelveAnswer = Console.ReadLine();
            StringValidation(questionTwelveAnswer);
            userAnswers.Add(questionTwelveAnswer);

            Console.WriteLine($"{questionarre[12]}");
            string carryWeight = Console.ReadLine();
            HeightValidation(carryWeight);
            userAnswers.Add(carryWeight);

            Console.WriteLine($"{questionarre[13]}");
            string questionFourteenAnswer = Console.ReadLine();
            StringValidation(questionFourteenAnswer);
            userAnswers.Add(questionFourteenAnswer);

            Console.WriteLine($"{questionarre[14]}");
            string questionFifteenAnswer = Console.ReadLine();
            StringValidation(questionFifteenAnswer);
            userAnswers.Add(questionFifteenAnswer);




            ///<summary>First while loop states the user's full name after it has been given. Second while loop stops the main for loop to write the user's age. 
            for (int i = 0; i < questionarre.Count; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine($"Full Name: {userAnswers[0]} {userAnswers[1]}.");
                    break;//break to avoid stackoverflow
                }


                else if (i == 3)
                {

                    Console.WriteLine($"Current age is: {DateTime.Now.Year - CreateInt(birthYear)}");
                    break; //break to avoid stackoverflow

                }
                else
                {
                    Console.WriteLine(questionarre[i]);
                    Console.WriteLine(userAnswers[i]);
                }

            }



        }
        ///<summary> Int Validation sending a boolean to make sure it is a number </summary>
        static bool CheckInt(string userInput)
            
        {

            int result;
            return int.TryParse(userInput, out result);
           

        }
        /// <summary> This is taking the same input as CheckInt and turning it into a usable int if calculations are needed </summary>
        static int CreateInt(string userInput) 
           
        {
            int useResult = Convert.ToInt32(userInput);
            return useResult;
        }

        ///<summary> Validate my Int for asking someone's height/ any 1-3 digit number </summary>
        static string HeightValidation(string userHeight) 
            
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
        { ///<summary> Validates whether the int added is between certain years. 
            
            if (CheckInt(birthYear))
            {
                int userYear = Convert.ToInt32(birthYear);

                if (userYear < 1900)
                {
                    Console.WriteLine("Please re-enter birth year. You're not that old."); //flavor text error message
                    birthYear = Console.ReadLine();
                    YearValidation(birthYear);
                }
                else if (userYear > DateTime.Now.Year)
                {
                    Console.WriteLine("Please re-enter birth year. That's too young, even for us!");
                    birthYear = Console.ReadLine();
                    YearValidation(birthYear);
                }
                
            }
            else //Checks here to make sure no null/ string values are given
            {
                Console.WriteLine("Try that one more time, I need a number!");
                birthYear = Console.ReadLine();
                YearValidation(birthYear);
            }
            return birthYear;
        }

        ///<summary>Simple Try.Parse, but code cluster only moves forward if the check is false </summary>
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
                
                if(userInput.Length == 0) //Secondary check to avoid Null values and re-loop statement
            {
                Console.WriteLine("Please answer the question.");
                userInput= Console.ReadLine();
                StringValidation(userInput);
            }
            return userInput;
        }

        ///<summary>
        ///Makes the user only able to input one char. Changes that char into a string for userAnswers list. 
        /// </summary>
        static string GenderValidation(char userInput)
        { 
           
            
            
                userInput= char.ToUpper(userInput);
            
                if (userInput == 'M') // If statements changes the characters into their full length word and returns one. 
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
                userInput = Convert.ToChar(Console.ReadLine());
                return userInput.ToString(); //This is mostly here so the Method feels like it will always have a return value occurring. 
                GenderValidation(userInput);
            
                } 
            
        }
        static void StringQuestion(List<string> fromQuestionnare, List<string> receivingArray)
        {
            Console.WriteLine($"{fromQuestionnare[0]}");  ///<param> Write the question out
            string firstName = Console.ReadLine();     /// Take a unique variable for the question and set it to ReadLine
            StringValidation(firstName);               /// Call the appropriate method. Either needing to validate a string or integer. Or two specialized ones
            receivingArray.Add(firstName);                /// Then save the returned string to the array of userAnswers[] </param>

        }

    }
}
