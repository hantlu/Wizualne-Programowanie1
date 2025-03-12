namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Liczba1 = new System.Windows.Forms.TextBox();
            this.Liczba2 = new System.Windows.Forms.TextBox();
            this.Dodawanie = new System.Windows.Forms.Button();
            this.Odejmowanie = new System.Windows.Forms.Button();
            this.Mnozenie = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Liczba1
            // 
            this.Liczba1.Location = new System.Drawing.Point(180, 64);
            this.Liczba1.Name = "Liczba1";
            this.Liczba1.Size = new System.Drawing.Size(165, 22);
            this.Liczba1.TabIndex = 10;
            this.Liczba1.Click += new System.EventHandler(this.textBox1_TextChanged);
            this.Liczba1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Liczba2
            // 
            this.Liczba2.Location = new System.Drawing.Point(182, 122);
            this.Liczba2.Name = "Liczba2";
            this.Liczba2.Size = new System.Drawing.Size(162, 22);
            this.Liczba2.TabIndex = 11;
            this.Liczba2.Click += new System.EventHandler(this.textBox1_TextChanged_1);
            this.Liczba2.TextChanged += new System.EventHandler(this.Liczba2_TextChanged);
            // 
            // Dodawanie
            // 
            this.Dodawanie.Location = new System.Drawing.Point(93, 170);
            this.Dodawanie.Name = "Dodawanie";
            this.Dodawanie.Size = new System.Drawing.Size(142, 52);
            this.Dodawanie.TabIndex = 12;
            this.Dodawanie.Text = "Dodawanie";
            this.Dodawanie.UseVisualStyleBackColor = true;
            this.Dodawanie.Click += new System.EventHandler(this.Dodawanie_Click);
            // 
            // Odejmowanie
            // 
            this.Odejmowanie.Location = new System.Drawing.Point(91, 239);
            this.Odejmowanie.Name = "Odejmowanie";
            this.Odejmowanie.Size = new System.Drawing.Size(144, 52);
            this.Odejmowanie.TabIndex = 13;
            this.Odejmowanie.Text = "Odejmowanie";
            this.Odejmowanie.UseVisualStyleBackColor = true;
            this.Odejmowanie.Click += new System.EventHandler(this.Odejmowanie_Click);
            // 
            // Mnozenie
            // 
            this.Mnozenie.Location = new System.Drawing.Point(276, 170);
            this.Mnozenie.Name = "Mnozenie";
            this.Mnozenie.Size = new System.Drawing.Size(144, 52);
            this.Mnozenie.TabIndex = 14;
            this.Mnozenie.Text = "Mnozenie";
            this.Mnozenie.UseVisualStyleBackColor = true;
            this.Mnozenie.Click += new System.EventHandler(this.Mnozenie_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(276, 239);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(144, 52);
            this.button11.TabIndex = 15;
            this.button11.Text = "Dzielenie";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.Mnozenie);
            this.Controls.Add(this.Odejmowanie);
            this.Controls.Add(this.Dodawanie);
            this.Controls.Add(this.Liczba2);
            this.Controls.Add(this.Liczba1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Liczba1;
        private System.Windows.Forms.TextBox Liczba2;
        private System.Windows.Forms.Button Dodawanie;
        private System.Windows.Forms.Button Odejmowanie;
        private System.Windows.Forms.Button Mnozenie;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
    }
}

