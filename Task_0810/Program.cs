using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Task_0810
{
    struct Student
    {
        public string second_name;
        public string name;
        public DateTime age;
        public int exam;
        public Student(string second_name, string name, DateTime age, int exam)
        {
            this.second_name = second_name;
            this.name = name;
            this.age = age;
            this.exam = exam;
        }
    }
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
            static async Task Main(string[] args)
            {
                foreach (var f in new DirectoryInfo(@"...").GetFiles("*.cs", SearchOption.AllDirectories))
                {
                    string s = File.ReadAllText(f.FullName);
                    File.WriteAllText(f.FullName, s, Encoding.UTF8);
                }
                Console.WriteLine("Задание 1");
                Student student1 = new Student("Хамитов", "Ринат", DateTime.Parse("10.11.2004"), 250);
                Student student2 = new Student("Хамидуллина", "Диана", DateTime.Parse("10.8.2004"), 250);
                Student student3 = new Student("Першунин", "Артём", DateTime.Parse("12.3.2005"), 249);
                Student student4 = new Student("Митрофанов", "Лёня", DateTime.Parse("1.2.2004"), 230);
                Student student5 = new Student("Гильфанова", "Аделя", DateTime.Parse("2.7.2004"), 290);
                Student student6 = new Student("Шапошникова", "Катя", DateTime.Parse("21.4.2004"), 260);
                Student student7 = new Student("Агиева", "Лилия", DateTime.Parse("3.12.2003"), 234);
                Student student8 = new Student("Ахметов", "Ильдар", DateTime.Parse("10.11.2004"), 263);
                Student student9 = new Student("Саитов", "Марат", DateTime.Parse("26.8.2004"), 248);
                Student student10 = new Student("Сагдуллин", "Амир", DateTime.Parse("2.9.2004"), 273);
                Dictionary<int, Student> people = new Dictionary<int, Student>()
            {
                { 1, student1}, { 2, student2},
                { 3, student3}, { 4, student4},
                { 5, student5}, { 6, student6},
                { 7, student7}, { 8, student8},
                { 9, student9}, { 10, student10}
            };
                int k = 11;
                string command;
                Console.WriteLine("Команды: \n 1 = создать нового студента \n 2 = Удалить студента \n 3 = Сортировать \n 4 = Выход (Выйти из программы)");
                do
                {
                    command = Console.ReadLine().ToLower();
                    if (command.Equals("1"))
                    {
                        Console.WriteLine("Введи его фамилию и имя, дату рождения, общее количество баллов (через пробел)");
                        string[] info = Console.ReadLine().Split(' ');
                        people[k] = new Student(info[0], info[1], DateTime.Parse(info[2]), int.Parse(info[3]));
                        k++;
                    }
                    else if (command.Equals("2"))
                    {
                        Console.WriteLine("Введи его фамилию и имя (через пробел)");
                        int c = -1;
                        string[] info = Console.ReadLine().Split(' ');
                        foreach (var (key, value) in people)
                        {
                            if (value.second_name.Equals(info[0]) && value.name.Equals(info[1]))
                            {
                                c = key;
                            }
                        }
                        if (c != -1)
                        {
                            k--;
                            people.Remove(c);
                        }
                    }
                    else if (command.Equals("выход"))
                    {
                        break;
                    }
                    if (command.Equals("3"))
                    {
                        foreach (KeyValuePair<int, Student> std in people.OrderByDescending(key => key.Value.exam))
                        {
                            Console.WriteLine("{0} {1} баллы = {2}", std.Value.second_name, std.Value.name, std.Value.exam);
                        }
                    }
                    else
                    {
                        foreach (var (key, value) in people)
                        {
                            Console.WriteLine($"{key}: {value.second_name} {value.name}");
                        }
                    }
                } while (!command.Equals("4"));

                Console.Clear();
                Console.WriteLine("Задание 2");
                string Viking_war(int[] Bavarian_Beer_Bears, int[] Scandinavian_Schollers)
                {
                    if (Bavarian_Beer_Bears.Count(n => n == 5) == Scandinavian_Schollers.Count(n => n == 5))
                    {
                        return "Drinks All Round! Free Beers on Bjorg!";
                    }
                    else
                    {
                        return "Ой, Бьорг - пончик! Ни для кого пива!";
                    }
                }
                int[] Bavarian_Beer_Bears = new int[] { 1, 2, 5, 5, 5, 3 };
                int[] Scandinavian_Schollers = new int[] { 2, 5, 5, 3 };
                Console.WriteLine(Viking_war(Bavarian_Beer_Bears, Scandinavian_Schollers));

                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Задание 3");
                // подключение поломка включение
                Сitizen citizen2 = new Сitizen("Хамидуллина", 128766, "поломка", 2, 1);
                Сitizen citizen3 = new Сitizen("Митрофанов", 128767, "подключение", 6, 1);
                Сitizen citizen4 = new Сitizen("Гильфанова", 128768, "включение", 2, 0);
                Сitizen citizen5 = new Сitizen("Шапошникова", 128769, "включение", 8, 1);
                List<Сitizen> window = new List<Сitizen>();
                List<Сitizen> window2 = new List<Сitizen>();
                List<Сitizen> window3 = new List<Сitizen>();
                Dictionary<int, Сitizen> people2 = new Dictionary<int, Сitizen>()
            {
                { citizen2.passport_ID, citizen2},
                { citizen3.passport_ID, citizen3}, { citizen4.passport_ID, citizen4},
                { citizen5.passport_ID, citizen5}
            };
                string path = "C:/Users/stone/source/repos/Task_0810/Task_0810/ex3.txt";
                using (StreamReader reader = new StreamReader(path))
                {
                    string? line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {

                        string[] arrline = line.Split(" ");
                        Сitizen citizen = new Сitizen(arrline[0], int.Parse(arrline[1]), arrline[2], int.Parse(arrline[3]), int.Parse(arrline[4]));
                        people2[citizen.passport_ID] = citizen;

                    }
                }
                Console.WriteLine("Хочешь добавить еще жителя?");
                string question = Console.ReadLine();
                if (question.ToLower().Equals("да"))
                {
                    Console.WriteLine("Чтобы закончить добавление жителя напиши: «стоп»");
                    do
                    {
                        Console.WriteLine("Введи его фамилию, номер паспорта, его проблему (подключение, поломка, включение),\n уровень его темперамента(0-10), уровень ума (0-1)");
                        question = Console.ReadLine();
                        if (question.ToLower().Equals("стоп"))
                        {
                            break;
                        }
                        string[] info = question.Split(' ');
                        Сitizen citizen = new Сitizen(info[0], int.Parse(info[1]), info[2], int.Parse(info[3]), int.Parse(info[4]));
                        people2[citizen.passport_ID] = citizen;
                    } while (!question.ToLower().Equals("стоп"));
                }
                foreach (var (key, value) in people2)
                {
                    Console.WriteLine($"{key}: {value.second_name}");
                }
                k = 1;
                foreach (var (key, value) in people2)
                {
                    if (value.intellect == 1)
                    {
                        switch (value.problem) // подключение поломка включение
                        {
                            case "подключение":
                                Add_window(ref window, value);
                                break;
                            case "поломка":
                                Add_window(ref window2, value);
                                break;
                            case "включение":
                                Add_window(ref window3, value);
                                break;
                        }
                    }
                    else
                    {
                        Сitizen newcit = value;
                        Random_window(ref newcit);
                        switch (newcit.problem) // подключение поломка включение
                        {
                            case "подключение":
                                Add_window(ref window, value);
                                break;
                            case "поломка":
                                Add_window(ref window2, value);
                                break;
                            case "включение":
                                Add_window(ref window3, value);
                                break;
                        }
                    }
                    Console.WriteLine($"НОМЕР ХОДА {k}");
                    Console.WriteLine("Очередь в окно 1 (подключение):");
                    Check_window(window);
                    Console.WriteLine();
                    Console.WriteLine("Очередь в окно 2 (поломка):");
                    Check_window(window2);
                    Console.WriteLine();
                    Console.WriteLine("Очередь в окно 3 (включение):");
                    Check_window(window3);
                    Console.WriteLine();
                    k++;
                }



            }
        }
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
    }
}