using System;

namespace RockPaperScissors
{
    public class Program
    {
        private static int _totalrounds;
        private static int _round;
        private static int _CPUWins;
        private static int _PlayerWins;
        private static int _Tie;
        public static bool Play = true;
        public static string player;

        static void Main(string[] args)
        {
            PlayGame();
        }
        public static void PlayGame()
        {
            string inputPlayerR;
            bool Play = true;
            bool roundsInRange = false;
            bool SetRounds = false;
            int totalrounds;
            int r = 0;
            var round = r;


            
            
                while (!roundsInRange)
                {

                    Console.Write("Welcome! Let's play Rock, Paper, Scissors! How many rounds would you like to play (between 1 - 10) until we have a winner?");
                    inputPlayerR = Console.ReadLine();
                    if (int.TryParse(inputPlayerR, out totalrounds))
                    {
                        if (totalrounds >= 1 && totalrounds <= 10)
                        {
                            roundsInRange = true; SetRounds = true; r += totalrounds; _totalrounds = totalrounds;
                            
                            
                        }
                        else if (totalrounds < 1 || totalrounds > 10)
                        {
                            Console.WriteLine("Choose a number between 1 - 10.");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Choose a number between 1 - 10.");
                            continue;
                        }
                    }Console.Write("The winner will be declared in "); Console.Write(r += totalrounds); Console.Write(" rounds.");
                }
                


                string inputPlayer;
                int outputPlayer;
                int CPUWins = 0;
                int PlayerWins = 0;
                int Tie = 0;
                bool ValidEntry = false;

                _CPUWins = CPUWins++;
                _PlayerWins = PlayerWins++;
                _Tie = Tie++;
                _round = round;

            do
            { 

                do
                {
                    Console.Write("\nRound: "); Console.Write(r);

                    Console.WriteLine("\nChoose your weapon... 1.ROCK, 2.PAPER, or 3.SCISORS!");
                    inputPlayer = Console.ReadLine();
                    if (int.TryParse(inputPlayer, out outputPlayer))
                    {
                        if (outputPlayer >= 1 && outputPlayer <= 3)
                        {
                            ValidEntry = true;
                        }
                        else if (outputPlayer < 1 || outputPlayer > 3)
                        {
                            Console.WriteLine("Choose a number between 1 - 3.");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Choose a number between 1 - 3.");
                            continue;
                        }
                    }
                    Random rnd = new Random();
                    int inputCPU = rnd.Next(1, 4);


                    switch (inputCPU)
                    {
                        case 1:
                            {
                                inputCPU = 1;
                                Console.WriteLine("Computer chose 1.ROCK.");


                                if (outputPlayer == 1)
                                {
                                    Console.WriteLine("It's a Tie!");
                                    Tie++; r++;
                                }
                                else if (outputPlayer == 2)
                                {
                                    Console.WriteLine("Player WINS!");
                                    PlayerWins++; r++;
                                }
                                else if (outputPlayer == 3)
                                {
                                    Console.WriteLine("Computer WINS!");
                                    CPUWins++; r++;
                                }



                            }
                            continue;

                        case 2:
                            {
                                inputCPU = 2;
                                Console.WriteLine("Computer chose 2.PAPER.");
                                if (int.TryParse(inputPlayer, out outputPlayer))
                                {
                                    ValidEntry = true;
                                    if (outputPlayer == 2)
                                    {
                                        Console.WriteLine("It's a Tie!");
                                        Tie++; r++;
                                    }
                                    else if (outputPlayer == 3)
                                    {
                                        Console.WriteLine("Player WINS!");
                                        PlayerWins++; r++;
                                    }
                                    else if (outputPlayer == 1)
                                    {
                                        Console.WriteLine("Computer WINS!");
                                        CPUWins++; r++;
                                    }
                                }
                            }
                            continue;

                        case 3:
                            {
                                inputCPU = 3;
                                Console.WriteLine("Computer chose 3.SCISSORS.");
                                if (int.TryParse(inputPlayer, out outputPlayer))
                                {
                                    ValidEntry = true;
                                    if (outputPlayer == 3)
                                    {
                                        Console.WriteLine("It's a Tie!");
                                        Tie++; r++;
                                    }
                                    else if (outputPlayer == 1)
                                    {
                                        Console.WriteLine("Player WINS!");
                                        PlayerWins++; r++;
                                    }
                                    else if (outputPlayer == 2)
                                    {
                                        Console.WriteLine("Computer WINS!");
                                        CPUWins++; r++;
                                    }
                                }
                            }
                            continue;

                        default:
                            Console.WriteLine("Please choose your weapon 1, 2, or 3.");
                            continue;
                    }

                } while (roundsInRange);





                if (round == _totalrounds)
                {
                    
                    string inputPlayerPlay;
                    SetRounds = false;
                    roundsInRange = false;


                    

                        if (round == _totalrounds && _PlayerWins < _CPUWins)
                        {
                            Console.WriteLine("Out of"); Console.Write(_totalrounds); Console.Write("Rounds, the Winner is COMPUTER!!!");
                            Console.WriteLine("Player Wins:"); Console.Write(_PlayerWins);
                            Console.WriteLine("Computer Wins:"); Console.Write(_CPUWins);
                            Console.WriteLine("Tied Rounds:"); Console.Write(_Tie);

                            Console.Write("Would you like to play again? Type y or n:");
                            inputPlayerPlay = Console.ReadLine();
                            if (inputPlayerPlay == "n")
                            {
                                Play = false;
                                Console.WriteLine("Till next time...");
                                break;
                            }
                            else if (inputPlayerPlay == "y")
                            {
                                Play = true;
                                continue;
                            }

                        }
                        else if (round == _totalrounds && _PlayerWins > _CPUWins)
                        {
                            Console.WriteLine("Out of"); Console.Write(_totalrounds); Console.Write("Rounds, the Winner is PLAYER!!!");
                            Console.WriteLine("Player Wins:"); Console.Write(_PlayerWins);
                            Console.WriteLine("Computer Wins:"); Console.Write(_CPUWins);
                            Console.WriteLine("Tied Rounds:"); Console.Write(_Tie);

                            Console.Write("Would you like to play again? Type y or n:");
                            inputPlayerPlay = Console.ReadLine();
                            if (inputPlayerPlay == "n")
                            {
                                Play = false;
                                Console.WriteLine("Till next time...");
                                break;
                            }
                            else if (inputPlayerPlay == "y")
                            {
                                Play = true;
                                continue;
                            }

                        }
                        else if (round == _totalrounds && _PlayerWins == _CPUWins)
                        {
                            Console.WriteLine("Out of"); Console.Write(_totalrounds); Console.Write("Rounds, we have a TIE GAME!!!");
                            Console.WriteLine("Player Wins:"); Console.Write(_PlayerWins);
                            Console.WriteLine("Computer Wins:"); Console.Write(_CPUWins);
                            Console.WriteLine("Tied Rounds:"); Console.Write(_Tie);

                            Console.Write("Would you like to play again? Type y or n:");
                            inputPlayerPlay = Console.ReadLine();
                            if (inputPlayerPlay == "n")
                            {
                                Play = false;
                                Console.WriteLine("Till next time...");
                                break;
                            }
                            else if (inputPlayerPlay == "y")
                            {
                                Play = true;
                                continue;
                            }

                        }

                    
                }
            } while (Play);
        }
    }
}


  

            


               
       



    
