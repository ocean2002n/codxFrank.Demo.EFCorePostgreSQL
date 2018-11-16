using System;
using codxFrank.Demo.EFCorePostgreSQL.Models;

namespace codxFrank.Demo.EFCorePostgreSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用以下指令加入資料庫類別檔
            // -o Model : 將資料庫類別檔放至於Model資料夾內
            // -f : 強制執行，將已存在的資料覆蓋
            // 如果使用Database First 的話不建議自行修改自動產出的任何檔，因為如果與資料庫不一致會造成交易失敗
            //dotnet ef dbcontext scaffold "Host=localhost;Port=32769;Database=PHIS;Username=postgres;" Npgsql.EntityFrameworkCore.PostgreSQL -o Models -f
            using (var db = new PHISContext())
            {
                // Creating a new item and saving it to the database
                var newItem = new Item();
                newItem.Name = "Red Apple";
                newItem.Description = "Description of red apple";
                db.Item.Add(newItem);
                var count = db.SaveChanges();

                var cus = new Customers();
                cus.Name = "Frank";
                cus.Age = 10;
                db.Customers.Add(cus);
                var count2= db.SaveChanges();

                Console.WriteLine("{0} records saved to database", count);
                Console.WriteLine("{0} records saved to database", count2);
                // Retrieving and displaying data
                Console.WriteLine();
                Console.WriteLine("All items in the database:");
                foreach (var item in db.Item)
                {
                    Console.WriteLine("{0} | {1}", item.Name, item.Description);
                }
                foreach (var customer in db.Customers)
                {
                    Console.WriteLine("{0} | {1}", customer.Name, customer.CustomerId);
                }
            }
        }
    }
}
