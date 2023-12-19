namespace WindowsFormsApp2
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rosnace = new System.Windows.Forms.CheckBox();
            this.malejace = new System.Windows.Forms.CheckBox();
            this.losowe = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.szybkie = new System.Windows.Forms.CheckBox();
            this.przez_scal = new System.Windows.Forms.CheckBox();
            this.przez_wstaw = new System.Windows.Forms.CheckBox();
            this.przez_wyb = new System.Windows.Forms.CheckBox();
            this.babelk = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tekst = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.wykres, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(150, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.57447F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.42553F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 376);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rosnace);
            this.groupBox1.Controls.Add(this.malejace);
            this.groupBox1.Controls.Add(this.losowe);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "rodzaj ciagu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rosnace
            // 
            this.rosnace.AutoSize = true;
            this.rosnace.Location = new System.Drawing.Point(10, 101);
            this.rosnace.Name = "rosnace";
            this.rosnace.Size = new System.Drawing.Size(63, 17);
            this.rosnace.TabIndex = 2;
            this.rosnace.Text = "rosnacy";
            this.rosnace.UseVisualStyleBackColor = true;
            this.rosnace.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // malejace
            // 
            this.malejace.AutoSize = true;
            this.malejace.Location = new System.Drawing.Point(10, 65);
            this.malejace.Name = "malejace";
            this.malejace.Size = new System.Drawing.Size(67, 17);
            this.malejace.TabIndex = 1;
            this.malejace.Text = "malejacy";
            this.malejace.UseVisualStyleBackColor = true;
            this.malejace.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // losowe
            // 
            this.losowe.AutoSize = true;
            this.losowe.Location = new System.Drawing.Point(10, 27);
            this.losowe.Name = "losowe";
            this.losowe.Size = new System.Drawing.Size(58, 17);
            this.losowe.TabIndex = 0;
            this.losowe.Text = "losowy";
            this.losowe.UseVisualStyleBackColor = true;
            this.losowe.CheckedChanged += new System.EventHandler(this.losowy_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.szybkie);
            this.groupBox2.Controls.Add(this.przez_scal);
            this.groupBox2.Controls.Add(this.przez_wstaw);
            this.groupBox2.Controls.Add(this.przez_wyb);
            this.groupBox2.Controls.Add(this.babelk);
            this.groupBox2.Location = new System.Drawing.Point(3, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 240);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "rodzaj sortowania";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // szybkie
            // 
            this.szybkie.AutoSize = true;
            this.szybkie.Location = new System.Drawing.Point(19, 160);
            this.szybkie.Name = "szybkie";
            this.szybkie.Size = new System.Drawing.Size(61, 17);
            this.szybkie.TabIndex = 11;
            this.szybkie.Text = "szybkie";
            this.szybkie.UseVisualStyleBackColor = true;
            this.szybkie.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // przez_scal
            // 
            this.przez_scal.AutoSize = true;
            this.przez_scal.Location = new System.Drawing.Point(19, 123);
            this.przez_scal.Name = "przez_scal";
            this.przez_scal.Size = new System.Drawing.Size(93, 17);
            this.przez_scal.TabIndex = 10;
            this.przez_scal.Text = "przez scalanie";
            this.przez_scal.UseVisualStyleBackColor = true;
            this.przez_scal.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // przez_wstaw
            // 
            this.przez_wstaw.AutoSize = true;
            this.przez_wstaw.Location = new System.Drawing.Point(19, 88);
            this.przez_wstaw.Name = "przez_wstaw";
            this.przez_wstaw.Size = new System.Drawing.Size(106, 17);
            this.przez_wstaw.TabIndex = 9;
            this.przez_wstaw.Text = "przez wstawianie";
            this.przez_wstaw.UseVisualStyleBackColor = true;
            this.przez_wstaw.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // przez_wyb
            // 
            this.przez_wyb.AutoSize = true;
            this.przez_wyb.Location = new System.Drawing.Point(19, 53);
            this.przez_wyb.Name = "przez_wyb";
            this.przez_wyb.Size = new System.Drawing.Size(82, 17);
            this.przez_wyb.TabIndex = 8;
            this.przez_wyb.Text = "przez wybor";
            this.przez_wyb.UseVisualStyleBackColor = true;
            this.przez_wyb.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // babelk
            // 
            this.babelk.AutoSize = true;
            this.babelk.Location = new System.Drawing.Point(19, 19);
            this.babelk.Name = "babelk";
            this.babelk.Size = new System.Drawing.Size(78, 17);
            this.babelk.TabIndex = 3;
            this.babelk.Text = "babelkowe";
            this.babelk.UseVisualStyleBackColor = true;
            this.babelk.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "pokaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.wykres.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.wykres.Legends.Add(legend3);
            this.wykres.Location = new System.Drawing.Point(194, 133);
            this.wykres.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.wykres.Series.Add(series3);
            this.wykres.Size = new System.Drawing.Size(300, 240);
            this.wykres.TabIndex = 8;
            this.wykres.Text = "chart1";
            this.wykres.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tekst);
            this.groupBox3.Location = new System.Drawing.Point(478, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 97);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "wpisz ilosc elementow";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBox1
            // 
            this.tekst.Location = new System.Drawing.Point(48, 38);
            this.tekst.Name = "textBox1";
            this.tekst.Size = new System.Drawing.Size(90, 20);
            this.tekst.TabIndex = 0;
            this.tekst.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox rosnace;
        private System.Windows.Forms.CheckBox malejace;
        private System.Windows.Forms.CheckBox losowe;
        private System.Windows.Forms.CheckBox szybkie;
        private System.Windows.Forms.CheckBox przez_scal;
        private System.Windows.Forms.CheckBox przez_wstaw;
        private System.Windows.Forms.CheckBox przez_wyb;
        private System.Windows.Forms.CheckBox babelk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart wykres;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tekst;
    }
}

