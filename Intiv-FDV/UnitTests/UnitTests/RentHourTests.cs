using Intiv_FDV.Domain.ConcreteClasses;
using Intiv_FDV.Domain.Enums;
using Intiv_FDV.Domain.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTests.MockFactory;

namespace UnitTests.UnitTests
{
    [TestClass]
    public class RentHourTests
    {
        [TestMethod]
        public void OneItemOneHourNoDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith1Item1Hour();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 5);
        }

        [TestMethod]
        public void OneItemTwoHourNoDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith1Item2Hour();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 10);
        }

        [TestMethod]
        public void TwoItemOneHourNoDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith2Item1Hour();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 10);
        }

        [TestMethod]
        public void TwoItemTwoHourNoDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith2Item2Hour();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 20);
        }

        [TestMethod]
        public void ThreeItemOneHourDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith3Item1Hour();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 10.5);
        }

        [TestMethod]
        public void ThreeItemTwoHourDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith3Item2Hour();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 21);
        }

        [TestMethod]
        public void SixItemOneHourDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith6Item1Hour();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 30);
        }

        [TestMethod]
        public void SixItemTwoHourDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith6Item2Hour();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 60);
        }

    }
}
