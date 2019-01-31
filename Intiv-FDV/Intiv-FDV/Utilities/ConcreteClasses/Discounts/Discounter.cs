using Intiv_FDV.Domain.Enums;
using Intiv_FDV.Utilities.Interfaces.Discounts;
using System;
using System.Collections.Generic;
using System.Text;
using Intiv_FDV.Utilities.ConcreteClasses.RatesDictionary;
using Intiv_FDV.Domain.ConcreteClasses;
using Intiv_FDV.Utilities.Interfaces.RatesDictionary;

namespace Intiv_FDV.Utilities.ConcreteClasses.Discounts
{
    public class Discounter : IDiscounter
    {
        public double FamilyDiscount { get; set ; }
        public Dictionary<DiscountTypeEnum, Delegate> DiscountStrategy { get ; set ; }

        public Discounter(Dictionary<DiscountTypeEnum, Delegate> discountStrategy)
        {
            DiscountStrategy = discountStrategy;
            DiscountStrategy[DiscountTypeEnum.Family] = new Func<double, double>(ApplyFamilyDiscount);
            FamilyDiscount = 0.7;
        }

        public double ApplyFamilyDiscount(double grossTotal)
        {
            return grossTotal * FamilyDiscount;
        }

        private static readonly Discounter instance = new Discounter(new Dictionary<DiscountTypeEnum, Delegate>());

        public static Discounter GetInstance()
        {
            return instance;
        }

    }
}
