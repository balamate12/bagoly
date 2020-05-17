namespace bagoly
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
            this.button1_kolcsonzes = new System.Windows.Forms.Button();
            this.button2_visszavitel = new System.Windows.Forms.Button();
            this.button3_kesesek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_kolcsonzes
            // 
            this.button1_kolcsonzes.Location = new System.Drawing.Point(34, 64);
            this.button1_kolcsonzes.Name = "button1_kolcsonzes";
            this.button1_kolcsonzes.Size = new System.Drawing.Size(122, 23);
            this.button1_kolcsonzes.TabIndex = 0;
            this.button1_kolcsonzes.Text = "Kölcsönzés";
            this.button1_kolcsonzes.UseVisualStyleBackColor = true;
            this.button1_kolcsonzes.Click += new System.EventHandler(this.Button1_kolcsonzes_Click);
            // 
            // button2_visszavitel
            // 
            this.button2_visszavitel.Location = new System.Drawing.Point(162, 64);
            this.button2_visszavitel.Name = "button2_visszavitel";
            this.button2_visszavitel.Size = new System.Drawing.Size(122, 23);
            this.button2_visszavitel.TabIndex = 1;
            this.button2_visszavitel.Text = "Visszavitel";
            this.button2_visszavitel.UseVisualStyleBackColor = true;
            // 
            // button3_kesesek
            // 
            this.button3_kesesek.Location = new System.Drawing.Point(290, 64);
            this.button3_kesesek.Name = "button3_kesesek";
            this.button3_kesesek.Size = new System.Drawing.Size(122, 23);
            this.button3_kesesek.TabIndex = 2;
            this.button3_kesesek.Text = "Késések";
            this.button3_kesesek.UseVisualStyleBackColor = true;
            this.button3_kesesek.Click += new System.EventHandler(this.Button3_kesesek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 146);
            this.Controls.Add(this.button3_kesesek);
            this.Controls.Add(this.button2_visszavitel);
            this.Controls.Add(this.button1_kolcsonzes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_kolcsonzes;
        private System.Windows.Forms.Button button2_visszavitel;
        private System.Windows.Forms.Button button3_kesesek;
    }
}

