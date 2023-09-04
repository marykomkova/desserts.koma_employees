
namespace DessertKoma_Employees.Controls
{
    partial class ChangePasswordControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordControl));
            this.elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.info_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.logotype = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.newPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.oldPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.seeNewPasswordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.hideNewPasswordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.seePasswordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.hidePasswordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.save_button = new Guna.UI2.WinForms.Guna2Button();
            this.error_label = new System.Windows.Forms.Label();
            this.error_label2 = new System.Windows.Forms.Label();
            this.info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse
            // 
            this.elipse.BorderRadius = 35;
            this.elipse.TargetControl = this;
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
            this.info_panel.TabIndex = 29;
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
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.newPasswordTextBox.BorderRadius = 10;
            this.newPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPasswordTextBox.DefaultText = "";
            this.newPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newPasswordTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.newPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.newPasswordTextBox.Location = new System.Drawing.Point(250, 233);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newPasswordTextBox.MaxLength = 100;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '●';
            this.newPasswordTextBox.PlaceholderText = "Введите новый пароль";
            this.newPasswordTextBox.SelectedText = "";
            this.newPasswordTextBox.Size = new System.Drawing.Size(388, 36);
            this.newPasswordTextBox.TabIndex = 58;
            this.newPasswordTextBox.TextChanged += new System.EventHandler(this.newPasswordTextBox_TextChanged);
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.BorderColor = System.Drawing.Color.Gainsboro;
            this.oldPasswordTextBox.BorderRadius = 10;
            this.oldPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oldPasswordTextBox.DefaultText = "";
            this.oldPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.oldPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.oldPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.oldPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.oldPasswordTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.oldPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.oldPasswordTextBox.Location = new System.Drawing.Point(250, 143);
            this.oldPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oldPasswordTextBox.MaxLength = 100;
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.PasswordChar = '●';
            this.oldPasswordTextBox.PlaceholderText = "Введите старый пароль";
            this.oldPasswordTextBox.SelectedText = "";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(388, 36);
            this.oldPasswordTextBox.TabIndex = 57;
            this.oldPasswordTextBox.TextChanged += new System.EventHandler(this.oldPasswordTextBox_TextChanged);
            // 
            // seeNewPasswordBtn
            // 
            this.seeNewPasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.seeNewPasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seeNewPasswordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.seeNewPasswordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.seeNewPasswordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.seeNewPasswordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.seeNewPasswordBtn.FillColor = System.Drawing.Color.Transparent;
            this.seeNewPasswordBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seeNewPasswordBtn.ForeColor = System.Drawing.Color.Black;
            this.seeNewPasswordBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.seeNewPasswordBtn.Image = ((System.Drawing.Image)(resources.GetObject("seeNewPasswordBtn.Image")));
            this.seeNewPasswordBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.seeNewPasswordBtn.Location = new System.Drawing.Point(644, 235);
            this.seeNewPasswordBtn.Name = "seeNewPasswordBtn";
            this.seeNewPasswordBtn.Size = new System.Drawing.Size(36, 33);
            this.seeNewPasswordBtn.TabIndex = 55;
            this.seeNewPasswordBtn.UseTransparentBackground = true;
            this.seeNewPasswordBtn.Click += new System.EventHandler(this.seeNewPasswordBtn_Click);
            // 
            // hideNewPasswordBtn
            // 
            this.hideNewPasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.hideNewPasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideNewPasswordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hideNewPasswordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hideNewPasswordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hideNewPasswordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hideNewPasswordBtn.FillColor = System.Drawing.Color.Transparent;
            this.hideNewPasswordBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hideNewPasswordBtn.ForeColor = System.Drawing.Color.Black;
            this.hideNewPasswordBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.hideNewPasswordBtn.Image = ((System.Drawing.Image)(resources.GetObject("hideNewPasswordBtn.Image")));
            this.hideNewPasswordBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.hideNewPasswordBtn.Location = new System.Drawing.Point(644, 235);
            this.hideNewPasswordBtn.Name = "hideNewPasswordBtn";
            this.hideNewPasswordBtn.Size = new System.Drawing.Size(36, 33);
            this.hideNewPasswordBtn.TabIndex = 56;
            this.hideNewPasswordBtn.UseTransparentBackground = true;
            this.hideNewPasswordBtn.Visible = false;
            this.hideNewPasswordBtn.Click += new System.EventHandler(this.hideNewPasswordBtn_Click);
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPasswordLabel.Location = new System.Drawing.Point(83, 241);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(156, 28);
            this.newPasswordLabel.TabIndex = 54;
            this.newPasswordLabel.Text = "Новый пароль:";
            this.newPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // seePasswordBtn
            // 
            this.seePasswordBtn.BackColor = System.Drawing.Color.Transparent;
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
            this.seePasswordBtn.Location = new System.Drawing.Point(644, 143);
            this.seePasswordBtn.Name = "seePasswordBtn";
            this.seePasswordBtn.Size = new System.Drawing.Size(36, 33);
            this.seePasswordBtn.TabIndex = 52;
            this.seePasswordBtn.UseTransparentBackground = true;
            this.seePasswordBtn.Click += new System.EventHandler(this.seePasswordBtn_Click);
            // 
            // hidePasswordBtn
            // 
            this.hidePasswordBtn.BackColor = System.Drawing.Color.Transparent;
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
            this.hidePasswordBtn.Location = new System.Drawing.Point(644, 143);
            this.hidePasswordBtn.Name = "hidePasswordBtn";
            this.hidePasswordBtn.Size = new System.Drawing.Size(36, 33);
            this.hidePasswordBtn.TabIndex = 53;
            this.hidePasswordBtn.UseTransparentBackground = true;
            this.hidePasswordBtn.Visible = false;
            this.hidePasswordBtn.Click += new System.EventHandler(this.hidePasswordBtn_Click);
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPasswordLabel.Location = new System.Drawing.Point(83, 149);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(161, 28);
            this.oldPasswordLabel.TabIndex = 51;
            this.oldPasswordLabel.Text = "Старый пароль:";
            this.oldPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.save_button.ImageSize = new System.Drawing.Size(50, 50);
            this.save_button.Location = new System.Drawing.Point(716, 374);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(72, 61);
            this.save_button.TabIndex = 50;
            this.save_button.UseTransparentBackground = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(250, 183);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(194, 20);
            this.error_label.TabIndex = 77;
            this.error_label.Text = "!!! Не все поля заполнены";
            this.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.error_label.Visible = false;
            // 
            // error_label2
            // 
            this.error_label2.AutoSize = true;
            this.error_label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.error_label2.ForeColor = System.Drawing.Color.Red;
            this.error_label2.Location = new System.Drawing.Point(250, 273);
            this.error_label2.Name = "error_label2";
            this.error_label2.Size = new System.Drawing.Size(194, 20);
            this.error_label2.TabIndex = 78;
            this.error_label2.Text = "!!! Не все поля заполнены";
            this.error_label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.error_label2.Visible = false;
            // 
            // ChangePasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.error_label2);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.oldPasswordTextBox);
            this.Controls.Add(this.seeNewPasswordBtn);
            this.Controls.Add(this.hideNewPasswordBtn);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.seePasswordBtn);
            this.Controls.Add(this.hidePasswordBtn);
            this.Controls.Add(this.oldPasswordLabel);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.info_panel);
            this.Name = "ChangePasswordControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.info_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipse;
        private Guna.UI2.WinForms.Guna2TextBox newPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox oldPasswordTextBox;
        private Guna.UI2.WinForms.Guna2Button seeNewPasswordBtn;
        private Guna.UI2.WinForms.Guna2Button hideNewPasswordBtn;
        private System.Windows.Forms.Label newPasswordLabel;
        private Guna.UI2.WinForms.Guna2Button seePasswordBtn;
        private Guna.UI2.WinForms.Guna2Button hidePasswordBtn;
        private System.Windows.Forms.Label oldPasswordLabel;
        private Guna.UI2.WinForms.Guna2Button save_button;
        private Guna.UI2.WinForms.Guna2ShadowPanel info_panel;
        private Guna.UI2.WinForms.Guna2PictureBox logotype;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        private System.Windows.Forms.Label error_label2;
        private System.Windows.Forms.Label error_label;
    }
}
