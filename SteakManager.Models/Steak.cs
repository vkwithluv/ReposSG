using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SteakManager.Models
{
    public class Steak
    {
        public static int baseId;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cut { get; set; }
        public double Weight { get; set; }
        public bool IsBoneIn { get; set; }

        public Steak(int Id, string SteakName, string SteakCut, double SteakWeight, bool IsBoneInSteak)
        {
            Id = Interlocked.Increment(ref baseId);
            SteakName = Name;
            SteakCut = Cut;
            SteakWeight = Weight;
            IsBoneInSteak = IsBoneIn;

            this.Id = Id;
            this.Name = Name;
            this.Cut = Cut;
            this.Weight = Weight;
            this.IsBoneIn = IsBoneIn;

           string.Format
                ("ID [Id: {0}; Steak Name: {1}; Steak Cut: {2}; Avg Weight in Ounces: {3}; Has Bone: {4}]",
                Id, Name, Cut, Weight, IsBoneIn);
        }
        public override string ToString() //Menu Display or View Display?
        {
            return string.Format
                ("ID [Id: {0}; Steak Name: {1}; Steak Cut: {2}; Avg Weight in Ounces: {3}; Has Bone: {4}]",
                Id, Name, Cut, Weight, IsBoneIn);
        }
    }
}
