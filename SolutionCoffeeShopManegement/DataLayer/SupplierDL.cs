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
        //Truyền theo kiểu query bình thường
        //public int Add(Supplier supplier)
        // {
        //     string sql = "INSERT INTO Supplier (ID,NAME,ADDRESS) VALUES('"+supplier.Id+"','"+supplier.Name+"','"+supplier.Address+"')";
        //     try
        //     {
        //         return MyExecuteNonQuery(sql, CommandType.Text);
        //     }
        //     catch (SqlException ex)
        //     {
        //         throw ex; 
        //     }
        // }
        //Cái này là truyền theo Parameter dùng List<SqlParemeter>
        public int Add(Supplier supplier)
        {
            string sql = "uspAddSupplier"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", supplier.Id));
            parameters.Add(new SqlParameter("@name", supplier.Name));
            parameters.Add(new SqlParameter("@address", supplier.Address));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        //public int Delete(Supplier supplier)
        //{
        //    string sql = "DELETE FROM Supplier WHERE id ='"+supplier.Id+"'";
        //    try
        //    {
        //        return MyExecuteNonQuery(sql, CommandType.Text);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}
        public int Delete(Supplier supplier)
        {
            string sql = "uspDeleteSupplier"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", supplier.Id));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //public int Update(Supplier supplier)
        //{
        //    string sql = "Update Supplier set name= N'" + supplier.Name + "',address=N'" + supplier.Address + "' WHERE id ='" + supplier.Id + "'";
        //    try
        //    {
        //        return MyExecuteNonQuery(sql, CommandType.Text);
        //    }
        //    catch (SqlException ex)
        //    {

        //        throw ex;
        //    }
        //}
        public int Update(Supplier supplier)
        {
            string sql = "uspUpdateSupplier"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter> {
            //parameters.Add(new SqlParameter("@id", supplier.Id));
            //parameters.Add(new SqlParameter("@name", supplier.Name));
            //parameters.Add(new SqlParameter("@address", supplier.Address));
            new SqlParameter("@id", supplier.Id),
            new SqlParameter("name",supplier.Name),
            new SqlParameter("address",supplier.Address)
            };


            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

