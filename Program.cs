using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
          Metka:
            Console.Clear();
            //METKA "начальный экран"
            Console.WriteLine("\nДля начала игры нажмите клавишу `Y`\nДля ознакомления с правилами игры нажмите клавишу `R`\nДля выход нажмите клавишу `N`");
            var result = Console.ReadLine();
            Console.Clear();

            switch (result.ToLower())
               {
                case "y":
             

                    Dictionary<string, int> cards = new Dictionary<string, int>
                    {
                        ["Hearts_Ace"] = 11,
                        ["Diamonds_Ace"] = 11,
                        ["Clubs_Ace"] = 11,
                        ["Spades_Ace"] = 11,

                        ["Hearts_Two"] = 2,
                        ["Diamonds_Two"] = 2,
                        ["Clubs_Two"] = 2,
                        ["Spades_Two"] = 2,

                        ["Hearts_Three"] = 3,
                        ["Diamonds_Three"] = 3,
                        ["Clubs_Three"] = 3,
                        ["Spades_Three"] = 3,

                        ["Hearts_Four"] = 4,
                        ["Diamonds_Four"] = 4,
                        ["Clubs_Four"] = 4,
                        ["Spades_Four"] = 4,

                        ["Hearts_Five"] = 5,
                        ["Diamonds_Five"] = 5,
                        ["Clubs_Five"] = 5,
                        ["Spades_Five"] = 5,

                        ["Hearts_Six"] = 6,
                        ["Diamonds_Six"] = 6,
                        ["Clubs_Six"] = 6,
                        ["Spades_Six"] = 6,

                        ["Hearts_Seven"] = 7,
                        ["Diamonds_Seven"] = 7,
                        ["Clubs_Seven"] = 7,
                        ["Spades_Seven"] = 7,

                        ["Hearts_Eight"] = 8,
                        ["Diamonds_Eight"] = 8,
                        ["Clubs_Eight"] = 8,
                        ["Spades_Eight"] = 8,

                        ["Hearts_Nine"] = 9,
                        ["Diamonds_Nine"] = 9,
                        ["Clubs_Nine"] = 9,
                        ["Spades_Nine"] = 9,

                        ["Hearts_Ten"] = 10,
                        ["Diamonds_Ten"] = 10,
                        ["Clubs_Ten"] = 10,
                        ["Spades_Ten"] = 10,

                        ["Hearts_Jack"] = 10,
                        ["Diamonds_Jack"] = 10,
                        ["Clubs_Jack"] = 10,
                        ["Spades_Jack"] = 10,

                        ["Hearts_Queen"] = 10,
                        ["Diamonds_Queen"] = 10,
                        ["Clubs_Queen"] = 10,
                        ["Spades_Queen"] = 10,

                        ["Hearts_King"] = 10,
                        ["Diamonds_King"] = 10,
                        ["Clubs_King"] = 10,
                        ["Spades_King"] = 10,
                    };

                    string[] pack =
  {
     "Hearts_Ace", "Diamonds_Ace", "Clubs_Ace", "Spades_Ace",

     "Hearts_Two", "Diamonds_Two", "Clubs_Two", "Spades_Two",

     "Hearts_Three", "Diamonds_Three", "Clubs_Three", "Spades_Three",

     "Hearts_Four", "Diamonds_Four", "Clubs_Four", "Spades_Four",

     "Hearts_Five", "Diamonds_Five", "Clubs_Five", "Spades_Five",

     "Hearts_Six", "Diamonds_Six", "Clubs_Six", "Spades_Six",

     "Hearts_Seven", "Diamonds_Seven", "Clubs_Seven", "Spades_Seven",

     "Hearts_Eight", "Diamonds_Eight", "Clubs_Eight", "Spades_Eight",

     "Hearts_Nine", "Diamonds_Nine", "Clubs_Nine", "Spades_Nine",

     "Hearts_Ten", "Diamonds_Ten", "Clubs_Ten", "Spades_Ten",

     "Hearts_Jack", "Diamonds_Jack", "Clubs_Jack", "Spades_Jack",

     "Hearts_Queen", "Diamonds_Queen", "Clubs_Queen", "Spades_Queen",

     "Hearts_King", "Diamonds_King", "Clubs_King", "Spades_King"
};

                    Console.WriteLine("//");
                    Console.WriteLine("Cards Names:");
                    Console.WriteLine("//");
                    for (int i = 0; i < pack.Length; i++)
                     {
                        Console.WriteLine(pack[i]);
                     }

                    Console.ReadKey();



                    Console.WriteLine("//");
                    Console.WriteLine("Pack of Cards and Values:");
                    Console.WriteLine("//");

                    foreach (KeyValuePair<string, int> keyValue in cards)
                    {
                        Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                    }

                    Console.WriteLine("//");
                    Console.WriteLine("Shuffling (press the Button)");
                    Console.ReadKey();


        
                    // Тасуем колоду из 52 карт
                    Console.WriteLine("//");
                    Console.WriteLine("Shuffling Cards:");
                    Console.WriteLine("//");


                    string[] spack = new string[52];
                    Random rnd = new Random();
                   
                    for (int i = 0; i < pack.Length; i++)
                    {
                        int j = rnd.Next(53);
                        spack[i] = pack[j];
                        Console.WriteLine("№" + i + " - " + spack[i]);
                        Console.ReadKey();
                    }

                    
                    Console.ReadKey();





                    Console.ReadKey();
                    break;

                case "r":
                Console.WriteLine("Ознакомьтесь с правилами игры в BlackJack");
                Console.WriteLine("\n1. Цель игры - набрать карты на общую сумму, максимально близкую к 21. 21 - это идеальный вариант, но если вы наберете хоть на очко больше - вы проиграли (перебор);");
                Console.WriteLine("\n2. Сумма ваших очков должна быть больше, чем у Крупье, либо Крупье должен `перебрать` (набрать более 21 очка);");
                Console.WriteLine("\n3. Если ваши очки равны, то это ничья (Stay), вы не выиграли и не проиграли, `остались при своих`;");
                Console.WriteLine("\n4. Победить набор карт на сумму 21 очко может только любая десятка (10, J, Q, K) в паре с тузом. Такая комбинация называется BlackJack и является самой старшей в игре;");
                Console.WriteLine("\n5. Игрокам раздается по паре карт, одна карта крупье закрыта;");
                Console.WriteLine("\n6. Игрок должен решить продолжать (`HitMe`) или остановиться;");
                Console.WriteLine("\n7. Крупье обязан брать ещё карту, если у него 16 и менее очков и остановиться на любом количестве очков более 17 включительно.");
                Console.WriteLine("\n8. Достоинство карт:");
                Console.WriteLine("Каждая карта имеет свое достоинство. Карты от двойки до десятки совпадают с их номиналом.");
                Console.WriteLine("Например для двойки – это два очка, тройки - три очка и так далее. J, Q, K - оцениваются в 10 очков.");
                Console.WriteLine("Ценность туза заключается в том, что его номинал может быть равен как 1, так и 11 очкам, в зависимости от игровой ситуации.");
                Console.WriteLine("Допустим, если вам раздали тройку и туза, объявляется, что у игрока четыре или четырнадцать очков.");
                Console.WriteLine("Если ему придет семерка, то это остановит дальнейший набор и будет означать 21 очко.");
                Console.WriteLine("Однако, если он получит восьмерку, дилер объявит 12 очков, а не перебор и предложит играть дальше.");
                Console.WriteLine("\n9. Максимальное количество игроков 7 + Крупье;");
                Console.WriteLine("\n10. Колода карт одна - 52 карты;");

                    Console.WriteLine("\n");
                    Console.WriteLine("press the Button");


                    Console.ReadKey();
                    goto Metka;
                    // Нужен goto METKA "начальный экран"
                    // break;


                case "n":
                Console.WriteLine("Gud Luck!");
                Console.WriteLine("press the Button");
                Console.ReadKey();
                break;
                
                    
                  default: 
                  Console.WriteLine("Please choose correct one!");
                  Console.WriteLine("press the Button");
                  Console.ReadKey();
                  goto Metka;
                  // Нужен goto METKA "начальный экран"
                  // break;
               }
                  Console.Clear();
        }
    }
}
