using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;

namespace assignment1
{
    internal class Program
    {
        static void Q1()
        {
            Console.WriteLine("Welcome to the world of C#");
        }
        static void q2()
        {
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Hi! " + userName + " Welcome to the world of C#");
        }
        static void q3()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void q4()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");

        }
        static void q5()
        {
            int size, even, odd;
            int[] arr;
            Console.Write("Enter size of the array: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} elements in array:", size);

            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Number({0}) :", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            even = 0;
            odd = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            Console.Write("Total even elements: {0}\n", even);
            Console.Write("Total odd elements: {0}", odd);
        }
        static void q6()
        {

            int celsius, faren;
            Console.WriteLine("Enter the Temperature in Celsius(°C) : ");
            celsius = int.Parse(Console.ReadLine());
            faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit is(°F) : " + faren);
        }
        static void q7()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < a; i++)
            {
                Console.WriteLine(i * i);
            }
        }
        static void q8()
        {
            int i, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);

        }
        static void q9()
        {
            int f1 = 0, f2 = 1, i;

            Console.Write(f1 + " ");
            for (i = 1; i < 40; i++)
            {
                Console.Write(f2 + " ");
                int next = f1 + f2;
                f1 = f2;
                f2 = next;
            }
        }
    
    static void q10()
    {
            int n = int.Parse(Console.ReadLine());
            int n1 = 0;
            for (int i = 5; i <= n; i++)
            {
                n1 = n1 + i * i * i;
            }
            Console.WriteLine(n1);
        }
    static void q11()
    {
        int n = int.Parse(Console.ReadLine()); ;

        for (int i = 1; i <= 20; ++i)
            Console.Write(n + " * " + i +
                              " = " + n *
                               i + "\n");
    }


    static void q12()
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = 0;
            for (int i = 5; i <= n; i++)
            {
                n1 = n1 + i * i * i;
            }
            Console.WriteLine(n1);
        }
    static void q13()
        {
            int number1, number2, number3;
            string result;

            Console.Write("Input the first number :");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number :");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number :");
            number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                result = "The 1st Number is the greatest among three. \n";
            }
            else if (number2 > number1 && number2 > number3)
            {
                result = "The 2nd Number is the greatest among three \n";
            }
            else
            {
                result = "The 3rd Number is the greatest among three \n";
            }

            Console.WriteLine(result);


        }
        static void q14()
        {
            int size = 5;
            int[] arr;
            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Number({0}) :", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(arr.Min());
        }
        static void q15()
        {
            int[] arr = new int[10];
            int i;
            int j;
            int c = 0;
            int k = 0;
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > c)
                    c = arr[i];
                if (arr[i] < k)
                    k = arr[i];
            }
            Array.Sort(arr);
            int sum = arr.Sum();
            int avg = sum / 10;

            Console.WriteLine(avg);
            Console.WriteLine(sum);
            Console.WriteLine(c);
            Console.WriteLine(k);


            for (j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");
            }
            Console.WriteLine();
            Array.Reverse(arr);
            for (j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");
            }
        }
        static void q16()
        {
            string str = Console.ReadLine();

            Console.WriteLine("String: " + str);
            Console.WriteLine("String Length: " + str.Length);

        }
        static void q17()
        {
            string myStr, rev;
            myStr = Console.ReadLine();
            rev = "";
            Console.WriteLine("String is {0}", myStr);
            int len;
            len = myStr.Length - 1;
            while (len >= 0)
            {
                rev = rev + myStr[len];
                len--;
            }
            Console.WriteLine("Reversed String is {0}", rev);
        }
        static void q18()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            // Equals() method return true
            // as both string objects are equal
            Console.WriteLine(s1.Equals(s2));

        }
        static void q19()
        {
            string string1, rev;
            string1 = Console.ReadLine();
            char[] ch = string1.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + string1 + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + string1 + " is not a Palindrome!");
            }


        }

        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 1 || a > 19)
                Console.Write("Invalid input");
            else
            {
                if (a == 1)
                    Q1();
                else if (a == 2)
                    q2();
                else if (a == 3)
                    q3();
                else if (a == 4)
                    q4();
                else if (a == 5)
                    q5();
                else if (a == 6)
                    q6();
                else if (a == 7)
                    q7();
                else if (a == 8)
                    q8();
                else if (a == 9)
                    q9();
                else if (a == 10)
                    q10();
                else if (a == 11)
                    q11();
                else if (a == 12)
                    q12();
                else if (a == 13)
                    q13();
                else if (a == 14)
                    q14();
                else if (a == 15)
                    q15();
                else if (a == 16)
                    q16();
                else if (a == 17)
                    q17();
                else if (a == 18)
                    q18();
                else if (a == 19)
                    q19();
            }

        }
    }
}
