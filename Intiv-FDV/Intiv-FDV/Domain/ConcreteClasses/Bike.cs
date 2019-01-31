using Intiv_FDV.Domain.Abstractions;
using Intiv_FDV.Domain.Enums;
using Intiv_FDV.Domain.Interfaces;
using Intiv_FDV.Utilities.ConcreteClasses.RatesDictionary;

namespace Intiv_FDV.Domain.ConcreteClasses
{
    public class Bike : Item, Iitem
    {
        public ItemTypeEnum ItemType { get; set; }

        private int BaseValue { get; set; }

        private double Rate { get; set; }

        public double Value
        {
            get
            {
                return BaseValue * Rate;
            }
            set { }
        }

        public Bike(TimeTypeEnum rate)
        {
            ItemType = ItemTypeEnum.Bike;
            BaseValue = 1;
            Rate = (double)RatesDictionary.GetInstance().RateStrategy[rate].DynamicInvoke(BaseValue);
        }

        public Bike(TimeTypeEnum rate, int baseValue)
        {
            ItemType = ItemTypeEnum.Bike;
            BaseValue = baseValue;
            Rate = (double)RatesDictionary.GetInstance().RateStrategy[rate].DynamicInvoke(BaseValue);
        }
    }
}
