using System.Collections.Generic;

namespace ProgrammingSchool
{
    public class StarSystem
    {
        public string Name { get; set; }
        public List<Star> Stars { get; set; }
        public double Mass {
            get
            {
                double value = 0;
                foreach (Star star in Stars)
                {
                    value += star.Mass;
                }
                return value;
            }
        }
    }
}
