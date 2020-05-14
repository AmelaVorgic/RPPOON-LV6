using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6RPPOON
{
    class StringUpperCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            if (stringToCheck.Any(char.IsUpper))
            {
                return true;
            }
            else return false;
        }
    }
}
