using System;
using System.Collections.Generic;
using System.Text;

namespace DoSomeMaths2
{
    class Maths
    {
        public int AddMe(int x)
        {
            int result = x + x;
            return result;
        }

        public int AddMe(decimal x)
        {
            decimal result = x * x;
            int changed = Convert.ToInt32(result);
            return changed;
        }

        public int AddMe(string x)
        {
            int y = Convert.ToInt32(x);
            int result = y - 50;
            return result;
        }
    }
}
