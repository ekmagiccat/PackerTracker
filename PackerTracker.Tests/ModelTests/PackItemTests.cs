using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;


namespace PackerTracker.Tests
{
    [TestClass]
    public class PackItemTests
    {
        PackItem _instanceOfPackItem = new PackItem();

        [TestMethod]
        public void PackItemConstructor_CreatesInstanceofPackItem()
        {
            PackItem newPackItem = new PackItem();
            Assert.AreEqual(typeof(PackItem), newPackItem.GetType());
        }

        [TestMethod]
        [DataRow(1.0, 1.0)]
        [DataRow(0.0, 0.0)]
        [DataRow(-1.0, 0.0)]
        public void Price_setValue_SetsPrice(double price, double result)
        {
            // Act 
            _instanceOfPackItem.Price = price;
            // Assert
            Assert.AreEqual(result, _instanceOfPackItem.Price);
        }

        [TestMethod]
        [DataRow(1.0, 1.0)]
        [DataRow(-10.0, 0.0)]
        public void Weight_setWeight_SetsWeight(double weight, double result)
        {
            _instanceOfPackItem.Weight = weight;
            Assert.AreEqual(result, _instanceOfPackItem.Weight);
        }

        [TestMethod]
        [DataRow(true, true)]
        public void IsPurchased_ReturnsValue(bool isPurchased, bool result)
        {
            _instanceOfPackItem.IsPurchased = isPurchased;
            Assert.AreEqual(_instanceOfPackItem.IsPurchased, result);
        }
        [TestMethod]
        [DataRow(true, true)]
        public void IsPacked_SetValue_SetsIsPacked(bool setValue, bool expectedValue)
        {

            _instanceOfPackItem.IsPacked = setValue;
            Assert.AreEqual(_instanceOfPackItem.IsPacked, expectedValue);
        }

        [TestMethod]
        public void Coupling_IsPacked_IsPurchased_Never_True_False_Test()
        {
            PackItem packItem = new PackItem();
            Assert.IsFalse(packItem.IsPurchased);
            Assert.IsFalse(packItem.IsPacked);
            //Test set isPacked to true sets both isPacked and isPurchased to true
            packItem.IsPacked = true;
            Assert.IsTrue(packItem.IsPurchased);
            Assert.IsTrue(packItem.IsPacked);
            //Test set isPurchased to false sets both isPacked and isPurchased to false
            packItem.IsPurchased = false;
            Assert.IsFalse(packItem.IsPurchased);
            Assert.IsFalse(packItem.IsPacked);
            //Test set isPurchased to true sets isPurchased alone to true
            packItem.IsPurchased = true;
            Assert.IsTrue(packItem.IsPurchased);
            Assert.IsFalse(packItem.IsPacked);
            //Test set isPacked to false sets isPacked alone to false
            packItem.IsPacked = true;
            packItem.IsPacked = false;
            Assert.IsTrue(packItem.IsPurchased);
            Assert.IsFalse(packItem.IsPacked);
        }
        // [TestMethod]
        // public void SetNameofItem()
        // {
        //    string name = "Tent";

        // }
    }
}
