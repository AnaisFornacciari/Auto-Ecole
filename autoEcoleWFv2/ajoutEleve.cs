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
    public partial class ajoutEleve : Form
    {
        private mdlAutoEcoleContainer mesDonnees;
        public ajoutEleve(mdlAutoEcoleContainer mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            for (int i = 0; i < 30; i++)
            {
                this.creditHoraire.Items.Add(i);
            }
            this.bdgSourceEleve.DataSource = mesDonnees.eleves;
        }

        private int getNumEleve()
        {
            var reqDernier = (from el in this.mesDonnees.eleves
                              orderby el.id descending
                              select el);
            eleve dernierEleve = reqDernier.First();
            int n = dernierEleve.id + 1;
            return n;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.TBNumero.Text = this.getNumEleve().ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.bdgSourceEleve.EndEdit();
            this.mesDonnees.SaveChanges();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.bdgSourceEleve.EndEdit();
            this.mesDonnees.SaveChanges();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (TBAdresse.Text == "" || TBNom.Text == "" || TBNumero.Text == "" || TBPrenom.Text == "")
            {
                MessageBox.Show("Vous devez remplir tous les champs !");
                this.bdgSourceEleve.CancelEdit();
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            if (TBAdresse.Text == "" || TBNom.Text == "" || TBNumero.Text == "" || TBPrenom.Text == "")
            {
                MessageBox.Show("Vous devez remplir tous les champs !");
                this.bdgSourceEleve.CancelEdit();
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (TBAdresse.Text == "" || TBNom.Text == "" || TBNumero.Text == "" || TBPrenom.Text == "")
            {
                MessageBox.Show("Vous devez remplir tous les champs !");
                this.bdgSourceEleve.CancelEdit();
            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            if (TBAdresse.Text == "" || TBNom.Text == "" || TBNumero.Text == "" || TBPrenom.Text == "")
            {
                MessageBox.Show("Vous devez remplir tous les champs !");
                this.bdgSourceEleve.CancelEdit();
            }
        }
    }
}
