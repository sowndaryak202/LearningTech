using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnmangedCode
{
    class Program
    {
        static void Main(string[] args)
        {
            using(clearMemory cm = new clearMemory() )
            {
                cm.writeToConsole();
            };
            Console.ReadLine();
        }
    }

   public class clearMemory : IDisposable
    {
        public void writeToConsole()
        {
            Console.WriteLine("ssss");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
