namespace SoftwarePrenotazioniCamere
{
    partial class FormAccesso
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
            this.boxNome = new System.Windows.Forms.TextBox();
            this.btnAccedi = new System.Windows.Forms.Button();
            this.lblErrore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxCognome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxNome
            // 
            this.boxNome.Location = new System.Drawing.Point(25, 103);
            this.boxNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(457, 27);
            this.boxNome.TabIndex = 0;
            // 
            // btnAccedi
            // 
            this.btnAccedi.BackColor = System.Drawing.Color.White;
            this.btnAccedi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccedi.Location = new System.Drawing.Point(77, 351);
            this.btnAccedi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccedi.Name = "btnAccedi";
            this.btnAccedi.Size = new System.Drawing.Size(355, 67);
            this.btnAccedi.TabIndex = 1;
            this.btnAccedi.Text = "Accedi";
            this.btnAccedi.UseVisualStyleBackColor = false;
            this.btnAccedi.Click += new System.EventHandler(this.btnAccedi_Click);
            // 
            // lblErrore
            // 
            this.lblErrore.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrore.Location = new System.Drawing.Point(77, 301);
            this.lblErrore.Name = "lblErrore";
            this.lblErrore.Size = new System.Drawing.Size(355, 45);
            this.lblErrore.TabIndex = 2;
            this.lblErrore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(25, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cognome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxCognome
            // 
            this.boxCognome.Location = new System.Drawing.Point(25, 183);
            this.boxCognome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxCognome.Name = "boxCognome";
            this.boxCognome.Size = new System.Drawing.Size(457, 27);
            this.boxCognome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(25, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(25, 267);
            this.boxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(457, 27);
            this.boxPassword.TabIndex = 6;
            // 
            // btnIndietro
            // 
            this.btnIndietro.BackColor = System.Drawing.Color.White;
            this.btnIndietro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIndietro.Location = new System.Drawing.Point(379, 16);
            this.btnIndietro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(103, 49);
            this.btnIndietro.TabIndex = 8;
            this.btnIndietro.Text = "Indietro";
            this.btnIndietro.UseVisualStyleBackColor = false;
            this.btnIndietro.Click += new System.EventHandler(this.btnIndietro_Click);
            // 
            // FormAccesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(511, 469);
            this.Controls.Add(this.btnIndietro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxCognome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErrore);
            this.Controls.Add(this.btnAccedi);
            this.Controls.Add(this.boxNome);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAccesso";
            this.Text = "FormAccesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox boxNome;
        private Button btnAccedi;
        private Label lblErrore;
        private Label label2;
        private Label label3;
        private TextBox boxCognome;
        private Label label4;
        private TextBox boxPassword;
        private Button btnIndietro;
    }
}