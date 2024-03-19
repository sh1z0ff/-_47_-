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
    public partial class FormProfel : Form
    {
        public FormProfel(int n)
        {
            InitializeComponent();
            NumType = n;

        }
        int NumType;
        

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

        private void FormProfel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentstvoKleDataSet.Users' table. You can move, or remove it, as needed.
            
            this.usersTableAdapter.Fill(this.agentstvoKleDataSet.Users);
            
            lblCurrentPass.Hide();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            tbxOldPass.UseSystemPasswordChar = !cbShowPass.Checked;
            tbxNewPass.UseSystemPasswordChar = !cbShowPass.Checked;
        }

        private void btnLoudPhoto_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (openPhoto.ShowDialog() == DialogResult.OK)
                    photoPictureBox.Image = Image.FromFile(openPhoto.FileName);
            }
            catch
            {
                MessageBox.Show("Невозможно загрузить изображение из файла", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClearPhoto_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Очисть фото?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (res == DialogResult.No)
                return;
            else
                photoPictureBox.Image = null;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (tbxNewPass.Text.Trim() != "")
            {
                ClassCheckPass classCheckPass = new ClassCheckPass();
                if (!classCheckPass.CheckPass(tbxNewPass.Text))
                {
                    MessageBox.Show("Пароль не соответствует требованиям безопасности.", "Внимание!", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                if (tbxOldPass.Text != lblCurrentPass.Text)
                {
                    MessageBox.Show("Для сохранения нужно указать старый пароль.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                lblCurrentPass.Text = tbxNewPass.Text;

            }
            


            usersBindingSource.EndEdit();
            this.usersTableAdapter.Update(this.agentstvoKleDataSet.Users);
            Close();
        }
    }

}
