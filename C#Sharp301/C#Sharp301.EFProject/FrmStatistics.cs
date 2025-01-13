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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EFTravelDbEntities db=new EFTravelDbEntities(); 

        private void FrmStatistics_Load(object sender, EventArgs e)
        {

            lblLocationCount.Text = db.Location.Count().ToString();

            lblSumCapacity.Text = db.Location.Sum(x=>x.Capacity).ToString();

            lblGuideCount.Text = db.Guide.Count().ToString();

            lblAvgCapacity.Text=db.Location.Average(x=>x.Capacity)?.ToString("F2");

            lblAvgLocationPrice.Text=db.Location.Average(x=>x.Price)?.ToString("F2") + " ₺";

            int LastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == LastCountryId).Select(y => y.Country).FirstOrDefault();

            lblCappadociaLocationCapacity.Text= db.Location.Where(x => x.City == "Kapadokya" ).Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTurkiyeCapaccityAvg.Text=db.Location.Where(x=>x.Country=="Türkiye").Average(y=>y.Capacity).ToString();
        
            var romeguideId=db.Location.Where(x=>x.City== "Roma Turistlik").Select(y=>y.GuideId).FirstOrDefault();

            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeguideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
        
            var MaxCapacity=db.Location.Max(x=>x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x=>x.Capacity==MaxCapacity).Select(y=>y.City).FirstOrDefault().ToString();

            var MaxPrice = db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == MaxPrice).Select(y => y.City).FirstOrDefault().ToString();

            var guideIdByAysegulCinar = db.Guide.Where(x => x.GuideName== "Ayşegül" && x.GuideSurname== "Çınar").Select(y=>y.GuideId).FirstOrDefault();
            lblAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == guideIdByAysegulCinar).Count().ToString();

        }
    }
}
