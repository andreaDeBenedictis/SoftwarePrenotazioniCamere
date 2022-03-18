﻿namespace SoftwarePrenotazioniCamere
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
            this.listBoxVisualizzaSelezioni.ItemHeight = 28;
            this.listBoxVisualizzaSelezioni.Location = new System.Drawing.Point(14, 233);
            this.listBoxVisualizzaSelezioni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxVisualizzaSelezioni.Name = "listBoxVisualizzaSelezioni";
            this.listBoxVisualizzaSelezioni.Size = new System.Drawing.Size(849, 508);
            this.listBoxVisualizzaSelezioni.TabIndex = 0;
            // 
            // btnVisualizzaPrenotazioni
            // 
            this.btnVisualizzaPrenotazioni.BackColor = System.Drawing.Color.White;
            this.btnVisualizzaPrenotazioni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizzaPrenotazioni.Location = new System.Drawing.Point(15, 16);
            this.btnVisualizzaPrenotazioni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVisualizzaPrenotazioni.Name = "btnVisualizzaPrenotazioni";
            this.btnVisualizzaPrenotazioni.Size = new System.Drawing.Size(366, 97);
            this.btnVisualizzaPrenotazioni.TabIndex = 1;
            this.btnVisualizzaPrenotazioni.Text = "Visualizza Prenotazioni";
            this.btnVisualizzaPrenotazioni.UseVisualStyleBackColor = false;
            this.btnVisualizzaPrenotazioni.Click += new System.EventHandler(this.btnVisualizzaPrenotazioni_Click);
            // 
            // btnVisualizzaClienti
            // 
            this.btnVisualizzaClienti.BackColor = System.Drawing.Color.White;
            this.btnVisualizzaClienti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizzaClienti.Location = new System.Drawing.Point(387, 16);
            this.btnVisualizzaClienti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVisualizzaClienti.Name = "btnVisualizzaClienti";
            this.btnVisualizzaClienti.Size = new System.Drawing.Size(366, 97);
            this.btnVisualizzaClienti.TabIndex = 2;
            this.btnVisualizzaClienti.Text = "Visualizza Clienti";
            this.btnVisualizzaClienti.UseVisualStyleBackColor = false;
            this.btnVisualizzaClienti.Click += new System.EventHandler(this.btnVisualizzaClienti_Click);
            // 
            // btnVisualizzaDisponibilitàCamere
            // 
            this.btnVisualizzaDisponibilitàCamere.BackColor = System.Drawing.Color.White;
            this.btnVisualizzaDisponibilitàCamere.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizzaDisponibilitàCamere.Location = new System.Drawing.Point(759, 16);
            this.btnVisualizzaDisponibilitàCamere.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVisualizzaDisponibilitàCamere.Name = "btnVisualizzaDisponibilitàCamere";
            this.btnVisualizzaDisponibilitàCamere.Size = new System.Drawing.Size(366, 97);
            this.btnVisualizzaDisponibilitàCamere.TabIndex = 3;
            this.btnVisualizzaDisponibilitàCamere.Text = "Visualizza disponibilità camere";
            this.btnVisualizzaDisponibilitàCamere.UseVisualStyleBackColor = false;
            this.btnVisualizzaDisponibilitàCamere.Click += new System.EventHandler(this.btnVisualizzaDisponibilitàCamere_Click);
            // 
            // boxRicerca
            // 
            this.boxRicerca.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxRicerca.Location = new System.Drawing.Point(387, 149);
            this.boxRicerca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxRicerca.Multiline = true;
            this.boxRicerca.Name = "boxRicerca";
            this.boxRicerca.Size = new System.Drawing.Size(476, 43);
            this.boxRicerca.TabIndex = 4;
            // 
            // comboCercaPer
            // 
            this.comboCercaPer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboCercaPer.FormattingEnabled = true;
            this.comboCercaPer.Location = new System.Drawing.Point(15, 149);
            this.comboCercaPer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboCercaPer.Name = "comboCercaPer";
            this.comboCercaPer.Size = new System.Drawing.Size(366, 39);
            this.comboCercaPer.TabIndex = 10;
            this.comboCercaPer.Text = "Ricerca per:";
            this.comboCercaPer.SelectedIndexChanged += new System.EventHandler(this.comboCercaPer_SelectedIndexChanged);
            // 
            // btnPiano1
            // 
            this.btnPiano1.BackColor = System.Drawing.Color.White;
            this.btnPiano1.Enabled = false;
            this.btnPiano1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPiano1.Location = new System.Drawing.Point(870, 233);
            this.btnPiano1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPiano1.Name = "btnPiano1";
            this.btnPiano1.Size = new System.Drawing.Size(255, 97);
            this.btnPiano1.TabIndex = 6;
            this.btnPiano1.Text = "Piano 1";
            this.btnPiano1.UseVisualStyleBackColor = false;
            this.btnPiano1.Click += new System.EventHandler(this.btnPiano1_Click);
            // 
            // btnPiano2
            // 
            this.btnPiano2.BackColor = System.Drawing.Color.White;
            this.btnPiano2.Enabled = false;
            this.btnPiano2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPiano2.Location = new System.Drawing.Point(870, 433);
            this.btnPiano2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPiano2.Name = "btnPiano2";
            this.btnPiano2.Size = new System.Drawing.Size(255, 97);
            this.btnPiano2.TabIndex = 7;
            this.btnPiano2.Text = "Piano 2";
            this.btnPiano2.UseVisualStyleBackColor = false;
            this.btnPiano2.Click += new System.EventHandler(this.btnPiano2_Click);
            // 
            // btnPiano3
            // 
            this.btnPiano3.BackColor = System.Drawing.Color.White;
            this.btnPiano3.Enabled = false;
            this.btnPiano3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPiano3.Location = new System.Drawing.Point(870, 645);
            this.btnPiano3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPiano3.Name = "btnPiano3";
            this.btnPiano3.Size = new System.Drawing.Size(255, 97);
            this.btnPiano3.TabIndex = 8;
            this.btnPiano3.Text = "Piano 3";
            this.btnPiano3.UseVisualStyleBackColor = false;
            this.btnPiano3.Click += new System.EventHandler(this.btnPiano3_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.BackColor = System.Drawing.Color.White;
            this.btnCerca.Enabled = false;
            this.btnCerca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerca.Location = new System.Drawing.Point(870, 149);
            this.btnCerca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(255, 43);
            this.btnCerca.TabIndex = 5;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = false;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // FormMainDipendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1136, 760);
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
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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