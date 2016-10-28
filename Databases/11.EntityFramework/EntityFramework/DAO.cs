using EntityFramework.Data;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework
{
    public class DAO
    {
        public static NorthwindEntities DbConnection()
        {
            var connection = new NorthwindEntities();
            return connection;
        }

        public static string FindCustomer(string customerID)
        {
            var connection = DAO.DbConnection();
            var customer = connection.Customers.FirstOrDefault(c => c.CustomerID == customerID);
            return customer.ContactName;
        }

        public static void InsertCustomer(Customer customer)
        {
            var connection = DAO.DbConnection();
            connection.Customers.Add(customer);
            connection.SaveChanges();
        }

        public static void DeleteCustomer(string contactName)
        {
            var connection = DAO.DbConnection();
            var deletedCustomer = connection.Customers
                .Where(c => c.ContactName.Contains(contactName))
                .FirstOrDefault();

            connection.Customers.Remove(deletedCustomer);
            connection.SaveChanges();
        }

        public static void ModifyCustomer(Customer modifiedCustomer)
        {
            var connection = DAO.DbConnection();
            var customer = connection.Customers
                .FirstOrDefault(c => c.CustomerID == modifiedCustomer.CustomerID);

            var values = connection.Entry(customer).CurrentValues;
            values.SetValues(modifiedCustomer);
            connection.SaveChanges();
        }
               
    }
}
