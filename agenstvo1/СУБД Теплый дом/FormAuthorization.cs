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

namespace СУБД_Теплый_дом
{
    public partial class FormAuthorization : Form
    {
        public static string TxtCon = @"Data Source=213.155.192.79,3002;Initial Catalog=agentstvoKle;Persist Security Info=True;User ID=u21kleschenkov;Password=vhk5";
        public FormAuthorization()
        {
            InitializeComponent();
        }       
        /// <summary>
        /// генерация символов капчи
        /// </summary>
        /// <returns>Строка текста, содержащая символы капчи</returns>
        string GetCaptcha()
        {

            string Captcha = "";
            string txtchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            
            bool flagdidgit = false;
            Random rnd = new Random();
            for (int i = 1; i <= 3; i++)
            {
               
                char sim = txtchar[rnd.Next(txtchar.Length)];
                if (char.IsDigit(sim))
                    flagdidgit = true;
                Captcha += sim;
                
            }
            if (flagdidgit)
            {
                Captcha += txtchar[rnd.Next(26)];
            }
            else
                Captcha += txtchar[rnd.Next(26, 36)];

                return Captcha;
        }





        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentstvoKleDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.agentstvoKleDataSet1.Users);
            cmbTypeUser.SelectedIndex = 1;
            lblCaptcha.Text = GetCaptcha();
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            tbxPassword.UseSystemPasswordChar = !cbxShowPass.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            //if (lblCaptcha.Text != tbxCaptcha.Text.ToUpper())
            //{
            //    label6.Text = "*Капча введина не правильно!";
            //    lblCaptcha.Text = GetCaptcha();
            //    tbxCaptcha.Clear();
            //    return ;
            //}
                string txFilter = $"Login = '{tbxLogin.Text}' and Password = '{tbxPassword.Text}' and Type = '{cmbTypeUser.SelectedIndex}'";
            bsUsers.Filter = txFilter;
            
            if (bsUsers.Count == 0)
            {
                lMess.Visible = true;
                return;
            }
            if (cmbTypeUser.Text == "Клиент")
            {
                FormClient frm = new FormClient();
                frm.bsUsers.Filter = $"Login ='{tbxLogin.Text}'";
                this.Hide();
                frm.ShowDialog();
                this.Show();

            }
            if (cmbTypeUser.Text == "Риелтер")
            {
                FormRieltor frm = new FormRieltor();
                frm.bsUsers.Filter = $"Login ='{tbxLogin.Text}'";
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
           

            lMess.Visible = false;
            tbxLogin.Clear();
            tbxPassword.Clear();
            tbxLogin.Focus();
            label6.Text = "";
            tbxCaptcha.Clear();
            this.usersTableAdapter.Fill(this.agentstvoKleDataSet1.Users);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblCaptcha.Text = GetCaptcha();
        }

        private void tbxCaptcha_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblCaptcha_Paint(object sender, PaintEventArgs e)
        {
            Random rnd = new Random();
            Color[] color = { Color.Green, Color.Red, Color.Blue, Color.LightGray };
            for (int i = 0; i <= rnd.Next(5,11); i++)
            {
               int x1 =rnd.Next(lblCaptcha.Width);
                int y1 = rnd.Next(lblCaptcha.Height);
                int x2 = rnd.Next(lblCaptcha.Width);
                int y2 = rnd.Next(lblCaptcha.Height);
                Color col = color[rnd.Next(color.Length)];
                e.Graphics.DrawLine(new Pen(col, 1), x1, y1, x2, y2);
            }
        }

        private void lblReg_Click(object sender, EventArgs e)
        {
            formRegistration frm = new formRegistration();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            this.usersTableAdapter.Fill(this.agentstvoKleDataSet1.Users);
        }
    }
}
