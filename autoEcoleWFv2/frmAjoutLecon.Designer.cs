namespace autoEcoleWFv2
{
    partial class frmAjoutLecon
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxEleve = new System.Windows.Forms.ComboBox();
            this.dtLecon = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxHeure = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.enregistrerLecon = new System.Windows.Forms.Button();
            this.bdgSourceLecon = new System.Windows.Forms.BindingSource(this.components);
            this.bdgSourceEleve = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceLecon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elève ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Heure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Durée";
            // 
            // cmbBoxEleve
            // 
            this.cmbBoxEleve.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "nom", true));
            this.cmbBoxEleve.FormattingEnabled = true;
            this.cmbBoxEleve.Location = new System.Drawing.Point(99, 19);
            this.cmbBoxEleve.Name = "cmbBoxEleve";
            this.cmbBoxEleve.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxEleve.TabIndex = 4;
            // 
            // dtLecon
            // 
            this.dtLecon.Location = new System.Drawing.Point(99, 54);
            this.dtLecon.Name = "dtLecon";
            this.dtLecon.Size = new System.Drawing.Size(200, 20);
            this.dtLecon.TabIndex = 5;
            // 
            // cmbBoxHeure
            // 
            this.cmbBoxHeure.FormattingEnabled = true;
            this.cmbBoxHeure.Location = new System.Drawing.Point(99, 90);
            this.cmbBoxHeure.Name = "cmbBoxHeure";
            this.cmbBoxHeure.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxHeure.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(99, 133);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Une heure";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(99, 160);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Deux heures";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // enregistrerLecon
            // 
            this.enregistrerLecon.Location = new System.Drawing.Point(99, 201);
            this.enregistrerLecon.Name = "enregistrerLecon";
            this.enregistrerLecon.Size = new System.Drawing.Size(75, 23);
            this.enregistrerLecon.TabIndex = 9;
            this.enregistrerLecon.Text = "Enregistrer";
            this.enregistrerLecon.UseVisualStyleBackColor = true;
            this.enregistrerLecon.Click += new System.EventHandler(this.enregistrerLecon_Click);
            // 
            // bdgSourceLecon
            // 
            this.bdgSourceLecon.DataSource = typeof(autoEcoleWFv2.lecon);
            // 
            // bdgSourceEleve
            // 
            this.bdgSourceEleve.DataSource = typeof(autoEcoleWFv2.eleve);
            // 
            // frmAjoutLecon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 262);
            this.Controls.Add(this.enregistrerLecon);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cmbBoxHeure);
            this.Controls.Add(this.dtLecon);
            this.Controls.Add(this.cmbBoxEleve);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAjoutLecon";
            this.Text = "frmAjoutLecon";
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceLecon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBoxEleve;
        private System.Windows.Forms.DateTimePicker dtLecon;
        private System.Windows.Forms.ComboBox cmbBoxHeure;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button enregistrerLecon;
        private System.Windows.Forms.BindingSource bdgSourceLecon;
        private System.Windows.Forms.BindingSource bdgSourceEleve;
    }
}