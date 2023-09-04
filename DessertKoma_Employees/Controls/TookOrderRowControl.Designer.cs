
namespace DessertKoma_Employees.Controls
{
    partial class TookOrderRowControl
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
            this.employeeLabel = new System.Windows.Forms.Label();
            this.addOrderButton = new Guna.UI2.WinForms.Guna2Button();
            this.costLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLabel.Location = new System.Drawing.Point(18, 39);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(93, 23);
            this.employeeLabel.TabIndex = 139;
            this.employeeLabel.Text = "Сотрудник";
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
            this.addOrderButton.HoverState.FillColor = System.Drawing.Color.LavenderBlush;
            this.addOrderButton.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrderButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.addOrderButton.Location = new System.Drawing.Point(917, 14);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(145, 43);
            this.addOrderButton.TabIndex = 138;
            this.addOrderButton.Text = "Готов";
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(551, 25);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(94, 23);
            this.costLabel.TabIndex = 137;
            this.costLabel.Text = "Стоимость";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(349, 39);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(111, 23);
            this.dateLabel.TabIndex = 136;
            this.dateLabel.Text = "Дата выдачи";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderDateLabel.Location = new System.Drawing.Point(349, 9);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(103, 23);
            this.orderDateLabel.TabIndex = 135;
            this.orderDateLabel.Text = "Дата заказа";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(18, 9);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(83, 23);
            this.loginLabel.TabIndex = 134;
            this.loginLabel.Text = "Заказчик";
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
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.LavenderBlush;
            this.guna2Button1.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(697, 14);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(211, 43);
            this.guna2Button1.TabIndex = 140;
            this.guna2Button1.Text = "Десерты в заказе";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // TookOrderRowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "TookOrderRowControl";
            this.Size = new System.Drawing.Size(1081, 72);
            this.Load += new System.EventHandler(this.TookOrderRowControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeLabel;
        private Guna.UI2.WinForms.Guna2Button addOrderButton;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label loginLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
