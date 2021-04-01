using System;

namespace DecoratorPattern
{
    /// <summary>
    /// Contains the application-specific code.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// String containing the unique identifier of this application.
        /// </summary>
        public static string AppId = "{5940A03A-CCF6-4E4C-BEAA-3E02805DC687}";

        /// <summary>
        /// Entry point for the application.
        /// </summary>
        /// <param name="args">
        /// (Required.) Array of zero or more strings.
        /// <para />
        /// Each string is a command-line argument that was passed to this
        /// program on startup.
        /// </param>
        public static void Main(string[] args)
        {
            IPizza pizza = new PutRedOnionsOn(
                new PutTomatoSlicesOn(
                    new PutExtraCheeseOn(
                        new Pizza()
                        )
                    )
            );
            var pizzaType = pizza.GetPizzaType();

            Console.WriteLine(pizzaType);
            Console.ReadKey();
        }
    }
}