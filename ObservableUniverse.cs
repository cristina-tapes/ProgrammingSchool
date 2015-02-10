using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingSchool
{
    public class ObservableUniverse
    {
        public List<Galaxy> Galaxies { get; set; }
        public List<Star> Stars { get; set; }
        public DarkMatter DarkMatter { get; set; }
        public double Mass {
            get
            {
                double value = DarkMatter.Mass;
                foreach (Galaxy galaxy in Galaxies)
                {
                    value += galaxy.Mass;
                }
                foreach (Star star in Stars)
                {
                    value += star.Mass;
                }
                return value;
            }
        }
    }
}
