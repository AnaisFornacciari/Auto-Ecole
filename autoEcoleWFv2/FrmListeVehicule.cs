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
    public partial class FrmListeVehicule : Form
    {
        private mdlAutoEcoleContainer mesDonnees;
        public FrmListeVehicule(mdlAutoEcoleContainer donnees)
        {
            InitializeComponent();
            this.mesDonnees = donnees;
            this.vehiculeBindingSource.DataSource = donnees.vehicules;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.vehiculeBindingSource.EndEdit();
            this.mesDonnees.SaveChanges();
        }
    }
}
