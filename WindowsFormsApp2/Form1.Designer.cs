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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rosnace = new System.Windows.Forms.CheckBox();
            this.malejace = new System.Windows.Forms.CheckBox();
            this.losowe = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.babelkowe = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.babelkowe);
            this.groupBox2.Location = new System.Drawing.Point(3, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 240);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "rodzaj sortowania";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(19, 160);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(61, 17);
            this.checkBox8.TabIndex = 11;
            this.checkBox8.Text = "szybkie";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(19, 123);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(93, 17);
            this.checkBox7.TabIndex = 10;
            this.checkBox7.Text = "przez scalanie";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(19, 88);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(106, 17);
            this.checkBox6.TabIndex = 9;
            this.checkBox6.Text = "przez wstawianie";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(19, 53);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(82, 17);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "przez wybor";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox rosnace;
        private System.Windows.Forms.CheckBox malejace;
        private System.Windows.Forms.CheckBox losowe;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox babelkowe;
        private System.Windows.Forms.Button button1;
    }
}

