namespace IRF_Project_VLM0UR
{
    partial class havibontas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mo = new System.Windows.Forms.Button();
            this.Fr = new System.Windows.Forms.Button();
            this.Ne = new System.Windows.Forms.Button();
            this.Spa = new System.Windows.Forms.Button();
            this.Ol = new System.Windows.Forms.Button();
            this.Ho = new System.Windows.Forms.Button();
            this.Oro = new System.Windows.Forms.Button();
            this.Jap = new System.Windows.Forms.Button();
            this.USA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(13, 40);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(949, 415);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(988, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Oszlop";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(988, 71);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Vonal";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(988, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(509, 230);
            this.dataGridView1.TabIndex = 3;
            // 
            // Mo
            // 
            this.Mo.Location = new System.Drawing.Point(1122, 37);
            this.Mo.Name = "Mo";
            this.Mo.Size = new System.Drawing.Size(121, 55);
            this.Mo.TabIndex = 4;
            this.Mo.Text = "Magyarország";
            this.Mo.UseVisualStyleBackColor = true;
            this.Mo.Click += new System.EventHandler(this.Mo_Click);
            // 
            // Fr
            // 
            this.Fr.Location = new System.Drawing.Point(1249, 37);
            this.Fr.Name = "Fr";
            this.Fr.Size = new System.Drawing.Size(121, 55);
            this.Fr.TabIndex = 5;
            this.Fr.Text = "Franciaország";
            this.Fr.UseVisualStyleBackColor = true;
            this.Fr.Click += new System.EventHandler(this.Fr_Click);
            // 
            // Ne
            // 
            this.Ne.Location = new System.Drawing.Point(1376, 37);
            this.Ne.Name = "Ne";
            this.Ne.Size = new System.Drawing.Size(121, 55);
            this.Ne.TabIndex = 6;
            this.Ne.Text = "Németország";
            this.Ne.UseVisualStyleBackColor = true;
            this.Ne.Click += new System.EventHandler(this.Ne_Click);
            // 
            // Spa
            // 
            this.Spa.Location = new System.Drawing.Point(1122, 98);
            this.Spa.Name = "Spa";
            this.Spa.Size = new System.Drawing.Size(121, 55);
            this.Spa.TabIndex = 7;
            this.Spa.Text = "Spanyolország";
            this.Spa.UseVisualStyleBackColor = true;
            this.Spa.Click += new System.EventHandler(this.Spa_Click);
            // 
            // Ol
            // 
            this.Ol.Location = new System.Drawing.Point(1249, 98);
            this.Ol.Name = "Ol";
            this.Ol.Size = new System.Drawing.Size(121, 55);
            this.Ol.TabIndex = 8;
            this.Ol.Text = "Olaszország";
            this.Ol.UseVisualStyleBackColor = true;
            this.Ol.Click += new System.EventHandler(this.Ol_Click);
            // 
            // Ho
            // 
            this.Ho.Location = new System.Drawing.Point(1376, 98);
            this.Ho.Name = "Ho";
            this.Ho.Size = new System.Drawing.Size(121, 55);
            this.Ho.TabIndex = 9;
            this.Ho.Text = "Horvátország";
            this.Ho.UseVisualStyleBackColor = true;
            this.Ho.Click += new System.EventHandler(this.Ho_Click);
            // 
            // Oro
            // 
            this.Oro.Location = new System.Drawing.Point(1122, 159);
            this.Oro.Name = "Oro";
            this.Oro.Size = new System.Drawing.Size(121, 55);
            this.Oro.TabIndex = 10;
            this.Oro.Text = "Oroszország";
            this.Oro.UseVisualStyleBackColor = true;
            this.Oro.Click += new System.EventHandler(this.Oro_Click);
            // 
            // Jap
            // 
            this.Jap.Location = new System.Drawing.Point(1249, 159);
            this.Jap.Name = "Jap";
            this.Jap.Size = new System.Drawing.Size(121, 55);
            this.Jap.TabIndex = 11;
            this.Jap.Text = "Japán";
            this.Jap.UseVisualStyleBackColor = true;
            this.Jap.Click += new System.EventHandler(this.Jap_Click);
            // 
            // USA
            // 
            this.USA.Location = new System.Drawing.Point(1376, 159);
            this.USA.Name = "USA";
            this.USA.Size = new System.Drawing.Size(121, 55);
            this.USA.TabIndex = 12;
            this.USA.Text = "USA";
            this.USA.UseVisualStyleBackColor = true;
            this.USA.Click += new System.EventHandler(this.USA_Click);
            // 
            // havibontas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 591);
            this.Controls.Add(this.USA);
            this.Controls.Add(this.Jap);
            this.Controls.Add(this.Oro);
            this.Controls.Add(this.Ho);
            this.Controls.Add(this.Ol);
            this.Controls.Add(this.Spa);
            this.Controls.Add(this.Ne);
            this.Controls.Add(this.Fr);
            this.Controls.Add(this.Mo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.chart1);
            this.Name = "havibontas";
            this.Text = "havibontas";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Mo;
        private System.Windows.Forms.Button Fr;
        private System.Windows.Forms.Button Ne;
        private System.Windows.Forms.Button Spa;
        private System.Windows.Forms.Button Ol;
        private System.Windows.Forms.Button Ho;
        private System.Windows.Forms.Button Oro;
        private System.Windows.Forms.Button Jap;
        private System.Windows.Forms.Button USA;
    }
}