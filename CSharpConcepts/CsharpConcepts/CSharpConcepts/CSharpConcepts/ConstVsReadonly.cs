using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class ConstVsReadonly
    {
        public const int age = 12;
        public readonly int id = 641004;
        public readonly int areaCode ;

        public ConstVsReadonly()
        {
            // not allowed - age = 44;
            id = 641005;
            areaCode = 641004;
        }

        public void alertMsg()
        {
            // not allowed - age = 44;
            // not allowed id = 641005;
            // not allowed - areaCode = 641004;
        }
    }
}
