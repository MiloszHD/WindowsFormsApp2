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
            //chart1.Series.Clear();

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
            //ciagRosnacy.Generuj(10, 2, 5);
        }

        private void losowy_CheckedChanged(object sender, EventArgs e) // ciag losowy
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // ciag malejacy
        {
          //   ciagMalejacy.Generuj(10, 2, 5);

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
            int wielkosc = 100;
            int[] wylosowane = new int[wielkosc];
            int[] rosnace = new int[wielkosc];
            int[] malejace = new int[wielkosc];
            //chart1.ChartAreas.First().AxisY.LabelStyle.Format = "0ms";

            if(this.rosnace.Checked)
                for(int i=1; i< wielkosc; i++)
                {
                    rosnace[i] = i;
                }
            if (this.malejace.Checked)
                for (int i = wielkosc - 1; i > 0; i--)
                {
                    malejace[i] = i;
                }
            if(losowe.Checked)
            {
                Random rnd = new Random();
                int poczatek = 0;
                int koniec = 100;
                for(int i=0; i <wielkosc - 1; i++) 
                {
                    wylosowane[i] = rnd.Next(poczatek, koniec);
                }
            }
            if(babelkowe.Checked)
            {
                int[] liczby = new int[wielkosc];
                if(this.rosnace.Checked) 
                {
                    sorBab.babel(rosnace);
                }
                if(this.malejace.Checked)
                {
                    sorBab.babel(malejace);
                }

            }
        }
    }
}
