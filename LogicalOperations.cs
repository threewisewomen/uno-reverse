using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uno_reverse
{
    public interface ILogicalOperations
    {
        bool And(bool left, bool right);
        bool Or(bool left, bool right);
        bool Implication(bool left, bool right);
        bool Biconditional(bool left, bool right);
        bool Negation(bool p);

    }
    public class LogicalOperations : ILogicalOperations
    {
        public bool And(bool left, bool right)
        {
            return left && right;
        }
        public bool Or(bool left, bool right) 
        {
            return left || right;
        }
        public bool Implication (bool left, bool right)
        {
            return !left || right;
        }
        public bool Biconditional(bool left, bool right)
        {
            return left == right;
        }
        public  bool Negation(bool p)
        {
            return !p;
        }
    }
}
