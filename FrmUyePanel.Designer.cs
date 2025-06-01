namespace arayüz4
{
    partial class FrmUyePanel
    {
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiKargoKayit, tsmiKargoTasima, tsmiKargoTeslim, tsmiKargoSorgu, tsmiSikayetOlustur;

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(365, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(79, 20);
            toolStripMenuItem1.Text = "Kargo Kayit";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(89, 20);
            toolStripMenuItem2.Text = "Kargo Tasima";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(86, 20);
            toolStripMenuItem3.Text = "Kargo Teslim";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(84, 20);
            toolStripMenuItem4.Text = "Kargo Sorgu";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // FrmUyePanel
            // 
            ClientSize = new Size(365, 261);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmUyePanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calisan Paneli";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
    }
}
