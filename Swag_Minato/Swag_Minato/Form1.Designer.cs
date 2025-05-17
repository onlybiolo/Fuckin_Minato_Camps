namespace Swag_Minato
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Impostazioni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Impostazioni
            // 
            this.btn_Impostazioni.Location = new System.Drawing.Point(271, 183);
            this.btn_Impostazioni.Name = "btn_Impostazioni";
            this.btn_Impostazioni.Size = new System.Drawing.Size(258, 84);
            this.btn_Impostazioni.TabIndex = 0;
            this.btn_Impostazioni.Text = "IMPOSTAZIONI";
            this.btn_Impostazioni.UseVisualStyleBackColor = true;
            this.btn_Impostazioni.Click += new System.EventHandler(this.btn_Impostazioni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Impostazioni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Impostazioni;
    }
}

