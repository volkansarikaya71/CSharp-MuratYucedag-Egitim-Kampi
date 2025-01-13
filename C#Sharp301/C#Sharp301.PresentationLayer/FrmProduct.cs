using C_Sharp301.BusinessLayer.Abstract;
using C_Sharp301.BusinessLayer.Concrete;
using C_Sharp301.DataAccessLayer.EntityFramework;
using C_Sharp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public FrmProduct()
        {
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var productValues = _productService.TGetAll();
            dataGridView1.DataSource = productValues;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var productValues = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = productValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            product.ProductName= txtProductName.Text;
            product.ProductPrice=decimal.Parse(txtProductPrice.Text);
            product.ProductStock = int.Parse(txtProductStock.Text);
            product.ProductDescription=txtDescription.Text;
            _productService.TInsert(product);
            MessageBox.Show("Ekleme İşlemi Yapıldı.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var values = _productService.TGetById(id);
            _productService.TDelete(values);
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var values= _productService.TGetById(id);
            values.ProductName = txtProductName.Text;
            values.ProductPrice=decimal.Parse(txtProductPrice.Text);
            values.ProductStock= int.Parse(txtProductStock.Text);
            values.ProductDescription=txtDescription.Text;
            _productService.TUpdate(values);
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti.");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value=_productService.TGetById(id);
            dataGridView1 .DataSource = value;  
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values=_categoryService.TGetAll();
            cmbCategory.DataSource = values;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }
    }
}
