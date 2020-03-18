namespace FindHisWife
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
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.grpOyunAlani = new DevExpress.XtraEditors.GroupControl();
            this.btnOyunuBaslat = new DevExpress.XtraEditors.SimpleButton();
            this.btnOyunuBitir = new DevExpress.XtraEditors.SimpleButton();
            this.txtDikey = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtYatay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtHataSayisi = new DevExpress.XtraEditors.CalcEdit();
            this.txtSure = new DevExpress.XtraEditors.TimeEdit();
            this.chkBenBelirleyecegim = new DevExpress.XtraEditors.CheckButton();
            this.chkCokZor = new DevExpress.XtraEditors.CheckButton();
            this.chkZor = new DevExpress.XtraEditors.CheckButton();
            this.chkKolay = new DevExpress.XtraEditors.CheckButton();
            this.chkOrta = new DevExpress.XtraEditors.CheckButton();
            this.chkCokKolay = new DevExpress.XtraEditors.CheckButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOyunAlani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDikey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYatay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHataSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSure.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.labelControl3);
            this.grpMenu.Controls.Add(this.chkOrta);
            this.grpMenu.Controls.Add(this.chkCokKolay);
            this.grpMenu.Controls.Add(this.chkKolay);
            this.grpMenu.Controls.Add(this.chkZor);
            this.grpMenu.Controls.Add(this.chkCokZor);
            this.grpMenu.Controls.Add(this.chkBenBelirleyecegim);
            this.grpMenu.Controls.Add(this.txtHataSayisi);
            this.grpMenu.Controls.Add(this.txtSure);
            this.grpMenu.Controls.Add(this.labelControl2);
            this.grpMenu.Controls.Add(this.labelControl1);
            this.grpMenu.Controls.Add(this.txtYatay);
            this.grpMenu.Controls.Add(this.txtDikey);
            this.grpMenu.Controls.Add(this.btnOyunuBitir);
            this.grpMenu.Controls.Add(this.btnOyunuBaslat);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpMenu.Location = new System.Drawing.Point(0, 0);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(287, 792);
            this.grpMenu.TabIndex = 0;
            this.grpMenu.Text = "groupControl1";
            // 
            // grpOyunAlani
            // 
            this.grpOyunAlani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOyunAlani.Location = new System.Drawing.Point(287, 0);
            this.grpOyunAlani.Name = "grpOyunAlani";
            this.grpOyunAlani.Size = new System.Drawing.Size(1094, 792);
            this.grpOyunAlani.TabIndex = 1;
            this.grpOyunAlani.Text = "Oyun Alanı";
            // 
            // btnOyunuBaslat
            // 
            this.btnOyunuBaslat.Appearance.BackColor = System.Drawing.Color.White;
            this.btnOyunuBaslat.Appearance.Font = new System.Drawing.Font("Agent Orange", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOyunuBaslat.Appearance.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnOyunuBaslat.Appearance.Options.UseBackColor = true;
            this.btnOyunuBaslat.Appearance.Options.UseFont = true;
            this.btnOyunuBaslat.Appearance.Options.UseForeColor = true;
            this.btnOyunuBaslat.Location = new System.Drawing.Point(5, 732);
            this.btnOyunuBaslat.Name = "btnOyunuBaslat";
            this.btnOyunuBaslat.Size = new System.Drawing.Size(277, 55);
            this.btnOyunuBaslat.TabIndex = 0;
            this.btnOyunuBaslat.Text = "Oyunu Başlat";
            this.btnOyunuBaslat.Click += new System.EventHandler(this.btnOyunuBaslat_Click);
            // 
            // btnOyunuBitir
            // 
            this.btnOyunuBitir.Appearance.Font = new System.Drawing.Font("Agent Orange", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOyunuBitir.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnOyunuBitir.Appearance.Options.UseFont = true;
            this.btnOyunuBitir.Appearance.Options.UseForeColor = true;
            this.btnOyunuBitir.Location = new System.Drawing.Point(4, 671);
            this.btnOyunuBitir.Name = "btnOyunuBitir";
            this.btnOyunuBitir.Size = new System.Drawing.Size(277, 55);
            this.btnOyunuBitir.TabIndex = 0;
            this.btnOyunuBitir.Text = "Oyunu Bitir";
            this.btnOyunuBitir.Click += new System.EventHandler(this.btnOyunuBitir_Click);
            // 
            // txtDikey
            // 
            this.txtDikey.Enabled = false;
            this.txtDikey.Location = new System.Drawing.Point(66, 626);
            this.txtDikey.Name = "txtDikey";
            this.txtDikey.Properties.Appearance.Font = new System.Drawing.Font("Righteous", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDikey.Properties.Appearance.Options.UseFont = true;
            this.txtDikey.Properties.Mask.EditMask = "n0";
            this.txtDikey.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDikey.Size = new System.Drawing.Size(215, 30);
            this.txtDikey.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Revue BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(6, 629);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 24);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Dikey";
            // 
            // txtYatay
            // 
            this.txtYatay.Enabled = false;
            this.txtYatay.Location = new System.Drawing.Point(67, 590);
            this.txtYatay.Name = "txtYatay";
            this.txtYatay.Properties.Appearance.Font = new System.Drawing.Font("Righteous", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYatay.Properties.Appearance.Options.UseFont = true;
            this.txtYatay.Properties.Mask.EditMask = "n0";
            this.txtYatay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtYatay.Size = new System.Drawing.Size(215, 30);
            this.txtYatay.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Revue BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 593);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Yatay";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtHataSayisi
            // 
            this.txtHataSayisi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtHataSayisi.Location = new System.Drawing.Point(121, 82);
            this.txtHataSayisi.Name = "txtHataSayisi";
            this.txtHataSayisi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHataSayisi.Properties.Appearance.Options.UseFont = true;
            this.txtHataSayisi.Properties.Precision = 0;
            this.txtHataSayisi.Size = new System.Drawing.Size(161, 36);
            this.txtHataSayisi.TabIndex = 7;
            // 
            // txtSure
            // 
            this.txtSure.EditValue = new System.DateTime(2018, 9, 6, 0, 0, 0, 0);
            this.txtSure.Location = new System.Drawing.Point(4, 23);
            this.txtSure.Name = "txtSure";
            this.txtSure.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSure.Properties.Appearance.Options.UseFont = true;
            this.txtSure.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSure.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSure.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSure.Size = new System.Drawing.Size(278, 52);
            this.txtSure.TabIndex = 6;
            // 
            // chkBenBelirleyecegim
            // 
            this.chkBenBelirleyecegim.Appearance.Font = new System.Drawing.Font("Fabada", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBenBelirleyecegim.Appearance.Options.UseFont = true;
            this.chkBenBelirleyecegim.Location = new System.Drawing.Point(6, 526);
            this.chkBenBelirleyecegim.Name = "chkBenBelirleyecegim";
            this.chkBenBelirleyecegim.Size = new System.Drawing.Size(275, 58);
            this.chkBenBelirleyecegim.TabIndex = 8;
            this.chkBenBelirleyecegim.Text = "Ben Belirleyeceğim";
            this.chkBenBelirleyecegim.CheckedChanged += new System.EventHandler(this.chkBenBelirleyecegim_CheckedChanged);
            // 
            // chkCokZor
            // 
            this.chkCokZor.Appearance.Font = new System.Drawing.Font("Fabada", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCokZor.Appearance.Options.UseFont = true;
            this.chkCokZor.Location = new System.Drawing.Point(6, 462);
            this.chkCokZor.Name = "chkCokZor";
            this.chkCokZor.Size = new System.Drawing.Size(275, 58);
            this.chkCokZor.TabIndex = 8;
            this.chkCokZor.Text = "Çok Zor";
            this.chkCokZor.CheckedChanged += new System.EventHandler(this.chkCokZor_CheckedChanged);
            // 
            // chkZor
            // 
            this.chkZor.Appearance.Font = new System.Drawing.Font("Fabada", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkZor.Appearance.Options.UseFont = true;
            this.chkZor.Location = new System.Drawing.Point(6, 398);
            this.chkZor.Name = "chkZor";
            this.chkZor.Size = new System.Drawing.Size(275, 58);
            this.chkZor.TabIndex = 8;
            this.chkZor.Text = "Zor";
            this.chkZor.CheckedChanged += new System.EventHandler(this.chkZor_CheckedChanged);
            // 
            // chkKolay
            // 
            this.chkKolay.Appearance.Font = new System.Drawing.Font("Fabada", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKolay.Appearance.Options.UseFont = true;
            this.chkKolay.Location = new System.Drawing.Point(7, 270);
            this.chkKolay.Name = "chkKolay";
            this.chkKolay.Size = new System.Drawing.Size(275, 58);
            this.chkKolay.TabIndex = 8;
            this.chkKolay.Text = "Kolay";
            this.chkKolay.CheckedChanged += new System.EventHandler(this.chkKolay_CheckedChanged);
            // 
            // chkOrta
            // 
            this.chkOrta.Appearance.Font = new System.Drawing.Font("Fabada", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOrta.Appearance.Options.UseFont = true;
            this.chkOrta.Location = new System.Drawing.Point(6, 334);
            this.chkOrta.Name = "chkOrta";
            this.chkOrta.Size = new System.Drawing.Size(275, 58);
            this.chkOrta.TabIndex = 8;
            this.chkOrta.Text = "Orta";
            this.chkOrta.CheckedChanged += new System.EventHandler(this.chkOrta_CheckedChanged);
            // 
            // chkCokKolay
            // 
            this.chkCokKolay.Appearance.Font = new System.Drawing.Font("Fabada", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCokKolay.Appearance.Options.UseFont = true;
            this.chkCokKolay.Location = new System.Drawing.Point(7, 206);
            this.chkCokKolay.Name = "chkCokKolay";
            this.chkCokKolay.Size = new System.Drawing.Size(275, 58);
            this.chkCokKolay.TabIndex = 8;
            this.chkCokKolay.Text = "Çok Kolay";
            this.chkCokKolay.CheckedChanged += new System.EventHandler(this.chkCokKolay_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Revue BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(6, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(111, 22);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Hata Sayısı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 792);
            this.Controls.Add(this.grpOyunAlani);
            this.Controls.Add(this.grpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NETA-Find His Wife";
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOyunAlani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDikey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYatay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHataSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSure.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.TextEdit txtDikey;
        private DevExpress.XtraEditors.SimpleButton btnOyunuBitir;
        private DevExpress.XtraEditors.SimpleButton btnOyunuBaslat;
        private DevExpress.XtraEditors.GroupControl grpOyunAlani;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtYatay;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.CalcEdit txtHataSayisi;
        private DevExpress.XtraEditors.TimeEdit txtSure;
        private DevExpress.XtraEditors.CheckButton chkOrta;
        private DevExpress.XtraEditors.CheckButton chkCokKolay;
        private DevExpress.XtraEditors.CheckButton chkKolay;
        private DevExpress.XtraEditors.CheckButton chkZor;
        private DevExpress.XtraEditors.CheckButton chkCokZor;
        private DevExpress.XtraEditors.CheckButton chkBenBelirleyecegim;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}

