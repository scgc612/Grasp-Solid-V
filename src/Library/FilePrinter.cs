using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        /// <summary>
        /// Cambiado por DIP
        /// </summary>
        public void PrintRecipe(IRecipeContent recipeContent)
        {
            File.WriteAllText("Recipe.txt", recipeContent.GetTextToPrint());
        }
    }
}