using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;

namespace DataLayer
{
    public class ProductDL:DataProvider
    {
        public List<Product> GetProducts()
        {
            string id, name, purchasePrice, sellingPrice, categoryId, supplierID;
            List<Product> products = new List<Product>();
            string sql = "SELECT * FROM Product";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {

                    id = reader["id"].ToString(); //la chuoi hay so cung dc
                    name = reader["name"].ToString();
                    purchasePrice = reader["purchasePrice"].ToString();
                    sellingPrice = reader["sellingPrice"].ToString() ;
                    categoryId = reader["categoryId"].ToString();
                    supplierID = reader["supplierId"].ToString ();
                    Product pd = new Product(id, name, int.Parse(purchasePrice), int.Parse(sellingPrice), int.Parse(categoryId), supplierID);
                    products.Add(pd);
                }
                reader.Close();
                return products;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }

        }
    }
}
