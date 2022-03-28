namespace SoftwarePrenotazioniCamere
{
    partial class FormLoginDipendente
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrore = new System.Windows.Forms.Label();
            this.btnInvia = new System.Windows.Forms.Button();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHidden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassword.Location = new System.Drawing.Point(81, 80);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(261, 35);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 35);
            this.label2.TabIndex = 3;
            // 
            // lblErrore
            // 
            this.lblErrore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrore.Location = new System.Drawing.Point(80, 45);
            this.lblErrore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrore.Name = "lblErrore";
            this.lblErrore.Size = new System.Drawing.Size(261, 35);
            this.lblErrore.TabIndex = 4;
            this.lblErrore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(158, 219);
            this.btnInvia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(105, 41);
            this.btnInvia.TabIndex = 2;
            this.btnInvia.Text = "INVIA";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // boxPassword
            // 
            this.boxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxPassword.Location = new System.Drawing.Point(71, 148);
            this.boxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.PasswordChar = '*';
            this.boxPassword.Size = new System.Drawing.Size(271, 34);
            this.boxPassword.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Image = global::SoftwarePrenotazioniCamere.Properties.Resources.eye_icon;
            this.btnShow.Location = new System.Drawing.Point(295, 148);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(47, 34);
            this.btnShow.TabIndex = 7;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHidden
            // 
            this.btnHidden.BackColor = System.Drawing.Color.White;
            this.btnHidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidden.Image = global::SoftwarePrenotazioniCamere.Properties.Resources.hidden_eye_icon;
            this.btnHidden.Location = new System.Drawing.Point(295, 148);
            this.btnHidden.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHidden.Name = "btnHidden";
            this.btnHidden.Size = new System.Drawing.Size(47, 34);
            this.btnHidden.TabIndex = 8;
            this.btnHidden.UseVisualStyleBackColor = false;
            this.btnHidden.Click += new System.EventHandler(this.btnHidden_Click);
            // 
            // FormLoginDipendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(423, 333);
            this.Controls.Add(this.btnHidden);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.lblErrore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPassword);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormLoginDipendente";
            this.Text = "FormMainDipendente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblPassword;
        private Label label1;
        private Label label2;
        private Label lblErrore;
        private Button btnInvia;
        private TextBox boxPassword;
        private Button btnShow;
        private Button btnHidden;
    }
}