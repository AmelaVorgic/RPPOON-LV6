using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6RPPOON
{
    class StringLengthChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            if (stringToCheck.Length > 8)
            {
                return true;
            }
            return false;
        }
    }
}
