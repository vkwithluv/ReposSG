using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SteakManager.Data;
using SteakManager.Models;

namespace SteakManager.Views
{
    public class SteakView
    {
        public static int MenuChoice;
        public static int GetMenuChoice()
        {
            string inputMenu;


            Console.WriteLine("STEAK MANAGER \nMain Menu");
            Console.WriteLine("Please enter the number of your chosen Menu option to begin.");
            Console.Write("1. Create/Add a New Steak \n2. Display List of Steaks \n3. Search for Steak by ID# \n4. Edit Steak In List \n5. Remove Steak From List");
            inputMenu = Console.ReadLine();
            if (!int.TryParse(inputMenu, out MenuChoice) || MenuChoice < 1 || MenuChoice > 5)
            {
                Console.WriteLine("Please enter a valid Menu choice, 1-5.");
                MenuChoice = GetMenuChoice();
            }
            return GetMenuChoice();
        }




        public static int IdEntered;
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

        public static string GetNewSteakData()
        {
            //string inputName;
            //string inputCut;
            string inputWeight;
            string inputIsBoneIn;

            bool NewDataComplete = false;

            string readName;
            string readCut;
            double readWeight;
            int readIsBoneIn;
            bool HasBone;
            //Steak.Equals(HasBone); //or how to use get, set in model

            do
            {
                Console.WriteLine("Enter the Name of the Steak");
                readName = Console.ReadLine();

                Console.WriteLine("What part of the cow is this Steak Cut from?");
                readCut = Console.ReadLine();

                Console.WriteLine("What is the Weight, in ounces, of the Steak?");
                inputWeight = Console.ReadLine();
                if (!double.TryParse(inputWeight, out readWeight))
                {
                    NewDataComplete = false;
                    continue;
                }

                Console.WriteLine("Is there a Bone in this Steak? Type the number 1 for Yes or the number 2 for No.");
                inputIsBoneIn = Console.ReadLine();

                if (!int.TryParse(inputIsBoneIn, out readIsBoneIn))
                {
                    switch (readIsBoneIn)
                    {
                        case 1:
                            readIsBoneIn = 1;
                            HasBone = true;
                            NewDataComplete = true;
                            //return HasBone;
                            break;
                        case 2:
                            readIsBoneIn = 2;
                            HasBone = false;
                            NewDataComplete = true;
                            break;
                        case 3:
                            NewDataComplete = false;
                            Console.WriteLine("Invalid Input.");
                            continue;
                    }
                    /***private bool HasBone(int readIsBoneIn)
                               {
                                   if (readIsBoneIn = 1)
                                       return true;
                                       NewDataComplete = true;

                                   else if (readIsBoneIn = 2)
                                        return false;
                                        NewDataComplete = true;
                                   else
                                       NewDataComplete = false; 
                                         Console.WriteLine("Invalid Input.");
                                         continue;
                               }***/
                }

                if (NewDataComplete == true)
                {

                    return GetNewSteakData();


                }
            } while (!NewDataComplete);

            return null;

        }


        public static void DisplaySteaks(Steak data)
        {
            Console.WriteLine($"ID: {data.Id} \nName: {data.Name} \nCut: {data.Cut} \nWeight: {data.Weight}oz \n Bone In: {data.IsBoneIn}");
        }

        public static string EditSteakInfo(Steak steak)
        {
            GetSteakId();
            

            string inputWeight;
            string inputIsBoneIn;

            bool EditDataComplete = false;

            string readName;
            string readCut;
            double readWeight;
            int readIsBoneIn;
            bool HasBone;
            //Steak.Equals(HasBone); //or how to use get, set in model

            do
            {
                Console.WriteLine("Enter the NEW Name of the Steak");
                readName = Console.ReadLine();

                Console.WriteLine("What part of the cow is this NEW Steak Cut from?");
                readCut = Console.ReadLine();

                Console.WriteLine("What is the NEW Weight, in ounces, of the Steak?");
                inputWeight = Console.ReadLine();
                if (!double.TryParse(inputWeight, out readWeight))
                {
                    EditDataComplete = false;
                    continue;
                }

                Console.WriteLine("Is there a Bone in this Steak? Type the number 1 for Yes or the number 2 for No.");
                inputIsBoneIn = Console.ReadLine();

                if (!int.TryParse(inputIsBoneIn, out readIsBoneIn))
                {
                    switch (readIsBoneIn)
                    {
                        case 1:
                            readIsBoneIn = 1;
                            HasBone = true;
                            EditDataComplete = true;
                            //return HasBone;
                            break;
                        case 2:
                            readIsBoneIn = 2;
                            HasBone = false;
                            EditDataComplete = true;
                            break;
                        case 3:
                            EditDataComplete = false;
                            Console.WriteLine("Invalid Input.");
                            continue;
                    }
                    /***private bool HasBone(int readIsBoneIn)
                               {
                                   if (readIsBoneIn = 1)
                                       return true;
                                       NewDataComplete = true;

                                   else if (readIsBoneIn = 2)
                                        return false;
                                        NewDataComplete = true;
                                   else
                                       NewDataComplete = false; 
                                         Console.WriteLine("Invalid Input.");
                                         continue;
                               }***/
                }

                if (EditDataComplete == true)
                {

                    return null;


                }
            } while (!EditDataComplete);

            return null;




        }

        public static void SearchSteakId()
        {

            GetSteakId();

            IdEntered = GetSteakId();
            var myIdView = new SteakView();
            var myId = SteakView.GetSteakId();///IdEntered; 
            var id = SteakRepository.ListById(myId);

            foreach (var IdEntered in SteakRepository.data)
            {
                if (id == null)
                {
                    Console.WriteLine("Not in list");
                }
                else
                    DisplaySteaks(id);

            }

            ///var exists = SteakRepository.data.steak.Id.Contains(myId);
                                  
            //int IdEntered = SteakManager.Views.SteakView.GetSteakId();
            //bool validId = true;

            //while (validId)

        } 

        public static bool ConfirmRemoveSteak()
        {
            GetSteakId();
            bool DeleteConfirmed = false;

            do
            {

                string input;

                Console.WriteLine("Are you sure you want to remove this Steak from the List? Type: y/n");
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
                    Console.WriteLine("The is not a valid imput.");
                    DeleteConfirmed = false;

                }
                

                if (DeleteConfirmed == true)
                {
                    DeleteConfirmed = ConfirmRemoveSteak();
                   /// int d = IdEntered;
                   /// SteakManager.Data.SteakRepository.Delete(int d);

                }
                return ConfirmRemoveSteak();

            } while (!DeleteConfirmed);
        }

    }







}






