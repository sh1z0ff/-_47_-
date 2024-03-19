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
    public partial class FormPotrebAndPredlClienta : Form
    {
        public FormPotrebAndPredlClienta()
        {
            InitializeComponent();
        }

        private void FormPotrebAndPredlClienta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentstvoKleDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.agentstvoKleDataSet1.Users);
            // TODO: This line of code loads data into the 'agentstvoKleDataSet1.potrbnosti' table. You can move, or remove it, as needed.
            this.potrbnostiTableAdapter.Fill(this.agentstvoKleDataSet1.potrbnosti);
            // TODO: This line of code loads data into the 'agentstvoKleDataSet1.predlojenia' table. You can move, or remove it, as needed.
            this.predlojeniaTableAdapter.Fill(this.agentstvoKleDataSet1.predlojenia);
            bsPotrbnosti.Filter = $"id_Client = '{lbIDUSER.Text}'";
            bsPredlojenia.Filter = $"id_Client = '{lbIDUSER.Text}'";
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                bsPotrbnosti.Filter = $"id_Client = '{lbIDUSER.Text}' and Complete = false";
                bsPredlojenia.Filter = $"id_Client = '{lbIDUSER.Text}' and Complete = false";
            }
            else
            {
                bsPotrbnosti.Filter = $"id_Client = '{lbIDUSER.Text}'";
                bsPredlojenia.Filter = $"id_Client = '{lbIDUSER.Text}'";
            }
            
        }
    }
}
