using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using SteakManager.Models;

namespace SteakManager.Data
{
    public class SteakRepository
    {
        
        public static List<Steak> steakList = new List<Steak>(); 
        
        public SteakRepository()        // this is also a constructor, by the way!
        {
            steakList = new List<Steak>();
            if (steakList == null)
            {
                steakList.Add(new Steak("Filet Mignon", "Tenderloin", 4, false)); // new Steak() calls the Steak constructor.
                steakList.Add(new Steak("Skirt Steak", "Plate", 6.5, false));//so is the Id
                steakList.Add(new Steak("Ribeye", "Upper Ribcage", 10, false));
                steakList.Add(new Steak("Porterhouse", "1.25in Tenderloin & Short Loin cross section", 32, true));
                steakList.Add(new Steak("T-Bone", "0.5in Tenderloin & Short Loin cross section", 24, true));
                steakList.Add(new Steak("Tomahawk", "Upper Ribcage", 45, true));

                //test: NY Strip (New York Strip, Short Loin, 6, false)
            }

        }

        // Add the steak to the steakList
        public static Steak Create(Steak steak)
        {
            if (steakList.Contains(steak))
                return null;
            else
                steakList.Add(steak);
                return steak;

            //steakList.FirstOrDefault(d => d.Id == steak.Id);construtor should do this in Models
        }

        // Get all steaks in the list
        public static List<Steak> ListAll()
        {
            return steakList;
        }

        // Get a steak by its Id
        public static Steak ListById(int Id)
        {
            return steakList.FirstOrDefault(d => d.Id == Id);
        }

        // Replace the steak with Id, with the new steak
        public static void Edit(int Id, Steak newSteak)
        {
            // 1. Search steakList for a steak with an id equal to Id - in the repository or in View? I thought to dao a Contains() in View but save to repo?
                    // I think the idea is that this steak parameter has already been edited, and now we just want to save it to the list.
                    // The steak that's getting passed in IS the edited steak.
            
            // 2. Replace that steak with this newSteak.

        }

        // Remove the steak with Id from the steakList
        public static void Delete(int Id)
        {
            steakList.Remove(steakList.FirstOrDefault(d => d.Id == Id));
        }

    }
}
