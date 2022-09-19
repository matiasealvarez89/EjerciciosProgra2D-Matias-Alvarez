namespace Vista
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
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_Aceptar_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(312, 127);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PlaceholderText = "Aca ingrese";
            this.txt_usuario.Size = new System.Drawing.Size(176, 23);
            this.txt_usuario.TabIndex = 5;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(312, 191);
            this.txt_password.Name = "txt_password";
            this.txt_password.PlaceholderText = "Aca ingrese";
            this.txt_password.Size = new System.Drawing.Size(176, 23);
            this.txt_password.TabIndex = 4;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // btn_Aceptar_Click
            // 
            this.btn_Aceptar_Click.Location = new System.Drawing.Point(324, 255);
            this.btn_Aceptar_Click.Name = "btn_Aceptar_Click";
            this.btn_Aceptar_Click.Size = new System.Drawing.Size(146, 69);
            this.btn_Aceptar_Click.TabIndex = 3;
            this.btn_Aceptar_Click.Text = "Aceptar";
            this.btn_Aceptar_Click.UseVisualStyleBackColor = true;
            this.btn_Aceptar_Click.Click += new System.EventHandler(this.btn_Aceptar_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btn_Aceptar_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_usuario;
        private TextBox txt_password;
        private Button btn_Aceptar_Click;
    }
}