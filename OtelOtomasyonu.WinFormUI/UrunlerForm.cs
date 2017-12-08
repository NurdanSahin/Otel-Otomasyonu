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
    public partial class UrunlerForm : Form
    {
        public UrunlerForm()
        {
            InitializeComponent();
        }
        UrunlerORM uOrm = new UrunlerORM();
        KategoriORM kOrm = new KategoriORM();
        BirimTipORM bOrm = new BirimTipORM();
        private void UrunlerForm_Load(object sender, EventArgs e)
        {
            cmbBirim.DataSource = bOrm.Select();
            cmbBirim.ValueMember = "Id";
            cmbBirim.DisplayMember = "Adi";

            cmbKategori.DataSource = kOrm.Select();
            cmbKategori.DisplayMember = "Adi";
            cmbKategori.ValueMember = "Id";
            dataGridView1.DataSource
                = uOrm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.Adi = txtAdi.Text;
            u.Fiyat = nudFiyat.Value;
            u.Miktar = (double)nudMiktar.Value;
            u.BirimTipID = (int)cmbBirim.SelectedValue;
            u.KategoriID = (int)cmbKategori.SelectedValue;
            bool sonuc = uOrm.Insert(u);
            if (sonuc)
            {
                MessageBox.Show("Ürün eklenmiştir");
                dataGridView1.DataSource = uOrm.Select();
            }
            else
                MessageBox.Show("Ürün Eklenirken hata oluştu!");
        }
    }
}
