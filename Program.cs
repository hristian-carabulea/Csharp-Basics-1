using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string phrase = "It ain't over until the fat lady sings!";
            string firstName = "Hristian";
            string lastName = "Carabulea";
            char initial1 = 'H';
            char initial2 = 'C';
            int myAge = DateTime.Today.Year - 2000;
            double myHeight = 1.79; // float, double, decimal
            bool isAmerican = true;

            string answerIsAmerican, answerIsGerman;

            int number1 = 5, number2 = 8, returnResult;

            int dayOfTheWeek;

            if (isAmerican)
            {
                answerIsAmerican = "Yes";
                answerIsGerman = "No";
            }
            else
            {
                answerIsAmerican = "No";
                answerIsGerman = "Yes";
            }

            Console.WriteLine(phrase + " The length of the phrase is " + phrase.Length + " characters.");
            Console.WriteLine("Does the phrase contain 'fat lady'? " + phrase.Contains("fat lady") + ".");
            Console.WriteLine("'fat lady' begins in position " + (uint)(phrase.IndexOf("fat lady") + 1) + " of the phrase.");
            Console.WriteLine("The sixth character in the phrase is " + phrase[5] + ".");
            Console.WriteLine("My name is " + firstName + " " + lastName + ".");
            Console.WriteLine("My initials are " + initial1 + " " + initial2 + ".");
            Console.WriteLine("My age is " + myAge + " years.");
            Console.WriteLine("My height is " + myHeight + " meters.");
            Console.WriteLine("Am I American? " + answerIsAmerican + ". Am I German? " + answerIsGerman + ".");
            Console.WriteLine("Between " + number1 + " and " + number2 + ", " + (returnResult = GetMax(number1, number2)) + " is greater.");

            dayOfTheWeek = 1;
            Console.WriteLine("The day of the week you entered is " + GetDay(dayOfTheWeek) + ".");

            int index = 0;
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int lengthDaysOfWeek = daysOfWeek.Length;

            Console.WriteLine("The days of the week in the array of string daysOfWeek using a while loop are: ");
            while (index < lengthDaysOfWeek)
            {
                Console.WriteLine(daysOfWeek[index]);
                index++;
            }

            Console.Write("The best day of the week is: ");
            Console.WriteLine(daysOfWeek[4] + ".");

            index = 0;
            Console.WriteLine("The days of the week in the array of string daysOfWeek using a do loop are: ");
            do
            {
                Console.WriteLine(daysOfWeek[index]);
                index++;
            } while (index < lengthDaysOfWeek);

            Console.ReadLine();
        }

        static int GetMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum - 1)
            {
                case 0:
                    dayName = "Monday";
                    break;
                case 1:
                    dayName = "Tuesday";
                    break;
                case 2:
                    dayName = "Wednesday";
                    break;
                case 3:
                    dayName = "Thursday";
                    break;
                case 4:
                    dayName = "Friday";
                    break;
                case 5:
                    dayName = "Saturday";
                    break;
                case 6:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "You entered an invalid day number. Enter a number between 1 ad 7.";
                    break;
            }
            return dayName;
        }
    }
}

