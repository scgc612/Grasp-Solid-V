namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// Por el principio de inversion de dependencia, definimos la abstraccion 
    /// IRecipeContent de la que queremos que ConsolePrinter y Recipe dependan.
    /// De esta forma la dependencia de ConsolePrinter deja de ser Recipe y pasa ser IRecipeContent
    /// Se evita que la clase de alto nivel ConsolePrinter depende de una de bajo nivel Recipe.
    /// 
    /// Por otro lado tambien se cumple el pricipio OCP ya que esta interfaz permite la implementación de otras clases
    /// pudiendo utilizar una de las clases que implementan IPrinter.
    /// </summary>
    public interface IRecipeContent
    {
        string GetTextToPrint();
    }
}