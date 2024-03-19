
namespace СУБД_Теплый_дом
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.agentstvoKleDataSet1 = new СУБД_Теплый_дом.agentstvoKleDataSet();
            this.famLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usersTableAdapter = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.TableAdapterManager();
            this.btnPotrebAndPredloj = new System.Windows.Forms.Button();
            this.btnAddPotreb = new System.Windows.Forms.Button();
            this.btnAddPredloj = new System.Windows.Forms.Button();
            this.btnNechetFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFindFam = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.famDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allclient = new System.Windows.Forms.BindingSource(this.components);
            this.btnProfel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstvoKleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Allclient)).BeginInit();
            this.SuspendLayout();
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(12, 40);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(68, 18);
            famLabel.TabIndex = 2;
            famLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(41, 63);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 89);
            this.panel1.TabIndex = 2;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(86, 63);
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
            this.famLabel1.Location = new System.Drawing.Point(86, 40);
            this.famLabel1.Name = "famLabel1";
            this.famLabel1.Size = new System.Drawing.Size(100, 23);
            this.famLabel1.TabIndex = 3;
            this.famLabel1.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Рабочие место клиента:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::СУБД_Теплый_дом.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(862, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 89);
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
            // btnPotrebAndPredloj
            // 
            this.btnPotrebAndPredloj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnPotrebAndPredloj.Location = new System.Drawing.Point(12, 190);
            this.btnPotrebAndPredloj.Name = "btnPotrebAndPredloj";
            this.btnPotrebAndPredloj.Size = new System.Drawing.Size(242, 35);
            this.btnPotrebAndPredloj.TabIndex = 8;
            this.btnPotrebAndPredloj.Text = "Потребности и предложения";
            this.btnPotrebAndPredloj.UseVisualStyleBackColor = false;
            this.btnPotrebAndPredloj.Click += new System.EventHandler(this.btnPotrebAndPredloj_Click);
            // 
            // btnAddPotreb
            // 
            this.btnAddPotreb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnAddPotreb.Location = new System.Drawing.Point(12, 108);
            this.btnAddPotreb.Name = "btnAddPotreb";
            this.btnAddPotreb.Size = new System.Drawing.Size(242, 35);
            this.btnAddPotreb.TabIndex = 9;
            this.btnAddPotreb.Text = "Добавить потребности";
            this.btnAddPotreb.UseVisualStyleBackColor = false;
            this.btnAddPotreb.Click += new System.EventHandler(this.btnAddPotreb_Click);
            // 
            // btnAddPredloj
            // 
            this.btnAddPredloj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnAddPredloj.Location = new System.Drawing.Point(12, 149);
            this.btnAddPredloj.Name = "btnAddPredloj";
            this.btnAddPredloj.Size = new System.Drawing.Size(242, 35);
            this.btnAddPredloj.TabIndex = 10;
            this.btnAddPredloj.Text = "Добавить предложение";
            this.btnAddPredloj.UseVisualStyleBackColor = false;
            this.btnAddPredloj.Click += new System.EventHandler(this.btnAddPredloj_Click);
            // 
            // btnNechetFind
            // 
            this.btnNechetFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnNechetFind.Location = new System.Drawing.Point(301, 108);
            this.btnNechetFind.Name = "btnNechetFind";
            this.btnNechetFind.Size = new System.Drawing.Size(242, 35);
            this.btnNechetFind.TabIndex = 11;
            this.btnNechetFind.Text = "Нечеткий поиск";
            this.btnNechetFind.UseVisualStyleBackColor = false;
            this.btnNechetFind.Click += new System.EventHandler(this.btnNechetFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Поиск по фамилиям:";
            // 
            // tbxFindFam
            // 
            this.tbxFindFam.Location = new System.Drawing.Point(301, 196);
            this.tbxFindFam.Name = "tbxFindFam";
            this.tbxFindFam.Size = new System.Drawing.Size(242, 26);
            this.tbxFindFam.TabIndex = 13;
            this.tbxFindFam.TextChanged += new System.EventHandler(this.tbxFindFam_TextChanged);
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
            this.famDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.Allclient;
            this.dataGridView1.Location = new System.Drawing.Point(32, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(494, 294);
            this.dataGridView1.TabIndex = 14;
            // 
            // famDataGridViewTextBoxColumn
            // 
            this.famDataGridViewTextBoxColumn.DataPropertyName = "Fam";
            this.famDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.famDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.famDataGridViewTextBoxColumn.Name = "famDataGridViewTextBoxColumn";
            this.famDataGridViewTextBoxColumn.ReadOnly = true;
            this.famDataGridViewTextBoxColumn.Width = 245;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 245;
            // 
            // Allclient
            // 
            this.Allclient.DataMember = "Users";
            this.Allclient.DataSource = this.agentstvoKleDataSet1;
            this.Allclient.Filter = "Type =1 ";
            // 
            // btnProfel
            // 
            this.btnProfel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnProfel.Location = new System.Drawing.Point(12, 231);
            this.btnProfel.Name = "btnProfel";
            this.btnProfel.Size = new System.Drawing.Size(242, 35);
            this.btnProfel.TabIndex = 15;
            this.btnProfel.Text = "Профиль пользователя";
            this.btnProfel.UseVisualStyleBackColor = false;
            this.btnProfel.Click += new System.EventHandler(this.btnProfel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 627);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProfel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxFindFam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNechetFind);
            this.Controls.Add(this.btnAddPredloj);
            this.Controls.Add(this.btnAddPotreb);
            this.Controls.Add(this.btnPotrebAndPredloj);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Агентсво недвижимости \"Теплый дом\"";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstvoKleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Allclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private agentstvoKleDataSet agentstvoKleDataSet1;
        private agentstvoKleDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label famLabel1;
        private agentstvoKleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingSource bsUsers;
        private System.Windows.Forms.Button btnPotrebAndPredloj;
        private System.Windows.Forms.Button btnAddPotreb;
        private System.Windows.Forms.Button btnAddPredloj;
        private System.Windows.Forms.Button btnNechetFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFindFam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource Allclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn famDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnProfel;
        private System.Windows.Forms.Label label3;
    }
}