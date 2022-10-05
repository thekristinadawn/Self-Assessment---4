using System;
using System.Linq;

namespace Self_Assessment___4
{
    internal class Program
    {
        //Exercise #2 -- COMPLETE
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


        //Exercise #3 -- COMPLETE

        //static void Main(string[] args)
        //{
        //    string inputNumber = Console.ReadLine();
        //    Console.WriteLine(EnglishName(inputNumber));
        //}

        //static string EnglishName(string number)
        //{
        //    Console.WriteLine("Please enter a number:");

        //    int lastDigit = number[number.Length - 1];
        //    string englishDigit = string.Empty;

        //    switch (lastDigit)
        //    {
        //        case '0':
        //            englishDigit = "zero"; 
        //            break;

        //        case '1':
        //            englishDigit = "one";
        //            break;
        //        case '2':
        //            englishDigit = "two";
        //            break;
        //        case '3':
        //            englishDigit = "three";
        //            break;
        //        case '4':
        //            englishDigit = "four";
        //            break;
        //        case '5':
        //            englishDigit = "five";
        //            break;
        //        case '6':
        //            englishDigit = "six";
        //            break;
        //        case '7':
        //            englishDigit = "seven";
        //            break;
        //        case '8':
        //            englishDigit = "eight";
        //            break;
        //        case '9':
        //            englishDigit = "nine";
        //            break;
        //    }
        //    return englishDigit;
        //}

        //Exercise #6

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Please input numbers.");
        //    int sizeArray1 = Convert.ToInt32(Console.ReadLine());
        //    int[] Array1 = new int[sizeArray1];

        //}

        //static int FirstOccurence(int firstElement)
        //    foreach(int Array1 in array)
        //    {
        //    if array==array+1
        //    }

        //Exercise #11 -- COMPLETE

        static void ReverseOrder()
        {
            int sizeArray1;
            Console.WriteLine("Enter Size of Array:");
            sizeArray1 = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[sizeArray1];
            Console.WriteLine("Enter numbers:");
            for (int i = 0; i < sizeArray1; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Reverse(array1);
            Console.WriteLine(String.Join(',', array1));

        }

        static void Average()
        {
            int sizeArray1;
            Console.WriteLine("Enter Size of Array:");
            sizeArray1 = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[sizeArray1];
            Console.WriteLine("Enter numbers:");
            for (int i = 0; i < sizeArray1; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = array1.Sum();
            int length = array1.Length;
            int average = sum / length;
            Console.WriteLine(average);
        }

        static void SolveLinearEquation()
        {
            Console.WriteLine("Please input a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input x:");
            int x = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Unlimited result equation");
                else
                    Console.WriteLine("No result");
            }
            else
            {
                x = -b / a;
                Console.WriteLine("1 result");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please select a task:");
            Console.WriteLine("1) Reverse Order");
            Console.WriteLine("2) Average");
            Console.WriteLine("3) Solve Linear Equation");
            int answer = Convert.ToInt32(Console.ReadLine());
 
            switch (answer)
            {
                case 1:
                    ReverseOrder();
                    break;
                case 2:
                    Average();
                    break;
                case 3:
                    SolveLinearEquation();
                    break;

            }
        }
    }
}
