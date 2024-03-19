
namespace СУБД_Теплый_дом
{
    partial class FormAddPotreb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPotreb));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxRieltor = new System.Windows.Forms.ComboBox();
            this.tbxMinArea = new System.Windows.Forms.TextBox();
            this.tbxMinCountRoom = new System.Windows.Forms.TextBox();
            this.tbxMinStage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxMinCost = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbIdClient = new System.Windows.Forms.Label();
            this.bsUSPot = new System.Windows.Forms.BindingSource(this.components);
            this.agentstvoKleDataSet1 = new СУБД_Теплый_дом.agentstvoKleDataSet();
            this.usersTableAdapter = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.UsersTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMaxArea = new System.Windows.Forms.TextBox();
            this.tbxMaxCountRoom = new System.Windows.Forms.TextBox();
            this.tbxMaxStage = new System.Windows.Forms.TextBox();
            this.tbxMaxCost = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUSPot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstvoKleDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 97);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление потребности";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::СУБД_Теплый_дом.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(457, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Минимум";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Площадь:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Кол-во комнат:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Цена:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Выберете риелтора дл ваших потребностей:";
            // 
            // cbxRieltor
            // 
            this.cbxRieltor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRieltor.FormattingEnabled = true;
            this.cbxRieltor.Location = new System.Drawing.Point(329, 124);
            this.cbxRieltor.Name = "cbxRieltor";
            this.cbxRieltor.Size = new System.Drawing.Size(174, 26);
            this.cbxRieltor.TabIndex = 9;
            // 
            // tbxMinArea
            // 
            this.tbxMinArea.Location = new System.Drawing.Point(160, 260);
            this.tbxMinArea.Name = "tbxMinArea";
            this.tbxMinArea.Size = new System.Drawing.Size(100, 26);
            this.tbxMinArea.TabIndex = 10;
            // 
            // tbxMinCountRoom
            // 
            this.tbxMinCountRoom.Location = new System.Drawing.Point(160, 308);
            this.tbxMinCountRoom.Name = "tbxMinCountRoom";
            this.tbxMinCountRoom.Size = new System.Drawing.Size(100, 26);
            this.tbxMinCountRoom.TabIndex = 13;
            // 
            // tbxMinStage
            // 
            this.tbxMinStage.Location = new System.Drawing.Point(160, 350);
            this.tbxMinStage.Name = "tbxMinStage";
            this.tbxMinStage.Size = new System.Drawing.Size(100, 26);
            this.tbxMinStage.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Этаж:";
            // 
            // tbxMinCost
            // 
            this.tbxMinCost.Location = new System.Drawing.Point(160, 221);
            this.tbxMinCost.Name = "tbxMinCost";
            this.tbxMinCost.Size = new System.Drawing.Size(100, 26);
            this.tbxMinCost.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(439, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 38);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(439, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 38);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lbIdClient
            // 
            this.lbIdClient.AutoSize = true;
            this.lbIdClient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUSPot, "id_User", true));
            this.lbIdClient.Location = new System.Drawing.Point(13, 391);
            this.lbIdClient.Name = "lbIdClient";
            this.lbIdClient.Size = new System.Drawing.Size(0, 18);
            this.lbIdClient.TabIndex = 24;
            // 
            // bsUSPot
            // 
            this.bsUSPot.DataMember = "Users";
            this.bsUSPot.DataSource = this.agentstvoKleDataSet1;
            // 
            // agentstvoKleDataSet1
            // 
            this.agentstvoKleDataSet1.DataSetName = "agentstvoKleDataSet";
            this.agentstvoKleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Максимум";
            // 
            // tbxMaxArea
            // 
            this.tbxMaxArea.Location = new System.Drawing.Point(311, 260);
            this.tbxMaxArea.Name = "tbxMaxArea";
            this.tbxMaxArea.Size = new System.Drawing.Size(100, 26);
            this.tbxMaxArea.TabIndex = 18;
            // 
            // tbxMaxCountRoom
            // 
            this.tbxMaxCountRoom.Location = new System.Drawing.Point(311, 308);
            this.tbxMaxCountRoom.Name = "tbxMaxCountRoom";
            this.tbxMaxCountRoom.Size = new System.Drawing.Size(100, 26);
            this.tbxMaxCountRoom.TabIndex = 19;
            // 
            // tbxMaxStage
            // 
            this.tbxMaxStage.Location = new System.Drawing.Point(311, 350);
            this.tbxMaxStage.Name = "tbxMaxStage";
            this.tbxMaxStage.Size = new System.Drawing.Size(100, 26);
            this.tbxMaxStage.TabIndex = 20;
            // 
            // tbxMaxCost
            // 
            this.tbxMaxCost.Location = new System.Drawing.Point(311, 221);
            this.tbxMaxCost.Name = "tbxMaxCost";
            this.tbxMaxCost.Size = new System.Drawing.Size(100, 26);
            this.tbxMaxCost.TabIndex = 21;
            // 
            // FormAddPotreb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 416);
            this.Controls.Add(this.lbIdClient);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxMaxCost);
            this.Controls.Add(this.tbxMaxStage);
            this.Controls.Add(this.tbxMaxCountRoom);
            this.Controls.Add(this.tbxMaxArea);
            this.Controls.Add(this.tbxMinCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxMinStage);
            this.Controls.Add(this.tbxMinCountRoom);
            this.Controls.Add(this.tbxMinArea);
            this.Controls.Add(this.cbxRieltor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddPotreb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Агенство недвижимости \"Теплый дом\"";
            this.Load += new System.EventHandler(this.FormAddPotreb_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUSPot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstvoKleDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxRieltor;
        private System.Windows.Forms.TextBox tbxMinArea;
        private System.Windows.Forms.TextBox tbxMinCountRoom;
        private System.Windows.Forms.TextBox tbxMinStage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxMinCost;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbIdClient;
        private agentstvoKleDataSet agentstvoKleDataSet1;
        private agentstvoKleDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        public System.Windows.Forms.BindingSource bsUSPot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMaxArea;
        private System.Windows.Forms.TextBox tbxMaxCountRoom;
        private System.Windows.Forms.TextBox tbxMaxStage;
        private System.Windows.Forms.TextBox tbxMaxCost;
    }
}