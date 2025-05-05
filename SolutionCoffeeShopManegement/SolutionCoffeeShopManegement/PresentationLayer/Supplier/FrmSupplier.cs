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


namespace PresentationLayer.Supplier
{
    public partial class FrmSupplier : Form
    {
        private SupplierBL supplierBL;
        public FrmSupplier()
        {
            InitializeComponent();
            supplierBL = new SupplierBL();
        }
        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            dataGridViewSupplier.DataSource = supplierBL.GetSuppliers();  
   
        }
    }
}
