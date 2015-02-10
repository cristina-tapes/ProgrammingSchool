using System.Collections.Generic;

namespace ProgrammingSchool
{
    public class SolarSystem
    {
        public string Name { get; set; }
        public List<Star> Stars { get; set; }
        public List<Planet> Planets { get; set; }
        public string Description { get; set; }

        public double Mass {
            get
            {
                double value = 0;
                foreach (Star star in Stars)
                {
                    value += star.Mass;
                }
                foreach (Planet planet in Planets)
                {
                    value += planet.Mass;
                }
                return value;
            }
        }
    }
}
