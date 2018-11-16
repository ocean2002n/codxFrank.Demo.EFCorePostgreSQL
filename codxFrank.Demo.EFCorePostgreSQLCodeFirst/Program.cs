using System;
using codxFrank.Demo.EFCorePostgreSQLCodeFirst.Models;

namespace codxFrank.Demo.EFCorePostgreSQLCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://oomusou.io/efcore/migration/
            // 建立Migration指令
            // dotnet ef migrations add Migration00
            // 更新資料庫內容指令
            // dotnet ef database update
            using (var db = new PHIS2Context())
            {
                // Creating a new item and saving it to the database
                var cus = new Customers();
                cus.Name = "Frank";
                cus.Age = 10;
                db.Customers.Add(cus);
                var count2 = db.SaveChanges();

                Console.WriteLine("{0} records saved to database", count2);
                // Retrieving and displaying data
                Console.WriteLine();
                Console.WriteLine("All items in the database:");

                foreach (var customer in db.Customers)
                {
                    Console.WriteLine("{0} | {1}", customer.Name, customer.CustomerId);
                }
            }
        }
    }
}
