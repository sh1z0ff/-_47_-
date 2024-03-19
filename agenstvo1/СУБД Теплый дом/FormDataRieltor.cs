using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace СУБД_Теплый_дом
{
    public partial class FormDataRieltor : Form
    {
        public FormDataRieltor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\data.txt");
                sw.WriteLine(tbxMaxcountclients.Text);
                sw.WriteLine(tbxKommisiaSPredlojeni.Text);
                sw.WriteLine(tbxKommisiaSPonrebnosti.Text);
                sw.Close();
            }
            catch{ }
            this.Close();
        }

        private void FormDataRieltor_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\data.txt");
                tbxMaxcountclients.Text = sr.ReadLine();
                tbxKommisiaSPredlojeni.Text = sr.ReadLine();
                tbxKommisiaSPonrebnosti.Text = sr.ReadLine();
                sr.Close();
            }
            catch
            {
                tbxMaxcountclients.Text = "2";
                tbxKommisiaSPredlojeni.Text = "2";
                tbxKommisiaSPonrebnosti.Text = "2";
            }
           

        }
    }
}
