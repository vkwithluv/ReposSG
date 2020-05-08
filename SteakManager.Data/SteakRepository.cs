using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SteakManager.Models;

namespace SteakManager.Data
{
    public class SteakRepository: IEquatable<Steak>
    {
        public static List<Steak> data = new List<Steak>();
        
        public SteakRepository()
        {
       
                data = new List<Steak>();

                data.Add(new Steak(){ Id = 1, Name = "Filet Mignon", Cut = "Tenderloin", Weight = 4, IsBoneIn = false });
                new Steak{ Id = 2, Name = "Skirt Steak", Cut = "Plate", Weight = 6.5, IsBoneIn = false};
                new Steak(3, "Ribeye", "Upper Ribcage", 10, false);
                new Steak(4, "Porterhouse", "1.25in Tenderloin & Short Loin cross section", 32, true);
                new Steak(5, "T-Bone", "0.5in Tenderloin & Short Loin cross section", 24, true);
                new Steak(6, "Tomahawk", "Upper Ribcage", 45, true);

            //test: NY Strip (7, New York Strip, Short Loin, 6, false)

          
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
            return data.FirstOrDefault(d => d.Id == id); 
        }

        public static void Edit(int Id, Steak steak)
        {
            var dataOriginal = data.FirstOrDefault(d => d.Id == id);
            dataOriginal.Name = steak.Name;
            dataOriginal.Cut = steak.Cut;
            dataOriginal.Weight = steak.Weight;
            dataOriginal.IsBoneIn = steak.IsBoneIn;
        }
        public static void Remove(int Id)
        {
            data.Remove(data.FirstOrDefault(d => d.Id == id));
        }

    }
}
