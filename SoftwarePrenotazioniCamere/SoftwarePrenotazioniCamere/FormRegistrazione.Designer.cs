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
            this.boxCodiceFiscale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxCognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrati = new System.Windows.Forms.Button();
            this.boxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAccedi = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(29, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Codice Fiscale";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxCodiceFiscale
            // 
            this.boxCodiceFiscale.Location = new System.Drawing.Point(29, 170);
            this.boxCodiceFiscale.Name = "boxCodiceFiscale";
            this.boxCodiceFiscale.Size = new System.Drawing.Size(400, 23);
            this.boxCodiceFiscale.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(29, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cognome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxCognome
            // 
            this.boxCognome.Location = new System.Drawing.Point(29, 119);
            this.boxCognome.Name = "boxCognome";
            this.boxCognome.Size = new System.Drawing.Size(400, 23);
            this.boxCognome.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(29, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistrati
            // 
            this.btnRegistrati.BackColor = System.Drawing.Color.White;
            this.btnRegistrati.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrati.Location = new System.Drawing.Point(74, 323);
            this.btnRegistrati.Name = "btnRegistrati";
            this.btnRegistrati.Size = new System.Drawing.Size(311, 50);
            this.btnRegistrati.TabIndex = 9;
            this.btnRegistrati.Text = "Registrati";
            this.btnRegistrati.UseVisualStyleBackColor = false;
            this.btnRegistrati.Click += new System.EventHandler(this.btnRegistrati_Click);
            // 
            // boxNome
            // 
            this.boxNome.Location = new System.Drawing.Point(29, 68);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(400, 23);
            this.boxNome.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(29, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(29, 221);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(400, 23);
            this.boxEmail.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(29, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Telefono";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxTelefono
            // 
            this.boxTelefono.Location = new System.Drawing.Point(29, 272);
            this.boxTelefono.Name = "boxTelefono";
            this.boxTelefono.Size = new System.Drawing.Size(400, 23);
            this.boxTelefono.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(456, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 54);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sei già registrato?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccedi
            // 
            this.btnAccedi.BackColor = System.Drawing.Color.White;
            this.btnAccedi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccedi.Location = new System.Drawing.Point(456, 196);
            this.btnAccedi.Name = "btnAccedi";
            this.btnAccedi.Size = new System.Drawing.Size(311, 50);
            this.btnAccedi.TabIndex = 20;
            this.btnAccedi.Text = "Accedi";
            this.btnAccedi.UseVisualStyleBackColor = false;
            this.btnAccedi.Click += new System.EventHandler(this.btnAccedi_Click);
            // 
            // FormRegistrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.btnAccedi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxCodiceFiscale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxCognome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrati);
            this.Controls.Add(this.boxNome);
            this.Name = "FormRegistrazione";
            this.Text = "FormRegistrazione";
            this.Load += new System.EventHandler(this.FormRegistrazione_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox boxCodiceFiscale;
        private Label label3;
        private TextBox boxCognome;
        private Label label2;
        private Button btnRegistrati;
        private TextBox boxNome;
        private Label label1;
        private TextBox boxEmail;
        private Label label5;
        private TextBox boxTelefono;
        private Label label6;
        private Button btnAccedi;
        private SaveFileDialog saveFileDialog1;
    }
}