using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class PassAsFunc
    {
        public string PassAs(Func<int, string> val)
        {
            return val(1);
        }
    }
}
