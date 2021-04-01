using DecoratorPattern.Tests.Properties;
using NUnit.Framework;

namespace DecoratorPattern.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:DecoratorPattern.Pizza" />
    /// class.
    /// </summary>
    [TestFixture]
    public class PizzaTests
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:DecoratorPattern.IPizza" /> interface.
        /// </summary>
        private IPizza ThePizza { get; } = new Pizza();

        /// <summary>
        /// Asserts that the <see cref="M:DecoratorPattern.Pizza.GetPizzaType" />
        /// method returns the Normal pizza type.
        /// </summary>
        [Test]
        public void Test_GetPizzaType_Method_Says_ThisIsNormalPizza()
            => Assert.AreEqual(
                Resources.PizzaTypes_Normal, ThePizza.GetPizzaType()
            );
    }
}