
namespace DessertKoma_Employees.Controls
{
    partial class AddNewDessertControl
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
            System.Windows.Forms.Label ingredientLabel;
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label titleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewDessertControl));
            this.info_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.logotype = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.form_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.error_label3 = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.desPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.amountTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.titleTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ingredientsListBox = new System.Windows.Forms.ListBox();
            this.edit_button = new Guna.UI2.WinForms.Guna2Button();
            this.add_new_dessert_button = new Guna.UI2.WinForms.Guna2Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.dessertTypeLabel = new System.Windows.Forms.Label();
            this.costLabelValue = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            ingredientLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            this.info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desPic)).BeginInit();
            this.SuspendLayout();
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            costLabel.Location = new System.Drawing.Point(22, 184);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(98, 23);
            costLabel.TabIndex = 79;
            costLabel.Text = "Стоимость:";
            // 
            // ingredientLabel
            // 
            ingredientLabel.AutoSize = true;
            ingredientLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ingredientLabel.Location = new System.Drawing.Point(22, 224);
            ingredientLabel.Name = "ingredientLabel";
            ingredientLabel.Size = new System.Drawing.Size(120, 23);
            ingredientLabel.TabIndex = 72;
            ingredientLabel.Text = "Ингредиенты:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            countLabel.Location = new System.Drawing.Point(22, 138);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(106, 23);
            countLabel.TabIndex = 70;
            countLabel.Text = "Количество:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(22, 93);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(90, 23);
            titleLabel.TabIndex = 69;
            titleLabel.Text = "Название:";
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
            this.info_panel.TabIndex = 17;
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
            // form_elipse
            // 
            this.form_elipse.BorderRadius = 25;
            this.form_elipse.TargetControl = this;
            // 
            // error_label3
            // 
            this.error_label3.AutoSize = true;
            this.error_label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.error_label3.ForeColor = System.Drawing.Color.Red;
            this.error_label3.Location = new System.Drawing.Point(22, 417);
            this.error_label3.Name = "error_label3";
            this.error_label3.Size = new System.Drawing.Size(144, 19);
            this.error_label3.TabIndex = 84;
            this.error_label3.Text = "!!! Неверные данные";
            this.error_label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.error_label3.Visible = false;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(145, 165);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(124, 15);
            this.error_label.TabIndex = 82;
            this.error_label.Text = "!!! Неверные данные";
            this.error_label.Visible = false;
            // 
            // desPic
            // 
            this.desPic.BorderRadius = 5;
            this.desPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.desPic.FillColor = System.Drawing.Color.Transparent;
            this.desPic.Image = ((System.Drawing.Image)(resources.GetObject("desPic.Image")));
            this.desPic.ImageRotate = 0F;
            this.desPic.Location = new System.Drawing.Point(506, 132);
            this.desPic.Name = "desPic";
            this.desPic.Size = new System.Drawing.Size(285, 181);
            this.desPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.desPic.TabIndex = 78;
            this.desPic.TabStop = false;
            this.desPic.Click += new System.EventHandler(this.desPic_Click);
            this.desPic.MouseHover += new System.EventHandler(this.desPic_MouseHover);
            // 
            // amountTextBox
            // 
            this.amountTextBox.BorderRadius = 5;
            this.amountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountTextBox.DefaultText = "";
            this.amountTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amountTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amountTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amountTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amountTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.amountTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.amountTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.amountTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.amountTextBox.Location = new System.Drawing.Point(135, 132);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.PasswordChar = '\0';
            this.amountTextBox.PlaceholderText = "Введите количество";
            this.amountTextBox.SelectedText = "";
            this.amountTextBox.Size = new System.Drawing.Size(210, 29);
            this.amountTextBox.TabIndex = 77;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.BorderRadius = 5;
            this.titleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleTextBox.DefaultText = "";
            this.titleTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.titleTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.titleTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.titleTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.titleTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.titleTextBox.Location = new System.Drawing.Point(119, 87);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.MaxLength = 100;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.PasswordChar = '\0';
            this.titleTextBox.PlaceholderText = "Введите название";
            this.titleTextBox.SelectedText = "";
            this.titleTextBox.Size = new System.Drawing.Size(368, 29);
            this.titleTextBox.TabIndex = 76;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.ItemHeight = 16;
            this.ingredientsListBox.Location = new System.Drawing.Point(148, 224);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(351, 180);
            this.ingredientsListBox.TabIndex = 75;
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
            this.edit_button.Location = new System.Drawing.Point(506, 357);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(55, 47);
            this.edit_button.TabIndex = 74;
            this.edit_button.UseTransparentBackground = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
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
            this.add_new_dessert_button.ImageSize = new System.Drawing.Size(50, 50);
            this.add_new_dessert_button.Location = new System.Drawing.Point(708, 364);
            this.add_new_dessert_button.Name = "add_new_dessert_button";
            this.add_new_dessert_button.Size = new System.Drawing.Size(80, 72);
            this.add_new_dessert_button.TabIndex = 73;
            this.add_new_dessert_button.UseTransparentBackground = true;
            this.add_new_dessert_button.Click += new System.EventHandler(this.add_new_dessert_button_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(352, 138);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(135, 23);
            this.amountLabel.TabIndex = 71;
            this.amountLabel.Text = "измерение";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dessertTypeLabel
            // 
            this.dessertTypeLabel.AutoSize = true;
            this.dessertTypeLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dessertTypeLabel.Location = new System.Drawing.Point(510, 80);
            this.dessertTypeLabel.Name = "dessertTypeLabel";
            this.dessertTypeLabel.Size = new System.Drawing.Size(179, 38);
            this.dessertTypeLabel.TabIndex = 68;
            this.dessertTypeLabel.Text = "Тип десерта";
            this.dessertTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // costLabelValue
            // 
            this.costLabelValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabelValue.Location = new System.Drawing.Point(126, 184);
            this.costLabelValue.Name = "costLabelValue";
            this.costLabelValue.Size = new System.Drawing.Size(135, 23);
            this.costLabelValue.TabIndex = 85;
            this.costLabelValue.Text = "0 руб.";
            this.costLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddNewDessertControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.costLabelValue);
            this.Controls.Add(this.error_label3);
            this.Controls.Add(this.error_label);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.desPic);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.ingredientsListBox);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_new_dessert_button);
            this.Controls.Add(ingredientLabel);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.dessertTypeLabel);
            this.Controls.Add(this.info_panel);
            this.Name = "AddNewDessertControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.AddNewDessertControl_Load);
            this.info_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel info_panel;
        private Guna.UI2.WinForms.Guna2PictureBox logotype;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        private Guna.UI2.WinForms.Guna2Elipse form_elipse;
        private System.Windows.Forms.Label error_label;
        public Guna.UI2.WinForms.Guna2TextBox amountTextBox;
        public Guna.UI2.WinForms.Guna2TextBox titleTextBox;
        public System.Windows.Forms.ListBox ingredientsListBox;
        private Guna.UI2.WinForms.Guna2Button edit_button;
        private Guna.UI2.WinForms.Guna2Button add_new_dessert_button;
        public System.Windows.Forms.Label amountLabel;
        public System.Windows.Forms.Label dessertTypeLabel;
        public Guna.UI2.WinForms.Guna2PictureBox desPic;
        public System.Windows.Forms.Label costLabelValue;
        public System.Windows.Forms.Label error_label3;
    }
}
