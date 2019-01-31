using Intiv_FDV.Domain.ConcreteClasses;
using Intiv_FDV.Domain.Enums;
using Intiv_FDV.Domain.Interfaces;
using System.Collections.Generic;

namespace UnitTests.MockFactory
{
    public static class RentFactory
    {
        #region HourRent
        #region RentWithNoDiscount
        public static Rent GetRentWith1Item1Hour()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Hour)
                },
                DiscountType = null,
                Time = 1,
                TimeType = TimeTypeEnum.Hour
            };
        }

        public static Rent GetRentWith1Item2Hour()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Hour)
                },
                DiscountType = null,
                Time = 2,
                TimeType = TimeTypeEnum.Hour
            };
        }

        public static Rent GetRentWith2Item1Hour()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour)
                },
                DiscountType = null,
                Time = 1,
                TimeType = TimeTypeEnum.Hour
            };
        }

        public static Rent GetRentWith2Item2Hour()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour)
                },
                DiscountType = null,
                Time = 2,
                TimeType = TimeTypeEnum.Hour
            };
        }

        public static Rent GetRentWith6Item1Hour()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour),
                },
                DiscountType = DiscountTypeEnum.Family,
                Time = 1,
                TimeType = TimeTypeEnum.Hour
            };
        }

        public static Rent GetRentWith6Item2Hour()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour),
                },
                DiscountType = DiscountTypeEnum.Family,
                Time = 2,
                TimeType = TimeTypeEnum.Hour
            };
        }

        #endregion

        #region RentWithDiscount


        public static Rent GetRentWith3Item1Hour()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour),
                },
                DiscountType = DiscountTypeEnum.Family,
                Time = 1,
                TimeType = TimeTypeEnum.Hour
            };
        }

        public static Rent GetRentWith3Item2Hour()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour),
                    new Bike(TimeTypeEnum.Hour),
                },
                DiscountType = DiscountTypeEnum.Family,
                Time = 2,
                TimeType = TimeTypeEnum.Hour
            };
        }

        #endregion
        #endregion

        #region DayRent
        #region RentWithNoDiscount
        public static Rent GetRentWith1Item1Day()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Day)
                },
                DiscountType = null,
                Time = 1,
                TimeType = TimeTypeEnum.Day
            };
        }

        public static Rent GetRentWith1Item2Day()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Day)
                },
                DiscountType = null,
                Time = 2,
                TimeType = TimeTypeEnum.Day
            };
        }

        public static Rent GetRentWith2Item1Day()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day)
                },
                DiscountType = null,
                Time = 1,
                TimeType = TimeTypeEnum.Day
            };
        }

        public static Rent GetRentWith2Item2Day()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day)
                },
                DiscountType = null,
                Time = 2,
                TimeType = TimeTypeEnum.Day
            };
        }

        public static Rent GetRentWith6Item1Day()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day),
                },
                DiscountType = DiscountTypeEnum.Family,
                Time = 1,
                TimeType = TimeTypeEnum.Day
            };
        }

        public static Rent GetRentWith6Item2Day()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day),
                },
                DiscountType = DiscountTypeEnum.Family,
                Time = 2,
                TimeType = TimeTypeEnum.Day
            };
        }

        #endregion

        #region RentWithDiscount

        public static Rent GetRentWith3Item1Day()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day),
                },
                DiscountType = DiscountTypeEnum.Family,
                Time = 1,
                TimeType = TimeTypeEnum.Day
            };
        }

        public static Rent GetRentWith3Item2Day()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day),
                    new Bike(TimeTypeEnum.Day),
                },
                DiscountType = DiscountTypeEnum.Family,
                Time = 2,
                TimeType = TimeTypeEnum.Day
            };
        }

        #endregion
        #endregion

        #region WeekRent
        #region RentWithNoDiscount
        public static Rent GetRentWith1Item1Week()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Week)
                },
                DiscountType = null,
                Time = 1,
                TimeType = TimeTypeEnum.Week
            };
        }

        public static Rent GetRentWith1Item2Week()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Week)
                },
                DiscountType = null,
                Time = 2,
                TimeType = TimeTypeEnum.Week
            };
        }

        public static Rent GetRentWith2Item1Week()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week)
                },
                DiscountType = null,
                Time = 1,
                TimeType = TimeTypeEnum.Week
            };
        }

        public static Rent GetRentWith2Item2Week()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week)
                },
                DiscountType = null,
                Time = 2,
                TimeType = TimeTypeEnum.Day
            };
        }

        public static Rent GetRentWith6Item1Week()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week),
                },
                DiscountType = DiscountTypeEnum.Family,
                Time = 1,
                TimeType = TimeTypeEnum.Week
            };
        }

        public static Rent GetRentWith6Item2Week()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week),
                },
                DiscountType = DiscountTypeEnum.Family,
                Time = 2,
                TimeType = TimeTypeEnum.Week
            };
        }

        #endregion

        #region RentWithDiscount

        public static Rent GetRentWith3Item1Week()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week),
                },
                DiscountType = DiscountTypeEnum.Family,
                Time = 1,
                TimeType = TimeTypeEnum.Week
            };
        }

        public static Rent GetRentWith3Item2Week()
        {
            return new Rent
            {
                Items = new List<Iitem>
                {
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week),
                    new Bike(TimeTypeEnum.Week),
                },
                DiscountType = DiscountTypeEnum.Family,
                Time = 2,
                TimeType = TimeTypeEnum.Week
            };
        }

        #endregion
        #endregion

    }
}
