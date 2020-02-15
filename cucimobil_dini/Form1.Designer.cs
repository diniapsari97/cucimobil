namespace cucimobil_dini
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.biayaextra = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.biayacuci = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbpolesk = new System.Windows.Forms.CheckBox();
            this.cbpolesb = new System.Windows.Forms.CheckBox();
            this.cbvacum = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbsedan = new System.Windows.Forms.RadioButton();
            this.rbbus = new System.Windows.Forms.RadioButton();
            this.rbangkot = new System.Windows.Forms.RadioButton();
            this.rbmini = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tbhp = new System.Windows.Forms.TextBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.tbnop = new System.Windows.Forms.TextBox();
            this.tbno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tot = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbbayar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.kembali = new System.Windows.Forms.Label();
            this.btninput = new System.Windows.Forms.Button();
            this.btnhitung = new System.Windows.Forms.Button();
            this.btnbersih = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA CUCI MOBIL";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.biayaextra);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.biayacuci);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbpolesk);
            this.panel1.Controls.Add(this.cbpolesb);
            this.panel1.Controls.Add(this.cbvacum);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rbsedan);
            this.panel1.Controls.Add(this.rbbus);
            this.panel1.Controls.Add(this.rbangkot);
            this.panel1.Controls.Add(this.rbmini);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbhp);
            this.panel1.Controls.Add(this.tbnama);
            this.panel1.Controls.Add(this.tbnop);
            this.panel1.Controls.Add(this.tbno);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 183);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // biayaextra
            // 
            this.biayaextra.AutoSize = true;
            this.biayaextra.Location = new System.Drawing.Point(531, 124);
            this.biayaextra.Name = "biayaextra";
            this.biayaextra.Size = new System.Drawing.Size(13, 13);
            this.biayaextra.TabIndex = 20;
            this.biayaextra.Text = "0";
            this.biayaextra.TextChanged += new System.EventHandler(this.biayaextra_TextChanged);
            this.biayaextra.Click += new System.EventHandler(this.biayaextra_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(528, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "BIAYA EXTRA";
            // 
            // biayacuci
            // 
            this.biayacuci.AutoSize = true;
            this.biayacuci.Location = new System.Drawing.Point(531, 66);
            this.biayacuci.Name = "biayacuci";
            this.biayacuci.Size = new System.Drawing.Size(13, 13);
            this.biayacuci.TabIndex = 18;
            this.biayacuci.Text = "0";
            this.biayacuci.Click += new System.EventHandler(this.biayacuci_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(528, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "BIAYA CUCI MOBIL";
            // 
            // cbpolesk
            // 
            this.cbpolesk.AutoSize = true;
            this.cbpolesk.Location = new System.Drawing.Point(359, 152);
            this.cbpolesk.Name = "cbpolesk";
            this.cbpolesk.Size = new System.Drawing.Size(92, 17);
            this.cbpolesk.TabIndex = 16;
            this.cbpolesk.Text = "POLES KACA";
            this.cbpolesk.UseVisualStyleBackColor = true;
            this.cbpolesk.CheckedChanged += new System.EventHandler(this.cbpolesk_CheckedChanged);
            // 
            // cbpolesb
            // 
            this.cbpolesb.AutoSize = true;
            this.cbpolesb.Location = new System.Drawing.Point(264, 152);
            this.cbpolesb.Name = "cbpolesb";
            this.cbpolesb.Size = new System.Drawing.Size(94, 17);
            this.cbpolesb.TabIndex = 15;
            this.cbpolesb.Text = "POLES BODY";
            this.cbpolesb.UseVisualStyleBackColor = true;
            this.cbpolesb.CheckedChanged += new System.EventHandler(this.cbpolesb_CheckedChanged);
            // 
            // cbvacum
            // 
            this.cbvacum.AutoSize = true;
            this.cbvacum.Location = new System.Drawing.Point(328, 120);
            this.cbvacum.Name = "cbvacum";
            this.cbvacum.Size = new System.Drawing.Size(64, 17);
            this.cbvacum.TabIndex = 14;
            this.cbvacum.Text = "VACUM";
            this.cbvacum.UseVisualStyleBackColor = true;
            this.cbvacum.CheckedChanged += new System.EventHandler(this.cbvacum_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(325, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "LAYANAN EXTRA";
            // 
            // rbsedan
            // 
            this.rbsedan.AutoSize = true;
            this.rbsedan.Location = new System.Drawing.Point(403, 68);
            this.rbsedan.Name = "rbsedan";
            this.rbsedan.Size = new System.Drawing.Size(62, 17);
            this.rbsedan.TabIndex = 12;
            this.rbsedan.TabStop = true;
            this.rbsedan.Text = "SEDAN";
            this.rbsedan.UseVisualStyleBackColor = true;
            this.rbsedan.CheckedChanged += new System.EventHandler(this.rbsedan_CheckedChanged);
            // 
            // rbbus
            // 
            this.rbbus.AutoSize = true;
            this.rbbus.Location = new System.Drawing.Point(403, 36);
            this.rbbus.Name = "rbbus";
            this.rbbus.Size = new System.Drawing.Size(47, 17);
            this.rbbus.TabIndex = 11;
            this.rbbus.TabStop = true;
            this.rbbus.Text = "BUS";
            this.rbbus.UseVisualStyleBackColor = true;
            this.rbbus.CheckedChanged += new System.EventHandler(this.rbbus_CheckedChanged);
            // 
            // rbangkot
            // 
            this.rbangkot.AutoSize = true;
            this.rbangkot.Location = new System.Drawing.Point(286, 70);
            this.rbangkot.Name = "rbangkot";
            this.rbangkot.Size = new System.Drawing.Size(70, 17);
            this.rbangkot.TabIndex = 10;
            this.rbangkot.TabStop = true;
            this.rbangkot.Text = "ANGKOT";
            this.rbangkot.UseVisualStyleBackColor = true;
            this.rbangkot.CheckedChanged += new System.EventHandler(this.rbangkot_CheckedChanged);
            // 
            // rbmini
            // 
            this.rbmini.AutoSize = true;
            this.rbmini.BackColor = System.Drawing.SystemColors.Control;
            this.rbmini.Location = new System.Drawing.Point(286, 38);
            this.rbmini.Name = "rbmini";
            this.rbmini.Size = new System.Drawing.Size(73, 17);
            this.rbmini.TabIndex = 9;
            this.rbmini.TabStop = true;
            this.rbmini.Text = "MINI BUS";
            this.rbmini.UseVisualStyleBackColor = false;
            this.rbmini.CheckedChanged += new System.EventHandler(this.rbmini_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "JENIS MOBIL";
            // 
            // tbhp
            // 
            this.tbhp.Location = new System.Drawing.Point(142, 99);
            this.tbhp.Name = "tbhp";
            this.tbhp.Size = new System.Drawing.Size(100, 20);
            this.tbhp.TabIndex = 7;
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(142, 72);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(100, 20);
            this.tbnama.TabIndex = 6;
            // 
            // tbnop
            // 
            this.tbnop.Location = new System.Drawing.Point(142, 35);
            this.tbnop.Name = "tbnop";
            this.tbnop.Size = new System.Drawing.Size(100, 20);
            this.tbnop.TabIndex = 5;
            // 
            // tbno
            // 
            this.tbno.Location = new System.Drawing.Point(142, 8);
            this.tbno.Name = "tbno";
            this.tbno.Size = new System.Drawing.Size(100, 20);
            this.tbno.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "NO.HANDPHONE  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "NAMA CUSTOMER   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NO.POL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NO.CUCI";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "TOTAL BIAYA";
            // 
            // tot
            // 
            this.tot.AutoSize = true;
            this.tot.Location = new System.Drawing.Point(23, 297);
            this.tot.Name = "tot";
            this.tot.Size = new System.Drawing.Size(13, 13);
            this.tot.TabIndex = 3;
            this.tot.Text = "0";
            this.tot.Click += new System.EventHandler(this.tot_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(133, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "DIBAYARKAN";
            // 
            // tbbayar
            // 
            this.tbbayar.Location = new System.Drawing.Point(136, 297);
            this.tbbayar.Name = "tbbayar";
            this.tbbayar.Size = new System.Drawing.Size(100, 20);
            this.tbbayar.TabIndex = 5;
            this.tbbayar.TextChanged += new System.EventHandler(this.tbbayar_TextChanged);
            this.tbbayar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbbayar_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(291, 259);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "KEMBALIAN";
            // 
            // kembali
            // 
            this.kembali.AutoSize = true;
            this.kembali.Location = new System.Drawing.Point(291, 308);
            this.kembali.Name = "kembali";
            this.kembali.Size = new System.Drawing.Size(13, 13);
            this.kembali.TabIndex = 7;
            this.kembali.Text = "0";
            this.kembali.Click += new System.EventHandler(this.kembali_Click);
            // 
            // btninput
            // 
            this.btninput.Location = new System.Drawing.Point(396, 274);
            this.btninput.Name = "btninput";
            this.btninput.Size = new System.Drawing.Size(75, 23);
            this.btninput.TabIndex = 8;
            this.btninput.Text = "INPUT";
            this.btninput.UseVisualStyleBackColor = true;
            this.btninput.Click += new System.EventHandler(this.btninput_Click);
            // 
            // btnhitung
            // 
            this.btnhitung.Location = new System.Drawing.Point(477, 274);
            this.btnhitung.Name = "btnhitung";
            this.btnhitung.Size = new System.Drawing.Size(75, 23);
            this.btnhitung.TabIndex = 9;
            this.btnhitung.Text = "HITUNG";
            this.btnhitung.UseVisualStyleBackColor = true;
            this.btnhitung.Click += new System.EventHandler(this.btnhitung_Click);
            // 
            // btnbersih
            // 
            this.btnbersih.Location = new System.Drawing.Point(558, 274);
            this.btnbersih.Name = "btnbersih";
            this.btnbersih.Size = new System.Drawing.Size(75, 23);
            this.btnbersih.TabIndex = 10;
            this.btnbersih.Text = "BERSIH";
            this.btnbersih.UseVisualStyleBackColor = true;
            this.btnbersih.Click += new System.EventHandler(this.btnbersih_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(477, 303);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 11;
            this.btnsubmit.Text = "SUBMIT";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(3, 345);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(642, 170);
            this.dgv.TabIndex = 12;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 562);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.btnbersih);
            this.Controls.Add(this.btnhitung);
            this.Controls.Add(this.btninput);
            this.Controls.Add(this.kembali);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbbayar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tot);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label biayaextra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label biayacuci;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbpolesk;
        private System.Windows.Forms.CheckBox cbpolesb;
        private System.Windows.Forms.CheckBox cbvacum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbsedan;
        private System.Windows.Forms.RadioButton rbbus;
        private System.Windows.Forms.RadioButton rbangkot;
        private System.Windows.Forms.RadioButton rbmini;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbhp;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.TextBox tbnop;
        private System.Windows.Forms.TextBox tbno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label tot;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbbayar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label kembali;
        private System.Windows.Forms.Button btninput;
        private System.Windows.Forms.Button btnhitung;
        private System.Windows.Forms.Button btnbersih;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.DataGridView dgv;
    }
}

