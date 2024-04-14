namespace RecipeApp
{
    class Program
    {
        static void Main()
        {
            Recipe recipe = new Recipe();

            Console.WriteLine("Enter the number of ingredients: ");
            int numIngredients= Convert.ToInt32(Console.ReadLine());
            recipe.AddIngredients(numIngredients);

            Console.WriteLine("Enter the number of steps: ");
            int numSteps = Convert.ToInt32(Console.ReadLine());
            recipe.AddSteps(numSteps);

            recipe.DisplayRecipe();

            Console.WriteLine("Enter scaling factor (0.5, 2, or 3): ");
            double factor= Convert.ToDouble(Console.ReadLine());
            recipe.ScaleRecipe(factor);

            recipe.DisplayRecipe();

            recipe.ResetQuantities();

            recipe.DisplayRecipe();

            recipe.ClearData();
        }
    }
}
