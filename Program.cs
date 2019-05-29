using System;
using System.Collections.Generic;

namespace urban_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Business mcdonalds = new Business("123 fake street")
            {
                Stories = 1,
                Width = 10.0,
                Depth = 15.0
            };
            mcdonalds.dateConstructed();
            mcdonalds.purchase("bob");

            // mcdonalds.display();

            Business burgerKing = new Business("333 meow lane")
            {
                Stories = 10,
                Width = 15.0,
                Depth = 45.0
            };
            burgerKing.dateConstructed();
            burgerKing.purchase("Bill");

            City awesomeTown = new City();
            awesomeTown.addBuilding(mcdonalds);
            awesomeTown.addBuilding(burgerKing);

            foreach(Business build in awesomeTown.building){
                build.display();
            }

        }
    }
}
