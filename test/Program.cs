using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    struct Сitizen
    {
        public string second_name;
        public int passport_ID;
        public string problem;
        public int temperament;
        public int intellect;
        public Сitizen(string second_name, int passport_ID, string problem, int temperament, int intellect)
        {
            this.second_name = second_name;
            this.passport_ID = passport_ID;
            this.problem = problem;
            this.temperament = temperament;
            this.intellect = intellect;
        }
        class Program
    {
            public static void Random_window(ref Сitizen citizen) 
            {
                List<string> name_window = new List<string> { "подключение", "поломка", "включение" };
                name_window.Remove(citizen.problem);
                var random = new Random();
                int index = random.Next(name_window.Count);
                citizen.problem = name_window[index];

            }
            public static void Check_window(List<Сitizen> window)
            {
                int k = 1;

                foreach (Сitizen name in window)
                {
                    Console.WriteLine($"{name.second_name} номер в очереди {k}");
                    k++;
                }
            }

            public static void Add_window(ref List<Сitizen> window, Сitizen citizen)
            {
                if (citizen.temperament < 5)
                {
                    window.Add(citizen);
                }
                else
                {
                    Console.WriteLine($"На сколько человек обгонять? (спрашивает {citizen.second_name} в окно для проблемы {citizen.problem})");
                    int how_much_to_overtake = int.Parse(Console.ReadLine());
                    if (how_much_to_overtake > window.Count)
                    {
                        Console.WriteLine("Неверное количество обгонов");
                        window.Add(citizen);
                    }
                    else
                    {
                        window.Insert(window.Count - how_much_to_overtake, citizen);
                }
                    }
                return;
            }
            static void Main(string[] args)
            {

                Random rand = new Random();
                Queue<int> q = new Queue<int>();    //Это очередь, хранящая номера вершин
                string exit = "";
                int u;
                u = rand.Next(3, 5);
                bool[] used = new bool[u + 1];  //массив отмечающий посещённые вершины
                int[][] g = new int[u + 1][];   //массив содержащий записи смежных вершин

                for (int i = 0; i < u + 1; i++)
                {
                    g[i] = new int[u + 1];
                    Console.Write("\n({0}) вершина -->[", i + 1);
                    for (int j = 0; j < u + 1; j++)
                    {
                        g[i][j] = rand.Next(0, 2);
                    }
                    g[i][i] = 0;
                    foreach (var item in g[i])
                    {
                        Console.Write(" {0}", item);
                    }
                    Console.Write("]\n");
                }
            }
        }
    }
}
