using Assingment1.Accounts;


namespace Assingment1.Customers
{
    internal class Customer 
    {
       
        public   string FirstName { get; set; }       
        public  string LastName { get; set; } 
        public DateTime BirthDate { get; set; }
        public string Email { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public bool isDeleted { get; set; } = false;

        public DateTime CreatedDate;

        public  List<Account> Accounts = new List<Account>();
        public Customer(string FirsrName, string LastName)
        {
            this.FirstName= FirsrName;
           this.LastName= LastName;
            CreatedDate = DateTime.Now;
        }
     

        public virtual List<Account> createAccounts(params Account[] values)//RetailCustomer will do override
        {
            
            List<Account> valuesAsList = values.ToList();
            var oldColor=Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{this.FirstName} {this.LastName} created these accounts:\n");
            Console.ForegroundColor = oldColor;
            foreach (var item in valuesAsList)
            {

                Console.WriteLine("\t" +$"{item.GetType().Name}"+" "+ $"on date {item.CreatedDate} ");
                Accounts.Add(item);//اضافة الحساب المنشأالى قائمة حسابات الزبون
            }
            Console.Write("\n");
            return Accounts;

        }

        
        



        public void Delete()
        {
            double sumBalance=0;
            var oldColor = Console.ForegroundColor;
            foreach (var item in this.Accounts)//المرور على حسابات هذا الزبون وجمع ارصدته 
            {
                sumBalance+= item.Balance;
            }
            if (sumBalance == 0)//التاكد من ان الزبون لا يملك رصيد قبل حذفه
            {
                isDeleted = true;
                Console.ForegroundColor = ConsoleColor.Green;
                DateTime DeletedDate = DateTime.UtcNow;
                Console.WriteLine($"Customer {this.FirstName} {this.LastName} has been deleted in {DeletedDate}\n");
                Console.ForegroundColor = oldColor;
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine($"cann't delete this customer because he have a balance");
                Console.ForegroundColor = oldColor;
            }
        }
        public override string ToString()
        {
            
            var oldColor = Console.ForegroundColor;
            if (isDeleted == true)//التاكد من ان الزبون ليس محذوف
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("don't exist a customer with this name!\n");
                Console.ForegroundColor=oldColor;
                return "";
            }

            double sumBalance = 0;
            foreach (var item in this.Accounts)//المرور على قائمة حسابات هذا الزبون لجمع رصيد الزبون في كل حساباته
            {
                sumBalance += item.Balance;
            }
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine($"{FirstName} {LastName}-Balance: {sumBalance}$\n");
            Console.ForegroundColor=oldColor;
            return " ";
           
        }
    }
}
