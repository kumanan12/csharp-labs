using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceLib
{
    public class CIcalculator
    {

        public int Add(int n1, int n2)
        {
            var m1 = new InternalMath();
            return m1.Add(n1, 21);
        }
    }
}
