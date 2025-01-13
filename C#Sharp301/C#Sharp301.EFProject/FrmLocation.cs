using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        EFTravelDbEntities db = new EFTravelDbEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values=db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values=db.Guide.Select(x => new
            {
                FullName= x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmdGuide.DisplayMember = "FullName";
            cmdGuide.ValueMember = "GuideId";
            cmdGuide.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity=byte.Parse(nudCapacity.Value.ToString());
            location.City=txtCity.Text;
            location.Country=txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight=txtDayNight.Text;
            location.GuideId = int.Parse(cmdGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşleminiz Başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deleteValues = db.Location.Find(id);
            db.Location.Remove(deleteValues);
            db.SaveChanges();
            MessageBox.Show("Silme İşleminiz Başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValues = db.Location.Find(id);
            updateValues.DayNight = txtDayNight.Text;
            updateValues.Price = decimal.Parse(txtPrice.Text);
            updateValues.Capacity = byte.Parse(nudCapacity.Value.ToString());
            updateValues.City = txtCity.Text;
            updateValues.Country = txtCountry.Text; 
            updateValues.GuideId=int.Parse(cmdGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşleminiz Başarılı");

        }
    }
}
