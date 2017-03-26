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
    public partial class frmVehicule : Form
    {
        private mdlAutoEcoleContainer mesDonnees;
        public frmVehicule(mdlAutoEcoleContainer mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bdgSourceVehicule.DataSource = mesDonnees.vehicules;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.textBox1.ReadOnly = false;
            this.textBox2.ReadOnly = false;
            this.textBox3.ReadOnly = false;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == " " || textBox2.Text == "" || textBox3.Text == "" )
            {
                MessageBox.Show("Vous devez renseigner tous les champs");
                this.bdgSourceVehicule.CancelEdit();
            }
            this.textBox1.ReadOnly = true;
            this.textBox2.ReadOnly = true;
            this.textBox3.ReadOnly = true;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Vous devez renseigner tous les champs");
                this.bdgSourceVehicule.CancelEdit();
            }
            this.textBox1.ReadOnly = true;
            this.textBox2.ReadOnly = true;
            this.textBox3.ReadOnly = true;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Vous devez renseigner tous les champs");
                this.bdgSourceVehicule.CancelEdit();
            }
            this.textBox1.ReadOnly = true;
            this.textBox2.ReadOnly = true;
            this.textBox3.ReadOnly = true;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Vous devez renseigner tous les champs");
                this.bdgSourceVehicule.CancelEdit();
            }
            this.textBox1.ReadOnly = true;
            this.textBox2.ReadOnly = true;
            this.textBox3.ReadOnly = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.bdgSourceVehicule.EndEdit();
            this.mesDonnees.SaveChanges();
        }
    }
}
