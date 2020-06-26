using System.Threading;

namespace SteakManager.Models
{
    public class Steak
    {
        // these are the attributes
        public static int baseId;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cut { get; set; }
        public double Weight { get; set; }
        public bool IsBoneIn { get; set; }
        
        // the constructor is only called when you say new Steak(...)
        public Steak(string SteakName, string SteakCut, double SteakWeight, bool IsBoneInSteak)
        {
            Id = Interlocked.Increment(ref baseId); // when a new object is created, it sets the value for Id here.
            Name = SteakName;
            Cut = SteakCut;
            Weight = SteakWeight;
            IsBoneIn = IsBoneInSteak;
        }

        public override string ToString() //View Display
        {
            return string.Format
                ("ID [Id: {0}; Steak Name: {1}; Steak Cut: {2}; Avg Weight in Ounces: {3}; Has Bone: {4}]",
                Id, Name, Cut, Weight, IsBoneIn);
        }
    }
}
