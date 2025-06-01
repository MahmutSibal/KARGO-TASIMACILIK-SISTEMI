using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arayüz4
{
    public partial class FrmPanel : Form
    {
        public FrmPanel()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmKayit fk = new FrmKayit();
            fk.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmSikayetOlustur fs = new FrmSikayetOlustur();
            fs.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmKargoSorgu fs = new FrmKargoSorgu();
            fs.Show();
        }
    }
}
