using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace СУБД_Теплый_дом
{
    public partial class FormFindLeven : Form
    {
        public FormFindLeven(int n)
        {
            InitializeComponent();
            NumType = n;
        }
        int NumType;
        
        /// <summary>
        /// вычесление растояния ливенштейна
        /// </summary>
        /// <param name="Txt1">первая строка</param>
        /// <param name="Txt2">вторая строка</param>
        /// <returns>расстояние ливенштейна между двумя строками</returns>
         int Levenshtein(string Txt1, string Txt2)
         {
            
            int CountLev1 = Math.Abs(Txt1.Length - Txt2.Length);
            int MinLev = Math.Min(Txt1.Length, Txt2.Length);
            for (int i = 0; i <= MinLev - 1; i++)
            {
                if (Txt1[i] != Txt2[i])
                    CountLev1++;
            }

            string Txt3 = string.Join("", Txt1.Reverse());
            string Txt4 = string.Join("", Txt2.Reverse());
            int CountLev2 = Math.Abs(Txt3.Length - Txt4.Length);
            for (int i = 0; i <= MinLev - 1; i++)
            {
                if (Txt3[i] != Txt4[i])
                    CountLev2++;
            }
            return Math.Min(CountLev1, CountLev2);
         } 

        struct User
        {
            public string Fam, Name;
        }
        List<User> Lst = new List<User>();

        public void FormFindLeven_Load(object sender, EventArgs e)
        {
            
            SqlConnection ConI = new SqlConnection(FormAuthorization.TxtCon);
            ConI.Open();
            string Quert = $@"SELECT Fam, Name FROM Users where Type = {NumType}";
            SqlCommand Con = new SqlCommand(Quert,ConI);
            SqlDataReader read = Con.ExecuteReader();
            while (read.Read())
            {
                User us = new User();
                us.Fam = (string)read["Fam"];
                us.Name = (string)read["Name"];
                Lst.Add(us);
            }

            ConI.Close();
            label3.Text = Quert;
            btnFindAll_Click(sender, e);
        }

        //public bool Fleven = false;
        //public bool FNameSurname = false;

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvUsers.Rows.Clear();
            foreach (User us in Lst)
            {
                if (rbFam.Checked && Levenshtein(tbxFind.Text, us.Fam) <= 3)
                    dgvUsers.Rows.Add(us.Fam, us.Name);
                else if (rbName.Checked && Levenshtein(tbxFind.Text, us.Name) <= 3)
                    dgvUsers.Rows.Add(us.Fam, us.Name);
            }
            



        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            dgvUsers.Rows.Clear();
            foreach (User us in Lst)
            {
                dgvUsers.Rows.Add(us.Fam, us.Name);
            }
        }
    }
}
