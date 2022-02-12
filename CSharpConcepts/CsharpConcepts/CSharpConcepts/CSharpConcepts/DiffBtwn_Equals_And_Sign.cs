using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class DiffBtwn_Equals_And_Sign
    {
        /// <summary>
        /// “==” compares if the object references are same while “.Equals()” 
        /// compares if the contents are same.
        /// So if you run the below code both “==” and “.Equals()” 
        /// returns true because content as well as references are same.
        /// output: 
        /// True
        /// True
        /// </summary>
        public void CompareValue()
        {
            object o = ".NET Interview questions";
            object o1 = o;
            Console.WriteLine(o == o1);
            Console.WriteLine(o.Equals(o1));
            Console.ReadLine();
        }

        /// <summary>
        /// Now consider the below code where we have same content 
        /// but they point towards different instances. 
        /// So if you run the below code both “==” will return false and “.Equals()” 
        /// will return true. 
        /// Output: Flase True
        /// </summary>
        public void CompareValue2()
        {
            object o = ".NET Interview questions";
            object o1 = new string(".NET Interview questions".ToCharArray()); Console.WriteLine(o == o1);
            Console.WriteLine(o.Equals(o1));
            Console.ReadLine();
        }
    }
}
