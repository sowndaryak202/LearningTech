using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class NullCoalescing
    {
        /// <summary>
        /// As per the MSDN definition: 
        /// The ?? operator is called the null-coalescing operator
        /// and is used to define a default value for nullable value types or 
        /// reference types. It returns the left-hand operand if the operand is not null;
        /// otherwise, it returns the right operand. The C# Null Coalescing Operator 
        /// (??)  is a binary operator that simplifies checking for null values.
        /// It is used to assign a default value to a variable when the value is null.
        /// </summary>
        public void CheckNullCoalescing()
        {
            string name = null;
            string myname = name ?? "Laxmi";
            Console.WriteLine(myname);
            Console.ReadLine();
        }

        static string _name;
        static string Name
        {
            get
            {
                return _name ?? "Kailash";
            }
            set
            {
                _name = value;
            }
        }
        public int age { get; set; }

        /// <summary>
        /// In property also we can use a null Coalescing operator like this.
        /// </summary>
        public void CheckNullCoalescingInProp()
        {
            Console.WriteLine(Name);
            Console.ReadLine();
        }

        public class Employee
        {
            public int Id { get; set; }
            public int age { get; set; }
            public string name { get; set; }
            public string gender { get; set; }
        }

        /// <summary>
        /// Now I am showing you how this operator is used in LINQ.
        /// </summary>
        public void CheckNullCoalescingInLINQ()
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { Id = 1, age = 19, name = "Ritesh", gender = "M" });
            li.Add(new Employee { Id = 2, age = 20, name = "sujit", gender = "M" });
            li.Add(new Employee { Id = 3, age = 23, name = "Kabir", gender = "F" });
            li.Add(new Employee { Id = 4, age = 3, name = null, gender = "F" });
            li.Add(new Employee { Id = 5, age = 24, name = "Kamlesh", gender = "M" });
            li.Add(new Employee { Id = 6, age = 28, name = "Manoj", gender = "M" });

            var Data = from emp in li where emp.Id == 4 select new { Name = emp.name ?? "No name" };

            foreach (var obj in Data)
            {
                Console.WriteLine(obj.Name);
            }
            Console.ReadLine();
        }

    }
}
