using System.Collections.Generic;

namespace ProgrammingSchool
{
    public class Galaxy
    {
        public Blackhole Blackhole { get; set; }
        public List<Galaxy> Galaxies { get; set; }
        public DarkMatter DarkMatter { get; set; }
        public double Mass {
            get
            {
                double value = DarkMatter.Mass;
                foreach (Galaxy galaxy in Galaxies)
                {
                    value += galaxy.Mass;
                }
                return value;
            }
        }
    }
}
