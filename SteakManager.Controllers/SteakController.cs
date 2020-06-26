using System;
using System.Collections.Generic;
using SteakManager.Data;
using SteakManager.Models;
using SteakManager.Views;

namespace SteakManager.Controllers
{
    public class SteakController
    {
        private static SteakRepository steakRepository;

        public static void Run()
        {
            steakRepository = new SteakRepository();        // The list is created here
            string userInput;
            do
            {
                Console.WriteLine("Choose: 1.Create, 2.List All, 3.Find by ID, 4.Edit, 5.Remove.");
                userInput = Console.ReadLine();

                
                if (!int.TryParse(userInput, out int userChoice) || userChoice < 1 || userChoice > 5)
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();     //error message then get kicked out
                    return;
                }

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Create");
                        CreateSteak();
                        break;
                    case 2:
                        Console.WriteLine("List All");
                        DisplaySteaks();
                        break;
                    case 3:
                        Console.WriteLine("Find by ID");
                        SearchSteaks();
                        break;
                    case 4:
                        Console.WriteLine("Edit");
                        EditSteak();
                        break;
                    case 5:
                        Console.WriteLine("Remove");
                        RemoveSteak();
                        break;

                }

                Console.WriteLine("Press Q to Quit");
                userInput = Console.ReadLine();

            } while (userInput != "Q");
        }


        private static void EditSteak()
        {
            int Id = SteakView.SearchSteak();
            Steak mySteak = SteakRepository.ListById(Id);
            mySteak = SteakView.EditSteakInfo(mySteak);
            SteakRepository.Edit(mySteak.Id, mySteak);
            SteakView.DisplaySteak(mySteak);
        }

        private static void CreateSteak()
        {
            Steak mySteak = SteakView.GetNewSteakData();
            SteakRepository.Create(mySteak);
            SteakView.DisplaySteak(mySteak);

        }
        private static void DisplaySteaks()
        {
            List<Steak> steaks = SteakManager.Data.SteakRepository.ListAll();
            foreach(Steak steak in steaks)
            {
                SteakView.DisplaySteak(steak);
            }
        }
        private static void SearchSteaks()
        {
            int steakId = SteakView.SearchSteak();
            Steak mySteak = SteakRepository.ListById(steakId);
            SteakView.DisplaySteak(mySteak);
        }


        // 1. Search for the steak you want to remove. Use SteakView.GetSteakId() to get the id of the steak to remove?
        // 2. Get that steak using SteakRepository.ListById(Id);
        // 3. SteakView.ConfirmRemoveSteak(steak);
        // 4. SteakRepository.Delete(Id);
        private static void RemoveSteak()
        {
            var searchedId = SteakView.SearchSteak();
            Steak mySteak = SteakRepository.ListById(searchedId);
            SteakView.ConfirmRemoveSteak(mySteak);
            SteakRepository.Delete(searchedId);
           
            
            //var id = SteakRepository.ListById(searchedId);

            /**if (SteakView.ConfirmRemoveSteak(mySteak) == true)
            {
                SteakManager.Data.SteakRepository.Delete();

            }*/

            Console.WriteLine("Updated Steak List:");
            DisplaySteaks();
        }
    }
}



