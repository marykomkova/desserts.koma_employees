
namespace DessertKoma_Employees.Controls
{
    partial class AddIngredientControl
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label amountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIngredientControl));
            this.form_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.info_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.logotype = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.titleTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.countTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.amountComboBox = new System.Windows.Forms.ComboBox();
            this.единицыИзмеренияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dessertsKomaDataSet = new DessertKoma_Employees.DessertKomaDataSet();
            this.costTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.save_button = new Guna.UI2.WinForms.Guna2Button();
            this.единицыИзмеренияTableAdapter = new DessertKoma_Employees.DessertsKomaDataSetTableAdapters.ЕдиницыИзмеренияTableAdapter();
            titleLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            this.info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.единицыИзмеренияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertsKomaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(197, 116);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(90, 23);
            titleLabel.TabIndex = 132;
            titleLabel.Text = "Название:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            countLabel.Location = new System.Drawing.Point(197, 182);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(106, 23);
            countLabel.TabIndex = 133;
            countLabel.Text = "Количество:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            costLabel.Location = new System.Drawing.Point(197, 250);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(98, 23);
            costLabel.TabIndex = 134;
            costLabel.Text = "Стоимость:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            amountLabel.Location = new System.Drawing.Point(197, 317);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(173, 23);
            amountLabel.TabIndex = 135;
            amountLabel.Text = "Единица измерения:";
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
            this.info_panel.Location = new System.Drawing.Point(-8, -10);
            this.info_panel.Name = "info_panel";
            this.info_panel.ShadowColor = System.Drawing.Color.Black;
            this.info_panel.ShadowDepth = 50;
            this.info_panel.ShadowShift = 2;
            this.info_panel.Size = new System.Drawing.Size(814, 79);
            this.info_panel.TabIndex = 19;
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
            this.titleTextBox.Location = new System.Drawing.Point(295, 110);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.titleTextBox.MaxLength = 100;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.PasswordChar = '\0';
            this.titleTextBox.PlaceholderText = "Введите название";
            this.titleTextBox.SelectedText = "";
            this.titleTextBox.Size = new System.Drawing.Size(284, 29);
            this.titleTextBox.TabIndex = 128;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
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
            this.countTextBox.Location = new System.Drawing.Point(311, 176);
            this.countTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.countTextBox.MaxLength = 5;
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.PasswordChar = '\0';
            this.countTextBox.PlaceholderText = "Введите количество";
            this.countTextBox.SelectedText = "";
            this.countTextBox.Size = new System.Drawing.Size(268, 29);
            this.countTextBox.TabIndex = 129;
            this.countTextBox.TextChanged += new System.EventHandler(this.countTextBox_TextChanged);
            // 
            // amountComboBox
            // 
            this.amountComboBox.DataSource = this.единицыИзмеренияBindingSource;
            this.amountComboBox.DisplayMember = "Название";
            this.amountComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.amountComboBox.FormattingEnabled = true;
            this.amountComboBox.Location = new System.Drawing.Point(393, 309);
            this.amountComboBox.Name = "amountComboBox";
            this.amountComboBox.Size = new System.Drawing.Size(186, 31);
            this.amountComboBox.TabIndex = 130;
            this.amountComboBox.ValueMember = "Номер";
            this.amountComboBox.SelectionChangeCommitted += new System.EventHandler(this.amountComboBox_SelectionChangeCommitted);
            // 
            // единицыИзмеренияBindingSource
            // 
            this.единицыИзмеренияBindingSource.DataMember = "ЕдиницыИзмерения";
            this.единицыИзмеренияBindingSource.DataSource = this.dessertsKomaDataSet;
            // 
            // dessertsKomaDataSet
            // 
            this.dessertsKomaDataSet.DataSetName = "DessertsKomaDataSet";
            this.dessertsKomaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // costTextBox
            // 
            this.costTextBox.BorderRadius = 5;
            this.costTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.costTextBox.DefaultText = "";
            this.costTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.costTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.costTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.costTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.costTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.costTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.costTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.costTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.costTextBox.Location = new System.Drawing.Point(303, 244);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.costTextBox.MaxLength = 5;
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.PasswordChar = '\0';
            this.costTextBox.PlaceholderText = "Введите стоимость";
            this.costTextBox.SelectedText = "";
            this.costTextBox.Size = new System.Drawing.Size(276, 29);
            this.costTextBox.TabIndex = 131;
            this.costTextBox.TextChanged += new System.EventHandler(this.costTextBox_TextChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(197, 387);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(178, 23);
            this.errorLabel.TabIndex = 136;
            this.errorLabel.Text = "!!! Неверные данные";
            this.errorLabel.Visible = false;
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
            this.save_button.TabIndex = 137;
            this.save_button.UseTransparentBackground = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // единицыИзмеренияTableAdapter
            // 
            this.единицыИзмеренияTableAdapter.ClearBeforeFill = true;
            // 
            // AddIngredientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(amountLabel);
            this.Controls.Add(costLabel);
            this.Controls.Add(countLabel);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.amountComboBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.info_panel);
            this.Name = "AddIngredientControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.AddIngredientControl_Load);
            this.info_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.единицыИзмеренияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertsKomaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse form_elipse;
        private Guna.UI2.WinForms.Guna2ShadowPanel info_panel;
        private Guna.UI2.WinForms.Guna2PictureBox logotype;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        public Guna.UI2.WinForms.Guna2TextBox titleTextBox;
        public Guna.UI2.WinForms.Guna2TextBox countTextBox;
        private System.Windows.Forms.ComboBox amountComboBox;
        public Guna.UI2.WinForms.Guna2TextBox costTextBox;
        private System.Windows.Forms.Label errorLabel;
        private Guna.UI2.WinForms.Guna2Button save_button;
        private System.Windows.Forms.BindingSource единицыИзмеренияBindingSource;
        private DessertKomaDataSet dessertsKomaDataSet;
        private DessertsKomaDataSetTableAdapters.ЕдиницыИзмеренияTableAdapter единицыИзмеренияTableAdapter;
    }
}
