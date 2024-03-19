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
    public partial class FormRieltor : Form
    {
        public FormRieltor()
        {
            InitializeComponent();
        }

        private void FormRieltor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentstvoKleDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.agentstvoKleDataSet1.Users);

        }

        private void btnDataForRieltor_Click(object sender, EventArgs e)
        {
            FormDataRieltor frm = new FormDataRieltor();

            frm.ShowDialog();
        }

        private void tbxFind_TextChanged(object sender, EventArgs e)
        {
            bsAllRieltor.Filter = $"Fam Like'{tbxFind.Text}%' and Type = 0";
        }

        private void btnLevenshteinFind_Click(object sender, EventArgs e)
        {
            FormFindLeven frm = new FormFindLeven(0);

            frm.ShowDialog();
        }

        private void btnProfel_Click(object sender, EventArgs e)
        {
            FormProfel frm = new FormProfel(0);
            frm.usersBindingSource.Filter = this.bsUsers.Filter;
            frm.ShowDialog();
            this.usersTableAdapter.Fill(this.agentstvoKleDataSet1.Users);
        }

        private void btnPotrRieltor_Click(object sender, EventArgs e)
        {
            FormPotrebRieltor frm = new FormPotrebRieltor();
            frm.usersBindingSource.Filter = this.bsUsers.Filter;
            frm.ShowDialog();
        }

        private void btnOtschet_Click(object sender, EventArgs e)
        {
            FormOtschet frm = new FormOtschet();
            frm.usersBindingSource.Filter = this.bsUsers.Filter;
            frm.ShowDialog();
        }
    }
}
