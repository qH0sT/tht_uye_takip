namespace tht_uye_takip
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kaldırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türkhackteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.türkhackteamToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(750, 269);
            this.listView1.SmallImageList = this.ımageList1;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Üye Nicki";
            this.columnHeader1.Width = 189;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kullanıcı URL";
            this.columnHeader2.Width = 270;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mesaj Sayısı";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Son Aktivitesi";
            this.columnHeader4.Width = 120;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaldırToolStripMenuItem,
            this.ekleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 48);
            // 
            // kaldırToolStripMenuItem
            // 
            this.kaldırToolStripMenuItem.Name = "kaldırToolStripMenuItem";
            this.kaldırToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.kaldırToolStripMenuItem.Text = "Kaldır";
            this.kaldırToolStripMenuItem.Click += new System.EventHandler(this.kaldırToolStripMenuItem_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "away.png");
            this.ımageList1.Images.SetKeyName(1, "off.png");
            this.ımageList1.Images.SetKeyName(2, "onl.png");
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(688, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Durdur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 287);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(217, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Yeni bir mesaj yazıldığında bildirim göster.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(235, 287);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(168, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Online kullanıcı bildirimi göster.";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 311);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hakkında";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(509, 293);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(92, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gecikme:\r\n(milisaniye)";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "THT Üye Takip Programı V1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.gizleToolStripMenuItem,
            this.türkhackteamToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.hakkındaToolStripMenuItem1,
            this.türkhackteamToolStripMenuItem1,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(151, 158);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // gizleToolStripMenuItem
            // 
            this.gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            this.gizleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gizleToolStripMenuItem.Text = "Gizle";
            this.gizleToolStripMenuItem.Click += new System.EventHandler(this.gizleToolStripMenuItem_Click);
            // 
            // türkhackteamToolStripMenuItem
            // 
            this.türkhackteamToolStripMenuItem.Name = "türkhackteamToolStripMenuItem";
            this.türkhackteamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.türkhackteamToolStripMenuItem.Text = "Başlat";
            this.türkhackteamToolStripMenuItem.Click += new System.EventHandler(this.türkhackteamToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hakkındaToolStripMenuItem.Text = "Durdur";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem1
            // 
            this.hakkındaToolStripMenuItem1.Name = "hakkındaToolStripMenuItem1";
            this.hakkındaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.hakkındaToolStripMenuItem1.Text = "Hakkında";
            this.hakkındaToolStripMenuItem1.Click += new System.EventHandler(this.hakkındaToolStripMenuItem1_Click);
            // 
            // türkhackteamToolStripMenuItem1
            // 
            this.türkhackteamToolStripMenuItem1.Name = "türkhackteamToolStripMenuItem1";
            this.türkhackteamToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.türkhackteamToolStripMenuItem1.Text = "Türkhackteam";
            this.türkhackteamToolStripMenuItem1.Click += new System.EventHandler(this.türkhackteamToolStripMenuItem1_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THT Üye Takip Programı V1 | By 20071999";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kaldırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türkhackteamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem türkhackteamToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

