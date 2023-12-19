using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {

            InitializeComponent();
            wykres.Series.Clear();

            

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
            wykres.Series.Clear();

            int size = 0;
            if (!rosnace.Checked && !malejace.Checked && !losowe.Checked)
            {
                MessageBox.Show("Kliknij wybrany rodzaj ciągu");
                return;
            }
            if (!babelk.Checked && !przez_wyb.Checked && !przez_wstaw.Checked && !szybkie.Checked && !przez_scal.Checked)
            {
                MessageBox.Show("Kliknij wybrany rodzaj sortowania");
                return;
            }

            if (!int.TryParse(tekst.Text, out size))
            {
                MessageBox.Show("Wpisz ilosc elementow");
                return;
            }
            else
            {
                size = Convert.ToInt32(tekst.Text);
            }


            int[] losowo = new int[size];
            int[] rosnaco = new int[size];
            int[] malejaco = new int[size];
            wykres.ChartAreas.First().AxisY.LabelStyle.Format = "0ms";
            wykres.ChartAreas.First().AxisX.LabelStyle.Format = "1";

            if (this.rosnace.Checked)
            {
                for (int i = 0; i < size; i++)
                {
                    rosnaco[i] = i;
                }
            }
            if (this.malejace.Checked)
            {
                int b = 0;
                for (int i = 0; i < size; i++)
                {
                    b = size;
                    malejaco[i] = b - i;
                }
            }

            if (this.losowe.Checked)
            {
                Random rnd = new Random();
                int poczatek = 0;
                int koniec = 1001;
                for (int i = 0; i < size - 1; i++)
                {
                    losowo[i] = rnd.Next(poczatek, koniec);
                }
            }
            if (babelk.Checked)
            {
                sorBab b = new sorBab();
                if (this.rosnace.Checked)
                {
                    b.babel(rosnaco);
                    Series baR = new Series("bab-ros");
                    baR.Points.Add(b.czas);
                    wykres.Series.Add(baR);
                }
                if (this.malejace.Checked)
                {
                    b.babel(malejaco);
                    Series baM = new Series("bab-mal");
                    baM.Points.Add(b.czas);
                    wykres.Series.Add(baM);
                }
                if (this.losowe.Checked)
                {
                    b.babel(losowo);
                    Series baL = new Series("bab-los");
                    baL.Points.Add(b.czas);
                    wykres.Series.Add(baL);
                }
            }
            if (przez_wyb.Checked)
            {
                sorWybor wy = new sorWybor();
                if (this.rosnace.Checked)
                {
                    sorWybor.wybor(rosnaco);
                    Series baR = new Series("wybor-rosnace");
                    baR.Points.Add(wy.czas);
                    wykres.Series.Add(baR);
                }
                if (this.malejace.Checked)
                {
                    sorWybor.wybor(malejaco);
                    Series baM = new Series("wybor-malejace");
                    baM.Points.Add(wy.czas);
                    wykres.Series.Add(baM);
                }
                if (this.losowe.Checked)
                {
                    sorWybor.wybor(losowo);
                    Series baL = new Series("wybor-losowe");
                    baL.Points.Add(wy.czas);
                    wykres.Series.Add(baL);
                }
            }
            if (przez_wstaw.Checked)
            {
                sorWstaw sw = new sorWstaw();
                if (this.rosnace.Checked)
                {
                    sw.wstaw(rosnaco);
                    Series wR = new Series("wstaw-ros");
                    wR.Points.Add(sw.czas);
                    wykres.Series.Add(wR);
                }
                if (this.malejace.Checked)
                {
                    sw.wstaw(malejaco);
                    Series wS = new Series("wstaw-mal");
                    wS.Points.Add(sw.czas);
                    wykres.Series.Add(wS);
                }
                if (this.losowe.Checked)
                {
                    sw.wstaw(losowo);
                    Series wL = new Series("wstaw-los");
                    wL.Points.Add(sw.czas);
                    wykres.Series.Add(wL);
                }
            }
            if (szybkie.Checked)
            {
                sorSzybkie s = new sorSzybkie();
                if (this.rosnace.Checked)
                {
                    s.szybko(rosnaco, 0, size - 1);
                    Series sr = new Series("szyb-ros");
                    sr.Points.Add(s.czas);
                    wykres.Series.Add(sr);
                }
                if (this.malejace.Checked)
                {
                    s.szybko(malejaco, 0, size - 1);
                    Series sm = new Series("szyb-mal");
                    sm.Points.Add(s.czas);
                    wykres.Series.Add(sm);
                }
                if (this.losowe.Checked)
                {
                    s.szybko(losowo, 0, size - 1);
                    Series sl = new Series("szyb-los");
                    sl.Points.Add(s.czas);
                    wykres.Series.Add(sl);
                }
            }
            if (przez_scal.Checked)
            {
                sorScal c = new sorScal();
                if (this.rosnace.Checked)
                {
                    c.scalanie(rosnaco, 0, size - 1);
                    Series sr = new Series("scal-ros");
                    sr.Points.Add(c.czas);
                    wykres.Series.Add(sr);
                }
                if (this.malejace.Checked)
                {
                    c.scalanie(malejaco, 0, size - 1);
                    Series sm = new Series("scal-mal");
                    sm.Points.Add(c.czas);
                    wykres.Series.Add(sm);
                }
                if (this.losowe.Checked)
                {
                    c.scalanie(losowo, 0, size - 1);
                    Series sw = new Series("scal-los");
                    sw.Points.Add(c.czas);
                    wykres.Series.Add(sw);
                }
            }

        }

        private void chart1_Click(object sender, EventArgs e) //wykres
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e) //okno elementow
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) // ilosc elementow
        {

        }
    }
}
