namespace SoftwarePrenotazioniCamere
{
    partial class FormDettagliCamera
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
            this.btnIndietro = new System.Windows.Forms.Button();
            this.btnPrenota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTipologia = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblPiano = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSelA = new System.Windows.Forms.Button();
            this.btnSelDa = new System.Windows.Forms.Button();
            this.lblDataA = new System.Windows.Forms.Label();
            this.lblDataDa = new System.Windows.Forms.Label();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPrezzoTotale = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listBoxPrezzi = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblErrore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIndietro
            // 
            this.btnIndietro.BackColor = System.Drawing.Color.White;
            this.btnIndietro.Location = new System.Drawing.Point(715, 248);
            this.btnIndietro.Margin = new System.Windows.Forms.Padding(2);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(239, 36);
            this.btnIndietro.TabIndex = 0;
            this.btnIndietro.Text = "INDIETRO";
            this.btnIndietro.UseVisualStyleBackColor = false;
            this.btnIndietro.Click += new System.EventHandler(this.btnIndietro_Click);
            // 
            // btnPrenota
            // 
            this.btnPrenota.BackColor = System.Drawing.Color.White;
            this.btnPrenota.Location = new System.Drawing.Point(715, 202);
            this.btnPrenota.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrenota.Name = "btnPrenota";
            this.btnPrenota.Size = new System.Drawing.Size(239, 36);
            this.btnPrenota.TabIndex = 1;
            this.btnPrenota.Text = "PRENOTA";
            this.btnPrenota.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dettagli Camera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Piano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipologia:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblDescrizione);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblTipologia);
            this.panel1.Controls.Add(this.lblNumero);
            this.panel1.Controls.Add(this.lblPiano);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(23, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 447);
            this.panel1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(169, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "lblPrezzoPerNotte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(7, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Prezzo per notte:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(122, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 11;
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescrizione.Location = new System.Drawing.Point(126, 305);
            this.lblDescrizione.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(107, 21);
            this.lblDescrizione.TabIndex = 10;
            this.lblDescrizione.Text = "lblDescrizione";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(7, 305);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Descrizione:";
            // 
            // lblTipologia
            // 
            this.lblTipologia.AutoSize = true;
            this.lblTipologia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipologia.Location = new System.Drawing.Point(126, 214);
            this.lblTipologia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipologia.Name = "lblTipologia";
            this.lblTipologia.Size = new System.Drawing.Size(91, 21);
            this.lblTipologia.TabIndex = 8;
            this.lblTipologia.Text = "lblTipologia";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.Location = new System.Drawing.Point(126, 164);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(85, 21);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "lblNumero";
            // 
            // lblPiano
            // 
            this.lblPiano.AutoSize = true;
            this.lblPiano.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPiano.Location = new System.Drawing.Point(126, 116);
            this.lblPiano.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPiano.Name = "lblPiano";
            this.lblPiano.Size = new System.Drawing.Size(66, 21);
            this.lblPiano.TabIndex = 6;
            this.lblPiano.Text = "lblPiano";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(10, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Pernottamento:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.checkedListBox1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(384, 19);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 118);
            this.panel2.TabIndex = 7;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(165, 15);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(127, 76);
            this.checkedListBox1.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(10, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Servizi Aggiuntivi:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblErrore);
            this.panel3.Controls.Add(this.btnSelA);
            this.panel3.Controls.Add(this.btnSelDa);
            this.panel3.Controls.Add(this.lblDataA);
            this.panel3.Controls.Add(this.lblDataDa);
            this.panel3.Controls.Add(this.Calendario);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(384, 141);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 325);
            this.panel3.TabIndex = 8;
            // 
            // btnSelA
            // 
            this.btnSelA.Location = new System.Drawing.Point(179, 282);
            this.btnSelA.Name = "btnSelA";
            this.btnSelA.Size = new System.Drawing.Size(116, 23);
            this.btnSelA.TabIndex = 20;
            this.btnSelA.Text = "Seleziona";
            this.btnSelA.UseVisualStyleBackColor = true;
            this.btnSelA.Click += new System.EventHandler(this.btnSelA_Click);
            // 
            // btnSelDa
            // 
            this.btnSelDa.Location = new System.Drawing.Point(10, 282);
            this.btnSelDa.Name = "btnSelDa";
            this.btnSelDa.Size = new System.Drawing.Size(116, 23);
            this.btnSelDa.TabIndex = 19;
            this.btnSelDa.Text = "Seleziona";
            this.btnSelDa.UseVisualStyleBackColor = true;
            this.btnSelDa.Click += new System.EventHandler(this.btnSelDa_Click);
            // 
            // lblDataA
            // 
            this.lblDataA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDataA.Location = new System.Drawing.Point(179, 243);
            this.lblDataA.Name = "lblDataA";
            this.lblDataA.Size = new System.Drawing.Size(116, 23);
            this.lblDataA.TabIndex = 18;
            this.lblDataA.Text = "A";
            this.lblDataA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataDa
            // 
            this.lblDataDa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDataDa.Location = new System.Drawing.Point(10, 243);
            this.lblDataDa.Name = "lblDataDa";
            this.lblDataDa.Size = new System.Drawing.Size(116, 23);
            this.lblDataDa.TabIndex = 16;
            this.lblDataDa.Text = "Da";
            this.lblDataDa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(44, 42);
            this.Calendario.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 15;
            this.Calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateSelected);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblPrezzoTotale);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.listBoxPrezzi);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(715, 19);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 157);
            this.panel4.TabIndex = 9;
            // 
            // lblPrezzoTotale
            // 
            this.lblPrezzoTotale.AutoSize = true;
            this.lblPrezzoTotale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrezzoTotale.Location = new System.Drawing.Point(96, 113);
            this.lblPrezzoTotale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrezzoTotale.Name = "lblPrezzoTotale";
            this.lblPrezzoTotale.Size = new System.Drawing.Size(113, 21);
            this.lblPrezzoTotale.TabIndex = 20;
            this.lblPrezzoTotale.Text = "lblPrezzoTotale";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(18, 113);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 21);
            this.label13.TabIndex = 19;
            this.label13.Text = "Totale:";
            // 
            // listBoxPrezzi
            // 
            this.listBoxPrezzi.FormattingEnabled = true;
            this.listBoxPrezzi.ItemHeight = 15;
            this.listBoxPrezzi.Location = new System.Drawing.Point(92, 15);
            this.listBoxPrezzi.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPrezzi.Name = "listBoxPrezzi";
            this.listBoxPrezzi.Size = new System.Drawing.Size(127, 79);
            this.listBoxPrezzi.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(18, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 21);
            this.label12.TabIndex = 17;
            this.label12.Text = "Prezzo:";
            // 
            // lblErrore
            // 
            this.lblErrore.Location = new System.Drawing.Point(44, 209);
            this.lblErrore.Name = "lblErrore";
            this.lblErrore.Size = new System.Drawing.Size(227, 23);
            this.lblErrore.TabIndex = 21;
            this.lblErrore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDettagliCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(972, 486);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIndietro);
            this.Controls.Add(this.btnPrenota);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDettagliCamera";
            this.Text = "FormDettagliCamera";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnIndietro;
        private Button btnPrenota;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Label lblDescrizione;
        private Label label8;
        private Label lblTipologia;
        private Label lblNumero;
        private Label lblPiano;
        private Panel panel2;
        private Label label10;
        private Label label9;
        private CheckedListBox checkedListBox1;
        private Label label6;
        private Label label7;
        private Panel panel3;
        private MonthCalendar Calendario;
        private Panel panel4;
        private Label lblPrezzoTotale;
        private Label label13;
        private ListBox listBoxPrezzi;
        private Label label12;
        private Label lblDataA;
        private Label lblDataDa;
        private Button btnSelA;
        private Button btnSelDa;
        private Label lblErrore;
    }
}