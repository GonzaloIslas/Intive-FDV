using Intiv_FDV.Domain.Enums;
using Intiv_FDV.Domain.Interfaces;
using Intiv_FDV.Utilities.ConcreteClasses.Discounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intiv_FDV.Domain.Abstractions
{
    public abstract class Item : Iitem
    {
        public double Value { get; set; }

        public ItemTypeEnum ItemType { get; set; }

        protected double BaseValue { get; set; }

        protected double Rate { get; set; }
    }
}
