using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using WindowsFormWeb.DS1TableAdapters;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormWeb
{
    public partial class FormMise_a_jour : Form
    {
        public FormMise_a_jour()
        {
            InitializeComponent();
        }

        private void groupeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS1);
        }

        private void FormMise_a_jour_Load(object sender, EventArgs e)
        {
            this.groupeTableAdapter.Fill(this.dS1.groupe);
        }

        public void actualiser()
        {
            groupeDataGridView.DataSource = null;
            groupeDataGridView.DataSource = new groupeTableAdapter().GetData().ToList();
        }

        private void butsup_Click(object sender, EventArgs e)
        {
            int id = (int)groupeDataGridView.SelectedRows[0].Cells[0].Value;
            ServiceReference1.WebService1SoapClient a = new ServiceReference1.WebService1SoapClient();
            a.supprimer(id);
            this.actualiser();
        }


        private void butaj_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient a = new ServiceReference1.WebService1SoapClient();
            a.ajouter(nomgTextBox.Text);
            this.actualiser();
        }

        private void butmod_Click(object sender, EventArgs e)
        {
            int id = (int)groupeDataGridView.SelectedRows[0].Cells[0].Value;
            ServiceReference1.WebService1SoapClient a = new ServiceReference1.WebService1SoapClient();
            a.modifier(nomgTextBox.Text,id);
            this.actualiser();
        }

        private void butqt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
