using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MyProduct;
namespace MyProductUnitTest
{
    [TestClass]
    public class MyProductTest
    {
        [TestMethod]
        public void SumValidation_PageSize_3_Cost()
        {
            int pageSize = 3;
            eTableColumn column = eTableColumn.Cost;

            //arrange
            var target = new StubProduct();
            var expected = new List<int>{ 6, 15, 24, 21 };

            //act
            var actual = target.GetPageSumListFormColumn(column, pageSize);
            //assert

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumValidation_PageSize_4_Revenue()
        {
            int pageSize = 4;
            eTableColumn column = eTableColumn.Revenue;

            //arrange
            var target = new StubProduct();
            var expected = new List<int>{ 50, 66, 60 };

            //act
            var actual = target.GetPageSumListFormColumn(column, pageSize);
            //assert

            CollectionAssert.AreEqual(expected, actual);
        }
    }

    internal class StubProduct : Product
    {
        protected override void initDataTable()
        {
            dataTable.Rows.Add(new object[] { 1, 1, 11, 21 });
            dataTable.Rows.Add(new object[] { 2, 2, 12, 22 });
            dataTable.Rows.Add(new object[] { 3, 3, 13, 23 });
            dataTable.Rows.Add(new object[] { 4, 4, 14, 24 });
            dataTable.Rows.Add(new object[] { 5, 5, 15, 25 });
            dataTable.Rows.Add(new object[] { 6, 6, 16, 26 });
            dataTable.Rows.Add(new object[] { 7, 7, 17, 27 });
            dataTable.Rows.Add(new object[] { 8, 8, 18, 28 });
            dataTable.Rows.Add(new object[] { 9, 9, 19, 29 });
            dataTable.Rows.Add(new object[] { 10, 10, 20, 30 });
            dataTable.Rows.Add(new object[] { 11, 11, 21, 31 });
        }
    }
}
