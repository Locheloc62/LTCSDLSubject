using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;

namespace PresentationLayer.FormOfProduct
{
    public partial class FrmOfProduct : Form
    {
        private ProductBL productBL;
        public FrmOfProduct()
        {
            InitializeComponent();
            productBL = new ProductBL();
        }
        private void LoadSupplier()
        {
            try
            {
                dGVProduct.DataSource = productBL.GetProducts();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmOfProduct_Load(object sender, EventArgs e)
        {
            LoadSupplier();
        }

        private void dGVProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
