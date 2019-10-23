using System;

namespace Lab_02_3program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Write length of Fibonacci series");
                int length_of_series = Int32.Parse(Console.ReadLine());
                ulong current_number_of_series = 1;
                ulong next_number_of_series = 1;
                ulong previous_number_of_serious = 0;
                int all_4_number = 0;
                for (int i = 0; i < length_of_series; i++)
                {
                    if (current_number_of_series > 999 && current_number_of_series < 10000)
                    {
                        all_4_number += 1;
                    }
                    Console.WriteLine(next_number_of_series);
                    next_number_of_series = previous_number_of_serious + current_number_of_series;
                    previous_number_of_serious = current_number_of_series;
                    current_number_of_series = next_number_of_series;
                }
                Console.WriteLine($"Number of foursigned number are {all_4_number}");
                Console.ReadKey();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error.. Try again");
                Console.ReadKey();
                Program.Main(args);
            }
        }
    }
}
