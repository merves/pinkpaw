namespace Hanu.View
{
    partial class Appointment
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
            this.label3 = new System.Windows.Forms.Label();
            this.Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lstRandevu = new System.Windows.Forms.ListView();
            this.pnlHours = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstHasta = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpKisiDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Search:";
            // 
            // Sil
            // 
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(86, 22);
            this.Sil.Text = "Sil";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sil});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(87, 26);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 142;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(76, 24);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(242, 20);
            this.txtArama.TabIndex = 67;
            // 
            // lstRandevu
            // 
            this.lstRandevu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lstRandevu.ContextMenuStrip = this.menu;
            this.lstRandevu.FullRowSelect = true;
            this.lstRandevu.HideSelection = false;
            this.lstRandevu.Location = new System.Drawing.Point(22, 291);
            this.lstRandevu.Name = "lstRandevu";
            this.lstRandevu.Size = new System.Drawing.Size(296, 184);
            this.lstRandevu.TabIndex = 66;
            this.lstRandevu.UseCompatibleStateImageBehavior = false;
            this.lstRandevu.View = System.Windows.Forms.View.Details;
            // 
            // pnlHours
            // 
            this.pnlHours.Location = new System.Drawing.Point(363, 120);
            this.pnlHours.Name = "pnlHours";
            this.pnlHours.Size = new System.Drawing.Size(283, 239);
            this.pnlHours.TabIndex = 65;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkRed;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.Location = new System.Drawing.Point(449, 388);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 58);
            this.btnKaydet.TabIndex = 63;
            this.btnKaydet.Text = "Create Appointment";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Surname";
            this.columnHeader2.Width = 142;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 147;
            // 
            // lstHasta
            // 
            this.lstHasta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstHasta.FullRowSelect = true;
            this.lstHasta.HideSelection = false;
            this.lstHasta.Location = new System.Drawing.Point(22, 50);
            this.lstHasta.MultiSelect = false;
            this.lstHasta.Name = "lstHasta";
            this.lstHasta.Size = new System.Drawing.Size(296, 239);
            this.lstHasta.TabIndex = 62;
            this.lstHasta.UseCompatibleStateImageBehavior = false;
            this.lstHasta.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 139;
            this.label1.Text = "Date :";
            // 
            // dtpKisiDogumTarihi
            // 
            this.dtpKisiDogumTarihi.Location = new System.Drawing.Point(467, 47);
            this.dtpKisiDogumTarihi.Name = "dtpKisiDogumTarihi";
            this.dtpKisiDogumTarihi.Size = new System.Drawing.Size(144, 20);
            this.dtpKisiDogumTarihi.TabIndex = 138;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpKisiDogumTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lstRandevu);
            this.Controls.Add(this.pnlHours);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lstHasta);
            this.Name = "Appointment";
            this.Size = new System.Drawing.Size(667, 498);
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem Sil;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ListView lstRandevu;
        private System.Windows.Forms.Panel pnlHours;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lstHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpKisiDogumTarihi;
    }
}
