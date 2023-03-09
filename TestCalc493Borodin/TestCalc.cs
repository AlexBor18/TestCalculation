using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace TestCalc493Borodin
{
    [TestClass]
    public class TestCalc
    {
        [TestMethod]
        public void GetQuantityForProduct_NonExistentproductType()
        {
            float width = 20, length = 45;
            int productType = 3, materialType = 3, count = 15, quantity;
            int expected = -1;

            quantity = Calcalution.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentmaterialType()
        {
            float width = 20, length = 45;
            int productType = 4, materialType = 1, count = 15, quantity;
            int expected = -1;

            quantity = Calcalution.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_productTypeFirst()
        {
            float width = 5, length = 25;
            int productType = 2, materialType = 1, count = 11, quantity;
            int expected = 3448;

            quantity = Calcalution.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_productTypeSecond()
        {
            float width = 10, length = 30;
            int productType = 3, materialType = 4, count = 3, quantity;
            int expected = -1;

            quantity = Calcalution.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_productTypeThird()
        {
            float width = 20, length = 45;
            int productType = 4, materialType = 0, count = 15, quantity;
            int expected = 3057;

            quantity = Calcalution.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_materialTypeFirst()
        {
            float width = 10, length = 20;
            int productType = 3, materialType = 3, count = 10, quantity;
            int expected = 16911;

            quantity = Calcalution.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_materialTypeSecond()
        {
            float width = 10, length = 20;
            int productType = 3, materialType = 2, count = 10, quantity;
            int expected = 16881;

            quantity = Calcalution.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_ImpossibleWidth()
        {
            float width = -10, length = 20;
            int productType = 1, materialType = 1, count = 10, quantity;
            int expected = -2206;

            quantity = Calcalution.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_Impossiblelength()
        {
            float width = 10, length = -20;
            int productType = 3, materialType = 1, count = 10, quantity;
            int expected = -16910;

            quantity = Calcalution.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_Impossiblecount()
        {
            float width = 10, length = 20;
            int productType = 1, materialType = 5, count = -10, quantity;
            int expected = -1;

            quantity = Calcalution.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }
    }
}
