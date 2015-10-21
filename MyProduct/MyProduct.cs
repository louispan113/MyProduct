using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MyProduct
{
    internal enum eTableColumn
    {
        ID,
        Cost,
        Revenue,
        SellPrice
    }

    internal class Product
    {
        protected DataTable dataTable;
        internal Product()
        {
            this.dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn(eTableColumn.ID.ToString()));
            dataTable.Columns.Add(new DataColumn(eTableColumn.Cost.ToString()));
            dataTable.Columns.Add(new DataColumn(eTableColumn.Revenue.ToString()));
            dataTable.Columns.Add(new DataColumn(eTableColumn.SellPrice.ToString()));
            initDataTable();
        }
        protected virtual void initDataTable()
        {
            //dataTable.Rows.Add(new object[] { 1, 1, 11, 21 });
            //dataTable.Rows.Add(new object[] { 2, 2, 12, 22 });
            //dataTable.Rows.Add(new object[] { 3, 3, 13, 23 });
            //dataTable.Rows.Add(new object[] { 4, 4, 14, 24 });
            //dataTable.Rows.Add(new object[] { 5, 5, 15, 25 });
            //dataTable.Rows.Add(new object[] { 6, 6, 16, 26 });
            //dataTable.Rows.Add(new object[] { 7, 7, 17, 27 });
            //dataTable.Rows.Add(new object[] { 8, 8, 18, 28 });
            //dataTable.Rows.Add(new object[] { 9, 9, 19, 29 });
            //dataTable.Rows.Add(new object[] { 10, 10, 20, 30 });
            //dataTable.Rows.Add(new object[] { 11, 11, 21, 31 });
        }

        internal List<int> GetPageSumListFormColumn(eTableColumn column, int pageSize)
        {
            List<int> groupSum = new List<int>();
            int count = 0;
            int sum = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                count++;
                sum += Convert.ToInt32(row[column.ToString()]);
                if (count == pageSize)
                {

                    groupSum.Add(sum);
                    count = 0;
                    sum = 0;
                }
            }
            if(count != 0)
                groupSum.Add(sum);
            return groupSum;
        }
        
    }
}