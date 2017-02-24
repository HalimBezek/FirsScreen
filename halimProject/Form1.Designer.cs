namespace halimProject
{
    partial class PersonalList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlList = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALE_CARPET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALE_QUANTITIY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.stbsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avadfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adfvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adfvaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adfvadfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dataGridView1);
            this.pnlList.Controls.Add(this.menuStrip2);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlList.Location = new System.Drawing.Point(74, 73);
            this.pnlList.Name = "pnlList";
            this.pnlList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlList.Size = new System.Drawing.Size(706, 306);
            this.pnlList.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.SALE_CARPET,
            this.SALE_QUANTITIY});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 282);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "Adı";
            this.NAME.Name = "NAME";
            // 
            // SALE_CARPET
            // 
            this.SALE_CARPET.HeaderText = "Satılan Halı";
            this.SALE_CARPET.Name = "SALE_CARPET";
            // 
            // SALE_QUANTITIY
            // 
            this.SALE_QUANTITIY.HeaderText = "Satış Miktarı";
            this.SALE_QUANTITIY.Name = "SALE_QUANTITIY";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.toolStripMenuItem1;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(74, 379);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(88, 19);
            this.toolStripMenuItem1.Text = "Ana Sayfa";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(88, 19);
            this.toolStripMenuItem2.Text = "Satış Ekle";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(88, 19);
            this.toolStripMenuItem3.Text = "Satıcı Ekle";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(88, 19);
            this.toolStripMenuItem4.Text = "Halı Ekle";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(74, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 67);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(217, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "El Rincon De Fehmi";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbsToolStripMenuItem,
            this.avadfToolStripMenuItem,
            this.adfvaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(706, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // stbsToolStripMenuItem
            // 
            this.stbsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fvToolStripMenuItem});
            this.stbsToolStripMenuItem.Name = "stbsToolStripMenuItem";
            this.stbsToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.stbsToolStripMenuItem.Text = "stbs";
            // 
            // fvToolStripMenuItem
            // 
            this.fvToolStripMenuItem.Name = "fvToolStripMenuItem";
            this.fvToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fvToolStripMenuItem.Text = "fv";
            // 
            // avadfToolStripMenuItem
            // 
            this.avadfToolStripMenuItem.Name = "avadfToolStripMenuItem";
            this.avadfToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.avadfToolStripMenuItem.Text = "avadf";
            // 
            // adfvaToolStripMenuItem
            // 
            this.adfvaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adfvaToolStripMenuItem1,
            this.adfvadfToolStripMenuItem});
            this.adfvaToolStripMenuItem.Name = "adfvaToolStripMenuItem";
            this.adfvaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.adfvaToolStripMenuItem.Text = "adfva";
            // 
            // adfvaToolStripMenuItem1
            // 
            this.adfvaToolStripMenuItem1.Name = "adfvaToolStripMenuItem1";
            this.adfvaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.adfvaToolStripMenuItem1.Text = "adfva";
            // 
            // adfvadfToolStripMenuItem
            // 
            this.adfvadfToolStripMenuItem.Name = "adfvadfToolStripMenuItem";
            this.adfvadfToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adfvadfToolStripMenuItem.Text = "adfvadf";
            // 
            // PersonalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(780, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip2;
            this.MinimumSize = new System.Drawing.Size(796, 418);
            this.Name = "PersonalList";
            this.ShowInTaskbar = false;
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.PersonalList_Load);
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALE_CARPET;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALE_QUANTITIY;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem stbsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avadfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adfvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adfvaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adfvadfToolStripMenuItem;
    }
}

