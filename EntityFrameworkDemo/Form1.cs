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
        private void dgwProducts_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            tbxnameupdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();    
            }
    

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxnameupdate.Text,
                UnityPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)

            });
            LoadProduct();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)

            }); ;
            LoadProduct();
        }
        private void SearchProducts(string key)
        {
            //var result = _productDal.GetAll().Where(p =>p.Name.ToLower().Contains(key)).ToList();
            var result = _productDal.GetByName(key);
            dgwProducts.DataSource = result;
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }

        private void btxGetById_Click(object sender, EventArgs e)
        {
            _productDal.GetById(Convert.ToInt32(tbxSearch.Text));
        }
    }
    }

