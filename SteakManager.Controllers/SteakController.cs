using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SteakManager.Models;
using SteakManager.Data;
using SteakManager.Views;

namespace SteakManager.Controllers
{
    public class SteakController
    {
        public static void Run()
        {

            bool validMenu = false;
            int MenuChoice = SteakView.MenuChoice;



            while (validMenu)
            {
                switch (MenuChoice)
                {
                    case 1:
                        MenuChoice = 1;
                        validMenu = true;
                        CreateSteak();
                        break;
                    case 2:
                        MenuChoice = 2;
                        validMenu = true;
                        DisplaySteaks();
                        break;
                    case 3:
                        MenuChoice = 3;
                        validMenu = true;
                        SearchSteaks();
                        break;
                    case 4:
                        MenuChoice = 4;
                        validMenu = true;
                        EditSteak();
                        break;
                    case 5:
                        MenuChoice = 5;
                        validMenu = true;
                        RemoveSteak();
                        break;
                    default:
                        break;
                }
            }
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
            SteakManager.Views.SteakView.SearchSteakId();

            //int IdEntered = SteakManager.Views.SteakView.GetSteakId();
            //bool validId = true;

            //while (validId)

        }

        private static void EditSteak()
        {
            SteakManager.Views.SteakView.EditSteakInfo();
        }
        private static void RemoveSteak()
        {
            SteakManager.Views.SteakView.ConfirmRemoveSteak();
        }
    }
}



