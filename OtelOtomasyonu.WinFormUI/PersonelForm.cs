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
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }
        PersonellerORM pOrm = new PersonellerORM();
        private void PersonelForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pOrm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.Adi = txtAdi.Text;
            p.Soyadi = txtSoyadi.Text;
            p.TelNo = mskdTelNo.Text;
            p.Tckn = mskdTckn.Text;
            p.Adres = txtAdres.Text;
            p.DogumTarihi = dtpDogumTarihi.Value;
            p.IseGirisTarihi = dtpIseGiris.Value;
            p.Maas = nudMaas.Value;
            p.KullaniciAdi = txtKullaniciAdi.Text;
            p.Parola = txtParola.Text;
            bool sonuc = pOrm.Insert(p);
            if (sonuc)
            {
                MessageBox.Show("Personel eklenmiştir");
                dataGridView1.DataSource = pOrm.Select();
            }
            else
                MessageBox.Show("Personel  Eklenirken hata oluştu!");
        }
    }
}
