namespace IRF_Project_VLM0UR
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
            this.label1 = new System.Windows.Forms.Label();
            this.Magyar = new System.Windows.Forms.Button();
            this.Francia = new System.Windows.Forms.Button();
            this.Nemet = new System.Windows.Forms.Button();
            this.Spanyol = new System.Windows.Forms.Button();
            this.Olasz = new System.Windows.Forms.Button();
            this.Horvat = new System.Windows.Forms.Button();
            this.Orosz = new System.Windows.Forms.Button();
            this.Japan = new System.Windows.Forms.Button();
            this.USA = new System.Windows.Forms.Button();
            this.Eves = new System.Windows.Forms.Button();
            this.Multhet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Országok egy hónapnyi adatai:";
            // 
            // Magyar
            // 
            this.Magyar.Location = new System.Drawing.Point(15, 62);
            this.Magyar.Name = "Magyar";
            this.Magyar.Size = new System.Drawing.Size(151, 56);
            this.Magyar.TabIndex = 1;
            this.Magyar.Text = "Magyarország";
            this.Magyar.UseVisualStyleBackColor = true;
            // 
            // Francia
            // 
            this.Francia.Location = new System.Drawing.Point(172, 62);
            this.Francia.Name = "Francia";
            this.Francia.Size = new System.Drawing.Size(151, 56);
            this.Francia.TabIndex = 2;
            this.Francia.Text = "Franciaország";
            this.Francia.UseVisualStyleBackColor = true;
            // 
            // Nemet
            // 
            this.Nemet.Location = new System.Drawing.Point(329, 62);
            this.Nemet.Name = "Nemet";
            this.Nemet.Size = new System.Drawing.Size(151, 56);
            this.Nemet.TabIndex = 3;
            this.Nemet.Text = "Németország";
            this.Nemet.UseVisualStyleBackColor = true;
            // 
            // Spanyol
            // 
            this.Spanyol.Location = new System.Drawing.Point(15, 124);
            this.Spanyol.Name = "Spanyol";
            this.Spanyol.Size = new System.Drawing.Size(151, 56);
            this.Spanyol.TabIndex = 4;
            this.Spanyol.Text = "Spanyolország";
            this.Spanyol.UseVisualStyleBackColor = true;
            // 
            // Olasz
            // 
            this.Olasz.Location = new System.Drawing.Point(172, 124);
            this.Olasz.Name = "Olasz";
            this.Olasz.Size = new System.Drawing.Size(151, 56);
            this.Olasz.TabIndex = 5;
            this.Olasz.Text = "Olaszország";
            this.Olasz.UseVisualStyleBackColor = true;
            // 
            // Horvat
            // 
            this.Horvat.Location = new System.Drawing.Point(329, 124);
            this.Horvat.Name = "Horvat";
            this.Horvat.Size = new System.Drawing.Size(151, 56);
            this.Horvat.TabIndex = 6;
            this.Horvat.Text = "Horvátország";
            this.Horvat.UseVisualStyleBackColor = true;
            // 
            // Orosz
            // 
            this.Orosz.Location = new System.Drawing.Point(15, 186);
            this.Orosz.Name = "Orosz";
            this.Orosz.Size = new System.Drawing.Size(151, 56);
            this.Orosz.TabIndex = 7;
            this.Orosz.Text = "Oroszország";
            this.Orosz.UseVisualStyleBackColor = true;
            // 
            // Japan
            // 
            this.Japan.Location = new System.Drawing.Point(172, 186);
            this.Japan.Name = "Japan";
            this.Japan.Size = new System.Drawing.Size(151, 56);
            this.Japan.TabIndex = 8;
            this.Japan.Text = "Japán";
            this.Japan.UseVisualStyleBackColor = true;
            // 
            // USA
            // 
            this.USA.Location = new System.Drawing.Point(329, 186);
            this.USA.Name = "USA";
            this.USA.Size = new System.Drawing.Size(151, 56);
            this.USA.TabIndex = 9;
            this.USA.Text = "USA";
            this.USA.UseVisualStyleBackColor = true;
            // 
            // Eves
            // 
            this.Eves.Location = new System.Drawing.Point(87, 286);
            this.Eves.Name = "Eves";
            this.Eves.Size = new System.Drawing.Size(151, 75);
            this.Eves.TabIndex = 10;
            this.Eves.Text = "Éves adatok";
            this.Eves.UseVisualStyleBackColor = true;
            // 
            // Multhet
            // 
            this.Multhet.Location = new System.Drawing.Point(244, 286);
            this.Multhet.Name = "Multhet";
            this.Multhet.Size = new System.Drawing.Size(151, 75);
            this.Multhet.TabIndex = 11;
            this.Multhet.Text = "Múlt hét adatai";
            this.Multhet.UseVisualStyleBackColor = true;
            this.Multhet.Click += new System.EventHandler(this.Multhet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 530);
            this.Controls.Add(this.Multhet);
            this.Controls.Add(this.Eves);
            this.Controls.Add(this.USA);
            this.Controls.Add(this.Japan);
            this.Controls.Add(this.Orosz);
            this.Controls.Add(this.Horvat);
            this.Controls.Add(this.Olasz);
            this.Controls.Add(this.Spanyol);
            this.Controls.Add(this.Nemet);
            this.Controls.Add(this.Francia);
            this.Controls.Add(this.Magyar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Magyar;
        private System.Windows.Forms.Button Francia;
        private System.Windows.Forms.Button Nemet;
        private System.Windows.Forms.Button Spanyol;
        private System.Windows.Forms.Button Olasz;
        private System.Windows.Forms.Button Horvat;
        private System.Windows.Forms.Button Orosz;
        private System.Windows.Forms.Button Japan;
        private System.Windows.Forms.Button USA;
        private System.Windows.Forms.Button Eves;
        private System.Windows.Forms.Button Multhet;
    }
}

