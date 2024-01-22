namespace Assingment1.Customers
{
    internal class IndividualCustomer : Customer
    {
        public string HomeAdress { get; set; } = "";
        public string WorkingAddress { get; set; } = "";
        public IndividualCustomer(string FirsrName, string LastName) : base(FirsrName, LastName)
        {

        }
        


      


    }
}
