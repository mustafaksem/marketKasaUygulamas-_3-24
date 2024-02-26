namespace MarketKasaUygulamasi
{
    public partial class Form1 : Form
    {
        decimal toplam = 0;
        List<Sepet> sepetim = new List<Sepet>();
        Sepet sepet = new Sepet();
        public Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SepetToplami();
        }
        private void btnKola_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Coca Cola", 1, 17);
            Form2Cagir(sepet);
        }
        void Form2Cagir(Sepet sepet)
        {
            form2 = new Form2(sepet);
            form2.Show();
            form2._form1 = this;
        }
        private void btFanta_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Fanta", 1, 16);
            Form2Cagir(sepet);
        }
        private void btDondurma_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Dondurma", 1, 3);
            Form2Cagir(sepet);
        }
        private void btDomates_Click(object sender, EventArgs e)
        {
            sepet = new Sepet()
            {
                UrunAdi = "Domates",
                Adet = 1,
                BirimFiyati = 5,
                Toplam = 1 * 5,
            };
            Form2Cagir(sepet);
        }
        private void btBiber_Click(object sender, EventArgs e)
        {
            sepet = new Sepet()
            {
                UrunAdi = "Biber",
                Adet = 1,
                BirimFiyati = 5,
                Toplam = 1 * 5,
            };
            Form2Cagir(sepet);
        }
        private void btPatlican_Click(object sender, EventArgs e)
        {
            sepet = new Sepet()
            {
                UrunAdi = "Patlýcan",
                Adet = 1,
                BirimFiyati = 5,
                Toplam = 1 * 5,
            };
            Form2Cagir(sepet);
        }


        void SepetiGoster()
        {
            dG1.DataSource = "";
            dG1.DataSource = sepetim;
            SepetToplami();
        }

        void SepetToplami()
        {
            toplam = 0;
            foreach (var item in sepetim)
            {
                toplam = item.Toplam + toplam;
            }
            lbToplam.Text = String.Format("{0:C2}", toplam);
        }
        void Vazgec()
        {
            txtAdet.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SepeteUrunEkle();
        }
        void SepeteUrunEkle()
        {
            sepetim.Add(sepet);
            SepetiGoster();
            Vazgec();
        }
        private void btVazgec_Click(object sender, EventArgs e)
        {
            Vazgec();
        }

        private void btKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SepeteUrunEkle(Sepet sepet)
        {
            sepetim.Add(sepet);
            SepetiGoster();
        }

        private void dG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid =(DataGridView)sender;   
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >=0) 
            {
                string urunAdi = dG1.Rows[e.RowIndex].Cells ["urunAdi"].Value.ToString ();
                if (MessageBox.Show($"{urunAdi} adlý ürünü silmek istiyor musunuz? ", "Sil ?" , MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    sepetim.RemoveAt(e.RowIndex);
                    SepetiGoster ();
                }
                
            }
        }
    }
}
