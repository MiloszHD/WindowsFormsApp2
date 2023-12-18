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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rosnace = new System.Windows.Forms.CheckBox();
            this.malejace = new System.Windows.Forms.CheckBox();
            this.losowe = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.szybkie = new System.Windows.Forms.CheckBox();
            this.przez_scalanie = new System.Windows.Forms.CheckBox();
            this.przez_wstawianie = new System.Windows.Forms.CheckBox();
            this.przez_wybor = new System.Windows.Forms.CheckBox();
            this.babelkowe = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 1);
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
            this.groupBox2.Controls.Add(this.przez_scalanie);
            this.groupBox2.Controls.Add(this.przez_wstawianie);
            this.groupBox2.Controls.Add(this.przez_wybor);
            this.groupBox2.Controls.Add(this.babelkowe);
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
            // przez_scalanie
            // 
            this.przez_scalanie.AutoSize = true;
            this.przez_scalanie.Location = new System.Drawing.Point(19, 123);
            this.przez_scalanie.Name = "przez_scalanie";
            this.przez_scalanie.Size = new System.Drawing.Size(93, 17);
            this.przez_scalanie.TabIndex = 10;
            this.przez_scalanie.Text = "przez scalanie";
            this.przez_scalanie.UseVisualStyleBackColor = true;
            this.przez_scalanie.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // przez_wstawianie
            // 
            this.przez_wstawianie.AutoSize = true;
            this.przez_wstawianie.Location = new System.Drawing.Point(19, 88);
            this.przez_wstawianie.Name = "przez_wstawianie";
            this.przez_wstawianie.Size = new System.Drawing.Size(106, 17);
            this.przez_wstawianie.TabIndex = 9;
            this.przez_wstawianie.Text = "przez wstawianie";
            this.przez_wstawianie.UseVisualStyleBackColor = true;
            this.przez_wstawianie.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // przez_wybor
            // 
            this.przez_wybor.AutoSize = true;
            this.przez_wybor.Location = new System.Drawing.Point(19, 53);
            this.przez_wybor.Name = "przez_wybor";
            this.przez_wybor.Size = new System.Drawing.Size(82, 17);
            this.przez_wybor.TabIndex = 8;
            this.przez_wybor.Text = "przez wybor";
            this.przez_wybor.UseVisualStyleBackColor = true;
            this.przez_wybor.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // babelkowe
            // 
            this.babelkowe.AutoSize = true;
            this.babelkowe.Location = new System.Drawing.Point(19, 19);
            this.babelkowe.Name = "babelkowe";
            this.babelkowe.Size = new System.Drawing.Size(78, 17);
            this.babelkowe.TabIndex = 3;
            this.babelkowe.Text = "babelkowe";
            this.babelkowe.UseVisualStyleBackColor = true;
            this.babelkowe.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "pokaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(194, 133);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 240);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.CheckBox przez_scalanie;
        private System.Windows.Forms.CheckBox przez_wstawianie;
        private System.Windows.Forms.CheckBox przez_wybor;
        private System.Windows.Forms.CheckBox babelkowe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

