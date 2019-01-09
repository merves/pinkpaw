namespace Hanu.View
{
    partial class Customer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtHastaMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHastaAdres = new System.Windows.Forms.TextBox();
            this.txtHastaTel = new System.Windows.Forms.TextBox();
            this.txtHastaTckn = new System.Windows.Forms.TextBox();
            this.cmbHastaCinsiyeti = new System.Windows.Forms.ComboBox();
            this.txtHastaSoyadi = new System.Windows.Forms.TextBox();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.pnlHemsire = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menu.SuspendLayout();
            this.pnlHemsire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 116;
            this.label4.Text = "Search:";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(80, 322);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(132, 20);
            this.txtArama.TabIndex = 115;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(30, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 108;
            this.label9.Text = "GSM :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DarkRed;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Location = new System.Drawing.Point(263, 316);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(160, 31);
            this.btnGuncelle.TabIndex = 102;
            this.btnGuncelle.Text = "Create/Update";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtHastaMail
            // 
            this.txtHastaMail.Location = new System.Drawing.Point(137, 193);
            this.txtHastaMail.Name = "txtHastaMail";
            this.txtHastaMail.Size = new System.Drawing.Size(209, 20);
            this.txtHastaMail.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(30, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 110;
            this.label7.Text = "E-Posta :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(30, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 109;
            this.label8.Text = "Address :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(30, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 107;
            this.label10.Text = "T.C. No :";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sil});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(87, 26);
            // 
            // Sil
            // 
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(86, 22);
            this.Sil.Text = "Sil";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(30, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 106;
            this.label11.Text = "Gender :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(30, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 105;
            this.label12.Text = "Surname :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 104;
            this.label13.Text = "Name :";
            // 
            // txtHastaAdres
            // 
            this.txtHastaAdres.Location = new System.Drawing.Point(137, 165);
            this.txtHastaAdres.Name = "txtHastaAdres";
            this.txtHastaAdres.Size = new System.Drawing.Size(209, 20);
            this.txtHastaAdres.TabIndex = 100;
            // 
            // txtHastaTel
            // 
            this.txtHastaTel.Location = new System.Drawing.Point(137, 136);
            this.txtHastaTel.Name = "txtHastaTel";
            this.txtHastaTel.Size = new System.Drawing.Size(209, 20);
            this.txtHastaTel.TabIndex = 99;
            // 
            // txtHastaTckn
            // 
            this.txtHastaTckn.Location = new System.Drawing.Point(137, 106);
            this.txtHastaTckn.Name = "txtHastaTckn";
            this.txtHastaTckn.Size = new System.Drawing.Size(209, 20);
            this.txtHastaTckn.TabIndex = 98;
            // 
            // cmbHastaCinsiyeti
            // 
            this.cmbHastaCinsiyeti.FormattingEnabled = true;
            this.cmbHastaCinsiyeti.Location = new System.Drawing.Point(137, 71);
            this.cmbHastaCinsiyeti.Name = "cmbHastaCinsiyeti";
            this.cmbHastaCinsiyeti.Size = new System.Drawing.Size(209, 21);
            this.cmbHastaCinsiyeti.TabIndex = 96;
            // 
            // txtHastaSoyadi
            // 
            this.txtHastaSoyadi.Location = new System.Drawing.Point(137, 41);
            this.txtHastaSoyadi.Name = "txtHastaSoyadi";
            this.txtHastaSoyadi.Size = new System.Drawing.Size(209, 20);
            this.txtHastaSoyadi.TabIndex = 95;
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(137, 11);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(209, 20);
            this.txtHastaAdi.TabIndex = 94;
            // 
            // pnlHemsire
            // 
            this.pnlHemsire.Controls.Add(this.dataGridView2);
            this.pnlHemsire.Controls.Add(this.label3);
            this.pnlHemsire.Location = new System.Drawing.Point(446, 9);
            this.pnlHemsire.Name = "pnlHemsire";
            this.pnlHemsire.Size = new System.Drawing.Size(270, 338);
            this.pnlHemsire.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 96;
            this.label3.Text = "Derelict animals";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 383);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 150);
            this.dataGridView1.TabIndex = 117;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(255, 305);
            this.dataGridView2.TabIndex = 97;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.pnlHemsire);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtHastaMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtHastaAdres);
            this.Controls.Add(this.txtHastaTel);
            this.Controls.Add(this.txtHastaTckn);
            this.Controls.Add(this.cmbHastaCinsiyeti);
            this.Controls.Add(this.txtHastaSoyadi);
            this.Controls.Add(this.txtHastaAdi);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(738, 583);
            this.menu.ResumeLayout(false);
            this.pnlHemsire.ResumeLayout(false);
            this.pnlHemsire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtHastaMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Sil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHastaAdres;
        private System.Windows.Forms.TextBox txtHastaTel;
        private System.Windows.Forms.TextBox txtHastaTckn;
        private System.Windows.Forms.ComboBox cmbHastaCinsiyeti;
        private System.Windows.Forms.TextBox txtHastaSoyadi;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.Panel pnlHemsire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
