using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibCheckPassword;

namespace СУБД_Теплый_дом
{
    public partial class formRegistration : Form
    {
        public formRegistration()
        {
            InitializeComponent();
        }


        private void formRegistration_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'agentstvoKleDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.agentstvoKleDataSet1.Users);
            bsUsers.AddNew();
            lblTypeUser.Text = "1";
            lblTypeUser.Hide();

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            ClassCheckPass classCheckPass = new ClassCheckPass();
            if (!classCheckPass.CheckPass(tbxPass.Text))
            {
                MessageBox.Show("Пароли не соответствует требованиям!!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbxPass.Text != tbxShowPass.Text)
            {
                MessageBox.Show("Пароли не совпадают!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbxFam.Text.Trim() =="")
            {
                MessageBox.Show("Введите Фамилию", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbxName.Text.Trim() == "")
            {
                MessageBox.Show("Введите имя", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbxLogin.Text.Trim() == "")
            {
                MessageBox.Show("Введите Логин", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbxPass.Text.Trim() == "")
            {
                MessageBox.Show("Введите Пароль", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbxShowPass.Text.Trim() == "")
            {
                MessageBox.Show("Подтвердите пароль", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bsCheckLogin.Filter = $"Login = '{tbxLogin.Text}'";
            if (bsCheckLogin.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            bsUsers.EndEdit();
            this.usersTableAdapter.Update(this.agentstvoKleDataSet1.Users);
            Close();
        }

        private void cbLookPAss_CheckedChanged(object sender, EventArgs e)
        {
            tbxPass.UseSystemPasswordChar = !cbLookPAss.Checked;
            tbxShowPass.UseSystemPasswordChar = !cbLookPAss.Checked;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Очисть фото?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (res == DialogResult.No)
                return;
            else
            photoPictureBox.Image = null;
        }

        private void btnLoud_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if(openPhoto.ShowDialog() == DialogResult.OK)
                    photoPictureBox.Image = Image.FromFile(openPhoto.FileName);
                }
                catch 
                {
                    MessageBox.Show("Невозможно загрузить изображение из файла","Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error  );
                }
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
