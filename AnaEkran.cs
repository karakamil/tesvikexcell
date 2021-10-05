﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tesvik10
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void btnfirmakayit_Click(object sender, EventArgs e)
        {

            //panel3.Controls.Clear();
            FirmaKayit firmakayit = new FirmaKayit();
            if (Application.OpenForms["firmakayit"]==null)
            {
                
                firmakayit.TopLevel = false;
                panel3.Controls.Add(firmakayit);//panele formu yükledik

                firmakayit.Show();
                firmakayit.Dock = DockStyle.Fill; // açılan formun paneli doldurması sağlanıyor
                firmakayit.BringToFront();//panelin üzerinde form en üste getiriliyor. 
            }
            else
            {

                MessageBox.Show("Firma Kayıt Ekranı Zaten Açık");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panel3.Controls.Clear();
            SubeKayit subekayit = new SubeKayit();

            if (Application.OpenForms["subekayit"]==null)
            {
                subekayit.TopLevel = false;
                panel3.Controls.Add(subekayit);

                subekayit.Show();
                subekayit.Dock = DockStyle.Fill;
                subekayit.BringToFront();
            }
            else
            {
                MessageBox.Show("Şube Kayıt Ekranı Zaten Açık");
            }
           
                
        }

        private void btnParametre_Click(object sender, EventArgs e)
        {
            //panel3.Controls.Clear();
            KanuniParametre kanuniparemetre = new KanuniParametre();
            if (Application.OpenForms["kanuniparametre"]==null)
            {
                kanuniparemetre.TopLevel = false;
                panel3.Controls.Add(kanuniparemetre);

                kanuniparemetre.Show();
                kanuniparemetre.Dock = DockStyle.Fill;
                kanuniparemetre.BringToFront();
            }
            else
            {
                MessageBox.Show("Kanuni Parametreler Ekranı Zaten Açık");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (Application.OpenForms.Count > 1)
            {
                MessageBox.Show("Açık olan Pencereleriniz var Kapattıktan sonra programdan çıkmayı deneyizin. ");
            }
            else
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Programdan Çıkış Yapmak İstediğinize Eminmisiniz", "DİKKAT", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }

}

        private void button3_Click(object sender, EventArgs e)
        {
            ebildirge Ebildirge = new ebildirge();
            if (Application.OpenForms["Ebildirge"]==null)
            {
                Ebildirge.TopLevel = false;
                panel3.Controls.Add(Ebildirge);

                Ebildirge.Show();
                Ebildirge.Dock = DockStyle.Fill;
                Ebildirge.BringToFront();
            }
            else
            {
                MessageBox.Show("E-Bildirge Ekranı Zaten Açık");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tahmin tahmin = new Tahmin();
            if (Application.OpenForms["tahmin"]==null)
            {
                tahmin.TopLevel = false;
                panel3.Controls.Add(tahmin);

                tahmin.Show();
                tahmin.Dock = DockStyle.Fill;
                tahmin.BringToFront();
            }
            else
            {
                MessageBox.Show("Tahmin Ekranı Zaten Açık");
            }
        }
    }
}
