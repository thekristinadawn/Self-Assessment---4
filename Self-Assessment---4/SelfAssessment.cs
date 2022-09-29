using System;

namespace Self_Assessment___4
{
    internal class Program
    {

        //static void GetMax(int number1, int number2)
        //{

        //    int maxTwoNumbers = Math.Max(number1, number2);
        //    {
        //        return maxTwoNumbers;
        //    }
        //}

        //static void GetMaxThree(int number1, int number2, int number3)
        //{
        //    int maxThreeNumbers = Math.Max(Math.Max(number1, number2), number3);
        //    {
        //        Console.WriteLine(maxThreeNumbers);
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    GetMax(17, 2);
        //    GetMaxThree(8, 44, 21);
        //}


        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            Console.WriteLine(EnglishName(inputNumber));
        }

        static string EnglishName(string number)
        {
            Console.WriteLine("Please enter a number:");
            
            int lastDigit = number[number.Length - 1];
            string englishDigit = string.Empty;

            switch (lastDigit)
            {
                case '0':
                    englishDigit = "zero"; 
                    break;
                    
                case '1':
                    englishDigit = "one";
                    break;
                case '2':
                    englishDigit = "two";
                    break;
                case '3':
                    englishDigit = "three";
                    break;
                case '4':
                    englishDigit = "four";
                    break;
                case '5':
                    englishDigit = "five";
                    break;
                case '6':
                    englishDigit = "six";
                    break;
                case '7':
                    englishDigit = "seven";
                    break;
                case '8':
                    englishDigit = "eight";
                    break;
                case '9':
                    englishDigit = "nine";
                    break;
            }
            return englishDigit;
        }

       

    }
}
