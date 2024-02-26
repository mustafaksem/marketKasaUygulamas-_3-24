﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketKasaUygulamasi
{
    public partial class Form2 : Form
    {
        Sepet _sepet = new Sepet();
        public Form1 _form1;
        public Form2(Sepet sepet)
        {
            _sepet = sepet;
            InitializeComponent();

        }

        public Form2()
        {
            InitializeComponent();
        }

        private void btVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btKaydet_Click(object sender, EventArgs e)
        {
            _sepet.Adet = Convert.ToInt16(txtAdet.Text);
            _sepet.Toplam = _sepet.Adet * _sepet.BirimFiyati;
            _form1.SepeteUrunEkle(_sepet);
            this.Close();
        }
    }
}
