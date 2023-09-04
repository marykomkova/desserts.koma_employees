
namespace DessertKoma_Employees.Controls
{
    partial class UserRowControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRowControl));
            this.verificationCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.loginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.ролиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dessertsKomaDataSet = new DessertKoma_Employees.DessertKomaDataSet();
            this.deleteButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.editButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.saveButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.loginLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.ролиTableAdapter = new DessertKoma_Employees.DessertsKomaDataSetTableAdapters.РолиTableAdapter();
            this.error_label = new System.Windows.Forms.Label();
            this.closeButton = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ролиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertsKomaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // verificationCheckBox
            // 
            this.verificationCheckBox.AutoSize = true;
            this.verificationCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.verificationCheckBox.CheckedState.BorderRadius = 0;
            this.verificationCheckBox.CheckedState.BorderThickness = 0;
            this.verificationCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.verificationCheckBox.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.verificationCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verificationCheckBox.Enabled = false;
            this.verificationCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.verificationCheckBox.Location = new System.Drawing.Point(648, 32);
            this.verificationCheckBox.Name = "verificationCheckBox";
            this.verificationCheckBox.Size = new System.Drawing.Size(139, 27);
            this.verificationCheckBox.TabIndex = 95;
            this.verificationCheckBox.Text = "Подтвержден";
            this.verificationCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.verificationCheckBox.UncheckedState.BorderRadius = 0;
            this.verificationCheckBox.UncheckedState.BorderThickness = 0;
            this.verificationCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.verificationCheckBox.CheckedChanged += new System.EventHandler(this.verificationCheckBox_CheckedChanged);
            // 
            // pic
            // 
            this.pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic.Enabled = false;
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.ImageRotate = 0F;
            this.pic.Location = new System.Drawing.Point(885, 3);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(87, 108);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 96;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
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
            this.loginTextBox.Location = new System.Drawing.Point(20, 11);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.loginTextBox.MaxLength = 100;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PasswordChar = '\0';
            this.loginTextBox.PlaceholderText = "Введите логин";
            this.loginTextBox.SelectedText = "";
            this.loginTextBox.Size = new System.Drawing.Size(310, 29);
            this.loginTextBox.TabIndex = 97;
            this.loginTextBox.Visible = false;
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
            this.nameTextBox.Location = new System.Drawing.Point(20, 48);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nameTextBox.MaxLength = 100;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderText = "Введите имя";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(310, 29);
            this.nameTextBox.TabIndex = 98;
            this.nameTextBox.Visible = false;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(391, 10);
            this.phoneTextBox.Mask = "+375 (00) 000-00-00";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(192, 30);
            this.phoneTextBox.TabIndex = 99;
            this.phoneTextBox.Visible = false;
            // 
            // roleComboBox
            // 
            this.roleComboBox.DataSource = this.ролиBindingSource;
            this.roleComboBox.DisplayMember = "Название";
            this.roleComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(391, 48);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(192, 31);
            this.roleComboBox.TabIndex = 100;
            this.roleComboBox.ValueMember = "Номер";
            this.roleComboBox.Visible = false;
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
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.deleteButton.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.deleteButton.ImageRotate = 0F;
            this.deleteButton.ImageSize = new System.Drawing.Size(30, 30);
            this.deleteButton.Location = new System.Drawing.Point(1028, 71);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.deleteButton.Size = new System.Drawing.Size(40, 40);
            this.deleteButton.TabIndex = 104;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.editButton.ImageRotate = 0F;
            this.editButton.ImageSize = new System.Drawing.Size(30, 30);
            this.editButton.Location = new System.Drawing.Point(983, 71);
            this.editButton.Name = "editButton";
            this.editButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.editButton.Size = new System.Drawing.Size(40, 40);
            this.editButton.TabIndex = 105;
            this.editButton.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // saveButton
            // 
            this.saveButton.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.saveButton.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.saveButton.ImageRotate = 0F;
            this.saveButton.ImageSize = new System.Drawing.Size(30, 30);
            this.saveButton.Location = new System.Drawing.Point(983, 71);
            this.saveButton.Name = "saveButton";
            this.saveButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.saveButton.Size = new System.Drawing.Size(40, 40);
            this.saveButton.TabIndex = 106;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(16, 17);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(59, 23);
            this.loginLabel.TabIndex = 108;
            this.loginLabel.Text = "Логин";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(16, 54);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 23);
            this.nameLabel.TabIndex = 109;
            this.nameLabel.Text = "Имя";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(387, 17);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(143, 23);
            this.phoneLabel.TabIndex = 110;
            this.phoneLabel.Text = "Номер телефона";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleLabel.Location = new System.Drawing.Point(387, 56);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(48, 23);
            this.roleLabel.TabIndex = 111;
            this.roleLabel.Text = "Роль";
            // 
            // ролиTableAdapter
            // 
            this.ролиTableAdapter.ClearBeforeFill = true;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(656, 84);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(113, 20);
            this.error_label.TabIndex = 112;
            this.error_label.Text = "Не сохранено!";
            this.error_label.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.closeButton.ImageRotate = 0F;
            this.closeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.closeButton.Location = new System.Drawing.Point(1038, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeButton.Size = new System.Drawing.Size(30, 29);
            this.closeButton.TabIndex = 113;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // UserRowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.verificationCheckBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.saveButton);
            this.Name = "UserRowControl";
            this.Size = new System.Drawing.Size(1081, 114);
            this.Load += new System.EventHandler(this.UserRowControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ролиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertsKomaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox verificationCheckBox;
        private Guna.UI2.WinForms.Guna2PictureBox pic;
        public Guna.UI2.WinForms.Guna2TextBox loginTextBox;
        public Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private Guna.UI2.WinForms.Guna2ImageButton deleteButton;
        private Guna.UI2.WinForms.Guna2ImageButton editButton;
        private Guna.UI2.WinForms.Guna2ImageButton saveButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.BindingSource ролиBindingSource;
        private DessertKomaDataSet dessertsKomaDataSet;
        private DessertsKomaDataSetTableAdapters.РолиTableAdapter ролиTableAdapter;
        private System.Windows.Forms.Label error_label;
        private Guna.UI2.WinForms.Guna2ImageButton closeButton;
    }
}
