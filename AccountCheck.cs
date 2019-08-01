using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_System
{
    class AccountCheck
    {
        public int AccountVerification(int a, float b)
        {
            if(a == 123456 && b == 123.456F)
            {
                return 2;
            }
            else 
            {
                return 1;
            }    
            
        }
    }
}
