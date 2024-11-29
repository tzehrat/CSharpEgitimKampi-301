using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi_301.EFProject
{
    public partial class FrmStatistics : Form
    {
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            #region
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x =>(int?) x.Capacity)?.ToString("F0")??"0";
            lblAvgLocPrice.Text = db.Location.Average(x => (decimal?)x.Price)?.ToString("F2") + " \u20BA" ?? "0.00 \u20BA";
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountry.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();
            lblUsaLocCapacity.Text=db.Location.Where(x=>x.City=="Newyork").Select(y => y.Capacity)?.FirstOrDefault().ToString(); ;
            lblCndCapAvg.Text=db.Location.Where(x=>x.Country=="Canada").Average(y=>y.Capacity)?.ToString("0");
            var zurichGuideId=db.Location.Where(x=>x.City=="Zurich").Select(y=>y.GuideId).FirstOrDefault();
            lblZurichGuideInfo.Text = db.Guide.Where(x => x.GuideId == zurichGuideId).Select(y => y.GuideName +"\n"+ y.GuideSurname)?.FirstOrDefault().ToString();
            var maxCapTour = db.Location.Max(x => x.Capacity);
            lblMaxCapTour.Text=db.Location.Where(x=>x.Capacity==maxCapTour).Select(y=>y.City).FirstOrDefault();
            var maxPriceTour = db.Location.Max(x => x.Price);
            lblMaxPriceTour.Text = db.Location.Where(x => x.Price == maxPriceTour).Select(y => y.City).FirstOrDefault();
            lblMelGunayTours.Text = db.Location.Where(x=>x.GuideId==7).Count().ToString();
            // burayı önce rehber bilgileriniden Id seçip sonra bunu yazdırabilirsin
            #endregion

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void lblSumCapacity_Click(object sender, EventArgs e)
        {

        }

        private void lblUsaLocCapacity_Click(object sender, EventArgs e)
        {

        }
    }
}
