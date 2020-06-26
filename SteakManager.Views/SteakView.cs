using System;
using System.Runtime.Remoting.Messaging;
using SteakManager.Data;
using SteakManager.Models;

namespace SteakManager.Views
{
    public class SteakView
    {
        public static int IdEntered;      

        // You can delete this one
        public static int GetSteakId()
        {
            string inputId;
            bool validId = false;

            do
            {
                Console.WriteLine("Enter ID#:");
                inputId = Console.ReadLine();

                if (!int.TryParse(inputId, out IdEntered) || IdEntered < 1)// || IdEntered > SteakRepository.data[last])
                {
                    Console.WriteLine("Not a Valid ID#");
                    IdEntered = GetSteakId();
                }
                return GetSteakId();


            } while (validId);
        }



        public static Steak GetNewSteakData()
        {
            bool validWeight = false;
            double readWeight;
            bool boneAnswered = false;
            bool HasBone;

            Console.WriteLine("Enter the Name of the Steak");
            string inputName = Console.ReadLine();

            Console.WriteLine("What part of the cow is this Steak Cut from?");
            string inputCut = Console.ReadLine();

            
            Console.WriteLine("What is the Weight, in ounces, of the Steak? (please input a double)");
            string inputWeight = Console.ReadLine();
            do
            {
                if (!double.TryParse(inputWeight, out readWeight))
                {
                    Console.WriteLine("Invalid Input");
                }
                else if(double.TryParse(inputWeight, out readWeight))
                {
                    validWeight = true;
                }
            } while (!validWeight);


            Console.WriteLine("Is there a Bone in this Steak? Type Y for Yes or N for No.");
            string inputIsBoneIn = Console.ReadLine();
            do
            {
                if (inputIsBoneIn == "Y" || inputIsBoneIn == "y")
                {
                    HasBone = true;
                    boneAnswered = true;
                    
                }
                else if (inputIsBoneIn == "N" || inputIsBoneIn == "n")
                {
                    HasBone = false;
                    boneAnswered = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    HasBone = false;
                }
            } while (!boneAnswered);
         
            Steak mySteak = new Steak(inputName, inputCut, readWeight, HasBone);
            Console.WriteLine("Steak Created!");
            return mySteak;
        }

        
        public static void DisplaySteak(Steak data)
        {
            Console.WriteLine($"ID: {data.Id} \nName: {data.Name} \nCut: {data.Cut} \nWeight: {data.Weight}oz \n Bone In: {data.IsBoneIn}");
        }

        public static Steak EditSteakInfo(Steak steak)
        {
            DisplaySteak(steak);
           
            bool validNewWeight = false;
            double readNewWeight;
            bool newBoneAnswered = false;
            bool newHasBone;

            Console.WriteLine("Enter the Name of the Steak");
            string inputNewName = Console.ReadLine();

            Console.WriteLine("What part of the cow is this Steak Cut from?");
            string inputNewCut = Console.ReadLine();


            Console.WriteLine("What is the Weight, in ounces, of the Steak? (please input a double)");
            string inputNewWeight = Console.ReadLine();
            do
            {
                if (!double.TryParse(inputNewWeight, out readNewWeight))
                {
                    Console.WriteLine("Invalid Input");
                }
                else if (double.TryParse(inputNewWeight, out readNewWeight))
                {
                    validNewWeight = true;
                }
            } while (!validNewWeight);


            Console.WriteLine("Is there a Bone in this Steak? Type Y for Yes or N for No.");
            string inputIsBoneIn = Console.ReadLine();
            do
            {
                if (inputIsBoneIn == "Y" || inputIsBoneIn == "y")
                {
                    newHasBone = true;
                    newBoneAnswered = true;

                }
                else if (inputIsBoneIn == "N" || inputIsBoneIn == "n")
                {
                    newHasBone = false;
                    newBoneAnswered = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    newHasBone = false;
                }
            } while (!newBoneAnswered);

            steak.Name = inputNewName;
            steak.Cut = inputNewCut;
            steak.Weight = readNewWeight;
            steak.IsBoneIn = newHasBone;

            Console.WriteLine("Steak Edited!");

            return steak;

        }


        // Help the user find a steak. Return its id.

        // 1. Ask the user for the name of the steak they want to find.
        // 2. Search SteakRepository.steakList for a steak with that name.
        // 3. If no steak was found for that name, ask for a new name.
        // 4. If steak was found, return the Id of that steak.
        public static int SearchSteak()
        {
            Steak foundSteak = null;

            do
            {
                Console.WriteLine("Enter the Name of the Steak");
                string inputSearchName = Console.ReadLine();

                foreach (Steak steak in SteakRepository.steakList)
                {
                    if (inputSearchName == steak.Name)
                    {
                        foundSteak = steak;
                    }
                }

                if (foundSteak == null)
                    Console.WriteLine("That Steak Name is not in the List.");

            } while (foundSteak == null);
        
            return foundSteak.Id;
        }



        // Make sure the user wants to remove this steak. Return true or false.

        // 1. Display the steak
        // 2. Prompt the user - are they sure?
        // 3. Return boolean
        public static bool ConfirmRemoveSteak(Steak steak)
        {
            bool DeleteConfirmed = false;

            do
            {
                DisplaySteak(steak);

                string input;

                Console.WriteLine("Are you sure you want to remove this Steak from the List? Type Y for yes or N for no.");
                input = Console.ReadLine();
                if (DeleteConfirmed && input == "y" || input == "Y")
                {
                    Console.WriteLine("This steak has been removed from the List.");
                    DeleteConfirmed = true;
                }
                else if (DeleteConfirmed && input == "n" || input == "N")
                {
                    DeleteConfirmed = false;
                }
                else
                {
                    Console.WriteLine("The is not a valid input.");
                    DeleteConfirmed = false;
                    
                }


                if (DeleteConfirmed == true)
                {
                  int d = IdEntered;
                  SteakManager.Data.SteakRepository.Delete(d);

                }
                return ConfirmRemoveSteak(steak);

            } while (!DeleteConfirmed);
        }

    }







}






