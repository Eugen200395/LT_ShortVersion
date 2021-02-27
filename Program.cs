using System;
using System.Linq;

namespace LT_ShortVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool start = true;

            while (start)
            {
                int sum_1 = 0;
                int sum_2 = 0;

                Console.WriteLine("Приложение *Счастливый Билет*");
                Console.WriteLine("Для запуска программы нажми '+'. Для выхода из приложения нажми '-'");

                string choice = Console.ReadLine();
                {
                    switch (choice)
                    {
                        case "+":
                            {
                                Console.WriteLine($"Введите номер вашего билета: ");

                            a: string ticket = Console.ReadLine();
                                string check_ticket = new String(ticket.Where(x => Char.IsDigit(x)).Take(8).ToArray());
                                if (check_ticket.Length < 3 || ticket == null)
                                {
                                    Console.WriteLine("Введите номер вашего билета корректно!");
                                    goto a;
                                }

                                if (check_ticket.Length % 2 != 0)
                                {
                                    check_ticket = check_ticket.Insert(0, "0");
                                }

                                int[] arr = check_ticket.Select(x => int.Parse(x.ToString())).ToArray();
                                

                                for (int i = 0; i < check_ticket.Length; i++)
                                {
                                    if (i < (check_ticket.Length + 1) / 2)
                                    {
                                        sum_1 += arr[i];
                                    }
                                    else sum_2 += arr[i];
                                }
                                if (sum_1 != sum_2)
                                {
                                    Console.WriteLine($"Ваш билет #{check_ticket} - не счастливый :( ");
                                }
                                else
                                {
                                    Console.WriteLine($"Ваш билет #{check_ticket} - счатливый :)");
                                }
                                break;
                            }

                        case "-": { start = false; Console.WriteLine("Программа завершенна"); break; }
                    }
                }
            }
            Console.Read();
        }
    }
}

