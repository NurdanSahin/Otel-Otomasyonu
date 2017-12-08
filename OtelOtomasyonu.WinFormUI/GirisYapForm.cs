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
    public partial class GirisYapForm : Form
    {
        public GirisYapForm()
        {
            InitializeComponent();
        }

       

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            PersonellerORM pORM = new PersonellerORM();
            Personeller p = new Personeller();
            p.KullaniciAdi = txtKullaniciAdi.Text;
            p.Parola = txtParola.Text;
            Personeller aktif = pORM.GirisYap(p);
            if (aktif == null)
                MessageBox.Show("Kullanıcı Adı ve ya Parola hatalı !");

            else
            {

                PersonellerORM.AktifKullanici = aktif; 
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();


            }

        }

        private void GirisYapForm_Load(object sender, EventArgs e)
        {

        }
    }
}
