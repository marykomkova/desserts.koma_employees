
namespace DessertKoma_Employees.Controls
{
    partial class AddIngredientInNewDessertControl
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
            System.Windows.Forms.Label titleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIngredientInNewDessertControl));
            this.info_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.logotype = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.costAmountLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.countTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.add_new_dessert_button = new Guna.UI2.WinForms.Guna2Button();
            this.form_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            this.ингредиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dessertsKomaDataSet = new DessertKoma_Employees.DessertKomaDataSet();
            this.ингредиентыTableAdapter = new DessertKoma_Employees.DessertsKomaDataSetTableAdapters.ИнгредиентыTableAdapter();
            costLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            this.info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertsKomaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            costLabel.Location = new System.Drawing.Point(154, 300);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(98, 23);
            costLabel.TabIndex = 80;
            costLabel.Text = "Стоимость:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            countLabel.Location = new System.Drawing.Point(154, 219);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(106, 23);
            countLabel.TabIndex = 79;
            countLabel.Text = "Количество:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(154, 136);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(108, 23);
            titleLabel.TabIndex = 78;
            titleLabel.Text = "Ингредиент:";
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
            this.info_panel.TabIndex = 68;
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
            // costAmountLabel
            // 
            this.costAmountLabel.AutoSize = true;
            this.costAmountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costAmountLabel.Location = new System.Drawing.Point(258, 300);
            this.costAmountLabel.Name = "costAmountLabel";
            this.costAmountLabel.Size = new System.Drawing.Size(24, 23);
            this.costAmountLabel.TabIndex = 87;
            this.costAmountLabel.Text = "0 ";
            this.costAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(475, 219);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(124, 23);
            this.amountLabel.TabIndex = 86;
            this.amountLabel.Text = "ед. измерения";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(276, 246);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(104, 12);
            this.error_label.TabIndex = 85;
            this.error_label.Text = "!!! Неверные данные";
            this.error_label.Visible = false;
            // 
            // countTextBox
            // 
            this.countTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.countTextBox.Location = new System.Drawing.Point(267, 212);
            this.countTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.countTextBox.MaxLength = 7;
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.PasswordChar = '\0';
            this.countTextBox.PlaceholderText = "Введите количество";
            this.countTextBox.SelectedText = "";
            this.countTextBox.Size = new System.Drawing.Size(201, 30);
            this.countTextBox.TabIndex = 83;
            this.countTextBox.TextChanged += new System.EventHandler(this.countTextBox_TextChanged);
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
            this.add_new_dessert_button.Location = new System.Drawing.Point(710, 381);
            this.add_new_dessert_button.Name = "add_new_dessert_button";
            this.add_new_dessert_button.Size = new System.Drawing.Size(64, 54);
            this.add_new_dessert_button.TabIndex = 81;
            this.add_new_dessert_button.UseTransparentBackground = true;
            this.add_new_dessert_button.Click += new System.EventHandler(this.add_new_dessert_button_Click);
            // 
            // form_elipse
            // 
            this.form_elipse.BorderRadius = 25;
            this.form_elipse.TargetControl = this;
            // 
            // titleComboBox
            // 
            this.titleComboBox.DataSource = this.ингредиентыBindingSource;
            this.titleComboBox.DisplayMember = "Название";
            this.titleComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Location = new System.Drawing.Point(267, 128);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(307, 31);
            this.titleComboBox.TabIndex = 88;
            this.titleComboBox.ValueMember = "Номер";
            this.titleComboBox.SelectionChangeCommitted += new System.EventHandler(this.titleComboBox_SelectionChangeCommitted);
            // 
            // ингредиентыBindingSource
            // 
            this.ингредиентыBindingSource.DataMember = "Ингредиенты";
            this.ингредиентыBindingSource.DataSource = this.dessertsKomaDataSet;
            // 
            // dessertsKomaDataSet
            // 
            this.dessertsKomaDataSet.DataSetName = "DessertsKomaDataSet";
            this.dessertsKomaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ингредиентыTableAdapter
            // 
            this.ингредиентыTableAdapter.ClearBeforeFill = true;
            // 
            // AddIngredientInNewDessertControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.titleComboBox);
            this.Controls.Add(this.costAmountLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.add_new_dessert_button);
            this.Controls.Add(costLabel);
            this.Controls.Add(countLabel);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.info_panel);
            this.Name = "AddIngredientInNewDessertControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.AddIngredientInNewDessertControl_Load);
            this.info_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ингредиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertsKomaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel info_panel;
        private Guna.UI2.WinForms.Guna2PictureBox logotype;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        public System.Windows.Forms.Label costAmountLabel;
        public System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label error_label;
        private Guna.UI2.WinForms.Guna2TextBox countTextBox;
        private Guna.UI2.WinForms.Guna2Button add_new_dessert_button;
        private Guna.UI2.WinForms.Guna2Elipse form_elipse;
        private System.Windows.Forms.ComboBox titleComboBox;
        private System.Windows.Forms.BindingSource ингредиентыBindingSource;
        private DessertKomaDataSet dessertsKomaDataSet;
        private DessertsKomaDataSetTableAdapters.ИнгредиентыTableAdapter ингредиентыTableAdapter;
    }
}
