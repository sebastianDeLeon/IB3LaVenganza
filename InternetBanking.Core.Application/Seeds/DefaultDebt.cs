﻿using InternetBanking.Core.Application.Enums;
using InternetBanking.Core.Application.Interfaces.Repositories;
using InternetBanking.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.Core.Application.Seeds
{
    public class DefaultDebt
    {
        public static async Task SeedAsync(ITypeAccountRepository _repo)
        {
            TypeAccount defaulAccount = new();
            defaulAccount.Title = "Prestamo";

            var items = await _repo.GetAllAsync();

            if (items.All(user => user.Title != defaulAccount.Title))
            {
                var account = await _repo.createAsync(defaulAccount);
            }
        }
    }
}
