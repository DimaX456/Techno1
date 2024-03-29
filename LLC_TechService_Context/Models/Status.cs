﻿using System;
using System.Collections.Generic;

namespace LLC_TechService_Context.Models
{
    public partial class Status
    {
        public Status()
        {
            Orders = new HashSet<Order>();
        }

        public int IdStatus { get; set; }
        public string NameStatus { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
