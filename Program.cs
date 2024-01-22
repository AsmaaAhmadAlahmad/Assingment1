using Assingment1.Accounts;
using Assingment1.Customers;
namespace Assingment1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Define a retail Customer
            RetailCustomer AlHasanCompany = new RetailCustomer("AlHasanCompany","");


            //Create 3 different accounts with 3 different type
            BasicAccount basicAlHasanCompany = new BasicAccount();
            LoanAccount loanAlHasanCompany =new LoanAccount();
            SavingsAccount savingsAlHasanCompany=new SavingsAccount();
            //assing the created accounts to the  "Retail Customer"
            AlHasanCompany.createAccounts(loanAlHasanCompany,savingsAlHasanCompany, basicAlHasanCompany);


            //Deposit the (depositable) accounts with 100
            basicAlHasanCompany.Deposit(100, AlHasanCompany);
            loanAlHasanCompany.Deposit(100, AlHasanCompany);
            savingsAlHasanCompany.Deposit(100, AlHasanCompany);
            //Withdraw 60 from two accounts
            basicAlHasanCompany.Withdraw(60, AlHasanCompany);
            loanAlHasanCompany.Withdraw(60, AlHasanCompany);
            

            //Call yourCustomer.ToString() to print the fullname and the total balance
            AlHasanCompany.ToString();
            //  ************************************************************************************



            //Define a  individual Customer
            IndividualCustomer AsmaaAlAhmed = new IndividualCustomer("Asmaa","AlAhmed");


            //Create 4 different accounts with 4 different type
            BasicAccount basicAsmaaAlAhmed=new BasicAccount();
            LoanAccount loanAsmaaAlAhmed = new LoanAccount();
            SalaryAccount salaryAsmaaAlAhmed=new SalaryAccount();
            SavingsAccount savingsAsmaaAlAhmed=new SavingsAccount();
            //assing the created accounts to the  "individual Customer"
            AsmaaAlAhmed.createAccounts(basicAsmaaAlAhmed, loanAsmaaAlAhmed, salaryAsmaaAlAhmed, savingsAsmaaAlAhmed);


            //Deposit the(depositable) accounts with 200
            basicAsmaaAlAhmed.Deposit(200, AsmaaAlAhmed);
            loanAsmaaAlAhmed.Deposit(200, AsmaaAlAhmed);
            savingsAsmaaAlAhmed.Deposit(200, AsmaaAlAhmed);
            //Withdraw 80 from two accounts
            basicAsmaaAlAhmed.Withdraw(80,AsmaaAlAhmed);
            loanAsmaaAlAhmed.Withdraw(80,AsmaaAlAhmed);


            //Call yourCustomer.ToString() to print the fullname and the total balance
            AsmaaAlAhmed.ToString();


            


            
        }
    }
}