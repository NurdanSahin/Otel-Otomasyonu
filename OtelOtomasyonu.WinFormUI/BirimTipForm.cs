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
    public partial class BirimTipForm : Form
    {
        public BirimTipForm()
        {
            InitializeComponent();
        }
        BirimTipORM btOrm = new BirimTipORM();
        private void BirimTipForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = btOrm.Select();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BirimTipleri bt = new BirimTipleri();
            bt.Adi = txtAdi.Text;
            bool sonuc = btOrm.Insert(bt);
            if (sonuc)
            {
                MessageBox.Show("Birim Tip Ekleme Başarılı");
                dataGridView1.DataSource = btOrm.Select();

            }
            else
                MessageBox.Show("Kayıt Ekleme Başarısız");
        }
    }
    
}
