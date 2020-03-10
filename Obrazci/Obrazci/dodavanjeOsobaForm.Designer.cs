namespace Obrazci
{
    partial class dodavanjeOsobaForm
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
            this.buttonDodavanjeOsoba = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textIme = new System.Windows.Forms.TextBox();
            this.radioUcenik = new System.Windows.Forms.RadioButton();
            this.radioProfesor = new System.Windows.Forms.RadioButton();
            this.radioRavnatelj = new System.Windows.Forms.RadioButton();
            this.buttonPovratak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDodavanjeOsoba
            // 
            this.buttonDodavanjeOsoba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonDodavanjeOsoba.Location = new System.Drawing.Point(159, 114);
            this.buttonDodavanjeOsoba.Name = "buttonDodavanjeOsoba";
            this.buttonDodavanjeOsoba.Size = new System.Drawing.Size(113, 44);
            this.buttonDodavanjeOsoba.TabIndex = 0;
            this.buttonDodavanjeOsoba.Text = "Dodaj osobu";
            this.buttonDodavanjeOsoba.UseVisualStyleBackColor = true;
            this.buttonDodavanjeOsoba.Click += new System.EventHandler(this.buttonDodavanjeOsoba_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profesija: ";
            // 
            // textIme
            // 
            this.textIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textIme.Location = new System.Drawing.Point(52, 20);
            this.textIme.Name = "textIme";
            this.textIme.Size = new System.Drawing.Size(155, 23);
            this.textIme.TabIndex = 3;
            // 
            // radioUcenik
            // 
            this.radioUcenik.AutoSize = true;
            this.radioUcenik.Checked = true;
            this.radioUcenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioUcenik.Location = new System.Drawing.Point(15, 95);
            this.radioUcenik.Name = "radioUcenik";
            this.radioUcenik.Size = new System.Drawing.Size(69, 21);
            this.radioUcenik.TabIndex = 4;
            this.radioUcenik.TabStop = true;
            this.radioUcenik.Text = "Ucenik";
            this.radioUcenik.UseVisualStyleBackColor = true;
            // 
            // radioProfesor
            // 
            this.radioProfesor.AutoSize = true;
            this.radioProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioProfesor.Location = new System.Drawing.Point(15, 118);
            this.radioProfesor.Name = "radioProfesor";
            this.radioProfesor.Size = new System.Drawing.Size(80, 21);
            this.radioProfesor.TabIndex = 5;
            this.radioProfesor.Text = "Profesor";
            this.radioProfesor.UseVisualStyleBackColor = true;
            // 
            // radioRavnatelj
            // 
            this.radioRavnatelj.AutoSize = true;
            this.radioRavnatelj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioRavnatelj.Location = new System.Drawing.Point(15, 141);
            this.radioRavnatelj.Name = "radioRavnatelj";
            this.radioRavnatelj.Size = new System.Drawing.Size(85, 21);
            this.radioRavnatelj.TabIndex = 6;
            this.radioRavnatelj.Text = "Ravnatelj";
            this.radioRavnatelj.UseVisualStyleBackColor = true;
            // 
            // buttonPovratak
            // 
            this.buttonPovratak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonPovratak.Location = new System.Drawing.Point(159, 164);
            this.buttonPovratak.Name = "buttonPovratak";
            this.buttonPovratak.Size = new System.Drawing.Size(113, 29);
            this.buttonPovratak.TabIndex = 7;
            this.buttonPovratak.Text = "Povratak";
            this.buttonPovratak.UseVisualStyleBackColor = true;
            this.buttonPovratak.Click += new System.EventHandler(this.buttonPovratak_Click);
            // 
            // dodavanjeOsobaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 205);
            this.Controls.Add(this.buttonPovratak);
            this.Controls.Add(this.radioRavnatelj);
            this.Controls.Add(this.radioProfesor);
            this.Controls.Add(this.radioUcenik);
            this.Controls.Add(this.textIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDodavanjeOsoba);
            this.Name = "dodavanjeOsobaForm";
            this.Text = "dodavanjeOsobaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodavanjeOsoba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIme;
        private System.Windows.Forms.RadioButton radioUcenik;
        private System.Windows.Forms.RadioButton radioProfesor;
        private System.Windows.Forms.RadioButton radioRavnatelj;
        private System.Windows.Forms.Button buttonPovratak;
    }
}