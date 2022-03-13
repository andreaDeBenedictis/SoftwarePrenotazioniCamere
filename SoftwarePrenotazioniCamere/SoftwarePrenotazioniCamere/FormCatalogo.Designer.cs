namespace SoftwarePrenotazioniCamere
{
    partial class FormCatalogo
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
            this.boxListaCamere = new System.Windows.Forms.ListBox();
            this.btnPiano1 = new System.Windows.Forms.Button();
            this.btnPiano3 = new System.Windows.Forms.Button();
            this.btnPiano2 = new System.Windows.Forms.Button();
            this.btnDettagli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxListaCamere
            // 
            this.boxListaCamere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxListaCamere.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxListaCamere.FormattingEnabled = true;
            this.boxListaCamere.IntegralHeight = false;
            this.boxListaCamere.ItemHeight = 46;
            this.boxListaCamere.Location = new System.Drawing.Point(34, 32);
            this.boxListaCamere.Name = "boxListaCamere";
            this.boxListaCamere.Size = new System.Drawing.Size(571, 469);
            this.boxListaCamere.TabIndex = 0;
            this.boxListaCamere.SelectedIndexChanged += new System.EventHandler(this.boxListaCamere_SelectedIndexChanged);
            // 
            // btnPiano1
            // 
            this.btnPiano1.BackColor = System.Drawing.Color.White;
            this.btnPiano1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPiano1.Location = new System.Drawing.Point(689, 32);
            this.btnPiano1.Name = "btnPiano1";
            this.btnPiano1.Size = new System.Drawing.Size(311, 81);
            this.btnPiano1.TabIndex = 1;
            this.btnPiano1.Text = "Piano 1";
            this.btnPiano1.UseVisualStyleBackColor = false;
            this.btnPiano1.Click += new System.EventHandler(this.btnPiano1_Click);
            // 
            // btnPiano3
            // 
            this.btnPiano3.BackColor = System.Drawing.Color.White;
            this.btnPiano3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPiano3.Location = new System.Drawing.Point(689, 420);
            this.btnPiano3.Name = "btnPiano3";
            this.btnPiano3.Size = new System.Drawing.Size(311, 81);
            this.btnPiano3.TabIndex = 2;
            this.btnPiano3.Text = "Piano 3";
            this.btnPiano3.UseVisualStyleBackColor = false;
            this.btnPiano3.Click += new System.EventHandler(this.btnPiano3_Click);
            // 
            // btnPiano2
            // 
            this.btnPiano2.BackColor = System.Drawing.Color.White;
            this.btnPiano2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPiano2.Location = new System.Drawing.Point(689, 231);
            this.btnPiano2.Name = "btnPiano2";
            this.btnPiano2.Size = new System.Drawing.Size(311, 81);
            this.btnPiano2.TabIndex = 3;
            this.btnPiano2.Text = "Piano 2";
            this.btnPiano2.UseVisualStyleBackColor = false;
            this.btnPiano2.Click += new System.EventHandler(this.btnPiano2_Click);
            // 
            // btnDettagli
            // 
            this.btnDettagli.BackColor = System.Drawing.Color.White;
            this.btnDettagli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDettagli.Location = new System.Drawing.Point(34, 529);
            this.btnDettagli.Name = "btnDettagli";
            this.btnDettagli.Size = new System.Drawing.Size(571, 77);
            this.btnDettagli.TabIndex = 4;
            this.btnDettagli.Text = "Visualizza dettagli";
            this.btnDettagli.UseVisualStyleBackColor = false;
            this.btnDettagli.Click += new System.EventHandler(this.btnDettagli_Click);
            // 
            // FormCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1069, 631);
            this.Controls.Add(this.btnDettagli);
            this.Controls.Add(this.btnPiano2);
            this.Controls.Add(this.btnPiano3);
            this.Controls.Add(this.btnPiano1);
            this.Controls.Add(this.boxListaCamere);
            this.Name = "FormCatalogo";
            this.Text = "FormCatalogo";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox boxListaCamere;
        private Button btnPiano1;
        private Button btnPiano3;
        private Button btnPiano2;
        private Button btnDettagli;
    }
}