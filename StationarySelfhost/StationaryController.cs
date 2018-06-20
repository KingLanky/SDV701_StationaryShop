using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationarySelfhost
{
    public class StationaryController : System.Web.Http.ApiController
    {
        public List<int> GetOrders()
        {
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT OrderID FROM [Order]", null);
            List<int> lcOrders = new List<int>();
            foreach (DataRow dr in lcResult.Rows)
                lcOrders.Add((int)dr[0]);
            return lcOrders;
        }

        //public List<int> GetOrdersList()
        //{
        //    DataTable lcResult = clsDbConnection.GetDataTable("SELECT OrderID, OrderPrice, CustomerName FROM [Order]", null);
        //    Dictionary<int, string> lcOrders = new Dictionary<int, string>();
        //    foreach (DataRow dr in lcResult.Rows)
        //        lcOrders.Add((int)dr[0], );
        //    return lcOrders;
        //}

        public clsOrder GetOrderDetails(int OrderID)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("OrderID", OrderID);
            DataTable lcResult =
                clsDbConnection.GetDataTable("SELECT [Order].OrderID, [Order].StationaryID, Stationary.[Name] AS StationaryName, Stationary.BrandName AS BrandName, [Order].Quantity, [Order].OrderPrice, [Order].[Date], [Order].CustomerName, [Order].CustomerNo FROM [Order] " +
                "JOIN Stationary ON[Order].StationaryID = Stationary.StationaryID WHERE OrderID = @OrderID", par);
            if (lcResult.Rows.Count > 0)
                return new clsOrder()
                {
                    OrderID = (int)lcResult.Rows[0]["OrderID"],
                    StationaryID = (int)lcResult.Rows[0]["StationaryID"],
                    StationaryName = (string)lcResult.Rows[0]["StationaryName"],
                    BrandName = (string)lcResult.Rows[0]["BrandName"],
                    Quantity = (int)lcResult.Rows[0]["Quantity"],
                    OrderPrice = (decimal)lcResult.Rows[0]["OrderPrice"],
                    Date = (DateTime)lcResult.Rows[0]["Date"],
                    CustomerName = (string)lcResult.Rows[0]["CustomerName"],
                    CustomerNo = (string)lcResult.Rows[0]["CustomerNo"],
                };
            else
                return null;
        }

        public List<string> GetBrandNames()
        {
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT BrandName FROM Brand", null);
            List<string> lcNames = new List<string>();
            foreach (DataRow dr in lcResult.Rows) lcNames.Add((string)dr[0]);
            return lcNames;
        }

        public clsBrand GetBrand(string BrandName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("BrandName", BrandName);
            DataTable lcResult =
            clsDbConnection.GetDataTable("SELECT * FROM Brand WHERE BrandName = @BrandName", par);

            if (lcResult.Rows.Count > 0)
                return new clsBrand()
                {
                    BrandName = (string)lcResult.Rows[0]["BrandName"],
                    Founder = (string)lcResult.Rows[0]["Founder"],
                    StationaryList = getBrandStationary(BrandName)
                };
            else
                return null;
        }

        private List<clsAllStationary> getBrandStationary(string BrandName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("BrandName", BrandName);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM Stationary WHERE BrandName = @BrandName", par);
            List<clsAllStationary> lcStationary = new List<clsAllStationary>();
            foreach (DataRow dr in lcResult.Rows)
                lcStationary.Add(dataRow2AllStationary(dr));
            return lcStationary;
        }

        private clsAllStationary dataRow2AllStationary(DataRow dr)
        {
            return new clsAllStationary()
            {
                StationaryID = Convert.ToInt16(dr["StationaryID"]),
                BrandName = Convert.ToString(dr["BrandName"]),
                StationaryType = Convert.ToString(dr["StationaryType"]),
                Name = Convert.ToString(dr["Name"]),
                BodyShape = Convert.ToString(dr["BodyShape"]),
                Price = Convert.ToDecimal(dr["Price"]),
                Quantity = Convert.ToInt16(dr["Quantity"]),
                DateLastMod = dr["DateLastMod"] is DBNull ? (DateTime?)null : Convert.ToDateTime(dr["DateLastMod"]),
                InkColour = Convert.ToString(dr["InkColour"]),
                LineWidth = dr["LineWidth"] is DBNull ? (decimal?)null : Convert.ToDecimal(dr["LineWidth"]),
                Mechanical = Convert.ToBoolean(dr["Mechanical"]),
                LeadGrade = Convert.ToString(dr["LeadGrade"])

            };
        }


        // Not required
        //Update Brand
        public string PutBrand(clsBrand prBrand)
        { // update
            try
            {
                int lcRecCount = clsDbConnection.Execute("UPDATE Brand SET Founder = @Founder WHERE BrandName = @BrandName",
                prepareBrandParameters(prBrand));
                if (lcRecCount == 1)
                    return "One brand updated";
                else
                    return "Unexpected brand update count: " + lcRecCount;
            } catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        // Not required
        //Add/Insert Brand
        public string PostBrand(clsBrand prBrand)
        {//add / insert
            try
            {
                int lcRecCount = clsDbConnection.Execute("INSERT INTO Brand (BrandName, Founder) VALUES (@BrandName, @Founder)",
               prepareBrandParameters(prBrand));
                if (lcRecCount == 1)
                    return "New brand Added";
                else
                    return "Unexpected brand creation count: " + lcRecCount;

            } catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private Dictionary<string, object> prepareBrandParameters(clsBrand prBrand)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(2);
            par.Add("BrandName", prBrand.BrandName);
            par.Add("Founder", prBrand.Founder);
            return par;
        }

        // _____________________ STATIONARY _____________________

        //Update Stationary
        public string PutStationary(clsAllStationary prStationary)
        { // update
            try
            {
                int lcRecCount = clsDbConnection.Execute("UPDATE Stationary SET " +
                    "Name = @Name, BodyShape = @BodyShape, Price = @Price, Quantity = @Quantity, DateLastMod = @DateLastMod, " +
                    "InkColour = @InkColour, LineWidth = @LineWidth, Mechanical = @Mechanical, LeadGrade = @LeadGrade " +
                    "WHERE StationaryID = @StationaryID",
                prepareStationaryParameters(prStationary));
                if (lcRecCount == 1)
                    return "One Stationary updated";
                else
                    return "Unexpected Stationary update count: " + lcRecCount;
            } catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        //Add/Insirt Stationary
        public string PostStationary(clsAllStationary prStationary)
        { // insert 
            try
            {
                int lcRecCount = clsDbConnection.Execute("INSERT INTO Stationary " +
                    "(BrandName, StationaryType, Name, BodyShape, Price, Quantity, DateLastMod, InkColour, LineWidth, Mechanical, LeadGrade) " +
                    "VALUES (@BrandName, @StationaryType, @Name, @BodyShape, @Price, @Quantity, @DateLastMod, @InkColour, @LineWidth, @Mechanical, @LeadGrade)",
                    prepareStationaryParameters(prStationary));
                if (lcRecCount == 1)
                    return "One Stationary inserted";
                else
                    return "Unexpected Stationary insert count: " + lcRecCount;
            } catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        //Delete Stationary
        public string DeleteStationary(int prStationaryID)
        {
            // Delete
            try
            {

                Dictionary<string, object> par = new Dictionary<string, object>(1);
                par.Add("prStationaryID", prStationaryID);

                int lcRecCount = clsDbConnection.Execute("DELETE FROM Stationary WHERE StationaryID = @prStationaryID", par);

                if (lcRecCount == 1)
                    return "One Stationary deleted";
                else
                    return "Unexpected Stationary delete count: " + lcRecCount;
            } catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private Dictionary<string, object> prepareStationaryParameters(clsAllStationary prStationary)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(12);
            par.Add("StationaryID", prStationary.StationaryID);
            par.Add("BrandName", prStationary.BrandName);
            par.Add("StationaryType", prStationary.StationaryType);
            par.Add("Name", prStationary.Name);
            par.Add("BodyShape", prStationary.BodyShape);
            par.Add("Price", prStationary.Price);
            par.Add("Quantity", prStationary.Quantity);
            par.Add("DateLastMod", prStationary.DateLastMod);
            par.Add("InkColour", prStationary.InkColour);
            par.Add("LineWidth", prStationary.LineWidth);
            par.Add("Mechanical", prStationary.Mechanical);
            par.Add("LeadGrade", prStationary.LeadGrade);

            return par;
        }

    }


}
