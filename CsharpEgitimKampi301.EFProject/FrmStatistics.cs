using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        EgitimKampiEfTravelDbEntities db =  new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();   
            lblSumCapacity.Text = db.Location.Sum(x=> x.Capacity).ToString(); 
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString();
            lblAvgLocationPrice.Text = db.Location.Average(x=> x.Price).ToString();

            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y =>
            y.Country).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Cappadocia").Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTurkiyeCapacityAvg.Text = db.Location.Where(x=>x.Country == "Turkey").Average(y=>y.Capacity).ToString();

            var romeGuideId = db.Location.Where(x => x.City == "Roma Touristic").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurName).FirstOrDefault().ToString();

            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString(); 

            var maxPrice = db.Location.Max(x=>x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x=>x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();

            #region Ayşegül Çınarın Tur Sayısı (!ÖNEMLİ!)
            var guideIdByNameAysegulCinar = db.Guide.Where(x=>x.GuideName=="Ayşegül" && x.GuideSurName=="Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysegülCinarLocationCount.Text=db.Location.Where (x=>x.GuideId == guideIdByNameAysegulCinar).Count().ToString();
            #endregion
        }














        private void lblAvgCapacity_Click(object sender, EventArgs e)
        {

        }
    }
}
