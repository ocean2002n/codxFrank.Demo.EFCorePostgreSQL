﻿using System;
using System.Collections.Generic;

namespace codxFrank.Demo.EFCorePostgreSQL.Models
{
    public partial class Item
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
