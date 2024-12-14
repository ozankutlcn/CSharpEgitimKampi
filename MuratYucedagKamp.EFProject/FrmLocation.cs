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
    public partial class FrmLocation : Form
    {
        EgitimKampiEfTravelDbEntities entities = new EgitimKampiEfTravelDbEntities();
        public FrmLocation()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var datas = entities.Location.ToList();
            dataGridView1.DataSource = datas;
           
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var guide = entities.Guide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = guide;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            entities.Location.Add(location);
            entities.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı !");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deleteValue = entities.Location.Find(id);
            entities.Location.Remove(deleteValue);
            entities.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı !");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = entities.Location.Find(id);
            updateValue.City = txtCity.Text;
            updateValue.Country = txtCountry.Text;
            updateValue.Price = decimal.Parse(txtPrice.Text);
            updateValue.Capacity = byte.Parse(nudCapacity.Value.ToString());
            updateValue.DayNight = txtDayNight.Text.ToString();
            updateValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            entities.SaveChanges();
            MessageBox.Show("Güncelleme Başarıyla Yapılmıştır !");
        }
    }
}
