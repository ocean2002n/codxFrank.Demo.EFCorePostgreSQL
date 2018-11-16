using System;
using System.Collections.Generic;

namespace codxFrank.Demo.EFCorePostgreSQL.Models
{
    public partial class Customers
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
