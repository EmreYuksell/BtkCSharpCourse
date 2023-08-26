using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadProduct()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
              UnityPrice = Convert.ToDecimal(tbxUnitPrice.Text),
              StockAmount=Convert.ToInt32(tbxStockAmounth.Text)

            }) ;
            MessageBox.Show("Added");
            LoadProduct();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }
    }
    }

