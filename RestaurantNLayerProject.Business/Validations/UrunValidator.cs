﻿using FluentValidation;
using RestaurantNLayerProject.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Business.Validations
{
    public class UrunValidator: AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Ürün Adı Boş Geçirilemez.");
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Ürün Adı 50 Karakterden Fazla Girilemez.");
            RuleFor(c => c.Barkod).MaximumLength(20).WithMessage("Barkod Bilgisi 20 Karakterden Fazla Girilemez.");
        }
    }
}
