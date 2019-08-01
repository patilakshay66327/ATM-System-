using System;

namespace ATM_System
{
    class HomeScreen
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("Enter account number eg.(123456) :  ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter password in float eg.(123.456) : ");
            float accountPassword = float.Parse(Console.ReadLine());


            AccountCheck accountCheck = new AccountCheck();

            int flag = accountCheck.AccountVerification(accountNumber, accountPassword);

            Console.WriteLine("Value for flag "+flag);

            if (flag == 2)
            {
                int con;
                do
                {
                    Console.WriteLine("\n 1 : Amount Check\n 2 : Add Amount\n 3 : Amount Withdrow\n Enter Your Choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                 
                    switch (choice)
                    {
                        case 1:
                            AddAmount addAmount1 = new AddAmount();
                            addAmount1.displayAmount();
                            break;

                        case 2:
                            Console.WriteLine("Please enter the user amount to add : ");
                            int userAmount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("userAmount Entered is :" + userAmount);
                            AddAmount addAmount = new AddAmount();
                            addAmount.AddAmountFunction(userAmount);
                            break;

                        case 3:
                            Console.WriteLine("Please enter the user amount to withdraw : ");
                            int userWithdrawAmount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("userWithdrawAmount Entered is :" + userWithdrawAmount);
                            AddAmount withdrawAmount = new AddAmount();
                            withdrawAmount.withdrawAmountFunction(userWithdrawAmount);
                            break;

                        default:
                            Console.WriteLine("Wrong input.");
                            break;
                    }
                    Console.WriteLine("Do you Want to continue then press 0 : ");
                    con = int.Parse(Console.ReadLine());
                }while(con == 0);
        }
            else
            {
                Console.WriteLine("Please Enter valid Cridentials.");
            }
        }
    }
}
