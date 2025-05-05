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
    }
}
