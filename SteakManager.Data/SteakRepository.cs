using System.Collections.Generic;
using System.Linq;
using SteakManager.Models;

namespace SteakManager.Data
{
    public class SteakRepository
    {
        public static List<Steak> data = new List<Steak>();

        public SteakRepository()
        {
            data = new List<Steak>();
            if (data == null)
            {
                data.Add(new Steak(01, "Filet Mignon", "Tenderloin", 4, false));
                data.Add(new Steak(04, "Skirt Steak", "Plate", 6.5, false));
                data.Add(new Steak(03, "Ribeye", "Upper Ribcage", 10, false));
                data.Add(new Steak(02, "Porterhouse", "1.25in Tenderloin & Short Loin cross section", 32, true));
                data.Add(new Steak(05, "T-Bone", "0.5in Tenderloin & Short Loin cross section", 24, true));
                data.Add(new Steak(06, "Tomahawk", "Upper Ribcage", 45, true));

                //test: NY Strip (07, New York Strip, Short Loin, 6, false)
            }

        }

        public static Steak Create(Steak steak)
        {
            if (data.Any(x => x.Name == steak.Name))
            {
                return null;
            }

            else
                data.Add(steak);

            return data.FirstOrDefault(d => d.Id == steak.Id);

        }
        public static List<Steak> ListAll()
        {
            return data;
        }
        public static Steak ListById(int Id)
        {
            return data.FirstOrDefault(d => d.Id == Id);
        }

        public static void Edit(int Id, Steak steak)
        {
            var dataOriginal = data.FirstOrDefault(d => d.Id == Id);
            dataOriginal.Name = steak.Name;
            dataOriginal.Cut = steak.Cut;
            dataOriginal.Weight = steak.Weight;
            dataOriginal.IsBoneIn = steak.IsBoneIn;
        }
        public static void Delete(int Id)
        {
            data.Remove(data.FirstOrDefault(d => d.Id == Id));
        }

    }
}
