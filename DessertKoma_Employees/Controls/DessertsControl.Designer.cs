
namespace DessertKoma_Employees.Controls
{
    partial class DessertsControl
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
            System.Windows.Forms.Label ingredientLabel;
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DessertsControl));
            this.noDessertsPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.noDessertsLabel = new System.Windows.Forms.Label();
            this.savedLabel = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.countTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.titleTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.edit_button = new Guna.UI2.WinForms.Guna2Button();
            this.delete_button = new Guna.UI2.WinForms.Guna2Button();
            this.save_button = new Guna.UI2.WinForms.Guna2Button();
            this.to_last_button = new Guna.UI2.WinForms.Guna2Button();
            this.to_next_button = new Guna.UI2.WinForms.Guna2Button();
            this.to_previous_button = new Guna.UI2.WinForms.Guna2Button();
            this.to_first_button = new Guna.UI2.WinForms.Guna2Button();
            this.ingredientListBox = new System.Windows.Forms.ListBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.info_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dessertTypeIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.changeDessertTypeButton = new Guna.UI2.WinForms.Guna2Button();
            this.dessertDescriptionLabel = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.dessertTypeLabel = new System.Windows.Forms.Label();
            this.panel_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.десертыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlyDessertLabel = new System.Windows.Forms.Label();
            this.image_error_label = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.costLabel = new System.Windows.Forms.Label();
            ingredientLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.noDessertsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertTypeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.десертыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ingredientLabel
            // 
            ingredientLabel.AutoSize = true;
            ingredientLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ingredientLabel.Location = new System.Drawing.Point(31, 316);
            ingredientLabel.Name = "ingredientLabel";
            ingredientLabel.Size = new System.Drawing.Size(120, 23);
            ingredientLabel.TabIndex = 57;
            ingredientLabel.Text = "Ингредиенты:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            countLabel.Location = new System.Drawing.Point(31, 233);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(106, 23);
            countLabel.TabIndex = 56;
            countLabel.Text = "Количество:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(31, 192);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(90, 23);
            titleLabel.TabIndex = 53;
            titleLabel.Text = "Название:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(31, 280);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 23);
            label1.TabIndex = 75;
            label1.Text = "Стоимость:";
            // 
            // noDessertsPanel
            // 
            this.noDessertsPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.noDessertsPanel.Controls.Add(this.guna2Button3);
            this.noDessertsPanel.Controls.Add(this.noDessertsLabel);
            this.noDessertsPanel.FillColor = System.Drawing.Color.LavenderBlush;
            this.noDessertsPanel.Location = new System.Drawing.Point(7, 172);
            this.noDessertsPanel.Name = "noDessertsPanel";
            this.noDessertsPanel.ShadowColor = System.Drawing.Color.Black;
            this.noDessertsPanel.ShadowDepth = 50;
            this.noDessertsPanel.ShadowShift = 2;
            this.noDessertsPanel.Size = new System.Drawing.Size(1077, 461);
            this.noDessertsPanel.TabIndex = 71;
            this.noDessertsPanel.Visible = false;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button3.BorderRadius = 15;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Gray;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(431, 270);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(193, 66);
            this.guna2Button3.TabIndex = 21;
            this.guna2Button3.Text = "Создать десерт";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click_1);
            // 
            // noDessertsLabel
            // 
            this.noDessertsLabel.AutoSize = true;
            this.noDessertsLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noDessertsLabel.Location = new System.Drawing.Point(230, 73);
            this.noDessertsLabel.Name = "noDessertsLabel";
            this.noDessertsLabel.Size = new System.Drawing.Size(560, 38);
            this.noDessertsLabel.TabIndex = 19;
            this.noDessertsLabel.Text = "Десерты данного типа еще не созданы!";
            this.noDessertsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // savedLabel
            // 
            this.savedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savedLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.savedLabel.Location = new System.Drawing.Point(644, 535);
            this.savedLabel.Name = "savedLabel";
            this.savedLabel.Size = new System.Drawing.Size(122, 28);
            this.savedLabel.TabIndex = 70;
            this.savedLabel.Text = "сохранено";
            this.savedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savedLabel.Visible = false;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(153, 260);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(124, 15);
            this.error_label.TabIndex = 69;
            this.error_label.Text = "!!! Неверные данные";
            this.error_label.Visible = false;
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(49, 384);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(100, 23);
            this.idLabel.TabIndex = 68;
            this.idLabel.Text = "id";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idLabel.Visible = false;
            // 
            // countTextBox
            // 
            this.countTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.countTextBox.BorderRadius = 10;
            this.countTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.countTextBox.DefaultText = "";
            this.countTextBox.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.countTextBox.DisabledState.FillColor = System.Drawing.Color.White;
            this.countTextBox.DisabledState.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.countTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.countTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.countTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.countTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.countTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.countTextBox.Location = new System.Drawing.Point(144, 225);
            this.countTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.countTextBox.MaxLength = 5;
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.PasswordChar = '\0';
            this.countTextBox.PlaceholderText = "Введите количество";
            this.countTextBox.SelectedText = "";
            this.countTextBox.Size = new System.Drawing.Size(257, 31);
            this.countTextBox.TabIndex = 67;
            this.countTextBox.TextChanged += new System.EventHandler(this.countTextBox_TextChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.BorderColor = System.Drawing.Color.DarkGray;
            this.titleTextBox.BorderRadius = 10;
            this.titleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleTextBox.DefaultText = "";
            this.titleTextBox.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.titleTextBox.DisabledState.FillColor = System.Drawing.Color.White;
            this.titleTextBox.DisabledState.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.titleTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.titleTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.titleTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.titleTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.titleTextBox.Location = new System.Drawing.Point(128, 185);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.MaxLength = 100;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.PasswordChar = '\0';
            this.titleTextBox.PlaceholderText = "Введите название";
            this.titleTextBox.SelectedText = "";
            this.titleTextBox.Size = new System.Drawing.Size(368, 30);
            this.titleTextBox.TabIndex = 66;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.Transparent;
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
            this.edit_button.ImageSize = new System.Drawing.Size(40, 40);
            this.edit_button.Location = new System.Drawing.Point(111, 465);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(55, 47);
            this.edit_button.TabIndex = 65;
            this.edit_button.UseTransparentBackground = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Transparent;
            this.delete_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_button.FillColor = System.Drawing.Color.Transparent;
            this.delete_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.ForeColor = System.Drawing.Color.Black;
            this.delete_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.delete_button.Image = ((System.Drawing.Image)(resources.GetObject("delete_button.Image")));
            this.delete_button.ImageSize = new System.Drawing.Size(50, 50);
            this.delete_button.Location = new System.Drawing.Point(786, 467);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(87, 65);
            this.delete_button.TabIndex = 64;
            this.delete_button.UseTransparentBackground = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
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
            this.save_button.Location = new System.Drawing.Point(662, 467);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(87, 65);
            this.save_button.TabIndex = 63;
            this.save_button.UseTransparentBackground = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // to_last_button
            // 
            this.to_last_button.BackColor = System.Drawing.Color.Transparent;
            this.to_last_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.to_last_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_last_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.to_last_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.to_last_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.to_last_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.to_last_button.FillColor = System.Drawing.Color.Transparent;
            this.to_last_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_last_button.ForeColor = System.Drawing.Color.Black;
            this.to_last_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.to_last_button.Image = ((System.Drawing.Image)(resources.GetObject("to_last_button.Image")));
            this.to_last_button.ImageSize = new System.Drawing.Size(40, 40);
            this.to_last_button.Location = new System.Drawing.Point(234, 586);
            this.to_last_button.Name = "to_last_button";
            this.to_last_button.Size = new System.Drawing.Size(63, 40);
            this.to_last_button.TabIndex = 62;
            this.to_last_button.UseTransparentBackground = true;
            this.to_last_button.Click += new System.EventHandler(this.to_last_button_Click);
            // 
            // to_next_button
            // 
            this.to_next_button.BackColor = System.Drawing.Color.Transparent;
            this.to_next_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.to_next_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_next_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.to_next_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.to_next_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.to_next_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.to_next_button.FillColor = System.Drawing.Color.Transparent;
            this.to_next_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_next_button.ForeColor = System.Drawing.Color.Black;
            this.to_next_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.to_next_button.Image = ((System.Drawing.Image)(resources.GetObject("to_next_button.Image")));
            this.to_next_button.ImageSize = new System.Drawing.Size(40, 40);
            this.to_next_button.Location = new System.Drawing.Point(165, 586);
            this.to_next_button.Name = "to_next_button";
            this.to_next_button.Size = new System.Drawing.Size(63, 40);
            this.to_next_button.TabIndex = 61;
            this.to_next_button.UseTransparentBackground = true;
            this.to_next_button.Click += new System.EventHandler(this.to_next_button_Click);
            // 
            // to_previous_button
            // 
            this.to_previous_button.BackColor = System.Drawing.Color.Transparent;
            this.to_previous_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.to_previous_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_previous_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.to_previous_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.to_previous_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.to_previous_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.to_previous_button.FillColor = System.Drawing.Color.Transparent;
            this.to_previous_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_previous_button.ForeColor = System.Drawing.Color.Black;
            this.to_previous_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.to_previous_button.Image = ((System.Drawing.Image)(resources.GetObject("to_previous_button.Image")));
            this.to_previous_button.ImageSize = new System.Drawing.Size(40, 40);
            this.to_previous_button.Location = new System.Drawing.Point(96, 586);
            this.to_previous_button.Name = "to_previous_button";
            this.to_previous_button.Size = new System.Drawing.Size(63, 40);
            this.to_previous_button.TabIndex = 60;
            this.to_previous_button.UseTransparentBackground = true;
            this.to_previous_button.Click += new System.EventHandler(this.to_previous_button_Click);
            // 
            // to_first_button
            // 
            this.to_first_button.BackColor = System.Drawing.Color.Transparent;
            this.to_first_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.to_first_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_first_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.to_first_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.to_first_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.to_first_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.to_first_button.FillColor = System.Drawing.Color.Transparent;
            this.to_first_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_first_button.ForeColor = System.Drawing.Color.Black;
            this.to_first_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.to_first_button.Image = ((System.Drawing.Image)(resources.GetObject("to_first_button.Image")));
            this.to_first_button.ImageSize = new System.Drawing.Size(40, 40);
            this.to_first_button.Location = new System.Drawing.Point(27, 586);
            this.to_first_button.Name = "to_first_button";
            this.to_first_button.Size = new System.Drawing.Size(63, 40);
            this.to_first_button.TabIndex = 59;
            this.to_first_button.UseTransparentBackground = true;
            this.to_first_button.Click += new System.EventHandler(this.to_first_button_Click);
            // 
            // ingredientListBox
            // 
            this.ingredientListBox.FormattingEnabled = true;
            this.ingredientListBox.ItemHeight = 16;
            this.ingredientListBox.Location = new System.Drawing.Point(171, 316);
            this.ingredientListBox.Name = "ingredientListBox";
            this.ingredientListBox.Size = new System.Drawing.Size(351, 196);
            this.ingredientListBox.TabIndex = 58;
            // 
            // amountLabel
            // 
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(408, 233);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(152, 23);
            this.amountLabel.TabIndex = 55;
            this.amountLabel.Text = "измерение";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePictureBox.Location = new System.Drawing.Point(593, 185);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(481, 256);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 54;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.Click += new System.EventHandler(this.imagePictureBox_Click);
            this.imagePictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imagePictureBox_MouseClick);
            this.imagePictureBox.MouseEnter += new System.EventHandler(this.imagePictureBox_MouseEnter);
            this.imagePictureBox.MouseLeave += new System.EventHandler(this.imagePictureBox_MouseLeave);
            this.imagePictureBox.MouseHover += new System.EventHandler(this.imagePictureBox_MouseHover);
            // 
            // info_panel
            // 
            this.info_panel.BackColor = System.Drawing.Color.Transparent;
            this.info_panel.Controls.Add(this.guna2PictureBox2);
            this.info_panel.Controls.Add(this.dessertTypeIcon);
            this.info_panel.Controls.Add(this.changeDessertTypeButton);
            this.info_panel.Controls.Add(this.dessertDescriptionLabel);
            this.info_panel.Controls.Add(this.guna2Button2);
            this.info_panel.Controls.Add(this.dessertTypeLabel);
            this.info_panel.FillColor = System.Drawing.Color.White;
            this.info_panel.Location = new System.Drawing.Point(31, 34);
            this.info_panel.Name = "info_panel";
            this.info_panel.ShadowColor = System.Drawing.Color.Black;
            this.info_panel.ShadowDepth = 50;
            this.info_panel.ShadowShift = 2;
            this.info_panel.Size = new System.Drawing.Size(1053, 132);
            this.info_panel.TabIndex = 52;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(792, 9);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(127, 107);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 81;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // dessertTypeIcon
            // 
            this.dessertTypeIcon.BackColor = System.Drawing.Color.Transparent;
            this.dessertTypeIcon.BorderRadius = 5;
            this.dessertTypeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dessertTypeIcon.Image = ((System.Drawing.Image)(resources.GetObject("dessertTypeIcon.Image")));
            this.dessertTypeIcon.ImageRotate = 0F;
            this.dessertTypeIcon.Location = new System.Drawing.Point(15, 4);
            this.dessertTypeIcon.Name = "dessertTypeIcon";
            this.dessertTypeIcon.Size = new System.Drawing.Size(129, 120);
            this.dessertTypeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dessertTypeIcon.TabIndex = 21;
            this.dessertTypeIcon.TabStop = false;
            this.dessertTypeIcon.Click += new System.EventHandler(this.dessertTypeIcon_Click);
            this.dessertTypeIcon.MouseHover += new System.EventHandler(this.dessertTypeIcon_MouseHover);
            // 
            // changeDessertTypeButton
            // 
            this.changeDessertTypeButton.BackColor = System.Drawing.Color.Transparent;
            this.changeDessertTypeButton.BorderColor = System.Drawing.Color.DimGray;
            this.changeDessertTypeButton.BorderRadius = 15;
            this.changeDessertTypeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeDessertTypeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeDessertTypeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeDessertTypeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeDessertTypeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeDessertTypeButton.FillColor = System.Drawing.Color.Black;
            this.changeDessertTypeButton.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.changeDessertTypeButton.ForeColor = System.Drawing.Color.White;
            this.changeDessertTypeButton.Location = new System.Drawing.Point(850, 9);
            this.changeDessertTypeButton.Name = "changeDessertTypeButton";
            this.changeDessertTypeButton.Size = new System.Drawing.Size(193, 66);
            this.changeDessertTypeButton.TabIndex = 20;
            this.changeDessertTypeButton.Text = "Редактировать тип десерта";
            this.changeDessertTypeButton.Click += new System.EventHandler(this.changeDessertTypeButton_Click);
            // 
            // dessertDescriptionLabel
            // 
            this.dessertDescriptionLabel.AutoSize = true;
            this.dessertDescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dessertDescriptionLabel.Location = new System.Drawing.Point(157, 47);
            this.dessertDescriptionLabel.Name = "dessertDescriptionLabel";
            this.dessertDescriptionLabel.Size = new System.Drawing.Size(145, 28);
            this.dessertDescriptionLabel.TabIndex = 20;
            this.dessertDescriptionLabel.Text = "Описание типа";
            this.dessertDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // dessertTypeLabel
            // 
            this.dessertTypeLabel.AutoSize = true;
            this.dessertTypeLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dessertTypeLabel.Location = new System.Drawing.Point(146, 9);
            this.dessertTypeLabel.Name = "dessertTypeLabel";
            this.dessertTypeLabel.Size = new System.Drawing.Size(179, 38);
            this.dessertTypeLabel.TabIndex = 6;
            this.dessertTypeLabel.Text = "Тип десерта";
            this.dessertTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_elipse
            // 
            this.panel_elipse.BorderRadius = 35;
            this.panel_elipse.TargetControl = this.info_panel;
            // 
            // десертыBindingSource
            // 
            this.десертыBindingSource.DataMember = "Десерты";
            // 
            // onlyDessertLabel
            // 
            this.onlyDessertLabel.AutoSize = true;
            this.onlyDessertLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.onlyDessertLabel.ForeColor = System.Drawing.Color.Red;
            this.onlyDessertLabel.Location = new System.Drawing.Point(3, 547);
            this.onlyDessertLabel.Name = "onlyDessertLabel";
            this.onlyDessertLabel.Size = new System.Drawing.Size(333, 23);
            this.onlyDessertLabel.TabIndex = 72;
            this.onlyDessertLabel.Text = "Это единственный десерт данного типа!";
            // 
            // image_error_label
            // 
            this.image_error_label.AutoSize = true;
            this.image_error_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.image_error_label.ForeColor = System.Drawing.Color.Red;
            this.image_error_label.Location = new System.Drawing.Point(859, 444);
            this.image_error_label.Name = "image_error_label";
            this.image_error_label.Size = new System.Drawing.Size(215, 20);
            this.image_error_label.TabIndex = 73;
            this.image_error_label.Text = "Изображение не сохранено!";
            this.image_error_label.Visible = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2Button1.Location = new System.Drawing.Point(901, 467);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(87, 65);
            this.guna2Button1.TabIndex = 74;
            this.guna2Button1.Tag = " ";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // costLabel
            // 
            this.costLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(135, 280);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(152, 23);
            this.costLabel.TabIndex = 77;
            this.costLabel.Text = "0 руб.";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DessertsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.noDessertsPanel);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.to_last_button);
            this.Controls.Add(this.to_next_button);
            this.Controls.Add(this.to_previous_button);
            this.Controls.Add(this.to_first_button);
            this.Controls.Add(ingredientLabel);
            this.Controls.Add(this.ingredientListBox);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.savedLabel);
            this.Controls.Add(this.image_error_label);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.onlyDessertLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(label1);
            this.Name = "DessertsControl";
            this.Size = new System.Drawing.Size(1098, 640);
            this.Load += new System.EventHandler(this.DessertsControl_Load);
            this.noDessertsPanel.ResumeLayout(false);
            this.noDessertsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertTypeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.десертыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2ShadowPanel noDessertsPanel;
        private System.Windows.Forms.Label noDessertsLabel;
        public System.Windows.Forms.Label savedLabel;
        private System.Windows.Forms.Label error_label;
        public System.Windows.Forms.Label idLabel;
        public Guna.UI2.WinForms.Guna2TextBox countTextBox;
        public Guna.UI2.WinForms.Guna2TextBox titleTextBox;
        public System.Windows.Forms.ListBox ingredientListBox;
        public System.Windows.Forms.Label amountLabel;
        public System.Windows.Forms.PictureBox imagePictureBox;
        private Guna.UI2.WinForms.Guna2ShadowPanel info_panel;
        public Guna.UI2.WinForms.Guna2PictureBox dessertTypeIcon;
        public System.Windows.Forms.Label dessertDescriptionLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        public System.Windows.Forms.Label dessertTypeLabel;
        private Guna.UI2.WinForms.Guna2Elipse panel_elipse;
        private System.Windows.Forms.BindingSource десертыBindingSource;
        public Guna.UI2.WinForms.Guna2Button to_first_button;
        public Guna.UI2.WinForms.Guna2Button to_last_button;
        public Guna.UI2.WinForms.Guna2Button to_next_button;
        public Guna.UI2.WinForms.Guna2Button to_previous_button;
        public System.Windows.Forms.Label onlyDessertLabel;
        public System.Windows.Forms.Label image_error_label;
        public Guna.UI2.WinForms.Guna2Button edit_button;
        public Guna.UI2.WinForms.Guna2Button delete_button;
        public Guna.UI2.WinForms.Guna2Button save_button;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2Button changeDessertTypeButton;
        public Guna.UI2.WinForms.Guna2Button guna2Button3;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        public System.Windows.Forms.Label costLabel;
    }
}
