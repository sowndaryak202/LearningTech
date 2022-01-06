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
    /// Solution: using interface or wrapper class
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

    class ParentA
    {
        public void MethodA()
        {
            Console.WriteLine("MethodA from ParentA called");
        }
        public void MethodB()
        {
            Console.WriteLine("MethodB from ParentA called");
        }
    }

    class ParentB
    {
        public void MethodA()
        {
            Console.WriteLine("MethodA from ParentB called");
        }
        public void MethodB()
        {
            Console.WriteLine("MethodB from ParentB called");
        }
    }

    class ParentWrapper
    {
        ParentA objA = new ParentA();
        ParentB objB = new ParentB();
        public void ParentWrapperAMethodA()
        {
            objA.MethodA();
        }
        public void ParentWrapperAMethodB()
        {
            objA.MethodB();
        }
        public void ParentWrapperBMethodA()
        {
            objB.MethodA();
        }
        public void ParentWrapperBMethodB()
        {
            objB.MethodB();
        }
    }

    class Child : ParentWrapper
    {

    }
}
