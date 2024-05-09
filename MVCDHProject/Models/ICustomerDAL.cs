namespace MVCDHProject.Models
{
    public interface ICustomerDAL
    {
        List<Customer> Customers_Select();
        Customer Customer_Select(int Custid);
        void Customer_Insert(Customer customer);
        void Customer_Update(Customer customer);
        void Customer_Delete(int Custid);

    }
}
