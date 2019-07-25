using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Game_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Добрый день, {name}!");
            Console.WriteLine("Сегодня");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Хотите сыграть в BlackJack?");
            Console.WriteLine();

            Console.WriteLine("Для начала игры нажмите 'Y' / Для выхода нажмите 'n'");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine( );
                Console.WriteLine("Правила игры в BlackJack следующие:");
                Console.WriteLine("1.");
            }
            else if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.WriteLine();
                Console.WriteLine("Досведос! Приходите в следующий раз!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Твой выбор не ясен");
            }



            Console.WriteLine();


            



            Console.WriteLine("Для выхода нажмите ENTER два раза");
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
