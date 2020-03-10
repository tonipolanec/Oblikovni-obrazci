namespace Obrazci
{
    partial class KreiranjeNovogRazreda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNazivRazreda = new System.Windows.Forms.TextBox();
            this.listUcenici = new System.Windows.Forms.ListBox();
            this.listaProfesora = new System.Windows.Forms.ListBox();
            this.buttonPovratak = new System.Windows.Forms.Button();
            this.buttonDodajRazred = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv razreda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odaberi razrednika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(231, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odaberi ucenike";
            // 
            // textBoxNazivRazreda
            // 
            this.textBoxNazivRazreda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxNazivRazreda.Location = new System.Drawing.Point(131, 15);
            this.textBoxNazivRazreda.Name = "textBoxNazivRazreda";
            this.textBoxNazivRazreda.Size = new System.Drawing.Size(88, 26);
            this.textBoxNazivRazreda.TabIndex = 4;
            // 
            // listUcenici
            // 
            this.listUcenici.BackColor = System.Drawing.SystemColors.Control;
            this.listUcenici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUcenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listUcenici.FormattingEnabled = true;
            this.listUcenici.HorizontalScrollbar = true;
            this.listUcenici.ItemHeight = 20;
            this.listUcenici.Location = new System.Drawing.Point(235, 79);
            this.listUcenici.Name = "listUcenici";
            this.listUcenici.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listUcenici.Size = new System.Drawing.Size(226, 160);
            this.listUcenici.TabIndex = 5;
            // 
            // listaProfesora
            // 
            this.listaProfesora.BackColor = System.Drawing.SystemColors.Control;
            this.listaProfesora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaProfesora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listaProfesora.FormattingEnabled = true;
            this.listaProfesora.HorizontalScrollbar = true;
            this.listaProfesora.ItemHeight = 20;
            this.listaProfesora.Location = new System.Drawing.Point(16, 79);
            this.listaProfesora.Name = "listaProfesora";
            this.listaProfesora.Size = new System.Drawing.Size(213, 160);
            this.listaProfesora.TabIndex = 6;
            // 
            // buttonPovratak
            // 
            this.buttonPovratak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonPovratak.Location = new System.Drawing.Point(229, 253);
            this.buttonPovratak.Name = "buttonPovratak";
            this.buttonPovratak.Size = new System.Drawing.Size(113, 29);
            this.buttonPovratak.TabIndex = 9;
            this.buttonPovratak.Text = "Povratak";
            this.buttonPovratak.UseVisualStyleBackColor = true;
            this.buttonPovratak.Click += new System.EventHandler(this.buttonPovratak_Click);
            // 
            // buttonDodajRazred
            // 
            this.buttonDodajRazred.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonDodajRazred.Location = new System.Drawing.Point(348, 245);
            this.buttonDodajRazred.Name = "buttonDodajRazred";
            this.buttonDodajRazred.Size = new System.Drawing.Size(113, 44);
            this.buttonDodajRazred.TabIndex = 8;
            this.buttonDodajRazred.Text = "Dodaj razred";
            this.buttonDodajRazred.UseVisualStyleBackColor = true;
            this.buttonDodajRazred.Click += new System.EventHandler(this.buttonDodajRazred_Click);
            // 
            // KreiranjeNovogRazreda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 300);
            this.Controls.Add(this.buttonPovratak);
            this.Controls.Add(this.buttonDodajRazred);
            this.Controls.Add(this.listaProfesora);
            this.Controls.Add(this.listUcenici);
            this.Controls.Add(this.textBoxNazivRazreda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "KreiranjeNovogRazreda";
            this.Text = "KreiranjeNovogRazreda";
            this.Load += new System.EventHandler(this.KreiranjeNovogRazreda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNazivRazreda;
        private System.Windows.Forms.ListBox listUcenici;
        private System.Windows.Forms.ListBox listaProfesora;
        private System.Windows.Forms.Button buttonPovratak;
        private System.Windows.Forms.Button buttonDodajRazred;
    }
}