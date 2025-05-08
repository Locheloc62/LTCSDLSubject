using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BussinessLayer;
using TransferObject;


namespace PresentationLayer.FormSupplier
{
    public partial class FrmSupplier : Form
    {
        private SupplierBL supplierBL;
        public FrmSupplier()
        {
            InitializeComponent();
            supplierBL = new SupplierBL();
        }
        private void LoadSupplier()
        {
            try
            {
                dataGridViewSupplier.DataSource = supplierBL.GetSuppliers();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            LoadSupplier();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormSupplier.FrmAddSupplier frmAddSupplier = new FrmAddSupplier();
            DialogResult result= frmAddSupplier.ShowDialog();
            if(result==DialogResult.OK)
            {
                LoadSupplier();
            }
        }
        private void DeleteSupplier(string id)
        {
            try
            {
                Supplier supplier = new Supplier(id,null,null);
                int rowsAffected = supplierBL.Delete(supplier);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xoa thanh cong");
                    LoadSupplier();
                }
                else
                {
                    MessageBox.Show("Xoa that bai");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi khi xoa"+ex.Message);
            }
        }
        private void UpdateSupplier(string id, string name,string address)
        {
            try
            {
                Supplier supplier = new Supplier(id, name, address);
                int rowsAffected = supplierBL.Update(supplier);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Da cap nhat thanh cong");
                    LoadSupplier();
                }
                else
                {
                    MessageBox.Show("Cap nhat that bai");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi khi Cap nhat" + ex.Message);
            }
        }

        private void dataGridViewSupplier_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int col = e.ColumnIndex;
            int row = e.RowIndex;
            if (row >= 0 && dataGridViewSupplier.Columns[col] is DataGridViewImageColumn)
            {
                //int row=e.RowIndex;
                //if (row >= 0)
                //{
                string columnName = dataGridViewSupplier.Columns[col].Name;
                string id = dataGridViewSupplier.Rows[row].Cells["MaNCC"].Value.ToString();
                string name = dataGridViewSupplier.Rows[row].Cells["TenNCC"].Value.ToString();
                string address = dataGridViewSupplier.Rows[row].Cells["DCNCC"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (columnName == "Delete")
                {
                    if (result == DialogResult.Yes)
                    {
                        DeleteSupplier(id);
                    }

                }
                if (columnName == "Update")
                {
                    if (result == DialogResult.Yes)
                    {
                        UpdateSupplier(id, name, address);
                    }
                }
            }
        }
    }
}
