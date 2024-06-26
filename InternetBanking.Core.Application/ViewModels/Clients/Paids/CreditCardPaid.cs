﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.Core.Application.ViewModels.Clients.Paids
{
    public class CreditCardPaid
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes ingresar uno de tus tarjetas.")]
        public int IdCreditCard { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes ingresar una de tus cuentas de ahorro.")]
        public int IdSaveAccount { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(0, double.MaxValue, ErrorMessage = "Debes ingresar un monto apartir de 0. ")]
        public double Amount { get; set; }
        public bool HasError { get; set; }
        public string Error { get; set; }
    }
}
