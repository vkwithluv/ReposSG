using System;

namespace RPStest
{
    class Program
    {
        public static int SetRounds;
        public static bool Play = true;
        public static string player;

        static void Main(string[] args)
        {
            PlayGame();
        }

        public static void PlayGame()
        {
            string inputRounds;
            string Choiceinput;
            int playerChoice;
            int computerChoice;
            bool roundsInRange = false;
            int countRounds = 0;
            int countPlayerWins = 0;
            int countComputerWins = 0;
            int countTies = 0;

            System.Collections.IList rpsList = new System.Collections.ArrayList() { "ROCK", "PAPER", "SCISSORS" };

            Random r = new Random();

            do
            {
                if (!roundsInRange)
                {
                    Console.Write("Welcome! Let's play Rock, Paper, Scissors! How many rounds would you like to play (between 1 - 10) until we have a winner?");

                    inputRounds = Console.ReadLine();

                    if (int.TryParse(inputRounds, out SetRounds))
                    {
                        if (SetRounds >= 1 && SetRounds <= 10)
                        {
                            roundsInRange = true;
                        }
                        else if (SetRounds < 1 || SetRounds > 10)
                        {
                            Console.WriteLine("Sorry. The total number of rounds must be between 1 - 10.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sorry. The total number of rounds must be between 1 - 10.");
                            break;
                        }
                    }
                }

                if (roundsInRange)
                {
                    Console.WriteLine("\nChoose your weapon... 1.ROCK, 2.PAPER, or 3.SCISORS!");
                    Choiceinput = Console.ReadLine();

                    computerChoice = r.Next(0, rpsList.Count);

                    if (int.TryParse(Choiceinput, out playerChoice))
                    {
                        switch (playerChoice)
                        {
                            case 1:
                                player = "ROCK";
                                break;
                            case 2:
                                player = "PAPER";
                                break;
                            case 3:
                                player = "SCISSORS";
                                break;
                            default:
                                Console.WriteLine("Choose a number between 1 - 3.");
                                break;
                        }
                    }

                    if (player == rpsList[computerChoice].ToString())
                        countTies++;
                    else if (player == "ROCK" && rpsList[computerChoice].Equals("SCISSORS")
                        || player == "PAPER" && rpsList[computerChoice].Equals("ROCK")
                        || player == "SCISSORS" && rpsList[computerChoice].Equals("PAPER"))
                        countPlayerWins++;
                    else countComputerWins++;

                    countRounds++;
                    Console.WriteLine($"Computer chose: {rpsList[computerChoice]}");
                    Console.WriteLine($"Total Ties: {countTies} \nPlayer Wins: {countPlayerWins} \nComputer Wins: {countComputerWins}");
                    Reset(countRounds, countPlayerWins, countComputerWins, countTies);
                }
            } while (Play);
        }

        public static void Reset(int rounds, int pwins, int cwins, int ties)
        {
            if (rounds == SetRounds)
            {
                string playAgain;
                if (pwins > cwins)
                {
                    Console.WriteLine("PLAYER WINS!");
                }
                if (pwins == cwins)
                {
                    Console.WriteLine("IT'S A TIE!");
                }
                if (pwins < cwins)
                {
                    Console.WriteLine("COMPUTER WINS!");
                }

                Console.WriteLine("Would you like to play again? Type: y or n:");
                playAgain = Console.ReadLine();

                if (playAgain == "y")
                {
                    PlayGame();
                }
                else if (playAgain == "n")
                {
                    Console.WriteLine("Thanks for playing! Till next time...");
                    Play = false;
                }
                else
                {
                    Console.WriteLine("Please, type: y or n:");
                    Play = false;
                }
            }
        }
    }
}