using System;

namespace Full_GRASP_And_SOLID
{
    
    public class ConsolePrinter : IPrinter
    {
        /// <summary>
        /// Cambiado por DIP
        /// </summary>
        /// <param name="recipeContent"></param>
        public void PrintRecipe(IRecipeContent recipeContent)
        {
            Console.WriteLine(recipeContent.GetTextToPrint());
        }
    }
}