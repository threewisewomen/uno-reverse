using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace uno_reverse
{
    public interface ISetTheory
    {
        bool EvaluateProperty(string propertyString, int x);
        void GenerateSet(Func<int, bool> property, int limit);
    }
    public class SetTheory : ISetTheory
    {
        public bool EvaluateProperty(string propertyString, int x)
        {
            LambdaExpression lambda = System.Linq.Dynamic.Core.DynamicExpressionParser.ParseLambda(
                typeof(int), typeof(bool), propertyString);

            object result = lambda.Compile().DynamicInvoke(x);

            return (bool)result;
        }

        public void GenerateSet(Func<int, bool> property, int limit)
        {
            HashSet<int> set = new HashSet<int>();

            for(int i = 1; i <= limit; i++)
            {
                if(property(i))
                {
                    set.Add(i);
                }
            }

            Console.WriteLine("The generated set:");
            foreach(int element in set)
            {
                Console.WriteLine(element + " ");
            }
            Console.WriteLine("___________________________________");
        }
    }
}
