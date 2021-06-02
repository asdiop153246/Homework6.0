using System;

namespace Learning
{
    class Program
    {


        static void Main(string[] args)
        {
            
            Difficulty difficult1 = 0;
            double score = 0;
            
            Menus(difficult1,score);



        }




    
    static void Menus(Difficulty difficult1, double score)
    {

            Console.WriteLine("Score: {0}, Difficulty: {1}", score, difficult1);
            int menu;
            for (int i = 0; ; i++)
            {
                
                
                Console.WriteLine("Please input 0-2");
                menu = int.Parse(Console.ReadLine());
                           
            if (menu == 0)
            {
                Game(difficult1,score);

            }
            else if (menu == 1)
            {
                setting(ref difficult1,score);
                
            }
            else if (menu == 2)
            {
                    
                    break;
            }
            else
            {
                Console.WriteLine("Please just Input 0-2 you damn son");
            }
                break;
        }
    }
        
        static void Game(Difficulty difficult1,double score)
        {
            int numProblem = 0;
            double dif = 0;
            if (difficult1 == 0)
            {
                numProblem = 3;
                dif = 0;
            }
            else if (difficult1 == Difficulty.Normal)
            {
                numProblem = 5;
                dif = 1;
            }
            else if (difficult1 == Difficulty.Hard)
            {
                numProblem = 7;
                dif = 2;
            }
            Problem[] Gameplay = GenerateRandomProblems(numProblem);
            
            long x = DateTimeOffset.Now.ToUnixTimeSeconds();
            double correct = 0;
            for (int i = 0; i <= Gameplay.Length-1; i++)
            {
                Console.WriteLine(Gameplay[i].Message);
                int answers;
                answers = int.Parse(Console.ReadLine());

                
                if (Gameplay[i].Answer == answers)
                {
                    correct++;
                }
            }            
            
            long y = DateTimeOffset.Now.ToUnixTimeSeconds();
            long time = y - x;           
                       
            double currentscore;
            currentscore = (correct / numProblem) * ((25 - dif*dif) / Math.Max(time,25-dif*dif))*Math.Pow(2*dif+1,2);
            Console.WriteLine("Your score is: {0}",currentscore);
            score += currentscore;

            Menus(difficult1,score);

        }
        static void setting(ref Difficulty difficult1,double score)
        {
            
            
            for (int i = 0; ; i++)
            {
                
                int select;
                Console.WriteLine("Input the difficulty: ");
                select = int.Parse(Console.ReadLine());

                if (select == 0)
                {
                    difficult1 = Difficulty.Easy;
                    
                }
                else if (select == 1)
                {
                    difficult1 = Difficulty.Normal;
                    
                }
                else if (select == 2)
                {
                    difficult1 = Difficulty.Hard;
                    
                }
                else
                {
                    Console.WriteLine("Please Input 0-2");
                }
                break;

            }
            Console.WriteLine("Your Changed difficult to: {0}", difficult1);
            
            Menus(difficult1, score);
            
            

        }
        
        
        enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }
        
        struct Problem
        {
            public string Message;
            public int Answer;

            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }
        }
        
        
        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];

            Random rnd = new Random();
            int x, y;

            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50);
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] =
                    new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
                else
                    randomProblems[i] =
                    new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
            }

            return randomProblems;
        }



    }
}
