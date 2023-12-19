﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Series series = new Series();

        public Form1()
        {
            
            InitializeComponent();
            chart1.Series.Clear();

            //chart1.Series.Add(series);
            
        }

        private void groupBox1_Enter(object sender, EventArgs e) // okno ciagow
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e) // okno sortowan
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) // ciag rosnacy
        {
            
        }

        private void losowy_CheckedChanged(object sender, EventArgs e) // ciag losowy
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // ciag malejacy
        {
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) // caly ekran
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) //babelkowe
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e) // przez wybor
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e) // przez wstawianie
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e) // przez scalanie
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e) // szybkie
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e) // pokaz wynik
        {
            chart1.Series.Clear();

            int wielkosc = 100;
            int[] wylosowane = new int[wielkosc];
            int[] rosnace = new int[wielkosc];
            int[] malejace = new int[wielkosc];
            chart1.ChartAreas.First().AxisY.LabelStyle.Format = "0ms";
            chart1.ChartAreas.First().AxisX.LabelStyle.Format = "1";

            if(this.rosnace.Checked)
            {
                for (int i = 0; i < wielkosc; i++)
                {
                    rosnace[i] = i;
                }
            }
             if (this.malejace.Checked)
            {
                int b = 0;
                for (int i = 0; i < wielkosc; i--)
                {
                    b = wielkosc;
                    malejace[i] = b-i;
                }
            }
                
            if(losowe.Checked)
            {
                Random rnd = new Random();
                int poczatek = 0;
                int koniec = 100;
                for(int i=0; i < wielkosc - 1; i++) 
                {
                    wylosowane[i] = rnd.Next(poczatek, koniec);
                }
            }
            if(babelkowe.Checked)
            {
                sorBab b = new sorBab();
                if(this.rosnace.Checked) 
                {
                    b.babel(rosnace);
                    Series baR = new Series("bab-ros");
                    baR.Points.Add(b.duration);
                    chart1.Series.Add(baR);
                }
                if(this.malejace.Checked)
                {
                    b.babel(malejace);
                    Series baM = new Series("bab-mal");
                    baM.Points.Add(b.duration);
                    chart1.Series.Add(baM);
                }
                if (losowe.Checked)
                {
                    b.babel(wylosowane);
                    Series baL = new Series("bab-los");
                    baL.Points.Add(b.duration);
                    chart1.Series.Add(baL);
                }
            }
            if(przez_wybor.Checked)
            {
                sorWybor wy = new sorWybor();
                if(this.rosnace.Checked)
                {
                    sorWybor.wybor(rosnace);
                    Series baR = new Series("wybor-rosnace");
                    baR.Points.Add(wy.duration);
                    chart1.Series.Add(baR);
                }
                if(this.malejace.Checked)
                {
                    sorWybor.wybor(malejace);
                    Series baM = new Series("wybor-malejace");
                    baM.Points.Add(wy.duration);
                    chart1.Series.Add(baM);
                }
                if(losowe.Checked)
                {
                    sorWybor.wybor(wylosowane);
                    Series baL = new Series("wybor-losowe");
                    baL.Points.Add(wy.duration);
                    chart1.Series.Add(baL);
                }
            }
            if(przez_wstawianie.Checked)
            {
                sorWstaw sw = new sorWstaw();
                if(this.rosnace.Checked)
                {
                    sw.wstaw(rosnace);
                    Series wR = new Series("wstaw-ros");
                    wR.Points.Add(sw.duration);
                    chart1.Series.Add(wR);
                }
                if(this.malejace.Checked)
                {
                    sw.wstaw(malejace);
                    Series wS = new Series("wstaw-mal");
                    wS.Points.Add(sw.duration);
                    chart1.Series.Add(wS);
                }
                if(losowe.Checked)
                {
                    sw.wstaw(wylosowane);
                    Series wL = new Series("wstaw-los");
                    wL.Points.Add(sw.duration);
                    chart1.Series.Add(wL);
                }
            }
            if(szybkie.Checked)
            {
                
            }
        }

        private void chart1_Click(object sender, EventArgs e) //wykres
        {

        }
    }
}
