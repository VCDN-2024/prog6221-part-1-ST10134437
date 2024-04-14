using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    class Recipe
    {
        private Ingredient[] ingredients;
        private Step[] steps;

        public void AddIngredients(int numIngredients)
        {
            ingredients = new Ingredient[numIngredients];
            for (int i = 0; i < numIngredients; i++)
            {
                ingredients[i] = new Ingredient();
                Console.WriteLine("Enter ingredient name: ");
                ingredients[i].Name = Console.ReadLine();
                Console.WriteLine("Enter quantity: ");
                ingredients[i].Quantity = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter unit of measurement: ");
                ingredients[i].Unit = Console.ReadLine();
            }
        }
        public void AddSteps(int numSteps) 
        {
            steps = new Step[numSteps];
            for (int i = 0;i < numSteps; i++)
            {
                steps[i]= new Step();
                Console.WriteLine("Enter step description: ");
                steps[i].Description = Console.ReadLine();
            }
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe Ingredients: ");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");

            }
            Console.WriteLine("\nRecipe Steps:");
            for (int i = 0;i<steps.Length;i++)
            {
                Console.WriteLine($"{i+1}. {steps[i].Description}");
            }
                }
        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in ingredients) 
            {
                ingredient.Quantity *= factor;
            }
        }
        public void ResetQuantities()
        {
            //Reset quantities to original valuies
        }

        public void ClearData()
        {
            ingredients = null;
            steps = null;
        }
    }
}
