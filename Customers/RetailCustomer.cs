
using Assingment1.Accounts;

namespace Assingment1.Customers
{
    internal class RetailCustomer : Customer
    {
        public string CompanyAddress { get; set; } = "";
        public RetailCustomer(string FirsrName, string LastName) : base(FirsrName, LastName)
        {
        }
   

      
        public override List<Account> createAccounts(params Account[] values)
        {
            
            List<Account> valuesAsList = values.ToList();
          
           var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{this.FirstName} {this.LastName} created these accounts:\n");
            Console.ForegroundColor = oldColor;
           
            foreach (var item in valuesAsList)//المرور على الحسابات التي انشأها الزبون حاليا 
            {
                if (item is SalaryAccount)//من انشاء حساب من هذا النوع  RetailCustomer هنا سيتم منع
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{FirstName} {LastName} you cann't create SalaryAccount!");
                    Console.ForegroundColor = oldColor;

                }
                else
                {
                    Console.WriteLine("\t" + $"{ item.GetType().Name}" +" "+$"on date {item.CreatedDate}");
                    Accounts.Add(item);

                }

            }
            Console.Write("\n");
            return Accounts;

        }

    }
}
