
namespace DessertKoma_Employees.Controls
{
    partial class NotVerifiedOrderRowControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotVerifiedOrderRowControl));
            this.costLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dessertKomaDataSet = new DessertKoma_Employees.DessertKomaDataSet();
            this.addOrderButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.error_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertKomaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(522, 26);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(93, 23);
            this.costLabel.TabIndex = 123;
            this.costLabel.Text = "Сотрудник";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(314, 39);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(111, 23);
            this.dateLabel.TabIndex = 122;
            this.dateLabel.Text = "Дата выдачи";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderDateLabel.Location = new System.Drawing.Point(314, 9);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(103, 23);
            this.orderDateLabel.TabIndex = 121;
            this.orderDateLabel.Text = "Дата заказа";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(20, 25);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(83, 23);
            this.loginLabel.TabIndex = 120;
            this.loginLabel.Text = "Заказчик";
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(622, 18);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(233, 31);
            this.employeeComboBox.TabIndex = 124;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.dessertKomaDataSet;
            // 
            // dessertKomaDataSet
            // 
            this.dessertKomaDataSet.DataSetName = "DessertsKomaDataSet";
            this.dessertKomaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addOrderButton
            // 
            this.addOrderButton.BackColor = System.Drawing.Color.Transparent;
            this.addOrderButton.BorderColor = System.Drawing.Color.DimGray;
            this.addOrderButton.BorderRadius = 15;
            this.addOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addOrderButton.FillColor = System.Drawing.Color.Black;
            this.addOrderButton.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.addOrderButton.ForeColor = System.Drawing.Color.White;
            this.addOrderButton.HoverState.FillColor = System.Drawing.Color.White;
            this.addOrderButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.addOrderButton.Location = new System.Drawing.Point(874, 15);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(150, 37);
            this.addOrderButton.TabIndex = 125;
            this.addOrderButton.Text = "Подтвердить";
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.deleteButton.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.deleteButton.ImageRotate = 0F;
            this.deleteButton.ImageSize = new System.Drawing.Size(30, 30);
            this.deleteButton.Location = new System.Drawing.Point(1030, 11);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.deleteButton.Size = new System.Drawing.Size(40, 44);
            this.deleteButton.TabIndex = 126;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(618, 50);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(263, 19);
            this.error_label.TabIndex = 127;
            this.error_label.Text = "Выберите существующего сотрудника!";
            this.error_label.Visible = false;
            // 
            // NotVerifiedOrderRowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "NotVerifiedOrderRowControl";
            this.Size = new System.Drawing.Size(1081, 72);
            this.Load += new System.EventHandler(this.NotVerifiedOrderRowControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertKomaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private DessertKomaDataSet dessertKomaDataSet;
        private Guna.UI2.WinForms.Guna2Button addOrderButton;
        private Guna.UI2.WinForms.Guna2ImageButton deleteButton;
        public System.Windows.Forms.Label error_label;
    }
}
