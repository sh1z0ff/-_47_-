
namespace СУБД_Теплый_дом
{
    partial class formRegistration
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegistration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.agentstvoKleDataSet1 = new СУБД_Теплый_дом.agentstvoKleDataSet();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new СУБД_Теплый_дом.agentstvoKleDataSetTableAdapters.TableAdapterManager();
            this.tbxFam = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.btnLoud = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxShowPass = new System.Windows.Forms.TextBox();
            this.cbLookPAss = new System.Windows.Forms.CheckBox();
            this.openPhoto = new System.Windows.Forms.OpenFileDialog();
            this.lblTypeUser = new System.Windows.Forms.Label();
            this.bsCheckLogin = new System.Windows.Forms.BindingSource(this.components);
            famLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstvoKleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCheckLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(250)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 88);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Регистрация нового клиента";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::СУБД_Теплый_дом.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(372, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // agentstvoKleDataSet1
            // 
            this.agentstvoKleDataSet1.DataSetName = "agentstvoKleDataSet";
            this.agentstvoKleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsUsers
            // 
            this.bsUsers.DataMember = "Users";
            this.bsUsers.DataSource = this.agentstvoKleDataSet1;
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
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(88, 103);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(68, 18);
            famLabel.TabIndex = 11;
            famLabel.Text = "Фамилия:";
            // 
            // tbxFam
            // 
            this.tbxFam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Fam", true));
            this.tbxFam.Location = new System.Drawing.Point(162, 95);
            this.tbxFam.Name = "tbxFam";
            this.tbxFam.Size = new System.Drawing.Size(161, 26);
            this.tbxFam.TabIndex = 12;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(117, 133);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(39, 18);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Имя:";
            // 
            // tbxName
            // 
            this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Name", true));
            this.tbxName.Location = new System.Drawing.Point(162, 125);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(161, 26);
            this.tbxName.TabIndex = 13;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(105, 171);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(51, 18);
            loginLabel.TabIndex = 13;
            loginLabel.Text = "Логин:";
            // 
            // tbxLogin
            // 
            this.tbxLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Login", true));
            this.tbxLogin.Location = new System.Drawing.Point(162, 163);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(161, 26);
            this.tbxLogin.TabIndex = 14;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(96, 212);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(60, 18);
            passwordLabel.TabIndex = 14;
            passwordLabel.Text = "Пароль:";
            // 
            // tbxPass
            // 
            this.tbxPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Password", true));
            this.tbxPass.Location = new System.Drawing.Point(162, 204);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(161, 26);
            this.tbxPass.TabIndex = 15;
            this.tbxPass.UseSystemPasswordChar = true;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsUsers, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(338, 95);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(172, 147);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 16;
            this.photoPictureBox.TabStop = false;
            // 
            // btnLoud
            // 
            this.btnLoud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnLoud.Location = new System.Drawing.Point(338, 248);
            this.btnLoud.Name = "btnLoud";
            this.btnLoud.Size = new System.Drawing.Size(172, 35);
            this.btnLoud.TabIndex = 17;
            this.btnLoud.Text = "Загрузить фото";
            this.btnLoud.UseVisualStyleBackColor = false;
            this.btnLoud.Click += new System.EventHandler(this.btnLoud_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnClear.Location = new System.Drawing.Point(338, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(172, 35);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Очистить фото";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnReg.Location = new System.Drawing.Point(162, 388);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(161, 35);
            this.btnReg.TabIndex = 19;
            this.btnReg.Text = "Зарегестрироваться";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCansel.Location = new System.Drawing.Point(162, 428);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(161, 49);
            this.btnCansel.TabIndex = 20;
            this.btnCansel.Text = "Отменить регистрацию";
            this.btnCansel.UseVisualStyleBackColor = false;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Подтвердить пароль:";
            // 
            // tbxShowPass
            // 
            this.tbxShowPass.Location = new System.Drawing.Point(162, 236);
            this.tbxShowPass.Name = "tbxShowPass";
            this.tbxShowPass.Size = new System.Drawing.Size(161, 26);
            this.tbxShowPass.TabIndex = 22;
            this.tbxShowPass.UseSystemPasswordChar = true;
            // 
            // cbLookPAss
            // 
            this.cbLookPAss.AutoSize = true;
            this.cbLookPAss.Location = new System.Drawing.Point(162, 268);
            this.cbLookPAss.Name = "cbLookPAss";
            this.cbLookPAss.Size = new System.Drawing.Size(133, 22);
            this.cbLookPAss.TabIndex = 23;
            this.cbLookPAss.Text = "Показать пароль";
            this.cbLookPAss.UseVisualStyleBackColor = true;
            this.cbLookPAss.CheckedChanged += new System.EventHandler(this.cbLookPAss_CheckedChanged);
            // 
            // lblTypeUser
            // 
            this.lblTypeUser.AutoSize = true;
            this.lblTypeUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "Type", true));
            this.lblTypeUser.Location = new System.Drawing.Point(13, 484);
            this.lblTypeUser.Name = "lblTypeUser";
            this.lblTypeUser.Size = new System.Drawing.Size(67, 18);
            this.lblTypeUser.TabIndex = 24;
            this.lblTypeUser.Text = "TypeUser";
            // 
            // bsCheckLogin
            // 
            this.bsCheckLogin.DataMember = "Users";
            this.bsCheckLogin.DataSource = this.agentstvoKleDataSet1;
            // 
            // formRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 511);
            this.Controls.Add(this.lblTypeUser);
            this.Controls.Add(this.cbLookPAss);
            this.Controls.Add(this.tbxShowPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoud);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.tbxFam);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Агенство недвижимости \"Теплый дом\"";
            this.Load += new System.EventHandler(this.formRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentstvoKleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCheckLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private agentstvoKleDataSet agentstvoKleDataSet1;
        private System.Windows.Forms.BindingSource bsUsers;
        private agentstvoKleDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private agentstvoKleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbxFam;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button btnLoud;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxShowPass;
        private System.Windows.Forms.CheckBox cbLookPAss;
        private System.Windows.Forms.OpenFileDialog openPhoto;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Label lblTypeUser;
        private System.Windows.Forms.BindingSource bsCheckLogin;
    }
}