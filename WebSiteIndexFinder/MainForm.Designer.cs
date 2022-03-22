namespace WebSiteIndexFinder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TbWebSite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbKeyword = new System.Windows.Forms.TextBox();
            this.RbPc = new System.Windows.Forms.RadioButton();
            this.RbMobile = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BuAdd = new System.Windows.Forms.Button();
            this.GbSonuclar = new System.Windows.Forms.GroupBox();
            this.LvResults = new System.Windows.Forms.ListBox();
            this.BuSearch = new System.Windows.Forms.Button();
            this.LvQuests = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.GbSonuclar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbWebSite
            // 
            this.TbWebSite.Location = new System.Drawing.Point(96, 12);
            this.TbWebSite.Name = "TbWebSite";
            this.TbWebSite.Size = new System.Drawing.Size(445, 20);
            this.TbWebSite.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Site Adresi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anahtar Kelime:";
            // 
            // TbKeyword
            // 
            this.TbKeyword.Location = new System.Drawing.Point(96, 50);
            this.TbKeyword.Name = "TbKeyword";
            this.TbKeyword.Size = new System.Drawing.Size(445, 20);
            this.TbKeyword.TabIndex = 3;
            // 
            // RbPc
            // 
            this.RbPc.AutoSize = true;
            this.RbPc.Checked = true;
            this.RbPc.Location = new System.Drawing.Point(0, 3);
            this.RbPc.Name = "RbPc";
            this.RbPc.Size = new System.Drawing.Size(69, 17);
            this.RbPc.TabIndex = 4;
            this.RbPc.TabStop = true;
            this.RbPc.Text = "Bilgisayar";
            this.RbPc.UseVisualStyleBackColor = true;
            // 
            // RbMobile
            // 
            this.RbMobile.AutoSize = true;
            this.RbMobile.Location = new System.Drawing.Point(98, 3);
            this.RbMobile.Name = "RbMobile";
            this.RbMobile.Size = new System.Drawing.Size(50, 17);
            this.RbMobile.TabIndex = 5;
            this.RbMobile.Text = "Mobil";
            this.RbMobile.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RbPc);
            this.panel1.Controls.Add(this.RbMobile);
            this.panel1.Location = new System.Drawing.Point(96, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 28);
            this.panel1.TabIndex = 6;
            // 
            // BuAdd
            // 
            this.BuAdd.Location = new System.Drawing.Point(96, 123);
            this.BuAdd.Name = "BuAdd";
            this.BuAdd.Size = new System.Drawing.Size(445, 23);
            this.BuAdd.TabIndex = 7;
            this.BuAdd.Text = "Sıraya Ekle";
            this.BuAdd.UseVisualStyleBackColor = true;
            this.BuAdd.Click += new System.EventHandler(this.BuAdd_Click);
            // 
            // GbSonuclar
            // 
            this.GbSonuclar.Controls.Add(this.LvResults);
            this.GbSonuclar.Location = new System.Drawing.Point(593, 12);
            this.GbSonuclar.Name = "GbSonuclar";
            this.GbSonuclar.Size = new System.Drawing.Size(499, 426);
            this.GbSonuclar.TabIndex = 10;
            this.GbSonuclar.TabStop = false;
            this.GbSonuclar.Text = "Sonuçlar";
            // 
            // LvResults
            // 
            this.LvResults.FormattingEnabled = true;
            this.LvResults.Location = new System.Drawing.Point(6, 19);
            this.LvResults.Name = "LvResults";
            this.LvResults.Size = new System.Drawing.Size(487, 121);
            this.LvResults.TabIndex = 10;
            // 
            // BuSearch
            // 
            this.BuSearch.Location = new System.Drawing.Point(12, 415);
            this.BuSearch.Name = "BuSearch";
            this.BuSearch.Size = new System.Drawing.Size(450, 23);
            this.BuSearch.TabIndex = 11;
            this.BuSearch.Text = "Aramayı Başlat";
            this.BuSearch.UseVisualStyleBackColor = true;
            this.BuSearch.Click += new System.EventHandler(this.BuSearch_Click);
            // 
            // LvQuests
            // 
            this.LvQuests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.LvQuests.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LvQuests.HideSelection = false;
            this.LvQuests.Location = new System.Drawing.Point(12, 152);
            this.LvQuests.MultiSelect = false;
            this.LvQuests.Name = "LvQuests";
            this.LvQuests.Size = new System.Drawing.Size(529, 244);
            this.LvQuests.TabIndex = 12;
            this.LvQuests.UseCompatibleStateImageBehavior = false;
            this.LvQuests.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Site";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Anahtar Kelime";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mobil";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bilgisayar";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Durum";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tamamlandı";
            this.columnHeader6.Width = 70;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 450);
            this.Controls.Add(this.LvQuests);
            this.Controls.Add(this.BuSearch);
            this.Controls.Add(this.GbSonuclar);
            this.Controls.Add(this.BuAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TbKeyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbWebSite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Finder || Serdar ÖZKAN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GbSonuclar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbWebSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbKeyword;
        private System.Windows.Forms.RadioButton RbPc;
        private System.Windows.Forms.RadioButton RbMobile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BuAdd;
        private System.Windows.Forms.GroupBox GbSonuclar;
        private System.Windows.Forms.ListBox LvResults;
        private System.Windows.Forms.Button BuSearch;
        private System.Windows.Forms.ListView LvQuests;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

