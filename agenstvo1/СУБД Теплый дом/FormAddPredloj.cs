using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace СУБД_Теплый_дом
{
    public partial class FormAddPredloj : Form
    {
        public FormAddPredloj()
        {
            InitializeComponent();
        }
        List<int> lstIdClients = new List<int>();
        private void FormAddPredloj_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentstvoKleDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.agentstvoKleDataSet.Users);
            StreamReader sr = new StreamReader(Application.StartupPath + "\\data.txt");
            string MaxClient = sr.ReadLine();
            sr.Close();
            SqlConnection con = new SqlConnection(FormAuthorization.TxtCon);
            con.Open();
            string Quert = $@"select id_User, Fam+ ' '+ Name FIO 
from Users 
where type = 1 and (select Count(*)
	from potrbnosti
	where id_Client = Users.id_User  and Complete = 'false' ) + (select Count(*)
	from predlojenia
	where id_Client = Users.id_User  and Complete = 'false') <= {MaxClient}";
            SqlCommand com = new SqlCommand(Quert, con);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                cbxClients.Items.Add(read["FIO"]);
                lstIdClients.Add(int.Parse(read["id_User"].ToString()));
            }


            con.Close();
            if (cbxClients.Items.Count > 0)
            {
                cbxClients.SelectedIndex = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(FormAuthorization.TxtCon);
            con.Open();
            string txtQuery = $@"insert into predlojenia(id_Client,id_Realter,
 Cost,Stage,Room,Area,Complete) values({lstIdClients[cbxClients.SelectedIndex]}, {lbIdRealtor.Text}, {tbxCost.Text}, {tbxStage.Text}, {tbxCountRoom.Text}, {tbxArea.Text}, 'false')";
            SqlCommand com = new SqlCommand(txtQuery, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Предложение риелтора успешно добавлены.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    }
}
