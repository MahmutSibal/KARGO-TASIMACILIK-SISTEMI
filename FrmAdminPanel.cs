using arayüz4;
using System;
using System.Windows.Forms;

namespace arayüz4
{
    public partial class FrmAdminPanel : Form
    {
        public FrmAdminPanel()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void OpenForm(Form frm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == frm.GetType())
                {
                    f.Activate();
                    return;
                }
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsmiCalisanYonetimi_Click(object sender, EventArgs e) => OpenForm(new FrmCalisanYonetimi());
        private void tsmiKullaniciSorgu_Click(object sender, EventArgs e) => OpenForm(new FrmKullaniciSorgu());
        private void tsmiSikayetYonetimi_Click(object sender, EventArgs e) => OpenForm(new FrmSikayetYonetimi());
        private void tsmiSistemBakim_Click(object sender, EventArgs e) => OpenForm(new FrmSistemBakim());

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCalisanYonetimi frmCalisanYonetimi = new FrmCalisanYonetimi();
            frmCalisanYonetimi.MdiParent = this;
            frmCalisanYonetimi.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmKullaniciSorgu frmKullaniciSorgu = new FrmKullaniciSorgu();
            frmKullaniciSorgu.MdiParent = this;
            frmKullaniciSorgu.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmSikayetYonetimi frmSikayetYonetimi = new FrmSikayetYonetimi();
            frmSikayetYonetimi.MdiParent = this;
            frmSikayetYonetimi.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmSistemBakim frmSistemBakim = new FrmSistemBakim();
            frmSistemBakim.MdiParent = this;
            frmSistemBakim.Show();
        }
    }
}
