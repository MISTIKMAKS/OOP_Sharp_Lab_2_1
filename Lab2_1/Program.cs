using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class Program
    {
        static int array_result(int[] A, int P)
        {
            for (int i = 0; i < 25; i++)
            {
                if ((A[i] % 2 == 0) || (i % 8 != 0))
                {
                    P += A[i];
                }
            }
            return P;
        }
        static int output(int[] A, int P)
        {
            Console.WriteLine("Array: ");
            for (int i = 0; i < 25; i++)
            {
                Console.Write("[" + i + "] " + A[i] + "   ");
            }
            return 1;
        }
        static void Main(string[] args)
        {
            //-------Done-------
            //int[] A = {46, 22, 39, 45, 94, 69, 53, 23, 57, 79, 40, 70, 66, 92, 66, 46, 30, 67, 62, 41, 86, 29, 37, 68, 27};
            //-------Random-------
            //int Min = 5;
            //int Max = 90;
            //int[] A = new int[25];
            //Random random = new Random();
            //for (int i = 0; i < A.Length; i++)
            //{
            //    A[i] = random.Next(Min, Max);
            //}
            //-------Input-------
            int[] A = new int[25];
            for (int i = 0; i < A.Length; i++) 
            {
                Console.Write("A[" + i + "] = ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            int P = 0;
            Console.WriteLine("Result: " + array_result(A, P));
            Console.WriteLine("Array: " + output(A, P));
            Console.ReadKey();
        }
    }
}
