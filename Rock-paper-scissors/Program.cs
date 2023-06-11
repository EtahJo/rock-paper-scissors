using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            bool playAgain = true;


            while (playAgain)
            {

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.Write("Choose between ROCK,PAPER,SCISSORS:   ");
                    inputPlayer = Console.ReadLine();


                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputCPU.Equals(inputPlayer, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("DRAW!!\n\n CPU score :{0},  Player score :{1}", scoreCPU, scorePlayer);
                            }
                            else if (inputPlayer.Equals("PAPER", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                                Console.WriteLine("Player Score:{0}, CPU Score :{1}", scorePlayer, scoreCPU);

                            }
                            else if (inputPlayer.Equals("SCISSORS", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("CPU WINS !! \n\n");
                                scoreCPU++;
                                Console.WriteLine("Player Score:{0}, CPU Score :{1}", scorePlayer, scoreCPU);
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputCPU.Equals(inputPlayer, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("DRAW!!\n\n CPU score :{0},  Player score :{1}", scoreCPU, scorePlayer);
                            }
                            else if (inputPlayer.Equals("ROCK", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                                Console.WriteLine("Player Score:{0}, CPU Score :{1}", scorePlayer, scoreCPU);
                            }
                            else if (inputPlayer.Equals("SCISSORS", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("PLAYER WINS !! \n\n");
                                scorePlayer++;
                                Console.WriteLine("Player Score:{0}, CPU Score :{1}", scorePlayer, scoreCPU);
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputCPU.Equals(inputPlayer, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("DRAW!!\n\n CPU score :{0},  Player score :{1}", scoreCPU, scorePlayer);
                            }
                            else if (inputPlayer.Equals("ROCK", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                                Console.WriteLine("Player Score:{0}, CPU Score :{1}", scorePlayer, scoreCPU);
                            }
                            else if (inputPlayer.Equals("PAPER", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("CPU WINS !! \n\n");
                                scoreCPU++;
                                Console.WriteLine("Player Score:{0}, CPU Score :{1}", scorePlayer, scoreCPU);
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry");
                            break;

                    }


                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WINS !!");
                }
                else
                {
                    Console.WriteLine("CPU WINS !!");
                }
                Console.Write("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
            }


            

        }
    }
}

