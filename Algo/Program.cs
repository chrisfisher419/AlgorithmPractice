using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Algo
{
    class Program
    {
        
        static void Main(string[] args)

        {



            Multiplication(-5, 6);
            Division(35, 7);
            Console.ReadLine();
            //List<int> numbers = new List<int>();
            //Console.WriteLine("Enter numbers to add to a list");
            //int input = Convert.ToInt32(Console.ReadLine());

            //while (input != 0)
            //{
            //    numbers.Add(input);
            //    continue;
            //}

            //Console.WriteLine(numbers);











            


            ////Subtraction
            //int y2 = 120;
            //int z2 = 100;
            //int tmp2 = -(z2);
            //int sum2 = y2 + tmp2;
            //Console.WriteLine(sum2);




        }

        static void Division(int x, int y)
        {

            //Division
            if (x > 0 && y > 0)
            {

                int tmp = -y;
                for (int i = 1; i <= y; i++)
                {
                    int div = x += tmp;
                    if (div == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else if (x > 0 && y < 0)
            {
                
                for (int i = 1; i <= -y; i++)
                {
                    int div = x += y;
                    if (div == 0)
                    {
                        Console.WriteLine(-i);
                    }
                }
            }
            else if (x < 0 && y > 0)
            {
                for (int i = 1; i <= y; i++)
                {
                    int div = x += y;
                    if (div == 0)
                    {
                        Console.WriteLine(-i);
                    }
                }

            }
            else if (x < 0 && y < 0)
            {
                int tmp = -y;
                for (int i = 1; i <= tmp; i++)
                {
                    int div = x += tmp;
                    if (div == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }


        

        static void Multiplication(int x, int y)
        {
            //Multiplication
            int tmp = y;
            int sum = 0;
            if (tmp < 0)
            {
                tmp = -y;
            }

            for (int i = 0; i < tmp; i++)
            {
                sum += x;
                if (i == tmp - 1)
                {
                    if (y > 0)
                    {
                        Console.WriteLine(sum);
                    }

                    if (y < 0)
                    {
                        sum = -sum;
                        Console.WriteLine(sum);
                    }
                }

            }
            
        }

        static int countWays(int n)
        {
            int ways;
            if (n < 0)
            {
                return 0;
            }
            else if (n == 0)
            {
                return 1;

            }
            else
            {
                ways = countWays(n - 1) + countWays(n - 2) + countWays(n - 3);
                return ways;
            }
        }

        static bool isUnique(string text)
        {
            bool[] array = new bool[256]; // or larger for Unicode

            foreach (char value in text)
                if (array[(int)value])
                    return false;
                else
                    array[(int)value] = true;

            return true;
        }

        static void Arr1()
        {
            int[] arr1 = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int j = 0;

            foreach (int i in arr1)
            {
                Console.WriteLine(arr1[i-1]);
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            while (j < arr1.Length)
            {
                Console.WriteLine(arr1[j]);
                j++;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int k = 0; k < 2; k++)
                {

                }
            }

            
        }

        static void Rand()
        {
            try
            {
                Console.WriteLine("Enter 3 numbers");
                int input1 = Convert.ToInt32(Console.ReadLine());
                int input2 = Convert.ToInt32(Console.ReadLine());
                int input3 = Convert.ToInt32(Console.ReadLine());


                int[] arr = new int[] {input1, input2, input3};
                for (int i = 0; i < arr.Length; i++)
                {
                    if ((int) arr[i] < 10)
                    {
                        Console.WriteLine((int) arr[i]);

                    }
                }
            }
            catch (SystemException)
            {
                Console.WriteLine("Invalid input");
                Rand();
            }

            Console.ReadLine();
        }




    }
}
