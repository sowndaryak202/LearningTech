using System;

namespace CSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal i = 8;
            if (i / 10 == 0)
            {
                decimal j = i / 10;
                Console.WriteLine($"Value of i/10 is { j}");
            }

            #region Plusplus
            IPlusPlus plusPlus = new IPlusPlus();
            plusPlus.LearnDiff();
            #endregion

            #region NullCoalescing

            NullCoalescing nullCoalescing = new NullCoalescing();
            nullCoalescing.CheckNullCoalescingInLINQ();

            #endregion

            #region PassAsFunc
            PassAsFunc passAsFunc = new PassAsFunc();
            passAsFunc.PassAs((x) => { return x.ToString(); });
            #endregion

        }
    }
}
