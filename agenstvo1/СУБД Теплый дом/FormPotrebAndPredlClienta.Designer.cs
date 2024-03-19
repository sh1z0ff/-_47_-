
namespace СУБД_Теплый_дом
{
    partial class FormPotrebAndPredlClienta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPotrebAndPredlClienta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.minCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minStageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxStageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsPotrbnosti = new System.Windows.Forms.BindingSource(this.components);
            this.agentstvoKleDataSet1 = new СУБД_Теплый_дом.agentstvoKleDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsPredlojenia = new System.Windows.Forms.BindingSource(this.components);
            this.predlojeniaTableAdapter = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.predlojeniaTableAdapter();
            this.potrbnostiTableAdapter = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.potrbnostiTableAdapter();
            this.lbIDUSER = new System.Windows.Forms.Label();
            this.bsUserP = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.UsersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPotrbnosti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstvoKleDataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPredlojenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 90);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(122, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Потребности и предложения";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::СУБД_Теплый_дом.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(824, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(402, 22);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Не показыввать не завершенне потребгости и предложения";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 125);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(968, 401);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(960, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Потребности";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.minCostDataGridViewTextBoxColumn,
            this.maxCostDataGridViewTextBoxColumn,
            this.minStageDataGridViewTextBoxColumn,
            this.maxStageDataGridViewTextBoxColumn,
            this.minRoomDataGridViewTextBoxColumn,
            this.maxRoomDataGridViewTextBoxColumn,
            this.minAreaDataGridViewTextBoxColumn,
            this.maxAreaDataGridViewTextBoxColumn,
            this.completeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.bsPotrbnosti;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(954, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // minCostDataGridViewTextBoxColumn
            // 
            this.minCostDataGridViewTextBoxColumn.DataPropertyName = "Min_Cost";
            this.minCostDataGridViewTextBoxColumn.HeaderText = "Мин. Цена";
            this.minCostDataGridViewTextBoxColumn.Name = "minCostDataGridViewTextBoxColumn";
            this.minCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.minCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxCostDataGridViewTextBoxColumn
            // 
            this.maxCostDataGridViewTextBoxColumn.DataPropertyName = "Max_Cost";
            this.maxCostDataGridViewTextBoxColumn.HeaderText = "Макс. Цена";
            this.maxCostDataGridViewTextBoxColumn.Name = "maxCostDataGridViewTextBoxColumn";
            this.maxCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // minStageDataGridViewTextBoxColumn
            // 
            this.minStageDataGridViewTextBoxColumn.DataPropertyName = "Min_Stage";
            this.minStageDataGridViewTextBoxColumn.HeaderText = "Мин. Этаж";
            this.minStageDataGridViewTextBoxColumn.Name = "minStageDataGridViewTextBoxColumn";
            this.minStageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxStageDataGridViewTextBoxColumn
            // 
            this.maxStageDataGridViewTextBoxColumn.DataPropertyName = "Max_Stage";
            this.maxStageDataGridViewTextBoxColumn.HeaderText = "Макс. Этаж";
            this.maxStageDataGridViewTextBoxColumn.Name = "maxStageDataGridViewTextBoxColumn";
            this.maxStageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minRoomDataGridViewTextBoxColumn
            // 
            this.minRoomDataGridViewTextBoxColumn.DataPropertyName = "Min_Room";
            this.minRoomDataGridViewTextBoxColumn.HeaderText = "Мин. кол-во Комнат";
            this.minRoomDataGridViewTextBoxColumn.Name = "minRoomDataGridViewTextBoxColumn";
            this.minRoomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxRoomDataGridViewTextBoxColumn
            // 
            this.maxRoomDataGridViewTextBoxColumn.DataPropertyName = "Max_Room";
            this.maxRoomDataGridViewTextBoxColumn.HeaderText = "Макс. кол-во Комнат";
            this.maxRoomDataGridViewTextBoxColumn.Name = "maxRoomDataGridViewTextBoxColumn";
            this.maxRoomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minAreaDataGridViewTextBoxColumn
            // 
            this.minAreaDataGridViewTextBoxColumn.DataPropertyName = "Min_Area";
            this.minAreaDataGridViewTextBoxColumn.HeaderText = "Мин. Площадь";
            this.minAreaDataGridViewTextBoxColumn.Name = "minAreaDataGridViewTextBoxColumn";
            this.minAreaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxAreaDataGridViewTextBoxColumn
            // 
            this.maxAreaDataGridViewTextBoxColumn.DataPropertyName = "Max_Area";
            this.maxAreaDataGridViewTextBoxColumn.HeaderText = "Макс. Площадь";
            this.maxAreaDataGridViewTextBoxColumn.Name = "maxAreaDataGridViewTextBoxColumn";
            this.maxAreaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // completeDataGridViewCheckBoxColumn
            // 
            this.completeDataGridViewCheckBoxColumn.DataPropertyName = "Complete";
            this.completeDataGridViewCheckBoxColumn.HeaderText = "Завершено";
            this.completeDataGridViewCheckBoxColumn.Name = "completeDataGridViewCheckBoxColumn";
            this.completeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bsPotrbnosti
            // 
            this.bsPotrbnosti.DataMember = "potrbnosti";
            this.bsPotrbnosti.DataSource = this.agentstvoKleDataSet1;
            // 
            // agentstvoKleDataSet1
            // 
            this.agentstvoKleDataSet1.DataSetName = "agentstvoKleDataSet";
            this.agentstvoKleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(960, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Предложения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.stageDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.completeDataGridViewCheckBoxColumn1});
            this.dataGridView2.DataSource = this.bsPredlojenia;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(954, 364);
            this.dataGridView2.TabIndex = 0;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 250;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Площадь";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stageDataGridViewTextBoxColumn
            // 
            this.stageDataGridViewTextBoxColumn.DataPropertyName = "Stage";
            this.stageDataGridViewTextBoxColumn.HeaderText = "Этаж";
            this.stageDataGridViewTextBoxColumn.Name = "stageDataGridViewTextBoxColumn";
            this.stageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Комнат";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // completeDataGridViewCheckBoxColumn1
            // 
            this.completeDataGridViewCheckBoxColumn1.DataPropertyName = "Complete";
            this.completeDataGridViewCheckBoxColumn1.HeaderText = "Завершено";
            this.completeDataGridViewCheckBoxColumn1.Name = "completeDataGridViewCheckBoxColumn1";
            this.completeDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // bsPredlojenia
            // 
            this.bsPredlojenia.DataMember = "predlojenia";
            this.bsPredlojenia.DataSource = this.agentstvoKleDataSet1;
            // 
            // predlojeniaTableAdapter
            // 
            this.predlojeniaTableAdapter.ClearBeforeFill = true;
            // 
            // potrbnostiTableAdapter
            // 
            this.potrbnostiTableAdapter.ClearBeforeFill = true;
            // 
            // lbIDUSER
            // 
            this.lbIDUSER.AutoSize = true;
            this.lbIDUSER.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUserP, "id_User", true));
            this.lbIDUSER.Location = new System.Drawing.Point(956, 97);
            this.lbIDUSER.Name = "lbIDUSER";
            this.lbIDUSER.Size = new System.Drawing.Size(0, 18);
            this.lbIDUSER.TabIndex = 4;
            // 
            // bsUserP
            // 
            this.bsUserP.DataMember = "Users";
            this.bsUserP.DataSource = this.agentstvoKleDataSet1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // FormPotrebAndPredlClienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 526);
            this.Controls.Add(this.lbIDUSER);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPotrebAndPredlClienta";
            this.Text = "Агенство недвижимости \"Теплый дом\"";
            this.Load += new System.EventHandler(this.FormPotrebAndPredlClienta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPotrbnosti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstvoKleDataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPredlojenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private agentstvoKleDataSet agentstvoKleDataSet1;
        private agentstvoKleDataSetTableAdapters.predlojeniaTableAdapter predlojeniaTableAdapter;
        private agentstvoKleDataSetTableAdapters.potrbnostiTableAdapter potrbnostiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completeDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minStageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxStageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label lbIDUSER;
        private agentstvoKleDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        public System.Windows.Forms.BindingSource bsPotrbnosti;
        public System.Windows.Forms.BindingSource bsPredlojenia;
        public System.Windows.Forms.BindingSource bsUserP;
    }
}