namespace MarketKasaUygulamasi
{
    partial class Form2
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
            gbAdet = new GroupBox();
            btVazgec = new Button();
            btKaydet = new Button();
            txtAdet = new TextBox();
            label1 = new Label();
            gbAdet.SuspendLayout();
            SuspendLayout();
            // 
            // gbAdet
            // 
            gbAdet.Controls.Add(btVazgec);
            gbAdet.Controls.Add(btKaydet);
            gbAdet.Controls.Add(txtAdet);
            gbAdet.Controls.Add(label1);
            gbAdet.Location = new Point(12, 5);
            gbAdet.Name = "gbAdet";
            gbAdet.Size = new Size(375, 241);
            gbAdet.TabIndex = 11;
            gbAdet.TabStop = false;
            // 
            // btVazgec
            // 
            btVazgec.Location = new Point(88, 177);
            btVazgec.Name = "btVazgec";
            btVazgec.Size = new Size(205, 58);
            btVazgec.TabIndex = 3;
            btVazgec.Text = "Vazgeç";
            btVazgec.UseVisualStyleBackColor = true;
            btVazgec.Click += btVazgec_Click;
            // 
            // btKaydet
            // 
            btKaydet.Location = new Point(88, 112);
            btKaydet.Name = "btKaydet";
            btKaydet.Size = new Size(205, 59);
            btKaydet.TabIndex = 2;
            btKaydet.TabStop = false;
            btKaydet.Text = "Kaydet";
            btKaydet.UseVisualStyleBackColor = true;
            btKaydet.Click += btKaydet_Click;
            // 
            // txtAdet
            // 
            txtAdet.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAdet.Location = new Point(29, 57);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(303, 38);
            txtAdet.TabIndex = 1;
            txtAdet.Text = "1";
            txtAdet.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(141, 4);
            label1.Name = "label1";
            label1.Size = new Size(75, 38);
            label1.TabIndex = 0;
            label1.Text = "Adet";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 258);
            Controls.Add(gbAdet);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Adedi";
            Load += Form2_Load;
            gbAdet.ResumeLayout(false);
            gbAdet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAdet;
        private Button btVazgec;
        private Button btKaydet;
        private TextBox txtAdet;
        private Label label1;
    }
}