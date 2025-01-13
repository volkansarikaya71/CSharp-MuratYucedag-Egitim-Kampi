using C_Sharp301.BusinessLayer.Abstract;
using C_Sharp301.BusinessLayer.Concrete;
using C_Sharp301.DataAccessLayer.EntityFramework;
//using C_Sharp301.EFProject;
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
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }   

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName=txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id=int.Parse(txtCategoryId.Text);
            var deletedValue=_categoryService.TGetById(Id);
            _categoryService.TDelete(deletedValue);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtCategoryId.Text);
            var updatedValue = _categoryService.TGetById(Id);
            updatedValue.CategoryName = txtCategoryName.Text;
            updatedValue.CategoryStatus = true;
            _categoryService.TUpdate(updatedValue);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtCategoryId.Text);
            var Values = _categoryService.TGetById(Id);
            dataGridView1.DataSource= Values;
        }

    }
}
