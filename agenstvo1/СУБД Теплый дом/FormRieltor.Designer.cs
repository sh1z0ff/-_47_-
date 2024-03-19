
namespace СУБД_Теплый_дом
{
    partial class FormRieltor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRieltor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.agentstvoKleDataSet1 = new СУБД_Теплый_дом.agentstvoKleDataSet();
            this.famLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usersTableAdapter = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.TableAdapterManager();
            this.btnProfel = new System.Windows.Forms.Button();
            this.btnPotrRieltor = new System.Windows.Forms.Button();
            this.btnOtschet = new System.Windows.Forms.Button();
            this.btnLevenshteinFind = new System.Windows.Forms.Button();
            this.btnDataForRieltor = new System.Windows.Forms.Button();
            this.bsAllRieltor = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.famDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFind = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstvoKleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAllRieltor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(14, 35);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(68, 18);
            famLabel.TabIndex = 2;
            famLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(43, 58);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 92);
            this.panel1.TabIndex = 1;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(88, 58);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 5;
            this.nameLabel1.Text = "label2";
            // 
            // bsUsers
            // 
            this.bsUsers.DataMember = "Users";
            this.bsUsers.DataSource = this.agentstvoKleDataSet1;
            // 
            // agentstvoKleDataSet1
            // 
            this.agentstvoKleDataSet1.DataSetName = "agentstvoKleDataSet";
            this.agentstvoKleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // famLabel1
            // 
            this.famLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Fam", true));
            this.famLabel1.Location = new System.Drawing.Point(88, 35);
            this.famLabel1.Name = "famLabel1";
            this.famLabel1.Size = new System.Drawing.Size(100, 23);
            this.famLabel1.TabIndex = 3;
            this.famLabel1.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Рабочие место: Риелтора ";
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
            // btnProfel
            // 
            this.btnProfel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnProfel.Location = new System.Drawing.Point(17, 112);
            this.btnProfel.Name = "btnProfel";
            this.btnProfel.Size = new System.Drawing.Size(242, 35);
            this.btnProfel.TabIndex = 16;
            this.btnProfel.Text = "Профиль пользователя";
            this.btnProfel.UseVisualStyleBackColor = false;
            this.btnProfel.Click += new System.EventHandler(this.btnProfel_Click);
            // 
            // btnPotrRieltor
            // 
            this.btnPotrRieltor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnPotrRieltor.Location = new System.Drawing.Point(17, 153);
            this.btnPotrRieltor.Name = "btnPotrRieltor";
            this.btnPotrRieltor.Size = new System.Drawing.Size(242, 35);
            this.btnPotrRieltor.TabIndex = 17;
            this.btnPotrRieltor.Text = "Потребности риелтора";
            this.btnPotrRieltor.UseVisualStyleBackColor = false;
            this.btnPotrRieltor.Click += new System.EventHandler(this.btnPotrRieltor_Click);
            // 
            // btnOtschet
            // 
            this.btnOtschet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnOtschet.Location = new System.Drawing.Point(275, 112);
            this.btnOtschet.Name = "btnOtschet";
            this.btnOtschet.Size = new System.Drawing.Size(242, 35);
            this.btnOtschet.TabIndex = 18;
            this.btnOtschet.Text = "Отчеты о сделках";
            this.btnOtschet.UseVisualStyleBackColor = false;
            this.btnOtschet.Click += new System.EventHandler(this.btnOtschet_Click);
            // 
            // btnLevenshteinFind
            // 
            this.btnLevenshteinFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnLevenshteinFind.Location = new System.Drawing.Point(275, 153);
            this.btnLevenshteinFind.Name = "btnLevenshteinFind";
            this.btnLevenshteinFind.Size = new System.Drawing.Size(242, 35);
            this.btnLevenshteinFind.TabIndex = 19;
            this.btnLevenshteinFind.Text = "Нечетный поиск";
            this.btnLevenshteinFind.UseVisualStyleBackColor = false;
            this.btnLevenshteinFind.Click += new System.EventHandler(this.btnLevenshteinFind_Click);
            // 
            // btnDataForRieltor
            // 
            this.btnDataForRieltor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnDataForRieltor.Location = new System.Drawing.Point(275, 194);
            this.btnDataForRieltor.Name = "btnDataForRieltor";
            this.btnDataForRieltor.Size = new System.Drawing.Size(242, 35);
            this.btnDataForRieltor.TabIndex = 20;
            this.btnDataForRieltor.Text = "Данныйе для риелтора";
            this.btnDataForRieltor.UseVisualStyleBackColor = false;
            this.btnDataForRieltor.Click += new System.EventHandler(this.btnDataForRieltor_Click);
            // 
            // bsAllRieltor
            // 
            this.bsAllRieltor.DataMember = "Users";
            this.bsAllRieltor.DataSource = this.agentstvoKleDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.famDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsAllRieltor;
            this.dataGridView1.Location = new System.Drawing.Point(12, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(505, 253);
            this.dataGridView1.TabIndex = 21;
            // 
            // famDataGridViewTextBoxColumn
            // 
            this.famDataGridViewTextBoxColumn.DataPropertyName = "Fam";
            this.famDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.famDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.famDataGridViewTextBoxColumn.Name = "famDataGridViewTextBoxColumn";
            this.famDataGridViewTextBoxColumn.ReadOnly = true;
            this.famDataGridViewTextBoxColumn.Width = 250;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 225;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Поиск по фамилии:";
            // 
            // tbxFind
            // 
            this.tbxFind.Location = new System.Drawing.Point(159, 203);
            this.tbxFind.Name = "tbxFind";
            this.tbxFind.Size = new System.Drawing.Size(100, 26);
            this.tbxFind.TabIndex = 23;
            this.tbxFind.TextChanged += new System.EventHandler(this.tbxFind_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::СУБД_Теплый_дом.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(384, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormRieltor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 500);
            this.Controls.Add(this.tbxFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDataForRieltor);
            this.Controls.Add(this.btnLevenshteinFind);
            this.Controls.Add(this.btnOtschet);
            this.Controls.Add(this.btnPotrRieltor);
            this.Controls.Add(this.btnProfel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRieltor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Агентсво недвижимости \"Теплый дом\"";
            this.Load += new System.EventHandler(this.FormRieltor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstvoKleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAllRieltor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private agentstvoKleDataSet agentstvoKleDataSet1;
        private agentstvoKleDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private agentstvoKleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label famLabel1;
        public System.Windows.Forms.BindingSource bsUsers;
        private System.Windows.Forms.Button btnProfel;
        private System.Windows.Forms.Button btnPotrRieltor;
        private System.Windows.Forms.Button btnOtschet;
        private System.Windows.Forms.Button btnLevenshteinFind;
        private System.Windows.Forms.Button btnDataForRieltor;
        private System.Windows.Forms.BindingSource bsAllRieltor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn famDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFind;
    }
}