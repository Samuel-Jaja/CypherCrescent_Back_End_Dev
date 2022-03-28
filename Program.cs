using System;

namespace CypherCrescentSoftwareAcademy_BackEndCohort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays : Question 1

            //int[] myarray = new int[20];

            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    myarray[i] = i * 5;
            //    Console.WriteLine(myarray[i]);
            //}







            //Arrays : Question 2
           
            /*
            bool arraysAreEqual = true;

            Console.Write("Enter length of first array: ");
            int n = Int32.Parse(Console.ReadLine());

            int[] array1 = new int[n];

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                array1[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter length of second array: ");

            if (n != Int32.Parse(Console.ReadLine()))
                Console.WriteLine("\nArrays have different lengths.");
            else
            {
                int[] array2 = new int[n];

                for (int i = 0; i < array2.Length; i++)
                {
                    Console.Write("Enter element {0}: ", i);
                    array2[i] = Int32.Parse(Console.ReadLine());
                }

                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        Console.WriteLine("\nArrays are different.");
                        arraysAreEqual = false;
                        break;
                    }
                }

                if (arraysAreEqual)
                    Console.WriteLine("\nArrays are the same.");
            }
            */







            //Arrays : Question 3
            /*
            
            bool arraysAreEqual = true;
            char[] array1 = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            char[] array2 = new char[5] { 'a', 'b', 'c', 'd', 'e' };

            if (array1.Length > array2.Length) 
                Console.WriteLine("Second array is lexicographicaly first.");
            else if (array1.Length < array2.Length) 
                Console.WriteLine("First array is lexicographicaly first.");
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] < array2[i])
                    {
                        Console.WriteLine("First array is lexicographicaly first.");
                        arraysAreEqual = false;
                        break;
                    }
                    if (array1[i] > array2[i])
                    {
                        Console.WriteLine("Second array is lexicographicaly first.");
                        arraysAreEqual = false;
                        break;
                    }
                }

                if (arraysAreEqual) 
                    Console.WriteLine("Arrays are lexicographicaly equal.");
            }
            */
            








            //Arrays : Question 4
            
            int count = 1, tCount = 1, number = 0;

            Console.Write("Enter array length: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arrray = new int[n];

            for (int i = 0; i < arrray.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arrray[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrray.Length - 1; i++)
            {
                if (arrray[i] == arrray[i + 1]) tCount++;
                else tCount = 1;

                if (tCount > count)
                {
                    count = tCount;
                    number = arrray[i];
                }
            }

            for (int i = 0; i < count; i++) Console.Write("{0}, ", number);









            //Arrays : Question 5









            //Arrays : Question 6





            //Arrays : Question 7
            /*
            int sum = 0;

            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter K (K < N): ");
            int k = Int32.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arr, (a, b) => b.CompareTo(a));

            for (int i = 0; i < k; i++) sum += arr[i];

            Console.WriteLine("\nBiggest sum is {0}", sum);
            */






            //Arrays : Question 8
            /*
            int a, b, aMin, temporary;

            Console.Write("Enter array length: ");
            int n = Int32.Parse(Console.ReadLine());

            int[] array1 = new int[n];

            for (a = 0; a < n; a++)
            {
                Console.Write("Enter {0} element: ", a);
                array1[a] = Int32.Parse(Console.ReadLine());
            }

            for (b = 0; b < n - 1; b++)
            {
                aMin = b;

                for (a = b + 1; a < n; a++) 
                    if (array1[a] < array1[aMin]) 
                        aMin = a;

                if (aMin != b)
                {
                    temporary = array1[b];
                    array1[b] = array1[aMin];
                    array1[aMin] = temporary;
                }
            }

            for (a = 0; a < n; a++) 
                Console.Write("{0} ", array1[a]);
            */



            //Arrays : Question 9

            /*
            
            int sum = 0, tSum;

            Console.Write("Enter array length: ");
            int n = Int32.Parse(Console.ReadLine());

            int[] array1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} element: ", i);
                array1[i] = Int32.Parse(Console.ReadLine());
            }

            //Traingular Looping and Rectangular Looping 

            for (int i = 0; i < n - 1; i++)
            {
                tSum = array1[i];

                for (int j = i + 1; j < n; j++)
                {
                    tSum += array1[j];
                    if (tSum > sum) 
                        sum = tSum;
                }
            }

            Console.WriteLine(" The maximal sum result is {0}. ", sum);
            */






            //Arrays : Question 10
            /*
            int counter = 0, temporaryCounter = 1, mostFoundNumber = 0;

            Console.Write("Enter array length: ");
            int n = Int32.Parse(Console.ReadLine());

            int[] array1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} element: ", i);
                array1[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(array1);
            

            for (int i = 0; i < n - 1; i++)
            {
                if (array1[i] == array1[i + 1]) temporaryCounter++;
                else temporaryCounter = 1;
                if (temporaryCounter > counter)
                {
                    counter = temporaryCounter;
                    mostFoundNumber = array1[i];
                }
            }

            Console.WriteLine("{0} was found {1} times.", mostFoundNumber, counter);
            */

            //Arrays : Question 11


            //Arrays : Question 12



            //Arrays : Question 13



            //Arrays : Question 14


            //Arrays : Question 15
            
            //Arrays : Question 16
            
            //Arrays : Question 17
            
            //Arrays : Question 18
            
            //Arrays : Question 19
            
            

        }
    }
}
