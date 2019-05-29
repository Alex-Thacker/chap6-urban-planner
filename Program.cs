using System;
using System.Collections.Generic;

namespace urban_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Business mcdonalds = new Business("123 fake street") {
                Stories = 1,
                Width = 10.0,
                Depth = 15.0
            };
           mcdonalds.dateConstructed();
           mcdonalds.purchase("bob");
        
        List <Business> bus = new List <Business>() {
            mcdonalds
        };
        
        mcdonalds.display();
        }
    }
}
