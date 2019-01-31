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
    public class RentWeekTests
    {
        [TestMethod]
        public void OneItemOneWeekNoDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith1Item1Week();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 60);
        }

        [TestMethod]
        public void OneItemTwoWeekNoDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith1Item2Week();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 120);
        }

        [TestMethod]
        public void TwoItemOneWeekNoDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith2Item1Week();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 120);
        }

        [TestMethod]
        public void TwoItemTwoWeekNoDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith2Item2Week();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 240);
        }

        [TestMethod]
        public void ThreeItemOneWeekDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith3Item1Week();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(Math.Round(res), 126);
        }

        [TestMethod]
        public void ThreeItemTwoWeekDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith3Item2Week();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(Math.Round(res), 252);
        }

        [TestMethod]
        public void SixItemOneWeekDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith6Item1Week();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(res, 360);
        }

        [TestMethod]
        public void SixItemTwoWeekDiscount_MustSucced()
        {
            //Arrange
            var rent = RentFactory.GetRentWith6Item2Week();

            //Act
            var res = rent.NetTotal;

            //Assert
            Assert.AreEqual(Math.Round(res), 720);
        }
    }
}
