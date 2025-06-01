using System;
using System.Windows.Forms;

namespace arayüz4
{
    public partial class FrmUyePanel : Form
    {
        public FrmUyePanel()
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

        private void tsmiKargoKayit_Click(object sender, EventArgs e) => OpenForm(new FrmKargoKayit());
        private void tsmiKargoTasima_Click(object sender, EventArgs e) => OpenForm(new FrmKargoTasima());
        private void tsmiKargoTeslim_Click(object sender, EventArgs e) => OpenForm(new FrmKargoTeslim());
        private void tsmiKargoSorgu_Click(object sender, EventArgs e) => OpenForm(new FrmKargoSorgu());
        private void tsmiSikayetOlustur_Click(object sender, EventArgs e) => OpenForm(new FrmSikayetOlustur());

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmKargoKayit frmKargoKayit = new FrmKargoKayit();
            frmKargoKayit.MdiParent = this;
            frmKargoKayit.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmKargoTasima frmKargoTasima = new FrmKargoTasima();
            frmKargoTasima.MdiParent = this;
            frmKargoTasima.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmKargoTeslim frmKargoTeslim = new FrmKargoTeslim();
            frmKargoTeslim.MdiParent = this;
            frmKargoTeslim.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmKargoSorgu frmKargoSorgu = new FrmKargoSorgu();
            frmKargoSorgu.MdiParent = this;
            frmKargoSorgu.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmSikayetOlustur frmSikayetOlustur = new FrmSikayetOlustur();
            frmSikayetOlustur.MdiParent = this;
            frmSikayetOlustur.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}