
namespace СУБД_Теплый_дом
{
    partial class FormOtschet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOtschet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentstvoKleDataSet = new СУБД_Теплый_дом.agentstvoKleDataSet();
            this.famLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usersTableAdapter = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.TableAdapterManager();
            this.bsSdelkaRep = new System.Windows.Forms.BindingSource(this.components);
            this.sdelkaReportTableAdapter = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.SdelkaReportTableAdapter();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.fIOPokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSdelkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rieltorProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rieltorPokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblID_user = new System.Windows.Forms.Label();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstvoKleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSdelkaRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            famLabel.Location = new System.Drawing.Point(26, 54);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(68, 18);
            famLabel.TabIndex = 2;
            famLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(55, 83);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(39, 18);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Имя:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameLabel1);
            this.panel1.Controls.Add(famLabel);
            this.panel1.Controls.Add(this.famLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 109);
            this.panel1.TabIndex = 3;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel1.Location = new System.Drawing.Point(94, 83);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 5;
            this.nameLabel1.Text = "label2";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.agentstvoKleDataSet;
            // 
            // agentstvoKleDataSet
            // 
            this.agentstvoKleDataSet.DataSetName = "agentstvoKleDataSet";
            this.agentstvoKleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // famLabel1
            // 
            this.famLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Fam", true));
            this.famLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.famLabel1.Location = new System.Drawing.Point(94, 54);
            this.famLabel1.Name = "famLabel1";
            this.famLabel1.Size = new System.Drawing.Size(100, 23);
            this.famLabel1.TabIndex = 3;
            this.famLabel1.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отсчеты о сделках риелтора";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::СУБД_Теплый_дом.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(544, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.potrbnostiTableAdapter = null;
            this.tableAdapterManager.predlojeniaTableAdapter = null;
            this.tableAdapterManager.sdelkaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // bsSdelkaRep
            // 
            this.bsSdelkaRep.DataMember = "SdelkaReport";
            this.bsSdelkaRep.DataSource = this.agentstvoKleDataSet;
            // 
            // sdelkaReportTableAdapter
            // 
            this.sdelkaReportTableAdapter.ClearBeforeFill = true;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AllowUserToResizeColumns = false;
            this.dgvReport.AllowUserToResizeRows = false;
            this.dgvReport.AutoGenerateColumns = false;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIOPokDataGridViewTextBoxColumn,
            this.fIOProdDataGridViewTextBoxColumn,
            this.dateSdelkiDataGridViewTextBoxColumn,
            this.rieltorProdDataGridViewTextBoxColumn,
            this.rieltorPokDataGridViewTextBoxColumn});
            this.dgvReport.DataSource = this.bsSdelkaRep;
            this.dgvReport.Location = new System.Drawing.Point(77, 117);
            this.dgvReport.MultiSelect = false;
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(554, 319);
            this.dgvReport.TabIndex = 4;
            // 
            // fIOPokDataGridViewTextBoxColumn
            // 
            this.fIOPokDataGridViewTextBoxColumn.DataPropertyName = "FIOPok";
            this.fIOPokDataGridViewTextBoxColumn.HeaderText = "ФИО Покупателя";
            this.fIOPokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIOPokDataGridViewTextBoxColumn.Name = "fIOPokDataGridViewTextBoxColumn";
            this.fIOPokDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIOPokDataGridViewTextBoxColumn.Width = 175;
            // 
            // fIOProdDataGridViewTextBoxColumn
            // 
            this.fIOProdDataGridViewTextBoxColumn.DataPropertyName = "FIOProd";
            this.fIOProdDataGridViewTextBoxColumn.HeaderText = "ФИО Продавца";
            this.fIOProdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIOProdDataGridViewTextBoxColumn.Name = "fIOProdDataGridViewTextBoxColumn";
            this.fIOProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIOProdDataGridViewTextBoxColumn.Width = 175;
            // 
            // dateSdelkiDataGridViewTextBoxColumn
            // 
            this.dateSdelkiDataGridViewTextBoxColumn.DataPropertyName = "date_Sdelki";
            this.dateSdelkiDataGridViewTextBoxColumn.HeaderText = "Дата Сделки";
            this.dateSdelkiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateSdelkiDataGridViewTextBoxColumn.Name = "dateSdelkiDataGridViewTextBoxColumn";
            this.dateSdelkiDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateSdelkiDataGridViewTextBoxColumn.Width = 125;
            // 
            // rieltorProdDataGridViewTextBoxColumn
            // 
            this.rieltorProdDataGridViewTextBoxColumn.DataPropertyName = "RieltorProd";
            this.rieltorProdDataGridViewTextBoxColumn.HeaderText = "RieltorProd";
            this.rieltorProdDataGridViewTextBoxColumn.Name = "rieltorProdDataGridViewTextBoxColumn";
            this.rieltorProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.rieltorProdDataGridViewTextBoxColumn.Visible = false;
            // 
            // rieltorPokDataGridViewTextBoxColumn
            // 
            this.rieltorPokDataGridViewTextBoxColumn.DataPropertyName = "RieltorPok";
            this.rieltorPokDataGridViewTextBoxColumn.HeaderText = "RieltorPok";
            this.rieltorPokDataGridViewTextBoxColumn.Name = "rieltorPokDataGridViewTextBoxColumn";
            this.rieltorPokDataGridViewTextBoxColumn.ReadOnly = true;
            this.rieltorPokDataGridViewTextBoxColumn.Visible = false;
            // 
            // lblID_user
            // 
            this.lblID_user.AutoSize = true;
            this.lblID_user.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "id_User", true));
            this.lblID_user.Location = new System.Drawing.Point(13, 545);
            this.lblID_user.Name = "lblID_user";
            this.lblID_user.Size = new System.Drawing.Size(23, 17);
            this.lblID_user.TabIndex = 5;
            this.lblID_user.Text = "---";
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(130, 463);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(200, 24);
            this.dtpBegin.TabIndex = 6;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(371, 463);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 24);
            this.dtpEnd.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Начальная дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Конечная дата";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnExport.Location = new System.Drawing.Point(257, 510);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(187, 35);
            this.btnExport.TabIndex = 20;
            this.btnExport.Text = "Выполнить экспорт в Exle";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormOtschet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 570);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpBegin);
            this.Controls.Add(this.lblID_user);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOtschet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Агенство недвижимости \"Теплый дом\"";
            this.Load += new System.EventHandler(this.FormOtschet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstvoKleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSdelkaRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private agentstvoKleDataSet agentstvoKleDataSet;
        private agentstvoKleDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private agentstvoKleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label famLabel1;
        public System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource bsSdelkaRep;
        private agentstvoKleDataSetTableAdapters.SdelkaReportTableAdapter sdelkaReportTableAdapter;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOPokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSdelkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rieltorProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rieltorPokDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblID_user;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExport;
    }
}