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
    public partial class KasaForm : Form
    {
        public KasaForm()
        {
            InitializeComponent();
        }
        KasaORM kOrm = new KasaORM();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kasa k = new Kasa();
            k.Adi = txtAdi.Text;
            k.Aciklama = txtAciklama.Text;
            bool sonuc = kOrm.Insert(k);
            if (sonuc)
            {
                MessageBox.Show("Kasa Ekleme Başarılı");
                dataGridView1.DataSource = kOrm.Select();

            }
            else
                MessageBox.Show("Kayıt Ekleme Başarısız");
        }

        private void KasaForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kOrm.Select();
        }
    }
}
