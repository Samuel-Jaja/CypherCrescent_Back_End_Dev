using System;
using System.Collections.Generic;

namespace Methods_Recursion
{
    internal class Program
    {
        //Invocation of Methods in main entry
        static void Main(string[] args)
        {
            //Method Q1 Call
            int a, b, c;
            Console.Write("Enter a : ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter b : ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter c : ");
            c = Int32.Parse(Console.ReadLine());

            SolveQuadratic(a, b, c);

            //Method Q2 Call
            int num1 = Factorial1(5);
            Console.WriteLine(num1);
            
            int num2 = Factorial2(5);
            Console.WriteLine(num2);

            //Method Q3 Call
            Console.WriteLine(ValuePassed("2"));

            //Method Q4 Call
            int data = NumberOfStringChar("Engineering");
            Console.WriteLine(data);



            //Recursion Q2 Call
            string firstname = "CypherCrescent";
            Console.WriteLine(LengthOfString(firstname));

            //Recursion Q3 Call
            PrimeNumberGenerator(1, 10);

            //Recursion Q4 Call


        }


        //Methods Q1
        public static void SolveQuadratic(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            double x, x1, x2, imaginary;
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
               
                Console.WriteLine("Two Real Solutions: {0} or  {1}", x1, x2);
            }
            else if (d < 0)
            {
                d = -d;
                x = -b / (2 * a);
                imaginary = Math.Sqrt(d) / (2 * a);
               
                Console.WriteLine("Two Imaginary Solutions: {0} + {1} i or {2} + {3} i", x, imaginary, x, imaginary);
            }
            else
            {
                x = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("One Real Solution: {0}", x);
            }

        }


        //Methods Q2
        public static int Factorial1(int number)  //Recursively
        {
            if (number <= 1)
                return 1;
            return number * Factorial1(number - 1);
        }

        public static int Factorial2(int number)
        {
            if (number <= 1)
                return 1;
            int result = 1;
            for (int i = 2; i <= number; i++) //Iteratively
            {
                result = result * i;
            }
            return result;

        }


        //Methods Q3

        public static string ValuePassed(string Number)
        {
            int num = Convert.ToInt32(Number);
            string name = "";
            switch (num)
            {
                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
                case 10:
                    name = "Ten";
                    break;
                case 20:
                    name = "Twenty";
                    break;
                case 30:
                    name = "Thirty";
                    break;
                case 40:
                    name = "Fourty";
                    break;
                case 50:
                    name = "Fifty";
                    break;
                case 60:
                    name = "Sixty";
                    break;
                case 70:
                    name = "Seventy";
                    break;
                case 80:
                    name = "Eighty";
                    break;
                case 90:
                    name = "Ninety";
                    break;
                case 100:
                    name = "One Hundred";
                    break;
            }
            return name;
        }


        //Methods Q4
        public static int NumberOfStringChar(string _string)
        {
            int length = _string.Length;
            return length ;
        }

        //Q5: Remember to read more on Multi Threaded Applications MTA
        //Ask questions if you dont Understnad


        //Recursion Q2
        static int LengthOfString(string name)
        {
            if (name.Equals(""))
            {
                return 0;
            }
            else
            {
                return 1+ LengthOfString(name.Substring(1))  ;
            }
        }

        //Recursion Q3

        static void PrimeNumberGenerator(int initial, int final)
        {
            if (initial>final || initial == final)
            {
                return;
            }
            else
            {
                List<int> allfactors = new List<int>();
                for (int i = 1; i <= final; i++)
                {
                    if ((initial % i) == 0)
                    {
                        allfactors.Add(i);
                    }
                }
                if (allfactors.Count<3)
                {
                    for (int i = 0; i < allfactors.Count; i++)
                    {
                        Console.WriteLine(allfactors[i]);
                    }
                }
                else
                {
                    PrimeNumberGenerator(initial + 1, final);
                }
            }
            
        }


        //Recursion Q4




    }
}
