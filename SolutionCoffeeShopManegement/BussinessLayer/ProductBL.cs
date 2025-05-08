using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BussinessLayer
{
    public class ProductBL
    {
        private ProductDL ProductDL;
        public ProductBL()
        {
            ProductDL = new ProductDL();
        }
        public List<Product> GetProducts()
        {
            try
            {
                return ProductDL.GetProducts();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
