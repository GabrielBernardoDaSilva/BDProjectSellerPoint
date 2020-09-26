using BDProjectsSellerPoint.Data;
using BDProjectsSellerPoint.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDProjectsSellerPoint
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Product product = new Product
            //{
            //    Id = 0,
            //    Cod = "A1D34F",
            //    Description = "Brinquedo",
            //    Price = 4.56,
            //    Quantity = 5

            //};

            // ProductDAO.AddProd(product);

            //var lista = ProductDAO.GetProducts();

            //ProductDAO.UpdateProd(product);
            ProductDAO.DeleteProd(1);



        }
    }
}
