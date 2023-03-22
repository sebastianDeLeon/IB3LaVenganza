﻿using InternetBanking.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.Core.Domain.Entities
{
    public class TypeAccount:AuditableBaseEntity
    {
        public string Title { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
