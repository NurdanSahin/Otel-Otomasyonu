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
    public partial class SatisForm : Form
    {
        public SatisForm()
        {
            InitializeComponent();
        }

        private void SatisForm_Load(object sender, EventArgs e)
        {
            MusteriORM mOrm = new MusteriORM();
       cmbMusteri.DisplayMember = "Adi";
            cmbMusteri.ValueMember = "Id";

            cmbMusteri.DataSource = mOrm.Select();

            OdaORM oOrm = new OdaORM();
            cmbOda.DataSource = oOrm.Select();
            cmbOda.DisplayMember = "Adi";
            cmbOda.ValueMember = "Id";

            UrunlerORM uOrm = new UrunlerORM();
            dataGridView1.DataSource = uOrm.Select();
        }
        
        private void btnSatisEkle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen Satışa eklemek istediğiniz ürünü seçiniz :");
                return;
            }
            ListViewItem lvi = new ListViewItem();
            lvi.Text = (listView1.Items.Count + 1).ToString();
            lvi.SubItems.Add(dataGridView1.CurrentRow.Cells["Adi"].Value.ToString());
            lvi.SubItems.Add(nudUrunMiktari.Value.ToString());
            lvi.SubItems.Add(nudUrunFiyati.Value.ToString());
            lvi.SubItems.Add(nudIndirim.Value.ToString());
            lvi.Tag = dataGridView1.CurrentRow.Cells["Id"].Value;
            listView1.Items.Add(lvi);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SatisORM sOrm = new SatisORM();
            Satis s = new Satis();
            s.MusteriID =Convert.ToInt32(cmbMusteri.SelectedValue);
            s.OdaID =Convert.ToInt32( cmbOda.SelectedValue);
            s.PersonelID = PersonellerORM.AktifKullanici.Id;
            s.OdaFiyati = nudOdaFiyati.Value;
            s.SatisTarihi = DateTime.Now;
            int sId =Convert.ToInt32( sOrm.InsertScalar(s));
            if (sId > 0)
            {
                SatisDetayORM sdOrm = new SatisDetayORM();

                foreach (ListViewItem lvi in listView1.Items)
                {
                    SatisDetay sd = new SatisDetay();
                    sd.SatisID = sId;
                    sd.UrunID = (int)lvi.Tag;
                    sd.Fiyat = Convert.ToDecimal(lvi.SubItems[3].Text);
                    sd.Miktar = Convert.ToDouble(lvi.SubItems[2].Text);
                    sd.Indirim = Convert.ToDouble(lvi.SubItems[4].Text);
                    sdOrm.Insert(sd);

                }
                
            }
        }
    }
}
