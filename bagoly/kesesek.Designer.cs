namespace bagoly
{
    partial class kesesek
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
            this.listBox1_kesok = new System.Windows.Forms.ListBox();
            this.comboBox1_nev = new System.Windows.Forms.ComboBox();
            this.listBox2_konyvek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1_kesok
            // 
            this.listBox1_kesok.FormattingEnabled = true;
            this.listBox1_kesok.ItemHeight = 16;
            this.listBox1_kesok.Location = new System.Drawing.Point(27, 54);
            this.listBox1_kesok.Name = "listBox1_kesok";
            this.listBox1_kesok.Size = new System.Drawing.Size(296, 372);
            this.listBox1_kesok.TabIndex = 0;
            this.listBox1_kesok.SelectedIndexChanged += new System.EventHandler(this.ListBox1_kesok_SelectedIndexChanged);
            // 
            // comboBox1_nev
            // 
            this.comboBox1_nev.FormattingEnabled = true;
            this.comboBox1_nev.Location = new System.Drawing.Point(432, 54);
            this.comboBox1_nev.Name = "comboBox1_nev";
            this.comboBox1_nev.Size = new System.Drawing.Size(304, 24);
            this.comboBox1_nev.TabIndex = 1;
            // 
            // listBox2_konyvek
            // 
            this.listBox2_konyvek.FormattingEnabled = true;
            this.listBox2_konyvek.ItemHeight = 16;
            this.listBox2_konyvek.Location = new System.Drawing.Point(432, 121);
            this.listBox2_konyvek.Name = "listBox2_konyvek";
            this.listBox2_konyvek.Size = new System.Drawing.Size(304, 308);
            this.listBox2_konyvek.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Késők";
            // 
            // kesesek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2_konyvek);
            this.Controls.Add(this.comboBox1_nev);
            this.Controls.Add(this.listBox1_kesok);
            this.Name = "kesesek";
            this.Text = "kesesek";
            this.Load += new System.EventHandler(this.Kesesek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1_kesok;
        private System.Windows.Forms.ComboBox comboBox1_nev;
        private System.Windows.Forms.ListBox listBox2_konyvek;
        private System.Windows.Forms.Label label1;
    }
}