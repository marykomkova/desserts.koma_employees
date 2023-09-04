
namespace DessertKoma_Employees.Controls
{
    partial class IngredientsControl
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label LoginLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientsControl));
            this.ingredientsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.employeesHeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.to_next_button = new Guna.UI2.WinForms.Guna2Button();
            this.to_previous_button = new Guna.UI2.WinForms.Guna2Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            LoginLabel = new System.Windows.Forms.Label();
            this.employeesHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(497, 13);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 23);
            label2.TabIndex = 98;
            label2.Text = "Стоимость";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(701, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(172, 23);
            label1.TabIndex = 97;
            label1.Text = "Единица измерения";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(302, 13);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(103, 23);
            phoneLabel.TabIndex = 94;
            phoneLabel.Text = "Количество";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            LoginLabel.Location = new System.Drawing.Point(19, 13);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new System.Drawing.Size(87, 23);
            LoginLabel.TabIndex = 80;
            LoginLabel.Text = "Название";
            // 
            // ingredientsPanel
            // 
            this.ingredientsPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ingredientsPanel.Location = new System.Drawing.Point(7, 66);
            this.ingredientsPanel.Name = "ingredientsPanel";
            this.ingredientsPanel.Size = new System.Drawing.Size(1081, 489);
            this.ingredientsPanel.TabIndex = 73;
            this.ingredientsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ingredientsPanel_Paint);
            // 
            // employeesHeaderPanel
            // 
            this.employeesHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.employeesHeaderPanel.BorderRadius = 50;
            this.employeesHeaderPanel.Controls.Add(label2);
            this.employeesHeaderPanel.Controls.Add(label1);
            this.employeesHeaderPanel.Controls.Add(phoneLabel);
            this.employeesHeaderPanel.Controls.Add(LoginLabel);
            this.employeesHeaderPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.employeesHeaderPanel.Location = new System.Drawing.Point(7, 13);
            this.employeesHeaderPanel.Name = "employeesHeaderPanel";
            this.employeesHeaderPanel.Size = new System.Drawing.Size(1081, 47);
            this.employeesHeaderPanel.TabIndex = 72;
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
            this.guna2Button3.FillColor = System.Drawing.Color.Black;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button3.HoverState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Location = new System.Drawing.Point(428, 566);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(245, 44);
            this.guna2Button3.TabIndex = 71;
            this.guna2Button3.Text = "Добавить ингредиент";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // to_next_button
            // 
            this.to_next_button.BackColor = System.Drawing.Color.Transparent;
            this.to_next_button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.to_next_button.Location = new System.Drawing.Point(1028, 570);
            this.to_next_button.Name = "to_next_button";
            this.to_next_button.Size = new System.Drawing.Size(63, 40);
            this.to_next_button.TabIndex = 70;
            this.to_next_button.UseTransparentBackground = true;
            this.to_next_button.Visible = false;
            this.to_next_button.Click += new System.EventHandler(this.to_next_button_Click);
            // 
            // to_previous_button
            // 
            this.to_previous_button.BackColor = System.Drawing.Color.Transparent;
            this.to_previous_button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.to_previous_button.Location = new System.Drawing.Point(10, 570);
            this.to_previous_button.Name = "to_previous_button";
            this.to_previous_button.Size = new System.Drawing.Size(63, 40);
            this.to_previous_button.TabIndex = 69;
            this.to_previous_button.UseTransparentBackground = true;
            this.to_previous_button.Visible = false;
            this.to_previous_button.Click += new System.EventHandler(this.to_previous_button_Click);
            // 
            // IngredientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.ingredientsPanel);
            this.Controls.Add(this.employeesHeaderPanel);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.to_next_button);
            this.Controls.Add(this.to_previous_button);
            this.Name = "IngredientsControl";
            this.Size = new System.Drawing.Size(1098, 640);
            this.Load += new System.EventHandler(this.IngredientsControl_Load);
            this.employeesHeaderPanel.ResumeLayout(false);
            this.employeesHeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ingredientsPanel;
        private Guna.UI2.WinForms.Guna2Panel employeesHeaderPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        public Guna.UI2.WinForms.Guna2Button to_next_button;
        public Guna.UI2.WinForms.Guna2Button to_previous_button;
    }
}
