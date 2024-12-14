using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuratYucedagKamp.EFProject
{
    public partial class FrmStatistics : Form
    {
        
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
       
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString(); // Lokasyon Sayısını verir.
            lblCapacity.Text = db.Location.Sum(x => x.Capacity).ToString(); // Lokasyon tablosunda tüm kapasitelerin toplamını verir.
            lblGuide.Text = db.Guide.Count().ToString(); // Guide tablosundaki Guide sayısını verir.

            lblAvgCapacity.Text = db.Location.Average(x => (decimal)x.Capacity).ToString("0"); //Kapasite ortalamasını alır

            //var totalCapacity = db.Location.Sum(x => x.Capacity);
            //var capacityCount = db.Location.Count();
            //var avgCapacity =  totalCapacity / capacityCount;
            //lblAvgCapacity.Text = avgCapacity.ToString();

            lblAvgLocationPrice.Text = db.Location.Average(x => (decimal)x.Price).ToString("0.00") + " ₺"; //Ortalama tur fiyatı. Virgülden sonra çift hane getirme.

            var lastCountryId = db.Location.Max(x => x.LocationId); //Lokasyon tablosundaki ID'si en yüksek olan değer alınmıştır.
            lblLastCountry.Text = db.Location 
                .Where(x => x.LocationId == lastCountryId)
                .Select(y => y.Country) //Select edilen Country'nin Id si last countrye yani max ID'ye eşit mi bunu kontrolünü yapıyoruz
                .FirstOrDefault()
                .ToString();

            var kapadokyaTourcCapacity = db.Location
                .Where(x => x.City == "Nevheşir - Kapadokya") //City kolonunda Nevşehir olan satırın Capacitysini select et.
                .Select(x => x.Capacity)
                .FirstOrDefault();
            lblKapadokyaCapacity.Text = kapadokyaTourcCapacity.ToString();


            var avgCapacityTurkeyTour = db.Location
                .Where(x => x.Country == "Türkiye")
                .Average(x => x.Capacity);
            lblAvgTurkeyTourCapacity.Text = avgCapacityTurkeyTour.ToString();

            //-------------------------------------------------------------------------------------------
            var romeGuideId = db.Location
                .Where(x => x.City == "Roma") //Location tablosunda City satırında Roma olan değerin GuideId'isin select ediyorum.
                .Select(x => x.GuideId)
                .FirstOrDefault();

            var guideName = db.Guide
                .Where(x => x.GuideId == romeGuideId) //Guide tablosunda GuideId Lokasyon tablosundaki GuideId'ye eşit olan GuideNamei alıyorum
                .Select(x => x.GuideName + " " + x.GuideSurname)
                .FirstOrDefault();

            lblRomeGuideName.Text = guideName.ToString(); //Guide Name'i txt'ye atıyorum


            var maxtourCapacity = db.Location.Max(x => x.Capacity); //Maximum kapasiteli satırı buluyoruz
            lblMaxTourCapacity.Text = db.Location.Where(x => x.Capacity == maxtourCapacity).Select(x => x.City).FirstOrDefault();//maximum tur kapasitesi olan cityi select ediyoruz  


            var mostExpensiveTourPrice = db.Location.Max(x => x.Price);
            lblMostExpensiveTour.Text = db.Location.Where(x => x.Price == mostExpensiveTourPrice).Select(x => x.City).FirstOrDefault();


            var guideIdByOzanKutlucan = db.Guide.Where(x=>x.GuideName == "Ozan" && x.GuideSurname == "Kutlucan")
                .Select(y=>y.GuideId).FirstOrDefault();
            lblOzanKutlucanLocationCount.Text=db.Location.Where(x=>x.GuideId==guideIdByOzanKutlucan).Count().ToString();
            
            
            
        }

        private void lblMostExpensiveTour_Click(object sender, EventArgs e)
        {

        }
    }
}
