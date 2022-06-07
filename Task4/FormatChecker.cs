using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class FormatChecker
    {
        public bool IsValid(string mobileNumber)
        {
            bool ans = true;
            if (mobileNumber.Length < 11 || mobileNumber.Length > 11 || mobileNumber == "" || mobileNumber == null)
                return false;
            else 
            {
                char[] chars = mobileNumber.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] < 48 || chars[i] > 57)
                    {
                        ans = false;
                        break;
                    }
                }
                return ans;
            }
            
        }
    }
}
