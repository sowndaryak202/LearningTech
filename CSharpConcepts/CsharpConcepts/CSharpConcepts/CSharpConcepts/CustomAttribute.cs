using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class CustomAttribute : Attribute
    {
        public string Helptext { get; set; }
    }

    [Custom(Helptext = "This is Employee class")]
    public class Employee
    {
        [Obsolete("This is deprecated, Use new method 1", true)]
        public void Method1()
        {

        }

        public void NewMethod1()
        {

        }
    }

    public class CheckEmp
    {
        public void check()
        {
            Employee emp = new Employee();
            //emp.Method1();
        }
    }
}
