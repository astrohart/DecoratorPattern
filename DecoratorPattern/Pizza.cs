using DecoratorPattern.Properties;

namespace DecoratorPattern
{
    /// <summary>
    /// Concrete implementation of the <see cref="T:DecoratorPattern.IPizza" />
    /// interface.
    /// </summary>
    public class Pizza : IPizza
    {
        /// <summary>
        /// Gets a string specifying the type of the pizza.
        /// </summary>
        /// <returns>
        /// String specifying the type of the pizza.
        /// </returns>
        public string GetPizzaType()
            => Resources.PizzaTypes_Normal;
    }
}