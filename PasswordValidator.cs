using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6RPPOON
{
    class PasswordValidator
    {
        private StringChecker MyStringChecker;
        private StringChecker YourStringChecker;

        public PasswordValidator(StringChecker MyStringChecker)
        {
            this.MyStringChecker = MyStringChecker;
        }

        public void AddNewChecker(StringChecker newChecker)
        {
            this.YourStringChecker = newChecker;
        }

        protected override bool PerformCheck(string stringToCheck)
        {
            if (MyStringChecker.Check(stringToCheck))
            {
                return true;
            }
            return false;
        }
    }

}
