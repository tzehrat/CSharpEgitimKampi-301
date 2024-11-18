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

    public partial class Form1 : Form
    {
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;

        }



        private void btnDel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Silindi.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Bilgisi başarıyla Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Guide guide =new Guide();
            guide.GuideName = txtName.Text;
            guide.GuideSurname=txtSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Eklendi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var values = db.Guide.Where(x =>x.GuideId==id).ToList();
            dataGridView1.DataSource= values;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
