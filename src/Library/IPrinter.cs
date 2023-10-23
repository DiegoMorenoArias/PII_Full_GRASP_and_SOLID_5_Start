
using Library;

namespace Full_GRASP_And_SOLID
{
    public interface IPrinter
    {
         void PrintRecipe(IRecipeContent recipeContent); // Ahora PrintRecipe recibe un IRecipeContent y no un Recipe
    }
}