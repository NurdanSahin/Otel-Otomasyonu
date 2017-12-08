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
    public partial class OdaForm : Form
    {
        public OdaForm()
        {
            InitializeComponent();
        }

        OdaORM oOrm = new OdaORM();
        OdaTurleriORM odtOrm = new OdaTurleriORM();
       
        private void OdaForm_Load(object sender, EventArgs e)
        {
            cmbOdaTur.DataSource = odtOrm.Select();
            cmbOdaTur.DisplayMember = "Adi";
            cmbOdaTur.ValueMember = "Id";

            dataGridView1.DataSource = oOrm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Odalar o = new Odalar
            {
                Adi = txtAdi.Text,
                Aciklama = txtAciklama.Text,
                Aktif = true
            };
            o.OdaTurID = (int)cmbOdaTur.SelectedValue;
            bool sonuc = oOrm.Insert(o);
            if (sonuc)
            {
                MessageBox.Show("Oda eklenmiştir");
                dataGridView1.DataSource = oOrm.Select();
            }
            else
                MessageBox.Show("Oda Eklenirken hata oluştu!");
        }
    }
}
