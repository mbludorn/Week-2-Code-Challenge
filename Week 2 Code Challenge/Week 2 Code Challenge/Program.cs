using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i <= 20; i = i + 1)
            {
                //Call the Fizzbuzz Function
                Fizzbuzz(i);
            }

                //Call the LetterCounter Function using the name and the different parameters
                LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
                
                LetterCounter('n', "Never gonna give up. Never gonna let you down.");
                
                LetterCounter('s', "Sally sells seashells by the seashore. She's from Sussex.");

            //Keep window open
            Console.ReadKey();
        }

        static void Fizzbuzz(int number)
        {
            //If number is divisible by 5 and 3 then print fizzbuzz
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("Fizzbuzz");
            }
            //If number is divisible by 5 print fizz
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            //If number is divisible by 3 print buzz 
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            //If not divisible by either 5 or 3 then print out the number
            else
            {
                Console.WriteLine(number);
            }
        }

        static void LetterCounter(char letter, string inString)
         {
            //declare variables to count the number of uppercase and lowercase letters
            int numUpper = 0;
            int numLower = 0;
            int totalNum = numUpper + numLower;
        
        for (int i = 0; i < inString.Length; i++)
        {
            if (inString[i] ==letter) 
            numLower++;
            if (inString[i] == letter)
            numUpper++;
        }
        

            //Print to the Console
             Console.WriteLine("Input:" + inString);
             Console.WriteLine("Number of lowercase letters is " + numLower);
             Console.WriteLine("Number of uppercase letters is " + numUpper);
             Console.WriteLine("Total number of letters is " + totalNum);
        }
       }
    }
