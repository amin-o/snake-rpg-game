using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class FoodConsumable
    {
         
        public int X { get; set; }

        public int Y { get; set; }

        public string Name { get; set; }

        public int Points { get; set; }
 
        public FoodConsumable()
        {

        }
    
        public FoodConsumable(int x, int y, string name, int points)
        {

            X = x;
            Y = y;
            Name = name;
            Points = points;
    
        }

        public string generateNameOfConsumable()
        {

            //Types of foods
            String[] type = { "Ant", "Egg", "Pig", "Boar","Bird" };

            Random random = new Random();

            string tempName = "PLACE HOLDER";

            int i = random.Next(1, type.Length + 1);

            //Ant
            if(i == 1)
            {
                tempName = type[0];
            }//Egg
            else if (i == 2)
            {
                tempName = type[1];
            }
            //Pig
            else if (i == 3)
            {
                tempName = type[2];
            }
            //Boar
            else if (i == 4)
            {
                tempName = type[3];

            }
            //Bird
            else if (i == 5)
            {
                tempName = type[4];

            }

            return tempName;

        }

        public int generatePointsOfConsumable(string name)
        {

            int tempPoints = 0;

            if(name.CompareTo("Ant") == 0)
            {
                tempPoints = 10;

            } else if (name.CompareTo("Egg") == 0)
            {
                tempPoints = 25;
            }
            else if (name.CompareTo("Pig") == 0)
            {
                tempPoints = 50;
            }
            else if (name.CompareTo("Boar") == 0)
            {
                tempPoints = 75;
            } else if(name.CompareTo("Bird") == 0)
            {

                tempPoints = 100;

            }

            return tempPoints;
            
        }

    }
}
