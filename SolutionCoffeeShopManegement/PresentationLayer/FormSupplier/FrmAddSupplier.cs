using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;
using BussinessLayer;
using System.Data.SqlClient;
namespace PresentationLayer.FormSupplier
{
    public partial class FrmAddSupplier : Form
    {
        private SupplierBL supplierBL;
        public FrmAddSupplier()
        {
            InitializeComponent();
            supplierBL = new SupplierBL();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id, name, address;
            id = txtId.Text;
            name = txtName.Text.Trim();
            address = txtAddress.Text.Trim();

            Supplier supplier = new Supplier(id, name, address);
            try
            {
                int NumOfRows = supplierBL.Add(supplier);
               // MessageBox.Show("So dong da them: " + NumOfRows.ToString());

                if (NumOfRows > 0)
                    this.DialogResult = DialogResult.OK;
                else
                    this.DialogResult = DialogResult.Cancel;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Id of Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
