namespace DecoratorPattern
{
    /// <summary>
    /// Base interface.
    /// </summary>
    public interface IPizza
    {
        /// <summary>
        /// Gets a string specifying the type of the pizza.
        /// </summary>
        /// <returns>
        /// String specifying the type of the pizza.
        /// </returns>
        string GetPizzaType();
    }
}