using OtelOtomasyonu.ORM.Entity;
using OtelOtomasyonu.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.WinFormUI
{
    public partial class OdaTurleriForm : Form
    {
        public OdaTurleriForm()
        {
            InitializeComponent();
        }
        OdaTurleriORM odtOrm = new OdaTurleriORM();
        private void OdaTurleri_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = odtOrm.Select();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OdaTurleri odt = new OdaTurleri();
            odt.Adi = txtAdi.Text;
            odt.Aciklama = txtAciklama.Text;

            bool sonuc = odtOrm.Insert(odt);
            if (sonuc)
            {
                MessageBox.Show("Oda Türü eklenmiştir");
                dataGridView1.DataSource = odtOrm.Select();
            }
            else
                MessageBox.Show("Oda Türü Eklenirken hata oluştu!");
        }
    }
}
