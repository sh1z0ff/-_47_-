using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Теплый_дом
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentstvoKleDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.agentstvoKleDataSet1.Users);
            label1.Text = Allclient.Filter;
        }

        private void tbxFindFam_TextChanged(object sender, EventArgs e)
        {
            Allclient.Filter = $"Fam Like'{tbxFindFam.Text}%' and Type = 1";
        }

        private void btnNechetFind_Click(object sender, EventArgs e)
        {
            FormFindLeven frm = new FormFindLeven(1);
            frm.ShowDialog();
            //this.Hide();
        }

        private void btnProfel_Click(object sender, EventArgs e)
        {
            FormProfel frm = new FormProfel(1);
            frm.usersBindingSource.Filter = this.bsUsers.Filter;
            frm.ShowDialog();
            this.usersTableAdapter.Fill(this.agentstvoKleDataSet1.Users);

        }

        private void btnAddPotreb_Click(object sender, EventArgs e)
        {
            FormAddPotreb frm = new FormAddPotreb();
            frm.bsUSPot.Filter = this.bsUsers.Filter;
            frm.ShowDialog();
        }

        private void btnPotrebAndPredloj_Click(object sender, EventArgs e)
        {
            FormPotrebAndPredlClienta frm = new FormPotrebAndPredlClienta();
            frm.bsUserP.Filter = this.bsUsers.Filter;
            frm.ShowDialog();
        }

        private void btnAddPredloj_Click(object sender, EventArgs e)
        {
            FormAddPredloj frm = new FormAddPredloj();
            frm.bsUSPre.Filter = this.bsUsers.Filter;
            frm.ShowDialog();
        }
    }
}
