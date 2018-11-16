using System;
namespace codxFrank.Demo.EFCorePostgreSQLCodeFirst.Models
{

    public partial class Customers
    {
        //Table 的 PK，EF Core 規定要以 table name + ID 表示，
        //則 migration 時會自動將該欄位建立成 PK，不需要額外 attribute。
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
