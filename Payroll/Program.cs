using System;
using Payroll.ThirdParty;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Employable johnDoe = new Employee("John", "Doe", 120000);
            Employable jayneDone = new Employee("Jane", "Done", 125000);
            Console.WriteLine(johnDoe.GetFullName());
            Console.WriteLine(jayneDone.GetFullName());

            johnDoe.AddNote("AccountDetails", "ABC-123");
            johnDoe.AddNote("Position", "Lead Engineer");
            jayneDone.AddNote("AccountDetails", "XYZ-789");
            jayneDone.AddNote("Position", "Head of HR");

            // FIXME: Payroll.Employable -> Payroll.ThirdParty
            // Banking.PayOut(johnDoe, johnDoe.GetSalary() / 12);
            // Banking.PayOut(jayneDone, jayneDone.GetSalary() / 12);
        }
    }
}
