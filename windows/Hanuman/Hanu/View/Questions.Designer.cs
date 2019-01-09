namespace Hanu.View
{
    partial class Questions
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
            this.lstHasta = new System.Windows.Forms.ListView();
            this.Question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstHasta
            // 
            this.lstHasta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Question,
            this.Customer,
            this.Date,
            this.columnHeader1});
            this.lstHasta.FullRowSelect = true;
            this.lstHasta.HideSelection = false;
            this.lstHasta.Location = new System.Drawing.Point(39, 17);
            this.lstHasta.MultiSelect = false;
            this.lstHasta.Name = "lstHasta";
            this.lstHasta.Size = new System.Drawing.Size(433, 147);
            this.lstHasta.TabIndex = 63;
            this.lstHasta.UseCompatibleStateImageBehavior = false;
            this.lstHasta.View = System.Windows.Forms.View.Details;
            // 
            // Question
            // 
            this.Question.Text = "Question";
            this.Question.Width = 147;
            // 
            // Customer
            // 
            this.Customer.Text = "Customer";
            this.Customer.Width = 142;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Answer piece";
            this.columnHeader1.Width = 79;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(512, 201);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(190, 108);
            this.richTextBox1.TabIndex = 65;
            this.richTextBox1.Text = "";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DarkRed;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Location = new System.Drawing.Point(512, 344);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(190, 31);
            this.btnGuncelle.TabIndex = 125;
            this.btnGuncelle.Text = "Answer";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(512, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 31);
            this.button1.TabIndex = 127;
            this.button1.Text = "Add  Question";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(512, 17);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(190, 94);
            this.richTextBox2.TabIndex = 126;
            this.richTextBox2.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 165);
            this.dataGridView1.TabIndex = 128;
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lstHasta);
            this.Name = "Questions";
            this.Size = new System.Drawing.Size(737, 416);
            this.Load += new System.EventHandler(this.Questions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstHasta;
        private System.Windows.Forms.ColumnHeader Question;
        private System.Windows.Forms.ColumnHeader Customer;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
