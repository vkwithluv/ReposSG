using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SteakManager.Models;
using SteakManager.Data;
using SteakManager.Views;
using System.Runtime.CompilerServices;
using System.CodeDom;

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
                        ///SteakView.GetSteakId();
                        var myEditId = new SteakView();
                        var myId = SteakView.GetSteakId();
                        var id = SteakRepository.ListById(myId); //search in list repo

                        if (id == null)
                        {
                            Console.WriteLine("Not in list.");
                        }
                        else
                        {
                            var getsteak = SteakView.EditSteakInfo(id);
                            foreach (var steak in SteakRepository.data)
                            {
                                if (id == null)
                                {
                                    Console.WriteLine("Not in list");
                                }
                                else
                                    EditSteak(myId, steak);
                                {
                                    ///throw new NotImplementedException();
                                }
                            }
                        }
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



