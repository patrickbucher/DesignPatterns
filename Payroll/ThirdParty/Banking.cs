using System;

namespace Payroll.ThirdParty
{
    public class Banking
    {
        public static void PayOut(AccountHolder recipient, float salary)
        {
            string target = recipient.GetAccountDetails();
            Console.WriteLine($"Pay {salary:C2} to {recipient} at {target}");
        }
    }
}
