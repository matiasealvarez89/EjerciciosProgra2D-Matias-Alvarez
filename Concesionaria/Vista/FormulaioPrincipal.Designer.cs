namespace Vista
{
    partial class FormulaioPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_agergarGerente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_agergarGerente
            // 
            this.btn_agergarGerente.Location = new System.Drawing.Point(1, 12);
            this.btn_agergarGerente.Name = "btn_agergarGerente";
            this.btn_agergarGerente.Size = new System.Drawing.Size(124, 54);
            this.btn_agergarGerente.TabIndex = 0;
            this.btn_agergarGerente.Text = "Agregar Gerente";
            this.btn_agergarGerente.UseVisualStyleBackColor = true;
            this.btn_agergarGerente.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormulaioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(495, 284);
            this.Controls.Add(this.btn_agergarGerente);
            this.Name = "FormulaioPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_agergarGerente;
    }
}
