using Intiv_FDV.Domain.Enums;
using Intiv_FDV.Utilities.Interfaces.RatesDictionary;
using System;
using System.Collections.Generic;

namespace Intiv_FDV.Utilities.ConcreteClasses.RatesDictionary
{
    public class RatesDictionary : IRatesDictionary
    {
        public Dictionary<TimeTypeEnum, Delegate> RateStrategy { get; set; }
        public double HourlyRate { get; set; }
        public double DailyRate { get; set; }
        public double WeeklyRate { get; set; }

        public RatesDictionary(Dictionary<TimeTypeEnum, Delegate> rateStrategy)
        {
            RateStrategy = rateStrategy;
            RateStrategy[TimeTypeEnum.Hour] = new Func<double, double>(ApplyHourlyRate);
            RateStrategy[TimeTypeEnum.Day] = new Func<double, double>(ApplyDailyRate);
            RateStrategy[TimeTypeEnum.Week] = new Func<double, double>(ApplyWeeklyRate);
            HourlyRate = 5;
            DailyRate = 20;
            WeeklyRate = 60;
        }

        private double ApplyHourlyRate(double value)
        {
            return value * HourlyRate;
        }

        private double ApplyDailyRate(double value)
        {
            return value * DailyRate;
        }

        private double ApplyWeeklyRate(double value)
        {
            return value * WeeklyRate;
        }

        private static readonly RatesDictionary instance = new RatesDictionary(new Dictionary<TimeTypeEnum, Delegate>());

        public static RatesDictionary GetInstance()
        {
            return instance;
        }
    }
}
