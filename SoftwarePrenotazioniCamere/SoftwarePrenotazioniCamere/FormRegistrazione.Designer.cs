namespace SoftwarePrenotazioniCamere
{
    partial class FormRegistrazione
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
            this.label4 = new System.Windows.Forms.Label();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxCognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrati = new System.Windows.Forms.Button();
            this.boxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxTelefono = new System.Windows.Forms.TextBox();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(33, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(33, 227);
            this.boxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(457, 27);
            this.boxPassword.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(33, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cognome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxCognome
            // 
            this.boxCognome.Location = new System.Drawing.Point(33, 159);
            this.boxCognome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxCognome.Name = "boxCognome";
            this.boxCognome.Size = new System.Drawing.Size(457, 27);
            this.boxCognome.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistrati
            // 
            this.btnRegistrati.BackColor = System.Drawing.Color.White;
            this.btnRegistrati.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrati.Location = new System.Drawing.Point(85, 452);
            this.btnRegistrati.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrati.Name = "btnRegistrati";
            this.btnRegistrati.Size = new System.Drawing.Size(355, 67);
            this.btnRegistrati.TabIndex = 9;
            this.btnRegistrati.Text = "Registrati";
            this.btnRegistrati.UseVisualStyleBackColor = false;
            this.btnRegistrati.Click += new System.EventHandler(this.btnRegistrati_Click);
            // 
            // boxNome
            // 
            this.boxNome.Location = new System.Drawing.Point(33, 91);
            this.boxNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(457, 27);
            this.boxNome.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(33, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(33, 295);
            this.boxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(457, 27);
            this.boxEmail.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(33, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Telefono";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxTelefono
            // 
            this.boxTelefono.Location = new System.Drawing.Point(33, 363);
            this.boxTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxTelefono.Name = "boxTelefono";
            this.boxTelefono.Size = new System.Drawing.Size(457, 27);
            this.boxTelefono.TabIndex = 17;
            // 
            // btnIndietro
            // 
            this.btnIndietro.BackColor = System.Drawing.Color.White;
            this.btnIndietro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIndietro.Location = new System.Drawing.Point(398, 16);
            this.btnIndietro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(93, 48);
            this.btnIndietro.TabIndex = 20;
            this.btnIndietro.Text = "Indietro";
            this.btnIndietro.UseVisualStyleBackColor = false;
            this.btnIndietro.Click += new System.EventHandler(this.btnIndietro_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.Location = new System.Drawing.Point(85, 397);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(355, 51);
            this.lblError.TabIndex = 21;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRegistrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(525, 559);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnIndietro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxCognome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrati);
            this.Controls.Add(this.boxNome);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRegistrazione";
            this.Text = "FormRegistrazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox boxPassword;
        private Label label3;
        private TextBox boxCognome;
        private Label label2;
        private Button btnRegistrati;
        private TextBox boxNome;
        private Label label1;
        private TextBox boxEmail;
        private Label label5;
        private TextBox boxTelefono;
        private Button btnIndietro;
        private Label lblError;
    }
}