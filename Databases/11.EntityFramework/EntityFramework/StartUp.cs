using EntityFramework.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework
{
    public class StartUp
    {
        public static void Main()
        {
            //2. Create a DAO class with static methods which provide functionality 
            //for inserting, modifying and deleting customers:
            var customer = new Customer
            {
                CustomerID = "ASDAH",
                CompanyName = "Some company name",
                ContactName = "Pesho"
            };

            var modifiedCustomer = new Customer
            {
                CustomerID = "ASDAH",
                CompanyName = "Progress",
                ContactName = "Pesho Peshov",
                ContactTitle = "Tester"
            };

            //DAO.InsertCustomer(customer);
            //DAO.DeleteCustomer("pesho");
            //Console.WriteLine(DAO.FindCustomer("ANTON"));
            //DAO.ModifyCustomer(modifiedCustomer);


            //3. Write a method that finds all customers who have orders made in 1997 and shipped to Canada:
            using (var dbNorth = new NorthwindEntities())
            {
                var searchedCustomers = dbNorth.Orders
                    .Where(o => o.OrderDate.Value.Year == 1997 && o.ShipCountry == "Canada")
                    .Select(o => dbNorth.Customers.FirstOrDefault(e => e.CustomerID == o.CustomerID)).ToList();

                foreach (var item in searchedCustomers)
                {
                    //Console.WriteLine(item.ContactName);
                }
            }


            //4. Implement previous by using native SQL query and executing it through the DbContext:
            using (var database = new NorthwindEntities())
            {
                var query = @"SELECT * 
                            FROM Customers c, Orders o 
                            WHERE c.CustomerID = o.CustomerID AND o.ShipCountry = 'Canada' 
                            AND OrderDate BETWEEN '19970101' AND '19971231'";

                var customers = database.Customers.SqlQuery(query).ToList();

                foreach (var c in customers)
                {
                    //Console.WriteLine(c.ContactName);
                }

            }

            NorthwindEntities db = new NorthwindEntities();
            var startDate = new DateTime(1996, 3, 10);
            var endDate = new DateTime(1998, 5, 11);

            foreach (var order in FindAllSales(db, "CA", startDate, endDate))
            {
                //Console.WriteLine(order.OrderDate + " Region: " + order.ShipRegion);
            }          

        }

        //5. Write a method that finds all the sales by specified region and period (start / end dates):
        public static IEnumerable<Order> FindAllSales
           (NorthwindEntities db, string region, DateTime startDate, DateTime endDate)
        {
            IEnumerable<Order> salesFound = db
                .Orders
                .Where(o => o.ShipRegion == region
                && o.ShippedDate.Value >= startDate
                && o.ShippedDate.Value <= endDate).ToList();
            return salesFound;
        }

    }
}

