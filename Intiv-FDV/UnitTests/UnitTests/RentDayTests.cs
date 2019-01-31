using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.MockFactory;

namespace UnitTests.UnitTests
{
    [TestClass]
    public class RentDayTests
    {
        [TestMethod]
        public void OneItemOneDayNoDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith1Item1Day();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 20);
        }

        [TestMethod]
        public void OneItemTwoDayNoDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith1Item2Day();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 40);
        }

        [TestMethod]
        public void TwoItemOneDayNoDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith2Item1Day();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 40);
        }

        [TestMethod]
        public void TwoItemTwoDayNoDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith2Item2Day();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 80);
        }

        [TestMethod]
        public void ThreeItemOneDayDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith3Item1Day();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 42);
        }

        [TestMethod]
        public void ThreeItemTwoDayDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith3Item2Day();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 84);
        }

        [TestMethod]
        public void SixItemOneDayDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith6Item1Day();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 120);
        }

        [TestMethod]
        public void SixItemTwoDayDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith6Item2Day();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 240);
        }
    }
}
