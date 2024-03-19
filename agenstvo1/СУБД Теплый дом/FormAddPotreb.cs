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
    public partial class FormAddPotreb : Form
    {
        public FormAddPotreb()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        List<int> lstIdRieltor = new List<int>();
        private void FormAddPotreb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentstvoKleDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.agentstvoKleDataSet1.Users);

            StreamReader sr = new StreamReader(Application.StartupPath + "\\data.txt");
            string MaxClient = sr.ReadLine();
            sr.Close();




            SqlConnection con = new SqlConnection(FormAuthorization.TxtCon);
            con.Open();
            string Quert = $@"select id_User, Fam+ ' '+ Name FIO 
from Users 
where type = 0 and (select Count(*)
	from potrbnosti
	where id_Rieltor = Users.id_User  and Complete = 'false' ) + (select Count(*)
	from predlojenia
	where id_Realter = Users.id_User  and Complete = 'false') <= {MaxClient}";
            SqlCommand com = new SqlCommand(Quert,con);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                cbxRieltor.Items.Add(read["FIO"]);
                lstIdRieltor.Add(int.Parse(read["id_User"].ToString()));
            }


            con.Close();
            if (cbxRieltor.Items.Count > 0)
            {
                cbxRieltor.SelectedIndex = 0;
            }

            lbIdClient.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(FormAuthorization.TxtCon);
            con.Open();
            string txtQuery = $@"insert into potrbnosti(id_Client,id_Rieltor,
 Min_Cost,Max_Cost,Min_Stage,Max_Stage,Min_Room,Max_Room,Min_Area,Max_Area,Complete) values({lbIdClient.Text}, {lstIdRieltor[cbxRieltor.SelectedIndex]},{tbxMinCost.Text},{tbxMaxCost.Text}, {tbxMinStage.Text}, {tbxMaxStage.Text}, {tbxMinCountRoom.Text}, {tbxMaxCountRoom.Text}, {tbxMinArea.Text}, {tbxMaxArea.Text}, 'false')";
            SqlCommand com = new SqlCommand(txtQuery, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Потребности клиента успешно добавлены.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
