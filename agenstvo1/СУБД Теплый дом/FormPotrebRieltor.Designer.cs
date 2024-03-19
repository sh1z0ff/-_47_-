
namespace СУБД_Теплый_дом
{
    partial class FormPotrebRieltor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPotrebRieltor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentstvoKleDataSet = new СУБД_Теплый_дом.agentstvoKleDataSet();
            this.famLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usersTableAdapter = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.TableAdapterManager();
            this.potrbnostiTableAdapter = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.potrbnostiTableAdapter();
            this.dgvPotreb = new System.Windows.Forms.DataGridView();
            this.idpotrebnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minStageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxStageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsPotrebnosti = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPredloj = new System.Windows.Forms.DataGridView();
            this.bsPredlojenia = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lbIDRieltor = new System.Windows.Forms.Label();
            this.predlojeniaTableAdapter = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.predlojeniaTableAdapter();
            this.bsSdelka = new System.Windows.Forms.BindingSource(this.components);
            this.id_predlojenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstvoKleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotreb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPotrebnosti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredloj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPredlojenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSdelka)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            famLabel.Location = new System.Drawing.Point(36, 46);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(68, 18);
            famLabel.TabIndex = 2;
            famLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(64, 69);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 100);
            this.panel1.TabIndex = 3;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel1.Location = new System.Drawing.Point(106, 69);
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
            this.famLabel1.Location = new System.Drawing.Point(106, 46);
            this.famLabel1.Name = "famLabel1";
            this.famLabel1.Size = new System.Drawing.Size(100, 23);
            this.famLabel1.TabIndex = 3;
            this.famLabel1.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Потребности связаные с риелтора";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::СУБД_Теплый_дом.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(659, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 100);
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
            this.tableAdapterManager.potrbnostiTableAdapter = this.potrbnostiTableAdapter;
            this.tableAdapterManager.predlojeniaTableAdapter = null;
            this.tableAdapterManager.sdelkaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // potrbnostiTableAdapter
            // 
            this.potrbnostiTableAdapter.ClearBeforeFill = true;
            // 
            // dgvPotreb
            // 
            this.dgvPotreb.AllowUserToAddRows = false;
            this.dgvPotreb.AllowUserToDeleteRows = false;
            this.dgvPotreb.AllowUserToResizeColumns = false;
            this.dgvPotreb.AllowUserToResizeRows = false;
            this.dgvPotreb.AutoGenerateColumns = false;
            this.dgvPotreb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPotreb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpotrebnostDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn,
            this.minCostDataGridViewTextBoxColumn,
            this.maxCostDataGridViewTextBoxColumn,
            this.minStageDataGridViewTextBoxColumn,
            this.maxStageDataGridViewTextBoxColumn,
            this.minRoomDataGridViewTextBoxColumn,
            this.maxRoomDataGridViewTextBoxColumn,
            this.minAreaDataGridViewTextBoxColumn,
            this.maxAreaDataGridViewTextBoxColumn,
            this.completeDataGridViewCheckBoxColumn});
            this.dgvPotreb.DataSource = this.bsPotrebnosti;
            this.dgvPotreb.Location = new System.Drawing.Point(15, 128);
            this.dgvPotreb.Name = "dgvPotreb";
            this.dgvPotreb.ReadOnly = true;
            this.dgvPotreb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPotreb.Size = new System.Drawing.Size(788, 183);
            this.dgvPotreb.TabIndex = 4;
            this.dgvPotreb.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idpotrebnostDataGridViewTextBoxColumn
            // 
            this.idpotrebnostDataGridViewTextBoxColumn.DataPropertyName = "id_potrebnost";
            this.idpotrebnostDataGridViewTextBoxColumn.HeaderText = "id_potrebnost";
            this.idpotrebnostDataGridViewTextBoxColumn.Name = "idpotrebnostDataGridViewTextBoxColumn";
            this.idpotrebnostDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpotrebnostDataGridViewTextBoxColumn.Visible = false;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "id_Client";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "id_Client";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClientDataGridViewTextBoxColumn.Visible = false;
            // 
            // minCostDataGridViewTextBoxColumn
            // 
            this.minCostDataGridViewTextBoxColumn.DataPropertyName = "Min_Cost";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.minCostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.minCostDataGridViewTextBoxColumn.HeaderText = "Мин. Цена";
            this.minCostDataGridViewTextBoxColumn.Name = "minCostDataGridViewTextBoxColumn";
            this.minCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxCostDataGridViewTextBoxColumn
            // 
            this.maxCostDataGridViewTextBoxColumn.DataPropertyName = "Max_Cost";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.maxCostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.maxCostDataGridViewTextBoxColumn.HeaderText = "Макс. Цена";
            this.maxCostDataGridViewTextBoxColumn.Name = "maxCostDataGridViewTextBoxColumn";
            this.maxCostDataGridViewTextBoxColumn.ReadOnly = true;
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
            // bsPotrebnosti
            // 
            this.bsPotrebnosti.DataMember = "potrbnosti";
            this.bsPotrebnosti.DataSource = this.agentstvoKleDataSet;
            // 
            // dgvPredloj
            // 
            this.dgvPredloj.AllowUserToAddRows = false;
            this.dgvPredloj.AllowUserToDeleteRows = false;
            this.dgvPredloj.AllowUserToResizeColumns = false;
            this.dgvPredloj.AllowUserToResizeRows = false;
            this.dgvPredloj.AutoGenerateColumns = false;
            this.dgvPredloj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredloj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_predlojenia,
            this.addressDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.stageDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.completeDataGridViewCheckBoxColumn1});
            this.dgvPredloj.DataSource = this.bsPredlojenia;
            this.dgvPredloj.Location = new System.Drawing.Point(15, 340);
            this.dgvPredloj.Name = "dgvPredloj";
            this.dgvPredloj.ReadOnly = true;
            this.dgvPredloj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredloj.Size = new System.Drawing.Size(788, 183);
            this.dgvPredloj.TabIndex = 5;
            // 
            // bsPredlojenia
            // 
            this.bsPredlojenia.DataMember = "predlojenia";
            this.bsPredlojenia.DataSource = this.agentstvoKleDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список потребностей:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Список предложений:";
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnComplete.Location = new System.Drawing.Point(275, 539);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(242, 35);
            this.btnComplete.TabIndex = 19;
            this.btnComplete.Text = "Заключить сделку";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lbIDRieltor
            // 
            this.lbIDRieltor.AutoSize = true;
            this.lbIDRieltor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "id_User", true));
            this.lbIDRieltor.Location = new System.Drawing.Point(17, 564);
            this.lbIDRieltor.Name = "lbIDRieltor";
            this.lbIDRieltor.Size = new System.Drawing.Size(23, 17);
            this.lbIDRieltor.TabIndex = 20;
            this.lbIDRieltor.Text = "---";
            // 
            // predlojeniaTableAdapter
            // 
            this.predlojeniaTableAdapter.ClearBeforeFill = true;
            // 
            // id_predlojenia
            // 
            this.id_predlojenia.DataPropertyName = "id_predlojenia";
            this.id_predlojenia.HeaderText = "id_predlojenia";
            this.id_predlojenia.Name = "id_predlojenia";
            this.id_predlojenia.ReadOnly = true;
            this.id_predlojenia.Visible = false;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 175;
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
            this.roomDataGridViewTextBoxColumn.HeaderText = "Кол-во Комнат";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.costDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.costDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // completeDataGridViewCheckBoxColumn1
            // 
            this.completeDataGridViewCheckBoxColumn1.DataPropertyName = "Complete";
            this.completeDataGridViewCheckBoxColumn1.HeaderText = "Завершено";
            this.completeDataGridViewCheckBoxColumn1.Name = "completeDataGridViewCheckBoxColumn1";
            this.completeDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.completeDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // FormPotrebRieltor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 586);
            this.Controls.Add(this.lbIDRieltor);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPredloj);
            this.Controls.Add(this.dgvPotreb);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPotrebRieltor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Агенство недвижимости \"Теплый дом\"";
            this.Load += new System.EventHandler(this.FormPotrebRieltor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstvoKleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotreb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPotrebnosti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredloj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPredlojenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSdelka)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPotreb;
        private System.Windows.Forms.DataGridView dgvPredloj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private agentstvoKleDataSetTableAdapters.potrbnostiTableAdapter potrbnostiTableAdapter;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.BindingSource bsPotrebnosti;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpotrebnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minStageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxStageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label lbIDRieltor;
        private System.Windows.Forms.BindingSource bsPredlojenia;
        private agentstvoKleDataSetTableAdapters.predlojeniaTableAdapter predlojeniaTableAdapter;
        private System.Windows.Forms.BindingSource bsSdelka;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_predlojenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completeDataGridViewCheckBoxColumn1;
    }
}