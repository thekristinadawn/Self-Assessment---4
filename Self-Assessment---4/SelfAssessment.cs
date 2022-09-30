using System;
using System.Linq;

namespace Self_Assessment___4
{
    internal class Program
    {
        //Exercise #2
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


        //Exercise #3

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

        //Exercise #11

        static void main(string[] args)
        {
            ThreeTasks();
        }
        static int ThreeTasks(int number)
        {
            Console.WriteLine("Please select a task:");
            Console.WriteLine("1) Reverse Order");
            Console.WriteLine("2) Average");
            Console.WriteLine("3) Solve Linear Equation");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input numbers.");
            int sizearray1 = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    
                    int[] array1 = new int[sizearray1];
                    int reverseOrder = Array.Reverse(array1);
                    Console.WriteLine(reverseOrder);
                    break;
                case 2:
                    
                    int[] array2 = new int[sizearray1];
                    int sum = array2.Sum();
                    int length = array2.Length;
                    int average = sum / length;
                    Console.WriteLine(average);
                    break;
                case 3:
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
                    break;
                    //Solve the linear equation a * x + b = 0



            }
        }
    }
}
