
namespace DessertKoma_Employees.Controls
{
    partial class ChangeIngredientsInNewDessertControl
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
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label countLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeIngredientsInNewDessertControl));
            this.info_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.logotype = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.noIngredientsPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.noDessertsLabel = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.savedLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.costAmountLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.countTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.last_button = new Guna.UI2.WinForms.Guna2Button();
            this.to_next_button = new Guna.UI2.WinForms.Guna2Button();
            this.to_previous_button = new Guna.UI2.WinForms.Guna2Button();
            this.to_first_button = new Guna.UI2.WinForms.Guna2Button();
            this.delete_button = new Guna.UI2.WinForms.Guna2Button();
            this.save_button = new Guna.UI2.WinForms.Guna2Button();
            this.add_new_dessert_button = new Guna.UI2.WinForms.Guna2Button();
            this.IngredientNameLabel = new System.Windows.Forms.Label();
            this.form_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.onlyIngredientLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            this.info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).BeginInit();
            this.noIngredientsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            costLabel.Location = new System.Drawing.Point(203, 209);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(98, 23);
            costLabel.TabIndex = 83;
            costLabel.Text = "Стоимость:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            countLabel.Location = new System.Drawing.Point(203, 143);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(106, 23);
            countLabel.TabIndex = 82;
            countLabel.Text = "Количество:";
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
            this.info_panel.TabIndex = 65;
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
            // noIngredientsPanel
            // 
            this.noIngredientsPanel.BackColor = System.Drawing.Color.Transparent;
            this.noIngredientsPanel.Controls.Add(this.guna2Button4);
            this.noIngredientsPanel.Controls.Add(this.noDessertsLabel);
            this.noIngredientsPanel.Controls.Add(this.guna2Button3);
            this.noIngredientsPanel.FillColor = System.Drawing.Color.Pink;
            this.noIngredientsPanel.Location = new System.Drawing.Point(29, 85);
            this.noIngredientsPanel.Name = "noIngredientsPanel";
            this.noIngredientsPanel.ShadowColor = System.Drawing.Color.Black;
            this.noIngredientsPanel.ShadowDepth = 50;
            this.noIngredientsPanel.ShadowShift = 2;
            this.noIngredientsPanel.Size = new System.Drawing.Size(743, 347);
            this.noIngredientsPanel.TabIndex = 98;
            this.noIngredientsPanel.Visible = false;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button4.BorderRadius = 15;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Black;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button4.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button4.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.Location = new System.Drawing.Point(260, 205);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(193, 66);
            this.guna2Button4.TabIndex = 22;
            this.guna2Button4.Text = "Добавить ингредиент";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // noDessertsLabel
            // 
            this.noDessertsLabel.AutoSize = true;
            this.noDessertsLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noDessertsLabel.Location = new System.Drawing.Point(93, 29);
            this.noDessertsLabel.Name = "noDessertsLabel";
            this.noDessertsLabel.Size = new System.Drawing.Size(576, 38);
            this.noDessertsLabel.TabIndex = 20;
            this.noDessertsLabel.Text = "В данном десерте еще нет ингредиентов";
            this.noDessertsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.Location = new System.Drawing.Point(1049, 22);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(50, 39);
            this.guna2Button3.TabIndex = 12;
            // 
            // savedLabel
            // 
            this.savedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savedLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.savedLabel.Location = new System.Drawing.Point(159, 315);
            this.savedLabel.Name = "savedLabel";
            this.savedLabel.Size = new System.Drawing.Size(132, 28);
            this.savedLabel.TabIndex = 97;
            this.savedLabel.Text = "сохранено";
            this.savedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savedLabel.Visible = false;
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(25, 308);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(100, 23);
            this.idLabel.TabIndex = 96;
            this.idLabel.Text = "id";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idLabel.Visible = false;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(321, 170);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(144, 19);
            this.error_label.TabIndex = 95;
            this.error_label.Text = "!!! Неверные данные";
            this.error_label.Visible = false;
            // 
            // costAmountLabel
            // 
            this.costAmountLabel.AutoSize = true;
            this.costAmountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costAmountLabel.Location = new System.Drawing.Point(307, 209);
            this.costAmountLabel.Name = "costAmountLabel";
            this.costAmountLabel.Size = new System.Drawing.Size(91, 23);
            this.costAmountLabel.TabIndex = 94;
            this.costAmountLabel.Text = "стоимость";
            this.costAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(511, 143);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(28, 23);
            this.amountLabel.TabIndex = 93;
            this.amountLabel.Text = "ед";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countTextBox
            // 
            this.countTextBox.BorderRadius = 5;
            this.countTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.countTextBox.DefaultText = "";
            this.countTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.countTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.countTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.countTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.countTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.countTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.countTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.countTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.countTextBox.Location = new System.Drawing.Point(316, 137);
            this.countTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.countTextBox.MaxLength = 7;
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.PasswordChar = '\0';
            this.countTextBox.PlaceholderText = "Введите количество";
            this.countTextBox.SelectedText = "";
            this.countTextBox.Size = new System.Drawing.Size(188, 29);
            this.countTextBox.TabIndex = 92;
            this.countTextBox.TextChanged += new System.EventHandler(this.countTextBox_TextChanged);
            // 
            // last_button
            // 
            this.last_button.BackColor = System.Drawing.Color.Transparent;
            this.last_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.last_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.last_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.last_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.last_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.last_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.last_button.FillColor = System.Drawing.Color.Transparent;
            this.last_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.last_button.ForeColor = System.Drawing.Color.Black;
            this.last_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.last_button.Image = ((System.Drawing.Image)(resources.GetObject("last_button.Image")));
            this.last_button.ImageSize = new System.Drawing.Size(40, 40);
            this.last_button.Location = new System.Drawing.Point(454, 392);
            this.last_button.Name = "last_button";
            this.last_button.Size = new System.Drawing.Size(63, 40);
            this.last_button.TabIndex = 91;
            this.last_button.UseTransparentBackground = true;
            this.last_button.Click += new System.EventHandler(this.last_button_Click);
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
            this.to_next_button.Location = new System.Drawing.Point(385, 392);
            this.to_next_button.Name = "to_next_button";
            this.to_next_button.Size = new System.Drawing.Size(63, 40);
            this.to_next_button.TabIndex = 90;
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
            this.to_previous_button.Location = new System.Drawing.Point(316, 392);
            this.to_previous_button.Name = "to_previous_button";
            this.to_previous_button.Size = new System.Drawing.Size(63, 40);
            this.to_previous_button.TabIndex = 89;
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
            this.to_first_button.Location = new System.Drawing.Point(247, 392);
            this.to_first_button.Name = "to_first_button";
            this.to_first_button.Size = new System.Drawing.Size(63, 40);
            this.to_first_button.TabIndex = 88;
            this.to_first_button.UseTransparentBackground = true;
            this.to_first_button.Click += new System.EventHandler(this.to_first_button_Click);
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
            this.delete_button.ImageSize = new System.Drawing.Size(40, 40);
            this.delete_button.Location = new System.Drawing.Point(357, 262);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(50, 50);
            this.delete_button.TabIndex = 87;
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
            this.save_button.ImageSize = new System.Drawing.Size(40, 40);
            this.save_button.Location = new System.Drawing.Point(193, 262);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(64, 50);
            this.save_button.TabIndex = 86;
            this.save_button.UseTransparentBackground = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // add_new_dessert_button
            // 
            this.add_new_dessert_button.BackColor = System.Drawing.Color.Transparent;
            this.add_new_dessert_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.add_new_dessert_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_new_dessert_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_new_dessert_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_new_dessert_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_new_dessert_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_new_dessert_button.FillColor = System.Drawing.Color.Transparent;
            this.add_new_dessert_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_new_dessert_button.ForeColor = System.Drawing.Color.Black;
            this.add_new_dessert_button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.add_new_dessert_button.Image = ((System.Drawing.Image)(resources.GetObject("add_new_dessert_button.Image")));
            this.add_new_dessert_button.ImageSize = new System.Drawing.Size(40, 40);
            this.add_new_dessert_button.Location = new System.Drawing.Point(488, 262);
            this.add_new_dessert_button.Name = "add_new_dessert_button";
            this.add_new_dessert_button.Size = new System.Drawing.Size(62, 50);
            this.add_new_dessert_button.TabIndex = 85;
            this.add_new_dessert_button.UseTransparentBackground = true;
            this.add_new_dessert_button.Click += new System.EventHandler(this.add_new_dessert_button_Click);
            // 
            // IngredientNameLabel
            // 
            this.IngredientNameLabel.AutoSize = true;
            this.IngredientNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IngredientNameLabel.Location = new System.Drawing.Point(22, 87);
            this.IngredientNameLabel.Name = "IngredientNameLabel";
            this.IngredientNameLabel.Size = new System.Drawing.Size(179, 38);
            this.IngredientNameLabel.TabIndex = 84;
            this.IngredientNameLabel.Text = "Ингредиент";
            this.IngredientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form_elipse
            // 
            this.form_elipse.BorderRadius = 25;
            this.form_elipse.TargetControl = this;
            // 
            // onlyIngredientLabel
            // 
            this.onlyIngredientLabel.AutoSize = true;
            this.onlyIngredientLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.onlyIngredientLabel.ForeColor = System.Drawing.Color.Red;
            this.onlyIngredientLabel.Location = new System.Drawing.Point(204, 366);
            this.onlyIngredientLabel.Name = "onlyIngredientLabel";
            this.onlyIngredientLabel.Size = new System.Drawing.Size(372, 23);
            this.onlyIngredientLabel.TabIndex = 99;
            this.onlyIngredientLabel.Text = "Это единственный ингредиент данного типа!";
            this.onlyIngredientLabel.Visible = false;
            // 
            // ChangeIngredientsInNewDessertControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.noIngredientsPanel);
            this.Controls.Add(this.savedLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.costAmountLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.last_button);
            this.Controls.Add(this.to_next_button);
            this.Controls.Add(this.to_previous_button);
            this.Controls.Add(this.to_first_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.add_new_dessert_button);
            this.Controls.Add(this.IngredientNameLabel);
            this.Controls.Add(costLabel);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.onlyIngredientLabel);
            this.Name = "ChangeIngredientsInNewDessertControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.ChangeIngredientsInNewDessertControl_Load);
            this.info_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).EndInit();
            this.noIngredientsPanel.ResumeLayout(false);
            this.noIngredientsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel info_panel;
        private Guna.UI2.WinForms.Guna2PictureBox logotype;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        public Guna.UI2.WinForms.Guna2ShadowPanel noIngredientsPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.Label noDessertsLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        public System.Windows.Forms.Label savedLabel;
        public System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label error_label;
        public System.Windows.Forms.Label costAmountLabel;
        public System.Windows.Forms.Label amountLabel;
        public Guna.UI2.WinForms.Guna2TextBox countTextBox;
        private Guna.UI2.WinForms.Guna2Button last_button;
        private Guna.UI2.WinForms.Guna2Button to_next_button;
        private Guna.UI2.WinForms.Guna2Button to_previous_button;
        private Guna.UI2.WinForms.Guna2Button to_first_button;
        private Guna.UI2.WinForms.Guna2Button delete_button;
        private Guna.UI2.WinForms.Guna2Button save_button;
        private Guna.UI2.WinForms.Guna2Button add_new_dessert_button;
        public System.Windows.Forms.Label IngredientNameLabel;
        private Guna.UI2.WinForms.Guna2Elipse form_elipse;
        public System.Windows.Forms.Label onlyIngredientLabel;
    }
}
