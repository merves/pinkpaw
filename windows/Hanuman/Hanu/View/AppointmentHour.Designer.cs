﻿namespace Hanu.View
{
    partial class AppointmentHour
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
            this.tblSaatler = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tblSaatler
            // 
            this.tblSaatler.AutoSize = true;
            this.tblSaatler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblSaatler.ColumnCount = 4;
            this.tblSaatler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSaatler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSaatler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSaatler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSaatler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSaatler.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tblSaatler.Location = new System.Drawing.Point(0, 0);
            this.tblSaatler.Name = "tblSaatler";
            this.tblSaatler.RowCount = 4;
            this.tblSaatler.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSaatler.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSaatler.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSaatler.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSaatler.Size = new System.Drawing.Size(473, 291);
            this.tblSaatler.TabIndex = 1;
            // 
            // AppointmentHour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblSaatler);
            this.Name = "AppointmentHour";
            this.Size = new System.Drawing.Size(473, 291);
            this.Load += new System.EventHandler(this.AppointmentHour_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblSaatler;
    }
}
