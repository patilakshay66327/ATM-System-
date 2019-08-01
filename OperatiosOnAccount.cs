using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_System
{
    class AddAmount
    {   
        private static int amount;
        public void AddAmountFunction(int userAmount)
        {
            amount = amount + userAmount;
            Console.WriteLine("Amount "+ userAmount +" added successfully into your account");
        }

        public void withdrawAmountFunction(int withdrawValue)
        {
            amount = amount - withdrawValue;
            Console.WriteLine("Amount "+ withdrawValue +" withdraw successfully from your account");
        }

        public void displayAmount()
        {
            Console.WriteLine("Balance in you account : " + amount);
        }

    }
}
