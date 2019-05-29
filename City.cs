using System;
using System.Collections.Generic;

namespace urban_planner {
    class City {
        public string Name = "City of Awesome";
        public string Mayor = "Mr. doggyFoggy";
        public string Year = "1990";
        public List <Business> building = new List <Business>();
        public void addBuilding(Business build) {
            building.Add(build);
        }
        
    }
}

// Name of the city. string
// The mayor of the city. string
// Year the city was established. string
// A collection of all of the buildings in the city. list <business>
// A method to add a building to the city. 