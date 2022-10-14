using System;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace Тумаков
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Тумаков 6.1");
            string path = "C:/Users/stone/source/repos/Task_0810/Тумаков/ex1.txt";
            char[] alg = { 'a', 'e', 'i', 'o','u','y' };
            char[] als = { 'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','z' };
            int g = 0;
            int s = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    char[] arrline = line.ToCharArray();
                    foreach (char letter in arrline)
                    {
                        if (alg.Contains(letter))
                        {
                            g++;
                        }
                        else if (als.Contains(letter))
                        {
                            s++;
                        }
                    }
                }
            }
            Console.WriteLine($"Количество гласных {g} и согласных {s}");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Тумаков 6.2");
            Random rand = new Random();

            Console.WriteLine("Матрица A:");
            int[,] A = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    A[i, j] = rand.Next(1, 15);
                }
            }
            Print_Matrix(A);
            Console.WriteLine("Матрица B:");
            int[,] B = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    B[i, j] = rand.Next(1, 20);
                }
            }
            Print_Matrix(B);
            Console.WriteLine("\nМатрица C = A * B:");
            int[,] C = Matrix_multiplication(A, B);
            Print_Matrix(C);

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Тумаков 6.3");

            int[,] temperature = new int[12, 30];
            int[] sr_temp = new int[12];
            for (int i = 0; i < 12; i++)
            {
                int sum = 0;
                for (int j = 0; j < 30; j++)
                {
                    temperature[i, j] = rand.Next(1, 30);
                    sum += temperature[i, j];

                    Console.Write($"{temperature[i, j]} ");
                }
                sr_temp[i] = sum;
                Console.WriteLine();
            }
            Array.Sort(sr_temp);
            foreach (int srday in sr_temp)
            {
                Console.WriteLine(srday);
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("ДЗ Тумаков 6.1");

            path = "C:/Users/stone/source/repos/Task_0810/Тумаков/ex1.txt";
            List<char> list_alg = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y' };
            List<char> list_als = new List<char>()  { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
            g = 0;
            s = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    char[] arrline = line.ToCharArray();
                    foreach (char letter in arrline)
                    {
                        if (alg.Contains(letter))
                        {
                            g++;
                        }
                        else if (als.Contains(letter))
                        {
                            s++;
                        }
                    }
                }
            }
            Console.WriteLine($"Количество гласных {g} и согласных {s}");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("ДЗ Тумаков 6.3");
            temperature = new int[12, 30];
            Dictionary<int, int> month = new Dictionary<int, int> { };
            for (int i = 0; i < 12; i++)
            {
                int sum = 0;
                for (int j = 0; j < 30; j++)
                {
                    temperature[i, j] = rand.Next(1, 30);
                    sum += temperature[i, j];

                    Console.Write($"{temperature[i, j]} ");
                }
                month[i] = sum;
                Console.WriteLine();
            }
            Array.Sort(sr_temp);
            foreach (KeyValuePair<int, int> std in month.OrderBy(key => key.Value))
            {
                Console.WriteLine($"месяц: {std.Key}, ср температура: {std.Value}");
            }
        }
        static int[,] Matrix_multiplication(int[,] a, int[,] b)
        {
            int[,] r = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }
        static void Print_Matrix(int[,] A)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        Console.Write($"[{A[i, j]}, ");
                    }
                    else if (j == 2)
                    {
                        Console.Write($"{A[i, j]}]");
                    }
                    else
                    {
                        Console.Write($"{A[i, j]}, ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
