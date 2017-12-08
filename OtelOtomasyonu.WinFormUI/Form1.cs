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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BirimTipForm bt = new BirimTipForm();
        private void birimTipleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            
            if (bt.IsDisposed)
                bt = new BirimTipForm();
            bt.MdiParent = this; //form=this
            bt.Show();

            
        }
        KasaForm kf = new KasaForm();
        private void kasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kf.IsDisposed)
                kf = new KasaForm();
            kf.MdiParent = this;
            kf.Show();
        }
        KategoriForm ktg = new KategoriForm();
        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ktg.IsDisposed)
                ktg = new KategoriForm();
            ktg.MdiParent = this;
            ktg.Show();
        }
        UrunlerForm u = new UrunlerForm();
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (u.IsDisposed)
                u = new UrunlerForm();
            u.MdiParent = this;
            u.Show();
        }
        OdaForm o = new OdaForm();
        private void odalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (o.IsDisposed)
                o = new OdaForm();
            o.MdiParent = this;
            o.Show();
        }
        OdaTurleriForm otForm = new  OdaTurleriForm();
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (otForm.IsDisposed)
            otForm = new OdaTurleriForm();
            otForm.MdiParent = this;
            otForm.Show();

           

        }
        OzelliklerForm ozForm = new OzelliklerForm();
        private void özelliklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ozForm.IsDisposed)
                ozForm = new OzelliklerForm();
            ozForm.MdiParent = this;
            ozForm.Show();
        }
        OdaOzellikleriForm odozForm = new OdaOzellikleriForm();
        private void odaÖzellikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (odozForm.IsDisposed)
                odozForm = new OdaOzellikleriForm();
            odozForm.MdiParent = this;
            odozForm.Show();

        }
        MusterilerForm mForm =new  MusterilerForm();
        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mForm.IsDisposed)
                mForm = new MusterilerForm();
            mForm.MdiParent = this;
            mForm.Show();

        }
        PersonelForm pForm = new PersonelForm();
        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pForm.IsDisposed)
                pForm = new PersonelForm();
            pForm.MdiParent = this;
            pForm.Show();
        }
        SatisForm sf = new SatisForm();
        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sf.IsDisposed)
            {
                sf = new SatisForm();
            }
            sf.MdiParent = this;
            sf.Show();
        }
    }
}
