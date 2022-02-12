using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class IPlusPlus
    {
        /// <summary>
        /// ++i => increment -> assign
        /// i++ => assign -> increment
        /// </summary>
        public void LearnDiff()
        {
            int i = 0, a;
            int j = 0, b;
            a = i++;
            b = ++j;

            Console.WriteLine($"value of i++ is a: {a}, i : {i }");
            Console.WriteLine($"value of ++j is a: {b}, i : {j }");

            //Output :
            //value of i++ is a: 0, i: 1
            //value of ++j is a: 1, i: 1
        }
    }
}
