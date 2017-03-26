using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace autoEcoleWFv2
{
    public partial class frmAjoutLecon : Form
    {
        private mdlAutoEcoleContainer mesDonnees;
        public frmAjoutLecon(mdlAutoEcoleContainer donnees)
        {
            InitializeComponent();
            this.mesDonnees = donnees;
            this.bdgSourceEleve.DataSource = donnees.eleves;
            this.bdgSourceLecon.DataSource = donnees.lecons;
            for (int i = 8; i < 20; i++)
                this.cmbBoxHeure.Items.Add(i);
        }

        private int newNumLecon()
        {
            int n;
            int dernier = (from ra in this.mesDonnees.lecons
                           select ra.id).Max();
            n = dernier + 1;
            return n;
        }

        private lecon nouvellelecon()
        {
            int n = newNumLecon();
            eleve el = (eleve)cmbBoxEleve.SelectedValue;
            DateTime d = this.dtLecon.Value;
            int heureLecon = Convert.ToInt32(this.cmbBoxHeure.SelectedItem);
            int nbHeures = 1;
            if (this.radioButton2.Checked)
                nbHeures = 2;
            lecon l = new lecon();
            l.date = d;
            l.heure = heureLecon;
            l.duree = nbHeures;
            l.id = n;
            l.eleve = el;
            return l;
        }

        private void enregistrerLecon_Click(object sender, EventArgs e)
        {
            this.mesDonnees.lecons.AddObject(nouvellelecon());
            this.mesDonnees.SaveChanges();
        }
    }
}
