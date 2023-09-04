
namespace DessertKoma_Employees.Controls
{
    partial class UserAccountControl
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
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccountControl));
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.changePasswordButton = new Guna.UI2.WinForms.Guna2Button();
            this.save_email_button = new Guna.UI2.WinForms.Guna2Button();
            this.edit_email_button = new Guna.UI2.WinForms.Guna2Button();
            this.info_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.error_label = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.save_button = new Guna.UI2.WinForms.Guna2Button();
            this.edit_button = new Guna.UI2.WinForms.Guna2Button();
            this.userRoleLabel = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.emailNameLabel = new System.Windows.Forms.Label();
            this.userIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.error_label2 = new System.Windows.Forms.Label();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            emailLabel = new System.Windows.Forms.Label();
            this.info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.Location = new System.Drawing.Point(92, 341);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(55, 23);
            emailLabel.TabIndex = 51;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.emailTextBox.BorderRadius = 10;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.emailTextBox.Location = new System.Drawing.Point(154, 332);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.MaxLength = 100;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "Введите email";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(436, 40);
            this.emailTextBox.TabIndex = 56;
            this.emailTextBox.Visible = false;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.changePasswordButton.BorderRadius = 15;
            this.changePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changePasswordButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changePasswordButton.FillColor = System.Drawing.Color.Black;
            this.changePasswordButton.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.changePasswordButton.ForeColor = System.Drawing.Color.White;
            this.changePasswordButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.changePasswordButton.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePasswordButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.changePasswordButton.Location = new System.Drawing.Point(59, 429);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(223, 44);
            this.changePasswordButton.TabIndex = 55;
            this.changePasswordButton.Text = "Изменить пароль";
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // save_email_button
            // 
            this.save_email_button.BackColor = System.Drawing.Color.Transparent;
            this.save_email_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.save_email_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_email_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.save_email_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.save_email_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.save_email_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.save_email_button.FillColor = System.Drawing.Color.Transparent;
            this.save_email_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_email_button.ForeColor = System.Drawing.Color.Black;
            this.save_email_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.save_email_button.Image = ((System.Drawing.Image)(resources.GetObject("save_email_button.Image")));
            this.save_email_button.ImageSize = new System.Drawing.Size(25, 25);
            this.save_email_button.Location = new System.Drawing.Point(600, 336);
            this.save_email_button.Name = "save_email_button";
            this.save_email_button.PressedColor = System.Drawing.Color.Transparent;
            this.save_email_button.Size = new System.Drawing.Size(39, 34);
            this.save_email_button.TabIndex = 54;
            this.save_email_button.UseTransparentBackground = true;
            this.save_email_button.Visible = false;
            this.save_email_button.Click += new System.EventHandler(this.save_email_button_Click);
            // 
            // edit_email_button
            // 
            this.edit_email_button.BackColor = System.Drawing.Color.Transparent;
            this.edit_email_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.edit_email_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_email_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.edit_email_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.edit_email_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.edit_email_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.edit_email_button.FillColor = System.Drawing.Color.Transparent;
            this.edit_email_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_email_button.ForeColor = System.Drawing.Color.Black;
            this.edit_email_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.edit_email_button.Image = ((System.Drawing.Image)(resources.GetObject("edit_email_button.Image")));
            this.edit_email_button.Location = new System.Drawing.Point(59, 337);
            this.edit_email_button.Name = "edit_email_button";
            this.edit_email_button.PressedColor = System.Drawing.Color.Transparent;
            this.edit_email_button.Size = new System.Drawing.Size(27, 30);
            this.edit_email_button.TabIndex = 53;
            this.edit_email_button.UseTransparentBackground = true;
            this.edit_email_button.Click += new System.EventHandler(this.edit_email_button_Click);
            // 
            // info_panel
            // 
            this.info_panel.BackColor = System.Drawing.Color.Transparent;
            this.info_panel.Controls.Add(this.error_label);
            this.info_panel.Controls.Add(this.userNameLabel);
            this.info_panel.Controls.Add(this.nameTextBox);
            this.info_panel.Controls.Add(this.save_button);
            this.info_panel.Controls.Add(this.edit_button);
            this.info_panel.Controls.Add(this.userRoleLabel);
            this.info_panel.Controls.Add(this.guna2Button2);
            this.info_panel.FillColor = System.Drawing.Color.White;
            this.info_panel.Location = new System.Drawing.Point(24, 91);
            this.info_panel.Name = "info_panel";
            this.info_panel.ShadowColor = System.Drawing.Color.Black;
            this.info_panel.ShadowDepth = 50;
            this.info_panel.ShadowShift = 2;
            this.info_panel.Size = new System.Drawing.Size(1053, 132);
            this.info_panel.TabIndex = 49;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(217, 98);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(194, 20);
            this.error_label.TabIndex = 76;
            this.error_label.Text = "!!! Не все поля заполнены";
            this.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.error_label.Visible = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.Location = new System.Drawing.Point(205, 29);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(77, 38);
            this.userNameLabel.TabIndex = 6;
            this.userNameLabel.Text = "Имя";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.nameTextBox.BorderRadius = 10;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nameTextBox.Location = new System.Drawing.Point(206, 28);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.MaxLength = 100;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderText = "Введите имя";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(436, 40);
            this.nameTextBox.TabIndex = 44;
            this.nameTextBox.Visible = false;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // save_button
            // 
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
            this.save_button.ImageSize = new System.Drawing.Size(30, 30);
            this.save_button.Location = new System.Drawing.Point(649, 26);
            this.save_button.Name = "save_button";
            this.save_button.PressedColor = System.Drawing.Color.Transparent;
            this.save_button.Size = new System.Drawing.Size(41, 43);
            this.save_button.TabIndex = 43;
            this.save_button.UseTransparentBackground = true;
            this.save_button.Visible = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.edit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.edit_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.edit_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.edit_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.edit_button.FillColor = System.Drawing.Color.Transparent;
            this.edit_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_button.ForeColor = System.Drawing.Color.Black;
            this.edit_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.edit_button.Image = ((System.Drawing.Image)(resources.GetObject("edit_button.Image")));
            this.edit_button.ImageSize = new System.Drawing.Size(25, 25);
            this.edit_button.Location = new System.Drawing.Point(164, 33);
            this.edit_button.Name = "edit_button";
            this.edit_button.PressedColor = System.Drawing.Color.Transparent;
            this.edit_button.Size = new System.Drawing.Size(35, 32);
            this.edit_button.TabIndex = 41;
            this.edit_button.UseTransparentBackground = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userRoleLabel.Location = new System.Drawing.Point(216, 70);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.Size = new System.Drawing.Size(53, 28);
            this.userRoleLabel.TabIndex = 20;
            this.userRoleLabel.Text = "Роль";
            this.userRoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // panel_elipse
            // 
            this.panel_elipse.BorderRadius = 35;
            this.panel_elipse.TargetControl = this.info_panel;
            // 
            // emailNameLabel
            // 
            this.emailNameLabel.AutoSize = true;
            this.emailNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailNameLabel.Location = new System.Drawing.Point(157, 341);
            this.emailNameLabel.Name = "emailNameLabel";
            this.emailNameLabel.Size = new System.Drawing.Size(51, 23);
            this.emailNameLabel.TabIndex = 57;
            this.emailNameLabel.Text = "email";
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.Transparent;
            this.userIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userIcon.Image = ((System.Drawing.Image)(resources.GetObject("userIcon.Image")));
            this.userIcon.ImageRotate = 0F;
            this.userIcon.Location = new System.Drawing.Point(43, 43);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(124, 146);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIcon.TabIndex = 58;
            this.userIcon.TabStop = false;
            this.userIcon.UseTransparentBackground = true;
            this.userIcon.Click += new System.EventHandler(this.userIcon_Click);
            this.userIcon.MouseHover += new System.EventHandler(this.userIcon_MouseHover_1);
            // 
            // error_label2
            // 
            this.error_label2.AutoSize = true;
            this.error_label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.error_label2.ForeColor = System.Drawing.Color.Red;
            this.error_label2.Location = new System.Drawing.Point(157, 376);
            this.error_label2.Name = "error_label2";
            this.error_label2.Size = new System.Drawing.Size(194, 20);
            this.error_label2.TabIndex = 77;
            this.error_label2.Text = "!!! Не все поля заполнены";
            this.error_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.error_label2.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.exitButton.BorderRadius = 15;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.FillColor = System.Drawing.Color.Black;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitButton.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(824, 579);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(167, 44);
            this.exitButton.TabIndex = 78;
            this.exitButton.Text = "Выйти";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(955, 456);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(157, 181);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 79;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(993, 173);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(105, 82);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 80;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // UserAccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.error_label2);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.emailNameLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.save_email_button);
            this.Controls.Add(this.edit_email_button);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.info_panel);
            this.Name = "UserAccountControl";
            this.Size = new System.Drawing.Size(1098, 640);
            this.Load += new System.EventHandler(this.UserAccountControl_Load);
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private Guna.UI2.WinForms.Guna2Button changePasswordButton;
        private Guna.UI2.WinForms.Guna2Button save_email_button;
        private Guna.UI2.WinForms.Guna2Button edit_email_button;
        private Guna.UI2.WinForms.Guna2ShadowPanel info_panel;
        private System.Windows.Forms.Label userNameLabel;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2Button save_button;
        private Guna.UI2.WinForms.Guna2Button edit_button;
        private System.Windows.Forms.Label userRoleLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Elipse panel_elipse;
        private System.Windows.Forms.Label emailNameLabel;
        public Guna.UI2.WinForms.Guna2PictureBox userIcon;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Label error_label2;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}
