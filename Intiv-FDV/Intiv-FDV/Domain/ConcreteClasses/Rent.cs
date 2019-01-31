using Intiv_FDV.Domain.Enums;
using Intiv_FDV.Domain.Interfaces;
using Intiv_FDV.Utilities.ConcreteClasses.Discounts;
using System.Collections.Generic;

namespace Intiv_FDV.Domain.ConcreteClasses
{
    public class Rent
    {
        public IList<Iitem> Items { get; set; }

        public int Time { get; set; }

        public TimeTypeEnum TimeType { get; set; }

        public DiscountTypeEnum? DiscountType { get; set; }

        public double GrossTotal
        {
            get
            {
                var result = new double();
                foreach (var item in Items)
                {
                    result += item.Value;
                }
                result *= Time;
                return result;
            }
            set { }
        }

        public double NetTotal
        {
            get
            {
                return ApplyDiscount(Discounter.GetInstance());
            }
        }


        //since the task given says "Family Rental, is a promotion that can include from 3 to 5 Rentals (of any type) with a discount 
        //of 30% of the total price" am going to take it literally and only apply the discount if the amount of bikes(or items for that matter) 
        //are more or equal than 3 and less or equal than 5     
        public double ApplyDiscount(Discounter discounter)
        {
            if (Items.Count >= 3 && Items.Count <= 5) 
            {                               
                return (double)discounter.DiscountStrategy[DiscountType.Value].DynamicInvoke(GrossTotal);
            }
            else
            {
                return GrossTotal;
            }
        }
    }
}
