namespace Practicheskayarabota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите команду:"); Console.WriteLine("1. Игра угадай число"); Console.WriteLine("2. Таблица умножения"); Console.WriteLine("3. Вывод всех делителей числа");
            Console.WriteLine("4. Выход"); int oper = Convert.ToInt32(Console.ReadLine()); while (oper != 4)
            {
                switch (oper)
                {
                    case 1:
                        Game();
                        Console.WriteLine("Выберите команду:"); Console.WriteLine("1. Угадай число"); Console.WriteLine("2. Таблица умножения"); Console.WriteLine("3. Вывод всех делителей числа");
                        Console.WriteLine("4. Выход"); oper = Convert.ToInt32(Console.ReadLine()); break;
                    case 2:
                        {
                            Tabl();
                            Console.WriteLine("Выберите команду:"); Console.WriteLine("1. Угадай число"); Console.WriteLine("2. Таблица умножения"); Console.WriteLine("3. Вывод всех делителей числа");
                            Console.WriteLine("4. Выход"); oper = Convert.ToInt32(Console.ReadLine()); break;
                        }
                    case 3:
                        {
                            Div();
                            Console.WriteLine(); Console.WriteLine("Выберите команду:"); Console.WriteLine("1. Угадай число"); Console.WriteLine("2. Таблица умножения");
                            Console.WriteLine("3. Вывод всех делителей числа"); Console.WriteLine("4. Выход"); oper = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                }
            }
            static void Game()
            {
                Random rand = new Random(); int i = rand.Next(101);
                Console.WriteLine("Угадайте число от 0 до 100"); int number = Convert.ToInt32(Console.ReadLine());
                while (i < 100)
                {
                    if (number == i)
                    {
                        {
                            Console.WriteLine("Угадали!");
                            return;
                        }
                    }
                    else if (number > i)
                    {
                        Console.WriteLine("Меньше");
                        number = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Больше"); number = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            static void Tabl()
            {
                int[,] table = new int[10, 10];
                for (int i = 1; i < 10; ++i)
                {
                    for (int j = 1; j < 10; ++j)
                    {
                        table[i, j] = i * j;
                    }
                }
                for (int i = 1; i < 10; ++i)
                {
                    for (int j = 1; j < 10; ++j)
                    {
                        Console.Write(table[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            static void Div()
            {
                Console.WriteLine("Введите число: "); int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.Write(i + "\t");
                    }
                }
            }
        }
    }
}