using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Теплый_дом
{
    public partial class FormPotrebRieltor : Form
    {
        public FormPotrebRieltor()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agentstvoKleDataSet);

        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agentstvoKleDataSet);

        }

        private void FormPotrebRieltor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentstvoKleDataSet.predlojenia' table. You can move, or remove it, as needed.
            this.predlojeniaTableAdapter.Fill(this.agentstvoKleDataSet.predlojenia);
            // TODO: This line of code loads data into the 'agentstvoKleDataSet.potrbnosti' table. You can move, or remove it, as needed.
            this.potrbnostiTableAdapter.Fill(this.agentstvoKleDataSet.potrbnosti);
            // TODO: This line of code loads data into the 'agentstvoKleDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.agentstvoKleDataSet.Users);
            
            string txtFilter = $"id_Rieltor = '{lbIDRieltor.Text}' and Complete = 'false'";
            bsPotrebnosti.Filter = txtFilter;
            lbIDRieltor.Hide();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPotreb.CurrentRow == null)
            {
                return;
            }

            double MinCost = double.Parse(dgvPotreb.CurrentRow.Cells[2].Value.ToString());
            double MaxCost = double.Parse(dgvPotreb.CurrentRow.Cells[3].Value.ToString());
            int MinStage = int.Parse(dgvPotreb.CurrentRow.Cells[4].Value.ToString());
            int MaxStage = int.Parse(dgvPotreb.CurrentRow.Cells[5].Value.ToString());
            int MinRoom = int.Parse(dgvPotreb.CurrentRow.Cells[6].Value.ToString());
            int MaxRoom = int.Parse(dgvPotreb.CurrentRow.Cells[7].Value.ToString());
            double MinArea = double.Parse(dgvPotreb.CurrentRow.Cells[8].Value.ToString());
            double MaxArea = double.Parse(dgvPotreb.CurrentRow.Cells[9].Value.ToString());
            


            bsPredlojenia.Filter = $@"(Cost >= {MinCost} and Cost <= {MaxCost}) and (Stage >= {MinStage} and Stage <= {MaxStage}) and (Room >= {MinRoom} and Room <= {MaxRoom}) and (Area >= {MinArea} and Area <={MaxArea}) and Complete = 'false'"; 
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (bsPredlojenia.Count == 0 || bsPotrebnosti.Count == 0)
                return;
            int idPotreb = int.Parse(dgvPotreb.CurrentRow.Cells[0].Value.ToString());
            int idPredl = int.Parse(dgvPredloj.CurrentRow.Cells[0].Value.ToString());
            
            SqlConnection con = new SqlConnection(FormAuthorization.TxtCon);
            con.Open();
            string txt = $@"insert into sdelka (id_potrebnost, id_predlojenia, date_Sdelki) values({idPotreb}, {idPredl}, GETDATE())";
            SqlCommand com1 = new SqlCommand(txt, con);
            com1.ExecuteNonQuery();
            con.Close();
            int PrecentProd, precentPok;
            StreamReader sr = new StreamReader(Application.StartupPath + "\\data.txt");
            sr.ReadLine();
            PrecentProd = int.Parse(sr.ReadLine());
            precentPok = int.Parse(sr.ReadLine());
            sr.Close();
            double Sum = double.Parse(dgvPredloj.CurrentRow.Cells[3].Value.ToString());
            double sumProd = Sum * PrecentProd / 100;
            double sumPok = Sum * precentPok / 100;
            Sum += sumPok + sumProd;
            //double komPred = double.Parse(sr.ReadLine());
            //double komPotr = double.Parse(sr.ReadLine());
            //string kPre = dgvPredloj.CurrentRow.Cells[6].Value.ToString();
            //string kPot = dgvPredloj.CurrentRow.Cells[6].Value.ToString();
            //double PredSum = double.Parse(kPre)* 0.01 * komPred;
            //double PotSum = double.Parse(kPot) * 0.01 * komPotr;
            


            dgvPredloj.CurrentRow.Cells[6].Value = "true";
            bsPredlojenia.EndEdit();
            this.predlojeniaTableAdapter.Update(this.agentstvoKleDataSet.predlojenia);

            dgvPotreb.CurrentRow.Cells[10].Value = "true";
            bsPotrebnosti.EndEdit();
            this.potrbnostiTableAdapter.Update(this.agentstvoKleDataSet.potrbnosti);

            MessageBox.Show($@"Сделка заключина.Сумма оплаты:{Sum} 
Сумма комисси для клиента-покупателя:{sumPok}  Сумма комиссии для клиента-продавца {sumProd} .", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}
