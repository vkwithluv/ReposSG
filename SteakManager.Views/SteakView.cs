using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SteakManager.Models;
using SteakManager.Data;

namespace SteakManager.Views
{
    public class SteakView
    {
        public static int MenuChoice;
        public int GetMenuChoice()
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

            Console.WriteLine("Enter ID#:");
            inputId = Console.ReadLine();

            if (!int.TryParse(inputId, out IdEntered) || IdEntered < 1)// || IdEntered > SteakRepository.data[last])
            {
                Console.WriteLine("Not a Valid ID#");
                IdEntered = GetSteakId();
            }
            return GetSteakId();

            Console.WriteLine("Press the m key to return to Main Menu or press the q key to Quit:");
            Console.ReadKey();

        }

        /***    
        private void CreateDvd() 
        {
            var myView = new DvdView();
            var dvdInfos = myView.GetNewDvdInfo();
            var createDvd = _dvds.Create(dvdInfos);

            if (createDvd == null)
            {
                Console.WriteLine("Already in list.");
            }
        }***/
        public static string GetNewSteakData()
        {
            string inputName;
            string inputCut;
            string inputWeight;
            ConsoleKeyInfo inputIsBoneIn; //translate string to bool later?
            ConsoleKey y;
            ConsoleKey n;
            bool NewDataComplete = false;

            string readName;
            string readCut;
            double readWeight;
            bool readIsBoneIn;

            do
            {
                Console.WriteLine("Enter the Name of the Steak");
                readName = Console.ReadLine();
                //if (readName = SteakManager.Data.SteakRepository.data.Contains())???
                foreach(Steak Name in SteakRepository.data)
                {
                    Console.WriteLine("Already in list.");
                }

                SteakManager.Data.SteakRepository.data.Contains(new Steak { Name = readName });
                Console.WriteLine("What part of the cow is this Steak Cut from?");
                readCut = Console.ReadLine();

                Console.WriteLine("What is the Weight, in ounces, of the Steak?");
                inputWeight = Console.ReadLine();
                if (!double.TryParse(inputWeight, out readWeight))
                {
                    NewDataComplete = false;
                    continue;
                }

                Console.WriteLine("Is there a Bone in this Steak? Type the letter y for yes or the letter n for no.");
                inputIsBoneIn = Console.ReadKey();
                //inputIsBoneIn.Key; 

                if (inputIsBoneIn.Key = y)
                {
                    ///needs to read the key y or n and set bool to true or false
                    if ()
                    NewDataComplete = false;
                    Console.WriteLine("Invalid Input.");
                    continue;
                }

                NewDataComplete = true;
                if (NewDataComplete == true)
                {
                    
                    return GetNewSteakData();


                }
            } while (!NewDataComplete);

             return null;

        }


        public void DisplaySteaks(Steak data)
        {
     
            //Console.WriteLine($"ID: {SteakManager.Models.Steak.Id} \nName: {Name} \nCut: {Cut} \nWeight: {Weight}oz \n Bone In: {IsBoneIn}"); 
        }

        public string EditSteakInfo(Steak steak)
        {
            throw new NotImplementedException();
        }

        public int SearchSteakId()
        {
            //Should it be IdEntered? or Steak
            foreach (Steak aSteak in SteakManager.Data.SteakRepository.data)
            {
                Console.WriteLine(aSteak);
            }
        }
        public static bool ConfirmRemoveSteak()
        {
            throw new NotImplementedException();
        }

    }







}


 

    
}
