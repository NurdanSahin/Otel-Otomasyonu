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
    public partial class OdaOzellikleriForm : Form
    {
        public OdaOzellikleriForm()
        {
            InitializeComponent();
        }
      
        OdaOzellikleriORM odaOzellikOrm = new OdaOzellikleriORM();
        private void OdaOzellikleriForm_Load(object sender, EventArgs e)
        {
            OzelliklerORM ozellikOrm = new OzelliklerORM();
            OdaORM odaOrm = new OdaORM();
            cmbOdalar.DataSource = odaOrm.Select();
            cmbOdalar.DisplayMember = "Adi";
            cmbOdalar.ValueMember = "Id";
            
            listOzellikler.DataSource = ozellikOrm.Select();
            listOzellikler.DisplayMember = "Adi";
            listOzellikler.ValueMember = "Id";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OdaOzellikleri oz = new OdaOzellikleri();
            
            oz.OdaID = (int)cmbOdalar.SelectedValue;
            oz.OzellikID = (int)listOzellikler.SelectedValue;
            short deger;
            if(short.TryParse(txtDeger.Text,out deger))
            {
                oz.Deger = deger;
            }
           //parse etmeyi dene edebilirsen if ten true döndür içeri gir değeri ata 
            bool sonuc =odaOzellikOrm.Insert(oz);
            if (sonuc)
            {
                MessageBox.Show("Odaya seçilen özellik eklenmiştir");
                
            }
            else
                MessageBox.Show("Ozellik atama sırasında hata oluştu!");

        }
    }
}
