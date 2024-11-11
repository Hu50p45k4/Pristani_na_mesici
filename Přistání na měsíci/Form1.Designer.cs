
namespace Přistání_na_měsíci
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.poleVyska = new System.Windows.Forms.TextBox();
            this.poleRychlost = new System.Windows.Forms.TextBox();
            this.poleHmotnost = new System.Windows.Forms.TextBox();
            this.poleProcenta = new System.Windows.Forms.TextBox();
            this.tlacitkoBrzdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Výška (m):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rychlost (m/s):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hmotnost paliva (kg):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Procenta brzdění (0-100):";
            // 
            // poleVyska
            // 
            this.poleVyska.Enabled = false;
            this.poleVyska.Location = new System.Drawing.Point(270, 30);
            this.poleVyska.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.poleVyska.Name = "poleVyska";
            this.poleVyska.Size = new System.Drawing.Size(98, 29);
            this.poleVyska.TabIndex = 4;
            this.poleVyska.Text = "50";
            this.poleVyska.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleRychlost
            // 
            this.poleRychlost.Enabled = false;
            this.poleRychlost.Location = new System.Drawing.Point(270, 100);
            this.poleRychlost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.poleRychlost.Name = "poleRychlost";
            this.poleRychlost.Size = new System.Drawing.Size(98, 29);
            this.poleRychlost.TabIndex = 5;
            this.poleRychlost.Text = "8";
            this.poleRychlost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleHmotnost
            // 
            this.poleHmotnost.Enabled = false;
            this.poleHmotnost.Location = new System.Drawing.Point(270, 181);
            this.poleHmotnost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.poleHmotnost.Name = "poleHmotnost";
            this.poleHmotnost.Size = new System.Drawing.Size(98, 29);
            this.poleHmotnost.TabIndex = 6;
            this.poleHmotnost.Text = "35";
            this.poleHmotnost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleProcenta
            // 
            this.poleProcenta.Location = new System.Drawing.Point(270, 295);
            this.poleProcenta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.poleProcenta.Name = "poleProcenta";
            this.poleProcenta.Size = new System.Drawing.Size(98, 29);
            this.poleProcenta.TabIndex = 7;
            this.poleProcenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tlacitkoBrzdi
            // 
            this.tlacitkoBrzdi.Location = new System.Drawing.Point(124, 384);
            this.tlacitkoBrzdi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tlacitkoBrzdi.Name = "tlacitkoBrzdi";
            this.tlacitkoBrzdi.Size = new System.Drawing.Size(138, 42);
            this.tlacitkoBrzdi.TabIndex = 8;
            this.tlacitkoBrzdi.Text = "Brzdi";
            this.tlacitkoBrzdi.UseVisualStyleBackColor = true;
            this.tlacitkoBrzdi.Click += new System.EventHandler(this.tlacitkoBrzdi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 474);
            this.Controls.Add(this.tlacitkoBrzdi);
            this.Controls.Add(this.poleProcenta);
            this.Controls.Add(this.poleHmotnost);
            this.Controls.Add(this.poleRychlost);
            this.Controls.Add(this.poleVyska);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Přistání na měsíci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox poleVyska;
        private System.Windows.Forms.TextBox poleRychlost;
        private System.Windows.Forms.TextBox poleHmotnost;
        private System.Windows.Forms.TextBox poleProcenta;
        private System.Windows.Forms.Button tlacitkoBrzdi;
    }
}

