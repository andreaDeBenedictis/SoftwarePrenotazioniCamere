namespace SoftwarePrenotazioniCamere
{
    partial class FormMain
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
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMainDipendente = new System.Windows.Forms.Button();
            this.btnRegistrati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCatalogo.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCatalogo.Location = new System.Drawing.Point(103, 277);
            this.btnCatalogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(457, 76);
            this.btnCatalogo.TabIndex = 0;
            this.btnCatalogo.Text = "Catalogo camere disponibili";
            this.btnCatalogo.UseVisualStyleBackColor = false;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 124);
            this.label1.TabIndex = 1;
            this.label1.Text = "Albergo Girasole";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMainDipendente
            // 
            this.btnMainDipendente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMainDipendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMainDipendente.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMainDipendente.Location = new System.Drawing.Point(103, 411);
            this.btnMainDipendente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainDipendente.Name = "btnMainDipendente";
            this.btnMainDipendente.Size = new System.Drawing.Size(457, 76);
            this.btnMainDipendente.TabIndex = 2;
            this.btnMainDipendente.Text = "Accedi da dipendente";
            this.btnMainDipendente.UseVisualStyleBackColor = false;
            this.btnMainDipendente.Click += new System.EventHandler(this.btnMainDipendente_Click);
            // 
            // btnRegistrati
            // 
            this.btnRegistrati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRegistrati.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrati.Location = new System.Drawing.Point(447, 16);
            this.btnRegistrati.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrati.Name = "btnRegistrati";
            this.btnRegistrati.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRegistrati.Size = new System.Drawing.Size(113, 56);
            this.btnRegistrati.TabIndex = 3;
            this.btnRegistrati.Text = "Registrati";
            this.btnRegistrati.UseVisualStyleBackColor = false;
            this.btnRegistrati.Click += new System.EventHandler(this.btnRegistrati_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 560);
            this.Controls.Add(this.btnRegistrati);
            this.Controls.Add(this.btnMainDipendente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCatalogo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCatalogo;
        private Label label1;
        private Button btnMainDipendente;
        private Button btnRegistrati;
    }
}