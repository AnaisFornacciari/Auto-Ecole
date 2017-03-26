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
    public partial class frmValiderLecon : Form
    {
        private mdlAutoEcoleContainer mesDonnees;
        public frmValiderLecon(mdlAutoEcoleContainer donnees)
        {
            InitializeComponent();
            this.mesDonnees = donnees;
            this.leconBindingSource.DataSource = donnees.lecons;
            this.bdgSourceVehicule.DataSource = donnees.vehicules;
        }
    }
}
