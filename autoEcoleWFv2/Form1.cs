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
    public partial class Form1 : Form
    {
        private mdlAutoEcoleContainer mesDonnees;
        public Form1()
        {
            InitializeComponent();
            this.mesDonnees = new mdlAutoEcoleContainer();
        }

        private void gérerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ajoutEleve f = new ajoutEleve(this.mesDonnees);
            f.Show();
        }

        private void ajouterUnVéhiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehicule f = new frmVehicule(this.mesDonnees);
            f.Show();
        }

        private void gérerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListeVehicule f = new FrmListeVehicule(this.mesDonnees);
            f.Show();
        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutLecon f = new frmAjoutLecon(this.mesDonnees);
            f.Show();
        }

        private void validerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValiderLecon f = new frmValiderLecon(this.mesDonnees);
            f.Show();
        }
    }
}
