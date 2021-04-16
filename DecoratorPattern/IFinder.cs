using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public interface IFinder
    {
        bool IsMatch(string source, string pattern, string dest = "");
    }

    public class NeitherMatchCaseNorWholeWordFinder : IFinder
    {
        public bool IsMatch(string source, string pattern, string dest = "")
            => source.Contains(pattern) ||
               (dest.Contains(pattern) && source.Contains(dest));
    }

    public abstract class FinderDecorator : IFinder
    {
        /// <summary>
        /// Reference to an instance of an object that implements the <see cref="T:DecoratorPattern.IFinder" /> interface. 
        /// </summary>
        private IFinder _finder;

        /// <summary>
        /// Constructs a new instance of <see cref="T:DecoratorPattern.FinderDecorator" /> and returns a reference to it.
        /// </summary>
        protected FinderDecorator(IFinder finder)
        {
            _finder = finder;
        }

        public abstract bool IsMatch(string source, string pattern, string dest = "");
    }

    public class 
}
