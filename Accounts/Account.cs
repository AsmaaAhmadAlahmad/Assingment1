using Assingment1.Customers;
namespace Assingment1.Accounts
{
    internal  class  Account
    {

        public   double Balance { get; set; }
        public bool IsClosed { get; set; }

        public DateTime CreatedDate { get;  }

        public Account()
        {
            CreatedDate = DateTime.UtcNow;
        }
        public  double Deposit(double money, Customer customer)

        {
              var oldColor = Console.ForegroundColor;
            if (this.IsClosed == true)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{customer.FirstName} {customer.LastName} you cannot dipost money from {GetType().Name} because it is closed\n");

                Console.ForegroundColor = oldColor;
                return 0;
            }
            foreach (var item in customer.Accounts)//حلقة للمرور على حسابات الزبون والتحقق من بعض الشروط
            {
                if (item == this)//للتأكد من ان الزبون يملك هذا الحساب في قائمة حساباته
                {
                    if (item is SalaryAccount) //لمنع ايداع الرصيد في الحساب الذي من هذا النوع  
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{customer.FirstName} {customer.LastName} you cann't dipost money from your account {GetType().Name}");
                        Console.ForegroundColor = oldColor;

                        return 0;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"Customer {customer.FirstName} {customer.LastName}  deposited ${money} into his {GetType().Name}\n ,Balance after deposit: ${Balance += money}\n\n");
                        Console.ForegroundColor = oldColor;

                        return 0;
                    }
                }
              
            }
            Console.ForegroundColor = ConsoleColor.Red;//ان وصل التنفيذ الى هنا هذا يعني ان الزبون لايملك الحساب
            Console.WriteLine($" {customer.FirstName} {customer.LastName} you don't have this account!\n");
            Console.ForegroundColor = oldColor;

            
            return 0;
        
           


        }
       
        public  double Withdraw(double money, Customer customer)
        {
              var oldColor = Console.ForegroundColor;
            if (this.IsClosed == true)//للتأكد من ان الحساب ليس مغلق

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{customer.FirstName} {customer.LastName}You cannot withdraw money from {this.GetType().Name} because it is closed\n");
                Console.ForegroundColor = oldColor;
                return 0;
            }
           foreach (var item in customer.Accounts)//حلقة للمرور على حسابات الزبون والتحقق من بعض الشروط
            {
                if (item == this)//للتأكد من ان الزبون يملك هذا الحساب في قائمة حساباته
                {
                    if (item is SavingsAccount) //لمنع سحب رصيد من الحساب الذي من هذا النوع  
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{customer.FirstName} {customer.LastName} you cann't withdraw money from your account '{this.GetType().Name}'");
                        Console.ForegroundColor = oldColor;

                        return 0;
                    }
                    else
                    {
                        if (money > Balance)//للتأكد من وجود رصيد كافي لسحب المبلغ المطلوب
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("insufficient funds to withdraw\n");
                            Console.ForegroundColor = oldColor;

                            return 0;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{customer.FirstName} {customer.LastName} " +
                               $"withdraw from his {this.GetType().Name} ${money}\n Balance after withdrawal: ${Balance -= money}\n\n");
                            Console.ForegroundColor = oldColor;
                            return 0;
                        }
                    }
                }
               
            }
            Console.ForegroundColor = ConsoleColor.Red;//ان وصل التنفيذ الى هنا هذا يعني ان الزبون لايملك الحساب 
            Console.WriteLine($"{customer.FirstName} {customer.LastName} you don't have {this.GetType().Name}! \n");
            Console.ForegroundColor = oldColor;
            return 0;
        }



        public void Delete()
        {
            var oldColor = Console.ForegroundColor;
            if (Balance == 0)//التاكد من ان الحساب لايحوي رصيد حتى يتم حذفه
            {
                IsClosed = true;
                DateTime ClosedDate = DateTime.Now;
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine($"{this} has been closed in {ClosedDate}\n");
                Console.ForegroundColor = oldColor;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"you cann't close {this.GetType().Name} because it contains a balance!\n");
                Console.ForegroundColor = oldColor;
            }

        }

    }



}


