using System;
using Library;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeContent recipeContent) // Ahora PrintRecipe recibe un IRecipeContent no un Recipe
        {
            Console.WriteLine(recipeContent.GetTextToPrint());
        }
    }
}