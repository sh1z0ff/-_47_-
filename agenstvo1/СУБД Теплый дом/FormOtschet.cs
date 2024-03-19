using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace СУБД_Теплый_дом
{
    public partial class FormOtschet : Form
    {
        public FormOtschet()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agentstvoKleDataSet);

        }

        private void FormOtschet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentstvoKleDataSet.SdelkaReport' table. You can move, or remove it, as needed.
            this.sdelkaReportTableAdapter.Fill(this.agentstvoKleDataSet.SdelkaReport);


            // TODO: This line of code loads data into the 'agentstvoKleDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.agentstvoKleDataSet.Users);
            bsSdelkaRep.Filter = $"RieltorProd = {lblID_user.Text} or RieltorPok = {lblID_user.Text}";
            lblID_user.Hide();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Excel.Application exapp = new Excel.Application();
            exapp.Visible = true;
            exapp.Workbooks.Open(Application.StartupPath + "\\report.xlsx", null, true);
            Excel.Worksheet mylist = exapp.Worksheets.get_Item(1);
            int RowExcel = 4;


            for (int i = 0; i <= dgvReport.RowCount - 1; i++)
            {
                DateTime DateSdelka = DateTime.Parse(dgvReport.Rows[i].Cells[2].Value.ToString());
                if (DateSdelka >= dtpBegin.Value.Date && DateSdelka <= dtpEnd.Value.Date)
                {
                    mylist.Cells[ RowExcel, 1] = RowExcel-3;
                    mylist.Cells[ RowExcel, 2] = dgvReport.Rows[i].Cells[0].Value;
                    mylist.Cells[ RowExcel, 3] = dgvReport.Rows[i].Cells[1].Value;
                    mylist.Cells[ RowExcel, 4] = DateSdelka.ToString("dd.MM.yyyy");
                    RowExcel++;
                    
                }
                

            }
            RowExcel--;
            mylist.get_Range("A4:D" + RowExcel).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;


        }
    }
}
