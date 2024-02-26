namespace MarketKasaUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnKola = new Button();
            btFanta = new Button();
            btDondurma = new Button();
            btDomates = new Button();
            btBiber = new Button();
            btPatlican = new Button();
            dG1 = new DataGridView();
            Sil = new DataGridViewButtonColumn();
            lbToplam = new Label();
            btKapat = new Button();
            label1 = new Label();
            txtAdet = new TextBox();
            btKaydet = new Button();
            btVazgec = new Button();
            gbAdet = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dG1).BeginInit();
            gbAdet.SuspendLayout();
            SuspendLayout();
            // 
            // btnKola
            // 
            btnKola.Font = new Font("Microsoft Sans Serif", 12F);
            btnKola.Location = new Point(7, 36);
            btnKola.Name = "btnKola";
            btnKola.Size = new Size(219, 111);
            btnKola.TabIndex = 0;
            btnKola.TabStop = false;
            btnKola.Text = "kola";
            btnKola.UseVisualStyleBackColor = true;
            btnKola.Click += btnKola_Click;
            // 
            // btFanta
            // 
            btFanta.Font = new Font("Microsoft Sans Serif", 12F);
            btFanta.Location = new Point(249, 40);
            btFanta.Name = "btFanta";
            btFanta.Size = new Size(219, 103);
            btFanta.TabIndex = 1;
            btFanta.TabStop = false;
            btFanta.Text = "Fanta";
            btFanta.UseVisualStyleBackColor = true;
            btFanta.Click += btFanta_Click;
            // 
            // btDondurma
            // 
            btDondurma.Font = new Font("Microsoft Sans Serif", 12F);
            btDondurma.Location = new Point(489, 40);
            btDondurma.Name = "btDondurma";
            btDondurma.Size = new Size(219, 111);
            btDondurma.TabIndex = 2;
            btDondurma.TabStop = false;
            btDondurma.Text = "Dondurma";
            btDondurma.UseVisualStyleBackColor = true;
            btDondurma.Click += btDondurma_Click;
            // 
            // btDomates
            // 
            btDomates.Font = new Font("Microsoft Sans Serif", 12F);
            btDomates.Location = new Point(7, 163);
            btDomates.Name = "btDomates";
            btDomates.Size = new Size(219, 111);
            btDomates.TabIndex = 3;
            btDomates.TabStop = false;
            btDomates.Text = "Domates";
            btDomates.UseVisualStyleBackColor = true;
            btDomates.Click += btDomates_Click;
            // 
            // btBiber
            // 
            btBiber.Font = new Font("Microsoft Sans Serif", 12F);
            btBiber.Location = new Point(249, 163);
            btBiber.Name = "btBiber";
            btBiber.Size = new Size(219, 111);
            btBiber.TabIndex = 4;
            btBiber.TabStop = false;
            btBiber.Text = "Biber";
            btBiber.UseVisualStyleBackColor = true;
            btBiber.Click += btBiber_Click;
            // 
            // btPatlican
            // 
            btPatlican.Font = new Font("Microsoft Sans Serif", 12F);
            btPatlican.Location = new Point(489, 163);
            btPatlican.Name = "btPatlican";
            btPatlican.Size = new Size(219, 111);
            btPatlican.TabIndex = 5;
            btPatlican.TabStop = false;
            btPatlican.Text = "Patlıcan";
            btPatlican.UseVisualStyleBackColor = true;
            btPatlican.Click += btPatlican_Click;
            // 
            // dG1
            // 
            dG1.AllowUserToAddRows = false;
            dG1.AllowUserToDeleteRows = false;
            dG1.AllowUserToResizeRows = false;
            dG1.BackgroundColor = SystemColors.ControlLight;
            dG1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dG1.Columns.AddRange(new DataGridViewColumn[] { Sil });
            dG1.Location = new Point(714, 1);
            dG1.Name = "dG1";
            dG1.RowHeadersVisible = false;
            dG1.RowHeadersWidth = 51;
            dG1.Size = new Size(517, 523);
            dG1.TabIndex = 6;
            dG1.TabStop = false;
            dG1.CellContentClick += dG1_CellContentClick;
            // 
            // Sil
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Sil";
            Sil.DefaultCellStyle = dataGridViewCellStyle1;
            Sil.HeaderText = "Sil";
            Sil.MinimumWidth = 6;
            Sil.Name = "Sil";
            Sil.Text = "Sil";
            Sil.Width = 125;
            // 
            // lbToplam
            // 
            lbToplam.BorderStyle = BorderStyle.FixedSingle;
            lbToplam.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbToplam.ForeColor = Color.Brown;
            lbToplam.Location = new Point(714, 527);
            lbToplam.Name = "lbToplam";
            lbToplam.Size = new Size(517, 77);
            lbToplam.TabIndex = 9;
            lbToplam.Text = "0,00";
            lbToplam.TextAlign = ContentAlignment.TopCenter;
            // 
            // btKapat
            // 
            btKapat.BackColor = Color.LightCoral;
            btKapat.Font = new Font("Microsoft Sans Serif", 12F);
            btKapat.ForeColor = Color.Snow;
            btKapat.Location = new Point(249, 480);
            btKapat.Name = "btKapat";
            btKapat.Size = new Size(219, 111);
            btKapat.TabIndex = 11;
            btKapat.TabStop = false;
            btKapat.Text = "Formu KAPAT";
            btKapat.UseVisualStyleBackColor = false;
            btKapat.Click += btKapat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 30);
            label1.Name = "label1";
            label1.Size = new Size(54, 28);
            label1.TabIndex = 0;
            label1.Text = "Adet";
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(62, 61);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(125, 34);
            txtAdet.TabIndex = 1;
            txtAdet.Text = "1";
            txtAdet.TextAlign = HorizontalAlignment.Center;
            // 
            // btKaydet
            // 
            btKaydet.Location = new Point(17, 101);
            btKaydet.Name = "btKaydet";
            btKaydet.Size = new Size(121, 47);
            btKaydet.TabIndex = 2;
            btKaydet.TabStop = false;
            btKaydet.Text = "Kaydet";
            btKaydet.UseVisualStyleBackColor = true;
            btKaydet.Click += button1_Click;
            // 
            // btVazgec
            // 
            btVazgec.Location = new Point(144, 101);
            btVazgec.Name = "btVazgec";
            btVazgec.Size = new Size(109, 47);
            btVazgec.TabIndex = 3;
            btVazgec.Text = "Vazgeç";
            btVazgec.UseVisualStyleBackColor = true;
            btVazgec.Click += btVazgec_Click;
            // 
            // gbAdet
            // 
            gbAdet.Controls.Add(btVazgec);
            gbAdet.Controls.Add(btKaydet);
            gbAdet.Controls.Add(txtAdet);
            gbAdet.Controls.Add(label1);
            gbAdet.Location = new Point(371, 312);
            gbAdet.Name = "gbAdet";
            gbAdet.Size = new Size(259, 162);
            gbAdet.TabIndex = 10;
            gbAdet.TabStop = false;
            gbAdet.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1243, 603);
            Controls.Add(btKapat);
            Controls.Add(gbAdet);
            Controls.Add(lbToplam);
            Controls.Add(dG1);
            Controls.Add(btPatlican);
            Controls.Add(btBiber);
            Controls.Add(btDomates);
            Controls.Add(btDondurma);
            Controls.Add(btFanta);
            Controls.Add(btnKola);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Marekt Kasa Uygulamsı";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dG1).EndInit();
            gbAdet.ResumeLayout(false);
            gbAdet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKola;
        private Button btFanta;
        private Button btDondurma;
        private Button btDomates;
        private Button btBiber;
        private Button btPatlican;
        private DataGridView dG1;
        private Label lbToplam;
        private Button btKapat;
        private Label label1;
        private TextBox txtAdet;
        private Button btKaydet;
        private Button btVazgec;
        private GroupBox gbAdet;
        private DataGridViewButtonColumn Sil;
    }
}
