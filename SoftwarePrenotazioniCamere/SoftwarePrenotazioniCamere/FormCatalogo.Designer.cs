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
            this.SuspendLayout();
            // 
            // boxListaCamere
            // 
            this.boxListaCamere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxListaCamere.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxListaCamere.FormattingEnabled = true;
            this.boxListaCamere.IntegralHeight = false;
            this.boxListaCamere.ItemHeight = 31;
            this.boxListaCamere.Location = new System.Drawing.Point(24, 19);
            this.boxListaCamere.Margin = new System.Windows.Forms.Padding(2);
            this.boxListaCamere.Name = "boxListaCamere";
            this.boxListaCamere.Size = new System.Drawing.Size(585, 350);
            this.boxListaCamere.TabIndex = 0;
            this.boxListaCamere.SelectedIndexChanged += new System.EventHandler(this.boxListaCamere_SelectedIndexChanged);
            this.boxListaCamere.DoubleClick += new System.EventHandler(this.boxListaCamere_DoubleClick);
            // 
            // btnPiano1
            // 
            this.btnPiano1.BackColor = System.Drawing.Color.White;
            this.btnPiano1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPiano1.Location = new System.Drawing.Point(652, 19);
            this.btnPiano1.Margin = new System.Windows.Forms.Padding(2);
            this.btnPiano1.Name = "btnPiano1";
            this.btnPiano1.Size = new System.Drawing.Size(218, 49);
            this.btnPiano1.TabIndex = 1;
            this.btnPiano1.Text = "Piano 1";
            this.btnPiano1.UseVisualStyleBackColor = false;
            this.btnPiano1.Click += new System.EventHandler(this.btnPiano1_Click);
            // 
            // btnPiano3
            // 
            this.btnPiano3.BackColor = System.Drawing.Color.White;
            this.btnPiano3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPiano3.Location = new System.Drawing.Point(652, 320);
            this.btnPiano3.Margin = new System.Windows.Forms.Padding(2);
            this.btnPiano3.Name = "btnPiano3";
            this.btnPiano3.Size = new System.Drawing.Size(218, 49);
            this.btnPiano3.TabIndex = 3;
            this.btnPiano3.Text = "Piano 3";
            this.btnPiano3.UseVisualStyleBackColor = false;
            this.btnPiano3.Click += new System.EventHandler(this.btnPiano3_Click);
            // 
            // btnPiano2
            // 
            this.btnPiano2.BackColor = System.Drawing.Color.White;
            this.btnPiano2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPiano2.Location = new System.Drawing.Point(652, 169);
            this.btnPiano2.Margin = new System.Windows.Forms.Padding(2);
            this.btnPiano2.Name = "btnPiano2";
            this.btnPiano2.Size = new System.Drawing.Size(218, 49);
            this.btnPiano2.TabIndex = 2;
            this.btnPiano2.Text = "Piano 2";
            this.btnPiano2.UseVisualStyleBackColor = false;
            this.btnPiano2.Click += new System.EventHandler(this.btnPiano2_Click);
            // 
            // FormCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(911, 400);
            this.Controls.Add(this.btnPiano2);
            this.Controls.Add(this.btnPiano3);
            this.Controls.Add(this.btnPiano1);
            this.Controls.Add(this.boxListaCamere);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCatalogo";
            this.Text = "FormCatalogo";
            this.Load += new System.EventHandler(this.FormCatalogo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox boxListaCamere;
        private Button btnPiano1;
        private Button btnPiano3;
        private Button btnPiano2;
    }
}