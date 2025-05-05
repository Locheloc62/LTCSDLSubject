using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data.SqlClient;
using DataLayer;
using System.Data;

namespace DataLayer
{
    public class SupplierDL: DataProvider
    {
        public List<Supplier> GetSuppliers()
        {
            string id, name, address;
            List<Supplier> suppliers = new List<Supplier>();
            string sql = "SELECT * FROM Supplier";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while(reader.Read())
                {

                    id = reader["id"].ToString(); //la chuoi hay so cung dc
                    name = reader["name"].ToString();
                    address = reader["address"].ToString();

                    Supplier supplier = new Supplier(id, name, address);
                    suppliers.Add(supplier);
                }
                reader.Close();
                return suppliers;
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
       /*public int Add(Supplier supplier)
        {
            string sql = "INSERT INTO Supplier (ID,NAME,ADDRESS) VALUES('"+supplier.Id+"','"+supplier.Name+"','"+supplier.Address+"')";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex; 
            }
        }*/
        public int Add(Supplier supplier)
        {
            string sql = "uspAddSupplier"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", supplier.Id));
            parameters.Add(new SqlParameter("@name", supplier.Name));
            parameters.Add(new SqlParameter("@address", supplier.Address));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure,parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
