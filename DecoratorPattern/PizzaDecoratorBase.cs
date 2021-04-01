using System;

namespace DecoratorPattern
{
    /// <summary>
    /// Common abstract base class for all decorators.
    /// </summary>
    public abstract class PizzaDecoratorBase : IPizza
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:DecoratorPattern.IPizza" />
        /// interface.
        /// </summary>
        private readonly IPizza _pizza;

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
        protected PizzaDecoratorBase(IPizza pizza)
            => _pizza = pizza ?? throw new ArgumentNullException(nameof(pizza));

        /// <summary>
        /// Gets a string specifying the type of the pizza.
        /// </summary>
        /// <returns>
        /// String specifying the type of the pizza.
        /// </returns>
        public virtual string GetPizzaType()
            => _pizza.GetPizzaType();
    }
}