
namespace DessertKoma_Employees.Controls
{
    partial class InProgressOrdersRowControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InProgressOrdersRowControl));
            this.deleteButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.addOrderButton = new Guna.UI2.WinForms.Guna2Button();
            this.costLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
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
            this.deleteButton.Location = new System.Drawing.Point(1025, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.deleteButton.Size = new System.Drawing.Size(40, 44);
            this.deleteButton.TabIndex = 132;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.addOrderButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addOrderButton.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrderButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.addOrderButton.Location = new System.Drawing.Point(869, 13);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(145, 42);
            this.addOrderButton.TabIndex = 131;
            this.addOrderButton.Text = "Готов";
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(551, 23);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(94, 23);
            this.costLabel.TabIndex = 130;
            this.costLabel.Text = "Стоимость";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(322, 40);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(111, 23);
            this.dateLabel.TabIndex = 129;
            this.dateLabel.Text = "Дата выдачи";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderDateLabel.Location = new System.Drawing.Point(322, 10);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(103, 23);
            this.orderDateLabel.TabIndex = 128;
            this.orderDateLabel.Text = "Дата заказа";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(17, 10);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(83, 23);
            this.loginLabel.TabIndex = 127;
            this.loginLabel.Text = "Заказчик";
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLabel.Location = new System.Drawing.Point(17, 40);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(93, 23);
            this.employeeLabel.TabIndex = 133;
            this.employeeLabel.Text = "Сотрудник";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button1.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(651, 13);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(204, 42);
            this.guna2Button1.TabIndex = 134;
            this.guna2Button1.Text = "Десерты в заказе";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // InProgressOrdersRowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "InProgressOrdersRowControl";
            this.Size = new System.Drawing.Size(1081, 72);
            this.Load += new System.EventHandler(this.InProgressOrdersRowControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton deleteButton;
        private Guna.UI2.WinForms.Guna2Button addOrderButton;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label employeeLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
