using System;

namespace DogGenetics
{
    class Program
    {
           
        static void Main(string[] args)
        {

            bool DoggyDNA = true;
            string InputDogName;

            Random randomizer = new Random();

            int b = randomizer.Next(1, 100);
            int r = randomizer.Next(1, (100 - b));
            int e = randomizer.Next(1, (100 - (b + r)));
            int d = randomizer.Next(1, (100 - (b + r + e)));
            int s = randomizer.Next(1, (100 - (b + r + e + d)));

            do
            {

                Console.WriteLine("What is your dog's name?");

                InputDogName = Console.ReadLine();


                if (!string.IsNullOrEmpty(InputDogName))
                {
                    Console.Write("\nWell then, I have this highly reliable report on "); Console.Write(InputDogName); Console.Write("'s prestigious background right here:\n");
                    Console.Write(InputDogName); Console.Write(" is:\n\n\n");
                    {
                        // (b + r + e + d + s == 100)
                        
                            Console.Write(b); Console.Write("% Maltese\n");
                            Console.Write(r); Console.Write("% Doberman Pinscher\n");
                            Console.Write(e); Console.Write("% Bull Terrier\n");
                            Console.Write(d); Console.Write("% Miniature Schnauzer \n");
                            Console.Write(s); Console.Write("% Cavalier King Charles Spaniel\n");
                        


                    }
                    Console.WriteLine("\nWow, that's QUITE the dog!");
                    break;
                }

                if (string.IsNullOrEmpty(InputDogName))
                {
                    Console.WriteLine("Please type the name of your dog to recieve an accurate genetic breakdown.");
                    continue;
                }
            } while (DoggyDNA);


            


            
        }
    }
}

        

     
