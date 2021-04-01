using DecoratorPattern.Properties;

namespace DecoratorPattern
{
    /// <summary>
    /// Puts red onion pieces on the pizza.
    /// </summary>
    public class PutRedOnionsOn : PizzaDecoratorBase
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:DecoratorPattern.PizzaDecoratorBase" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="pizza">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:DecoratorPattern.IPizza" /> interface.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="pizza" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public PutRedOnionsOn(IPizza pizza) : base(pizza) { }

        /// <summary>
        /// Gets a string specifying the type of the pizza.
        /// </summary>
        /// <returns>
        /// String specifying the type of the pizza.
        /// </returns>
        public override string GetPizzaType()
            => base.GetPizzaType() + Resources.PizzaTopping_RedOnions;
    }
}