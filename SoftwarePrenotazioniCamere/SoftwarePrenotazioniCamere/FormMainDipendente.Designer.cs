namespace SoftwarePrenotazioniCamere
{
    partial class FormMainDipendente
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
            this.listBoxVisualizzaSelezioni = new System.Windows.Forms.ListBox();
            this.btnVisualizzaPrenotazioni = new System.Windows.Forms.Button();
            this.btnVisualizzaClienti = new System.Windows.Forms.Button();
            this.btnVisualizzaDisponibilitàCamere = new System.Windows.Forms.Button();
            this.boxRicerca = new System.Windows.Forms.TextBox();
            this.comboCercaPer = new System.Windows.Forms.ComboBox();
            this.btnPiano1 = new System.Windows.Forms.Button();
            this.btnPiano2 = new System.Windows.Forms.Button();
            this.btnPiano3 = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxVisualizzaSelezioni
            // 
            this.listBoxVisualizzaSelezioni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxVisualizzaSelezioni.FormattingEnabled = true;
            this.listBoxVisualizzaSelezioni.ItemHeight = 21;
            this.listBoxVisualizzaSelezioni.Location = new System.Drawing.Point(12, 175);
            this.listBoxVisualizzaSelezioni.Name = "listBoxVisualizzaSelezioni";
            this.listBoxVisualizzaSelezioni.Size = new System.Drawing.Size(743, 382);
            this.listBoxVisualizzaSelezioni.TabIndex = 0;
            // 
            // btnVisualizzaPrenotazioni
            // 
            this.btnVisualizzaPrenotazioni.BackColor = System.Drawing.Color.White;
            this.btnVisualizzaPrenotazioni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizzaPrenotazioni.Location = new System.Drawing.Point(13, 12);
            this.btnVisualizzaPrenotazioni.Name = "btnVisualizzaPrenotazioni";
            this.btnVisualizzaPrenotazioni.Size = new System.Drawing.Size(320, 73);
            this.btnVisualizzaPrenotazioni.TabIndex = 1;
            this.btnVisualizzaPrenotazioni.Text = "Visualizza Prenotazioni";
            this.btnVisualizzaPrenotazioni.UseVisualStyleBackColor = false;
            this.btnVisualizzaPrenotazioni.Click += new System.EventHandler(this.btnVisualizzaPrenotazioni_Click);
            // 
            // btnVisualizzaClienti
            // 
            this.btnVisualizzaClienti.BackColor = System.Drawing.Color.White;
            this.btnVisualizzaClienti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizzaClienti.Location = new System.Drawing.Point(339, 12);
            this.btnVisualizzaClienti.Name = "btnVisualizzaClienti";
            this.btnVisualizzaClienti.Size = new System.Drawing.Size(320, 73);
            this.btnVisualizzaClienti.TabIndex = 2;
            this.btnVisualizzaClienti.Text = "Visualizza Clienti";
            this.btnVisualizzaClienti.UseVisualStyleBackColor = false;
            this.btnVisualizzaClienti.Click += new System.EventHandler(this.btnVisualizzaClienti_Click);
            // 
            // btnVisualizzaDisponibilitàCamere
            // 
            this.btnVisualizzaDisponibilitàCamere.BackColor = System.Drawing.Color.White;
            this.btnVisualizzaDisponibilitàCamere.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizzaDisponibilitàCamere.Location = new System.Drawing.Point(664, 12);
            this.btnVisualizzaDisponibilitàCamere.Name = "btnVisualizzaDisponibilitàCamere";
            this.btnVisualizzaDisponibilitàCamere.Size = new System.Drawing.Size(320, 73);
            this.btnVisualizzaDisponibilitàCamere.TabIndex = 7;
            this.btnVisualizzaDisponibilitàCamere.Text = "Visualizza disponibilità camere";
            this.btnVisualizzaDisponibilitàCamere.UseVisualStyleBackColor = false;
            this.btnVisualizzaDisponibilitàCamere.Click += new System.EventHandler(this.btnVisualizzaDisponibilitàCamere_Click);
            // 
            // boxRicerca
            // 
            this.boxRicerca.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxRicerca.Location = new System.Drawing.Point(339, 112);
            this.boxRicerca.Multiline = true;
            this.boxRicerca.Name = "boxRicerca";
            this.boxRicerca.Size = new System.Drawing.Size(417, 33);
            this.boxRicerca.TabIndex = 9;
            // 
            // comboCercaPer
            // 
            this.comboCercaPer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboCercaPer.FormattingEnabled = true;
            this.comboCercaPer.Location = new System.Drawing.Point(13, 112);
            this.comboCercaPer.Name = "comboCercaPer";
            this.comboCercaPer.Size = new System.Drawing.Size(321, 33);
            this.comboCercaPer.TabIndex = 10;
            this.comboCercaPer.Text = "Ricerca per:";
            this.comboCercaPer.SelectedIndexChanged += new System.EventHandler(this.comboCercaPer_SelectedIndexChanged);
            // 
            // btnPiano1
            // 
            this.btnPiano1.BackColor = System.Drawing.Color.White;
            this.btnPiano1.Enabled = false;
            this.btnPiano1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPiano1.Location = new System.Drawing.Point(761, 175);
            this.btnPiano1.Name = "btnPiano1";
            this.btnPiano1.Size = new System.Drawing.Size(223, 73);
            this.btnPiano1.TabIndex = 13;
            this.btnPiano1.Text = "Piano 1";
            this.btnPiano1.UseVisualStyleBackColor = false;
            this.btnPiano1.Click += new System.EventHandler(this.btnPiano1_Click);
            // 
            // btnPiano2
            // 
            this.btnPiano2.BackColor = System.Drawing.Color.White;
            this.btnPiano2.Enabled = false;
            this.btnPiano2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPiano2.Location = new System.Drawing.Point(761, 325);
            this.btnPiano2.Name = "btnPiano2";
            this.btnPiano2.Size = new System.Drawing.Size(223, 73);
            this.btnPiano2.TabIndex = 14;
            this.btnPiano2.Text = "Piano 2";
            this.btnPiano2.UseVisualStyleBackColor = false;
            this.btnPiano2.Click += new System.EventHandler(this.btnPiano2_Click);
            // 
            // btnPiano3
            // 
            this.btnPiano3.BackColor = System.Drawing.Color.White;
            this.btnPiano3.Enabled = false;
            this.btnPiano3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPiano3.Location = new System.Drawing.Point(761, 484);
            this.btnPiano3.Name = "btnPiano3";
            this.btnPiano3.Size = new System.Drawing.Size(223, 73);
            this.btnPiano3.TabIndex = 15;
            this.btnPiano3.Text = "Piano 3";
            this.btnPiano3.UseVisualStyleBackColor = false;
            this.btnPiano3.Click += new System.EventHandler(this.btnPiano3_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.BackColor = System.Drawing.Color.White;
            this.btnCerca.Enabled = false;
            this.btnCerca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerca.Location = new System.Drawing.Point(761, 112);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(223, 32);
            this.btnCerca.TabIndex = 16;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = false;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // FormMainDipendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(994, 570);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.btnPiano3);
            this.Controls.Add(this.btnPiano2);
            this.Controls.Add(this.btnPiano1);
            this.Controls.Add(this.comboCercaPer);
            this.Controls.Add(this.boxRicerca);
            this.Controls.Add(this.btnVisualizzaDisponibilitàCamere);
            this.Controls.Add(this.btnVisualizzaClienti);
            this.Controls.Add(this.btnVisualizzaPrenotazioni);
            this.Controls.Add(this.listBoxVisualizzaSelezioni);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMainDipendente";
            this.Text = "FormMainDipendente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxVisualizzaSelezioni;
        private Button btnVisualizzaPrenotazioni;
        private Button btnVisualizzaClienti;
        private Button btnVisualizzaDisponibilitàCamere;
        private TextBox boxRicerca;
        private ComboBox comboCercaPer;
        private Button btnPiano1;
        private Button btnPiano2;
        private Button btnPiano3;
        private Button btnCerca;
    }
}