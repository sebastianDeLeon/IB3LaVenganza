﻿using InternetBanking.Core.Application.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.Core.Application.ViewModels.TypeAccount
{
    public class TypeAccountVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<ProductsVM> Products { get; set; }
    }
}
