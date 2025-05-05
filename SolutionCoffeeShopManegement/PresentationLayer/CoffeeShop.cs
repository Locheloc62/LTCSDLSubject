using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer;

namespace PresentationLayer
{
    public partial class CoffeeShop : Form
    {
       
        public CoffeeShop()
        {
            InitializeComponent();
        }
 
        private void CoffeeShop_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.Enabled = false;
            Login login = new Login();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Enabled = true;
                label1.Text = "Welcome" + "XXX";
            }
            else
            {
                Application.Exit();
            }
        }
        private void AddForm(Form form)
        {
            form.TopLevel = false;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(form);
            form.Show();
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
        } 

        private void btSupplier_Click(object sender, EventArgs e)
        {
            AddForm(new FormSupplier.FrmSupplier());
        }
    }
}
