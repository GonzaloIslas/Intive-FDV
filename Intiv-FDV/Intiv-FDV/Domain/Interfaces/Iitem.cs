using Intiv_FDV.Domain.Enums;
using Intiv_FDV.Utilities.ConcreteClasses.Discounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intiv_FDV.Domain.Interfaces
{
    public interface Iitem
    {
        double Value { get; set; }

        ItemTypeEnum ItemType { get; set; }

        
    }
}
