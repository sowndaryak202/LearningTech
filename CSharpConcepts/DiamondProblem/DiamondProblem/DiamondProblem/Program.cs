using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblem
{
    /// <summary>
    /// Problem statement : why multiple inheritance is not allowed
    /// Answer : because of diamond prob
    /// Solution: using interface 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //class A
    //{
    //    void methodA()
    //    {

    //    }
    //}

    //class B
    //{
    //    void methodA()
    //    {

    //    }
    //}

    //not allowed 

    //class c : A, B
    //{
    //    void methodc()
    //    {

    //    }
    ////}
    ///

    //solution :
    interface A
    {
        void methodA();
    }

    interface B
    {
        void methodA();
    }

    class c : A, B
    {
        void A.methodA()
        {
            throw new NotImplementedException();
        }

        void B.methodA()
        {
            throw new NotImplementedException();
        }

        void methodc()
        {

        }
    }
}
