
namespace DessertKoma_Employees.Controls
{
    partial class IngredientRowControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientRowControl));
            this.closeButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.error_label = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.editButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.deleteButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.titleTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.countTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.amountComboBox = new System.Windows.Forms.ComboBox();
            this.единицыИзмеренияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dessertsKomaDataSet = new DessertKoma_Employees.DessertKomaDataSet();
            this.saveButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.costTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.единицыИзмеренияTableAdapter = new DessertKoma_Employees.DessertsKomaDataSetTableAdapters.ЕдиницыИзмеренияTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.единицыИзмеренияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertsKomaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.closeButton.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.closeButton.ImageRotate = 0F;
            this.closeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.closeButton.Location = new System.Drawing.Point(1041, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeButton.Size = new System.Drawing.Size(30, 29);
            this.closeButton.TabIndex = 126;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(6, 48);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(102, 19);
            this.error_label.TabIndex = 125;
            this.error_label.Text = "Не сохранено!";
            this.error_label.Visible = false;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(701, 21);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(169, 23);
            this.amountLabel.TabIndex = 124;
            this.amountLabel.Text = "Единица измерения";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(500, 21);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(94, 23);
            this.costLabel.TabIndex = 123;
            this.costLabel.Text = "Стоимость";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.Location = new System.Drawing.Point(301, 21);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(102, 23);
            this.countLabel.TabIndex = 122;
            this.countLabel.Text = "Количество";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(5, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(87, 23);
            this.titleLabel.TabIndex = 121;
            this.titleLabel.Text = "Название";
            // 
            // editButton
            // 
            this.editButton.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.editButton.ImageRotate = 0F;
            this.editButton.ImageSize = new System.Drawing.Size(30, 30);
            this.editButton.Location = new System.Drawing.Point(915, 13);
            this.editButton.Name = "editButton";
            this.editButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.editButton.Size = new System.Drawing.Size(40, 41);
            this.editButton.TabIndex = 119;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.deleteButton.ImageRotate = 0F;
            this.deleteButton.ImageSize = new System.Drawing.Size(30, 30);
            this.deleteButton.Location = new System.Drawing.Point(980, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.deleteButton.Size = new System.Drawing.Size(40, 41);
            this.deleteButton.TabIndex = 118;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.titleTextBox.Location = new System.Drawing.Point(9, 15);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.titleTextBox.MaxLength = 100;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.PasswordChar = '\0';
            this.titleTextBox.PlaceholderText = "Введите название";
            this.titleTextBox.SelectedText = "";
            this.titleTextBox.Size = new System.Drawing.Size(284, 29);
            this.titleTextBox.TabIndex = 114;
            this.titleTextBox.Visible = false;
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
            this.countTextBox.Location = new System.Drawing.Point(305, 15);
            this.countTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.countTextBox.MaxLength = 5;
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.PasswordChar = '\0';
            this.countTextBox.PlaceholderText = "Введите количество";
            this.countTextBox.SelectedText = "";
            this.countTextBox.Size = new System.Drawing.Size(189, 29);
            this.countTextBox.TabIndex = 115;
            this.countTextBox.Visible = false;
            this.countTextBox.TextChanged += new System.EventHandler(this.countTextBox_TextChanged);
            // 
            // amountComboBox
            // 
            this.amountComboBox.DataSource = this.единицыИзмеренияBindingSource;
            this.amountComboBox.DisplayMember = "Название";
            this.amountComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.amountComboBox.FormattingEnabled = true;
            this.amountComboBox.Location = new System.Drawing.Point(701, 13);
            this.amountComboBox.Name = "amountComboBox";
            this.amountComboBox.Size = new System.Drawing.Size(192, 31);
            this.amountComboBox.TabIndex = 117;
            this.amountComboBox.ValueMember = "Номер";
            this.amountComboBox.Visible = false;
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
            this.saveButton.Location = new System.Drawing.Point(915, 13);
            this.saveButton.Name = "saveButton";
            this.saveButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.saveButton.Size = new System.Drawing.Size(40, 41);
            this.saveButton.TabIndex = 120;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            this.costTextBox.Location = new System.Drawing.Point(504, 15);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.costTextBox.MaxLength = 5;
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.PasswordChar = '\0';
            this.costTextBox.PlaceholderText = "Введите стоимость";
            this.costTextBox.SelectedText = "";
            this.costTextBox.Size = new System.Drawing.Size(189, 29);
            this.costTextBox.TabIndex = 127;
            this.costTextBox.Visible = false;
            this.costTextBox.TextChanged += new System.EventHandler(this.costTextBox_TextChanged);
            // 
            // единицыИзмеренияTableAdapter
            // 
            this.единицыИзмеренияTableAdapter.ClearBeforeFill = true;
            // 
            // IngredientRowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.amountComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.costTextBox);
            this.Name = "IngredientRowControl";
            this.Size = new System.Drawing.Size(1081, 75);
            this.Load += new System.EventHandler(this.IngredientRowControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.единицыИзмеренияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertsKomaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton closeButton;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label titleLabel;
        private Guna.UI2.WinForms.Guna2ImageButton editButton;
        private Guna.UI2.WinForms.Guna2ImageButton deleteButton;
        public Guna.UI2.WinForms.Guna2TextBox titleTextBox;
        public Guna.UI2.WinForms.Guna2TextBox countTextBox;
        private System.Windows.Forms.ComboBox amountComboBox;
        private Guna.UI2.WinForms.Guna2ImageButton saveButton;
        public Guna.UI2.WinForms.Guna2TextBox costTextBox;
        private System.Windows.Forms.BindingSource единицыИзмеренияBindingSource;
        private DessertKomaDataSet dessertsKomaDataSet;
        private DessertsKomaDataSetTableAdapters.ЕдиницыИзмеренияTableAdapter единицыИзмеренияTableAdapter;
    }
}
