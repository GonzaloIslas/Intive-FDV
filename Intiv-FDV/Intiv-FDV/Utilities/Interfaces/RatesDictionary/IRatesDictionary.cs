using Intiv_FDV.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intiv_FDV.Utilities.Interfaces.RatesDictionary
{
    public interface IRatesDictionary
    {
        double HourlyRate { get; set; }

        double DailyRate { get; set; }

        double WeeklyRate { get; set; }

        Dictionary<TimeTypeEnum, Delegate> RateStrategy { get; set; }
    }
}
