namespace TempMonitor
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dgvTemp = new System.Windows.Forms.DataGridView();
            this.crtTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grbUnit = new System.Windows.Forms.GroupBox();
            this.rdbCelsius = new System.Windows.Forms.RadioButton();
            this.rdbFarenheit = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtTemp)).BeginInit();
            this.grbUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTemp
            // 
            this.dgvTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemp.Location = new System.Drawing.Point(453, 12);
            this.dgvTemp.Name = "dgvTemp";
            this.dgvTemp.Size = new System.Drawing.Size(427, 374);
            this.dgvTemp.TabIndex = 0;
            // 
            // crtTemp
            // 
            legend1.Name = "Legend1";
            this.crtTemp.Legends.Add(legend1);
            this.crtTemp.Location = new System.Drawing.Point(12, 12);
            this.crtTemp.Name = "crtTemp";
            this.crtTemp.Size = new System.Drawing.Size(426, 374);
            this.crtTemp.TabIndex = 1;
            this.crtTemp.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 416);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(281, 416);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(21, 397);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(47, 13);
            this.lblAvg.TabIndex = 5;
            this.lblAvg.Text = "Average";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(150, 397);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "Max";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(278, 397);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 7;
            this.lblMin.Text = "Min";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 441);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 15);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbUnit
            // 
            this.grbUnit.Controls.Add(this.rdbFarenheit);
            this.grbUnit.Controls.Add(this.rdbCelsius);
            this.grbUnit.Location = new System.Drawing.Point(12, 458);
            this.grbUnit.Name = "grbUnit";
            this.grbUnit.Size = new System.Drawing.Size(84, 68);
            this.grbUnit.TabIndex = 9;
            this.grbUnit.TabStop = false;
            this.grbUnit.Text = "Unit";
            // 
            // rdbCelsius
            // 
            this.rdbCelsius.AutoSize = true;
            this.rdbCelsius.Location = new System.Drawing.Point(6, 19);
            this.rdbCelsius.Name = "rdbCelsius";
            this.rdbCelsius.Size = new System.Drawing.Size(58, 17);
            this.rdbCelsius.TabIndex = 0;
            this.rdbCelsius.TabStop = true;
            this.rdbCelsius.Text = "Celsius";
            this.rdbCelsius.UseVisualStyleBackColor = true;
            // 
            // rdbFarenheit
            // 
            this.rdbFarenheit.AutoSize = true;
            this.rdbFarenheit.Location = new System.Drawing.Point(6, 45);
            this.rdbFarenheit.Name = "rdbFarenheit";
            this.rdbFarenheit.Size = new System.Drawing.Size(69, 17);
            this.rdbFarenheit.TabIndex = 1;
            this.rdbFarenheit.TabStop = true;
            this.rdbFarenheit.Text = "Farenheit";
            this.rdbFarenheit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 535);
            this.Controls.Add(this.grbUnit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.crtTemp);
            this.Controls.Add(this.dgvTemp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtTemp)).EndInit();
            this.grbUnit.ResumeLayout(false);
            this.grbUnit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtTemp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbUnit;
        private System.Windows.Forms.RadioButton rdbFarenheit;
        private System.Windows.Forms.RadioButton rdbCelsius;
    }
}

