using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentTwo.Controllers
{
    public class J1Controller : ApiController
    {
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]

        public string Menu(int burger, int drink, int side, int dessert)
        {
            //Defining the variables
            int caloriesOfBurger = 0;
            int caloriesOfDrink = 0;
            int caloriesOfSide = 0;
            int caloriesOfDessert = 0;

            // Defineing the values of calories in individual array for each menu item
            int[] burgerCalorieValues = { 461, 431, 420, 0 };
            int[] drinkCalorieValues = { 130, 160, 118, 0 };
            int[] sideCalorieValues = { 100, 57, 70, 0 };
            int[] dessertCalorieValues = { 167, 266, 75, 0 };
            
            //Condition of getting the index values of the items in order to calculate the total calories
            if (burger >= 1 && burger <= 4)
            {
                caloriesOfBurger = burgerCalorieValues[burger - 1];
            }

            if (drink >= 1 && drink <= 4)
            {
                caloriesOfDrink = drinkCalorieValues[drink - 1];
            }

            if (side >= 1 && side <= 4)
            {
                caloriesOfSide = sideCalorieValues[side - 1];
            }

            if (dessert >= 1 && dessert <= 4)
            {
                caloriesOfDessert = dessertCalorieValues[dessert - 1];
            }
            //Total calories result
            int totalCalories = caloriesOfBurger + caloriesOfDrink + caloriesOfSide + caloriesOfDessert;

            return "Your total calorie count is " + totalCalories;
        }
    }
}
