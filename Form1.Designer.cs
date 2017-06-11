namespace Kakuro
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.bPlansza1 = new System.Windows.Forms.Button();
            this.bPlansza2 = new System.Windows.Forms.Button();
            this.bPlansza3 = new System.Windows.Forms.Button();
            this.bInstrukcja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bPlansza1
            // 
            this.bPlansza1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bPlansza1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPlansza1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bPlansza1.Location = new System.Drawing.Point(279, 169);
            this.bPlansza1.Name = "bPlansza1";
            this.bPlansza1.Size = new System.Drawing.Size(143, 61);
            this.bPlansza1.TabIndex = 1;
            this.bPlansza1.Text = "Plansza na rozgrzewkę :)";
            this.bPlansza1.UseVisualStyleBackColor = false;
            this.bPlansza1.Click += new System.EventHandler(this.bPlansza1_Click);
            // 
            // bPlansza2
            // 
            this.bPlansza2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bPlansza2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPlansza2.Location = new System.Drawing.Point(452, 168);
            this.bPlansza2.Name = "bPlansza2";
            this.bPlansza2.Size = new System.Drawing.Size(143, 62);
            this.bPlansza2.TabIndex = 2;
            this.bPlansza2.Text = "Plansza trudniejsza";
            this.bPlansza2.UseVisualStyleBackColor = false;
            this.bPlansza2.Click += new System.EventHandler(this.bPlansza2_Click);
            // 
            // bPlansza3
            // 
            this.bPlansza3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bPlansza3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPlansza3.Location = new System.Drawing.Point(624, 169);
            this.bPlansza3.Name = "bPlansza3";
            this.bPlansza3.Size = new System.Drawing.Size(143, 61);
            this.bPlansza3.TabIndex = 3;
            this.bPlansza3.Text = "Plansza trudniejsza";
            this.bPlansza3.UseVisualStyleBackColor = false;
            this.bPlansza3.Click += new System.EventHandler(this.bPlansza3_Click);
            // 
            // bInstrukcja
            // 
            this.bInstrukcja.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bInstrukcja.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bInstrukcja.Location = new System.Drawing.Point(55, 105);
            this.bInstrukcja.Name = "bInstrukcja";
            this.bInstrukcja.Size = new System.Drawing.Size(165, 54);
            this.bInstrukcja.TabIndex = 4;
            this.bInstrukcja.Text = "Instrukcja";
            this.bInstrukcja.UseVisualStyleBackColor = false;
            this.bInstrukcja.Click += new System.EventHandler(this.bInstrukcja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(330, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 80);
            this.label1.TabIndex = 5;
            this.label1.Text = "gra Kakuro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bInstrukcja);
            this.Controls.Add(this.bPlansza3);
            this.Controls.Add(this.bPlansza2);
            this.Controls.Add(this.bPlansza1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bPlansza1;
        private System.Windows.Forms.Button bPlansza2;
        private System.Windows.Forms.Button bPlansza3;
        private System.Windows.Forms.Button bInstrukcja;
        private System.Windows.Forms.Label label1;
    }
}

