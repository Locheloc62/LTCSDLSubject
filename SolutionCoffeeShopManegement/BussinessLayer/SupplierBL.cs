using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;
using System.Data.SqlClient;
namespace BussinessLayer
{
    public class SupplierBL
    {
        private SupplierDL supplierDL;
        public SupplierBL()
        {
            supplierDL = new SupplierDL();
        }
        public List<Supplier> GetSuppliers()
        {
            try
            {
                return supplierDL.GetSuppliers();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(Supplier supplier)
        {
            if(supplier.Id.Length!=5)
            {
                throw new Exception("Id of supplier must be 5 character");
            }
            try
            {
                return supplierDL.Add(supplier);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Delete(Supplier supplier)
        {
            try
            {
                return supplierDL.Delete(supplier);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Update(Supplier supplier)
        {
            try
            {
                return supplierDL.Update(supplier);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
