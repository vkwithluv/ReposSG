using System;

namespace HealthyHearts
{
    class Program
    {
        static void Main(string[] args)
        { 
            string InputUser;
            int UserAge;
            int Age = 0;
            //int Max = (220-(Age));
            //int TargetStart = (Max/2);
            //double TargetEnd = (Max*(.85));


            bool UserIsAlive = true;

            do
            {

                Console.WriteLine("White is your age?");
                InputUser = Console.ReadLine();
                if (int.TryParse(InputUser, out UserAge))
                {
                    if (UserAge >= 1 && UserAge <= 110)
                    {
                        Age += UserAge;
                        Console.Write("Your maximum heart rate should be "); Console.Write(220-UserAge); Console.Write(" beats per minute.\n");
                        Console.Write("Your target HR Zone is "); Console.Write((220 - UserAge)/2); Console.Write(" - "); Console.Write((220 - UserAge)*(.85)); Console.Write(" beats per minute.\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You are how old?! That can't be right.");
                    }
                    continue;
                }
            } while (UserIsAlive);
        }
    }
}
