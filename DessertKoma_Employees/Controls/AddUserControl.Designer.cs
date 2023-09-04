
namespace DessertKoma_Employees.Controls
{
    partial class AddUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label LoginLabel;
            System.Windows.Forms.Label roleLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserControl));
            this.form_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.info_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.logotype = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.ролиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dessertsKomaDataSet = new DessertKoma_Employees.DessertKomaDataSet();
            this.verificationCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ролиTableAdapter = new DessertKoma_Employees.DessertsKomaDataSetTableAdapters.РолиTableAdapter();
            this.userPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.save_button = new Guna.UI2.WinForms.Guna2Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.password_textBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.seePasswordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.hidePasswordBtn = new Guna.UI2.WinForms.Guna2Button();
            nameLabel = new System.Windows.Forms.Label();
            LoginLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ролиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertsKomaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(42, 159);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(48, 23);
            nameLabel.TabIndex = 79;
            nameLabel.Text = "Имя:";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            LoginLabel.Location = new System.Drawing.Point(42, 107);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new System.Drawing.Size(62, 23);
            LoginLabel.TabIndex = 78;
            LoginLabel.Text = "Логин:";
            LoginLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            roleLabel.Location = new System.Drawing.Point(42, 307);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(52, 23);
            roleLabel.TabIndex = 82;
            roleLabel.Text = "Роль:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(42, 256);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(147, 23);
            phoneLabel.TabIndex = 92;
            phoneLabel.Text = "Номер телефона:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passwordLabel.Location = new System.Drawing.Point(42, 203);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(73, 23);
            passwordLabel.TabIndex = 97;
            passwordLabel.Text = "Пароль:";
            // 
            // form_elipse
            // 
            this.form_elipse.BorderRadius = 25;
            this.form_elipse.TargetControl = this;
            // 
            // info_panel
            // 
            this.info_panel.BackColor = System.Drawing.Color.Transparent;
            this.info_panel.Controls.Add(this.logotype);
            this.info_panel.Controls.Add(this.guna2Button2);
            this.info_panel.Controls.Add(this.closeButton);
            this.info_panel.FillColor = System.Drawing.Color.White;
            this.info_panel.Location = new System.Drawing.Point(-10, -8);
            this.info_panel.Name = "info_panel";
            this.info_panel.ShadowColor = System.Drawing.Color.Black;
            this.info_panel.ShadowDepth = 50;
            this.info_panel.ShadowShift = 2;
            this.info_panel.Size = new System.Drawing.Size(814, 79);
            this.info_panel.TabIndex = 18;
            // 
            // logotype
            // 
            this.logotype.Image = ((System.Drawing.Image)(resources.GetObject("logotype.Image")));
            this.logotype.ImageRotate = 0F;
            this.logotype.Location = new System.Drawing.Point(22, 20);
            this.logotype.Name = "logotype";
            this.logotype.Size = new System.Drawing.Size(134, 49);
            this.logotype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logotype.TabIndex = 15;
            this.logotype.TabStop = false;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.Location = new System.Drawing.Point(1049, 22);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(50, 39);
            this.guna2Button2.TabIndex = 12;
            // 
            // closeButton
            // 
            this.closeButton.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeButton.FillColor = System.Drawing.Color.Transparent;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageSize = new System.Drawing.Size(25, 25);
            this.closeButton.Location = new System.Drawing.Point(750, 20);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(48, 40);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseTransparentBackground = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderRadius = 5;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.nameTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nameTextBox.Location = new System.Drawing.Point(97, 153);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.MaxLength = 100;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderText = "Введите имя";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(395, 29);
            this.nameTextBox.TabIndex = 81;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // loginTextBox
            // 
            this.loginTextBox.BorderRadius = 5;
            this.loginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextBox.DefaultText = "";
            this.loginTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.loginTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.loginTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.loginTextBox.Location = new System.Drawing.Point(111, 101);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginTextBox.MaxLength = 100;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PasswordChar = '\0';
            this.loginTextBox.PlaceholderText = "Введите логин";
            this.loginTextBox.SelectedText = "";
            this.loginTextBox.Size = new System.Drawing.Size(381, 29);
            this.loginTextBox.TabIndex = 80;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // roleComboBox
            // 
            this.roleComboBox.DataSource = this.ролиBindingSource;
            this.roleComboBox.DisplayMember = "Название";
            this.roleComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(100, 299);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(307, 31);
            this.roleComboBox.TabIndex = 89;
            this.roleComboBox.ValueMember = "Номер";
            this.roleComboBox.SelectionChangeCommitted += new System.EventHandler(this.roleComboBox_SelectionChangeCommitted);
            // 
            // ролиBindingSource
            // 
            this.ролиBindingSource.DataMember = "Роли";
            this.ролиBindingSource.DataSource = this.dessertsKomaDataSet;
            // 
            // dessertsKomaDataSet
            // 
            this.dessertsKomaDataSet.DataSetName = "DessertsKomaDataSet";
            this.dessertsKomaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verificationCheckBox
            // 
            this.verificationCheckBox.AutoSize = true;
            this.verificationCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.verificationCheckBox.CheckedState.BorderRadius = 0;
            this.verificationCheckBox.CheckedState.BorderThickness = 0;
            this.verificationCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.verificationCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verificationCheckBox.Location = new System.Drawing.Point(46, 355);
            this.verificationCheckBox.Name = "verificationCheckBox";
            this.verificationCheckBox.Size = new System.Drawing.Size(227, 27);
            this.verificationCheckBox.TabIndex = 91;
            this.verificationCheckBox.Text = "Подтвержден ли аккаунт";
            this.verificationCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.verificationCheckBox.UncheckedState.BorderRadius = 0;
            this.verificationCheckBox.UncheckedState.BorderThickness = 0;
            this.verificationCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.verificationCheckBox.CheckedChanged += new System.EventHandler(this.verificationCheckBox_CheckedChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(195, 249);
            this.phoneTextBox.Mask = "+375 (00) 000-00-00";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(209, 30);
            this.phoneTextBox.TabIndex = 93;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // ролиTableAdapter
            // 
            this.ролиTableAdapter.ClearBeforeFill = true;
            // 
            // userPic
            // 
            this.userPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPic.Image = ((System.Drawing.Image)(resources.GetObject("userPic.Image")));
            this.userPic.ImageRotate = 0F;
            this.userPic.Location = new System.Drawing.Point(548, 101);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(240, 252);
            this.userPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPic.TabIndex = 94;
            this.userPic.TabStop = false;
            this.userPic.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            this.userPic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userPic_MouseClick);
            this.userPic.MouseHover += new System.EventHandler(this.guna2PictureBox1_MouseHover);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.Transparent;
            this.save_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.save_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.save_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.save_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.save_button.FillColor = System.Drawing.Color.Transparent;
            this.save_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.ForeColor = System.Drawing.Color.Black;
            this.save_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.save_button.Image = ((System.Drawing.Image)(resources.GetObject("save_button.Image")));
            this.save_button.ImageSize = new System.Drawing.Size(40, 40);
            this.save_button.Location = new System.Drawing.Point(703, 378);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 57);
            this.save_button.TabIndex = 95;
            this.save_button.UseTransparentBackground = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(51, 397);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(178, 23);
            this.errorLabel.TabIndex = 96;
            this.errorLabel.Text = "!!! Неверные данные";
            this.errorLabel.Visible = false;
            // 
            // password_textBox
            // 
            this.password_textBox.BorderRadius = 5;
            this.password_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_textBox.DefaultText = "";
            this.password_textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.password_textBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.password_textBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.password_textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.password_textBox.Location = new System.Drawing.Point(121, 197);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '•';
            this.password_textBox.PlaceholderText = "Введите пароль";
            this.password_textBox.SelectedText = "";
            this.password_textBox.Size = new System.Drawing.Size(371, 29);
            this.password_textBox.TabIndex = 99;
            // 
            // seePasswordBtn
            // 
            this.seePasswordBtn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.seePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seePasswordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.seePasswordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.seePasswordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.seePasswordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.seePasswordBtn.FillColor = System.Drawing.Color.Transparent;
            this.seePasswordBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seePasswordBtn.ForeColor = System.Drawing.Color.Black;
            this.seePasswordBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.seePasswordBtn.Image = ((System.Drawing.Image)(resources.GetObject("seePasswordBtn.Image")));
            this.seePasswordBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.seePasswordBtn.Location = new System.Drawing.Point(498, 197);
            this.seePasswordBtn.Name = "seePasswordBtn";
            this.seePasswordBtn.Size = new System.Drawing.Size(36, 29);
            this.seePasswordBtn.TabIndex = 100;
            this.seePasswordBtn.Click += new System.EventHandler(this.seePasswordBtn_Click);
            // 
            // hidePasswordBtn
            // 
            this.hidePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidePasswordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hidePasswordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hidePasswordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hidePasswordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hidePasswordBtn.FillColor = System.Drawing.Color.Transparent;
            this.hidePasswordBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hidePasswordBtn.ForeColor = System.Drawing.Color.Black;
            this.hidePasswordBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.hidePasswordBtn.Image = ((System.Drawing.Image)(resources.GetObject("hidePasswordBtn.Image")));
            this.hidePasswordBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.hidePasswordBtn.Location = new System.Drawing.Point(498, 197);
            this.hidePasswordBtn.Name = "hidePasswordBtn";
            this.hidePasswordBtn.Size = new System.Drawing.Size(36, 29);
            this.hidePasswordBtn.TabIndex = 101;
            this.hidePasswordBtn.Visible = false;
            this.hidePasswordBtn.Click += new System.EventHandler(this.hidePasswordBtn_Click);
            // 
            // AddUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.seePasswordBtn);
            this.Controls.Add(this.hidePasswordBtn);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.userPic);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.verificationCheckBox);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(roleLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(LoginLabel);
            this.Controls.Add(this.info_panel);
            this.Name = "AddUserControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.AddUserControl_Load);
            this.info_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ролиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertsKomaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse form_elipse;
        private Guna.UI2.WinForms.Guna2ShadowPanel info_panel;
        private Guna.UI2.WinForms.Guna2PictureBox logotype;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        public Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        public Guna.UI2.WinForms.Guna2TextBox loginTextBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private Guna.UI2.WinForms.Guna2CheckBox verificationCheckBox;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.BindingSource ролиBindingSource;
        private DessertKomaDataSet dessertsKomaDataSet;
        private DessertsKomaDataSetTableAdapters.РолиTableAdapter ролиTableAdapter;
        private Guna.UI2.WinForms.Guna2Button save_button;
        private System.Windows.Forms.Label errorLabel;
        public Guna.UI2.WinForms.Guna2PictureBox userPic;
        private Guna.UI2.WinForms.Guna2TextBox password_textBox;
        private Guna.UI2.WinForms.Guna2Button seePasswordBtn;
        private Guna.UI2.WinForms.Guna2Button hidePasswordBtn;
    }
}
