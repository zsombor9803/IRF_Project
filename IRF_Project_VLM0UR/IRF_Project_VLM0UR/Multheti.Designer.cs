﻿namespace IRF_Project_VLM0UR
{
    partial class Multheti
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.H = new System.Windows.Forms.Button();
            this.K = new System.Windows.Forms.Button();
            this.Sze = new System.Windows.Forms.Button();
            this.Cs = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Button();
            this.Szo = new System.Windows.Forms.Button();
            this.V = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // H
            // 
            this.H.Location = new System.Drawing.Point(1350, 12);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(133, 60);
            this.H.TabIndex = 0;
            this.H.Text = "Hétfő";
            this.H.UseVisualStyleBackColor = true;
            this.H.Click += new System.EventHandler(this.H_Click);
            // 
            // K
            // 
            this.K.Location = new System.Drawing.Point(1350, 78);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(133, 60);
            this.K.TabIndex = 1;
            this.K.Text = "Kedd";
            this.K.UseVisualStyleBackColor = true;
            this.K.Click += new System.EventHandler(this.K_Click);
            // 
            // Sze
            // 
            this.Sze.Location = new System.Drawing.Point(1350, 144);
            this.Sze.Name = "Sze";
            this.Sze.Size = new System.Drawing.Size(133, 60);
            this.Sze.TabIndex = 2;
            this.Sze.Text = "Szerda";
            this.Sze.UseVisualStyleBackColor = true;
            this.Sze.Click += new System.EventHandler(this.Sze_Click);
            // 
            // Cs
            // 
            this.Cs.Location = new System.Drawing.Point(1350, 210);
            this.Cs.Name = "Cs";
            this.Cs.Size = new System.Drawing.Size(133, 60);
            this.Cs.TabIndex = 3;
            this.Cs.Text = "Csütörtök";
            this.Cs.UseVisualStyleBackColor = true;
            this.Cs.Click += new System.EventHandler(this.Cs_Click);
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(1350, 276);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(133, 60);
            this.P.TabIndex = 4;
            this.P.Text = "Péntek";
            this.P.UseVisualStyleBackColor = true;
            this.P.Click += new System.EventHandler(this.P_Click);
            // 
            // Szo
            // 
            this.Szo.Location = new System.Drawing.Point(1350, 342);
            this.Szo.Name = "Szo";
            this.Szo.Size = new System.Drawing.Size(133, 60);
            this.Szo.TabIndex = 5;
            this.Szo.Text = "Szombat";
            this.Szo.UseVisualStyleBackColor = true;
            this.Szo.Click += new System.EventHandler(this.Szo_Click);
            // 
            // V
            // 
            this.V.Location = new System.Drawing.Point(1350, 408);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(133, 60);
            this.V.TabIndex = 6;
            this.V.Text = "Vasárnap";
            this.V.UseVisualStyleBackColor = true;
            this.V.Click += new System.EventHandler(this.V_Click);
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(12, 384);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(644, 278);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(698, 384);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 21);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Oszlop";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(698, 413);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 21);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "Kör";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Multheti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 674);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.V);
            this.Controls.Add(this.Szo);
            this.Controls.Add(this.P);
            this.Controls.Add(this.Cs);
            this.Controls.Add(this.Sze);
            this.Controls.Add(this.K);
            this.Controls.Add(this.H);
            this.Name = "Multheti";
            this.Text = "Multheti";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button H;
        private System.Windows.Forms.Button K;
        private System.Windows.Forms.Button Sze;
        private System.Windows.Forms.Button Cs;
        private System.Windows.Forms.Button P;
        private System.Windows.Forms.Button Szo;
        private System.Windows.Forms.Button V;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}