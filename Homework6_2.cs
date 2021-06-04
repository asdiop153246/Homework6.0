using System;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {           
            Menu();
                        

        }
        static void Menu()
        {
            Anime Animelist = 0; //WIP System เดี๋ยวทำระบบให้อนิเมะแยกพร้อม Detailed                  
            
            for (int i = 0; ; i++)
            {

                int list;
                Console.WriteLine("Please choose Anime number (1 = OP, 2 = Slime, 3 = SevenSins, 4 = MyHero 0 = exit)");
                list = int.Parse(Console.ReadLine());

                if (list == 1)
                {
                    Animelist = 0;
                    Console.WriteLine("You choose One piece");
                    Console.WriteLine("The Anime will update on Tuesday");


                }
                else if (list == 2)
                {
                    Animelist = Anime.Slime;
                    Console.WriteLine("You choose Slime");
                    Console.WriteLine("The Anime will update on Wednesday");
                }
                else if (list == 3)
                {
                    Animelist = Anime.SevensSins;
                    Console.WriteLine("You choose Nanatsu no Taisai");
                    Console.WriteLine("The Anime will update on Friday");
                    
                }
                else if (list == 4)
                {
                    Animelist = Anime.Myhero;
                    Console.WriteLine("You choose Boku no Hero");
                    Console.WriteLine("The Anime will update on Saturday");
                    
                }
                else if (list == 0)
                {
                    Console.WriteLine("Thank you for your time, we will update more soon");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Anime list");
                }

            }
        }
        
        
        enum Anime
        {
            One_Piece,
            Slime,
            SevensSins,
            Myhero
        }

    }
}
