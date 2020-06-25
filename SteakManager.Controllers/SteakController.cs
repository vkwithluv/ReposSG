using System;
using SteakManager.Data;
using SteakManager.Models;
using SteakManager.Views;

namespace SteakManager.Controllers
{
    public class SteakController
    {
        public static void Run()
        {
            SteakView.GetMenuChoice();
           
        }

        private static void EditSteak(int myId, string getsteak)
        {
            throw new NotImplementedException();
        }

        private static void CreateSteak()
        {
            SteakManager.Views.SteakView.GetNewSteakData();
            var NewData = new SteakManager.Data.SteakRepository();
            return;

        }
        private static void DisplaySteaks()
        {
            SteakManager.Data.SteakRepository.ListAll();

        }
        private static void SearchSteaks()
        {
            SteakView.SearchSteakId();

        }

        private static void EditSteak(int Id, Steak steak)
        {
            SteakView.EditSteakInfo(steak);
            SteakRepository.Edit(Id, steak);
            DisplaySteaks();

        }
        private static void RemoveSteak()
        {
            SteakView.ConfirmRemoveSteak();

            var myRemoveId = new SteakView();
            var searchedID = SteakView.GetSteakId();
            var id = SteakRepository.ListById(searchedID);

            if (SteakView.ConfirmRemoveSteak() == true)
            {
                SteakManager.Data.SteakRepository.Delete(searchedID);

            }
            Console.WriteLine("Updated steak list:");
            DisplaySteaks();
        }
    }
}



