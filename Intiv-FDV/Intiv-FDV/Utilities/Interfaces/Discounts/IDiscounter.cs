using Intiv_FDV.Domain.ConcreteClasses;
using Intiv_FDV.Domain.Enums;
using Intiv_FDV.Utilities.Interfaces.RatesDictionary;
using System;
using System.Collections.Generic;

namespace Intiv_FDV.Utilities.Interfaces.Discounts
{
    public interface IDiscounter
    {
        double FamilyDiscount { get; set; }

        Dictionary<DiscountTypeEnum, Delegate> DiscountStrategy { get; set; }

        double ApplyFamilyDiscount(double grossTotal);
    }
}
