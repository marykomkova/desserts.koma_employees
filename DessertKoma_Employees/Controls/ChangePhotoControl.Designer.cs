
namespace DessertKoma_Employees.Controls
{
    partial class ChangePhotoControl
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
            this.change_photo_button = new Guna.UI2.WinForms.Guna2Button();
            this.elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.change_photo_button_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // change_photo_button
            // 
            this.change_photo_button.BackColor = System.Drawing.Color.DarkGray;
            this.change_photo_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_photo_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.change_photo_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.change_photo_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.change_photo_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.change_photo_button.FillColor = System.Drawing.Color.DarkGray;
            this.change_photo_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_photo_button.ForeColor = System.Drawing.Color.Black;
            this.change_photo_button.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.change_photo_button.Location = new System.Drawing.Point(14, 3);
            this.change_photo_button.Name = "change_photo_button";
            this.change_photo_button.Size = new System.Drawing.Size(293, 80);
            this.change_photo_button.TabIndex = 7;
            this.change_photo_button.Text = "Изменить фото";
            this.change_photo_button.Click += new System.EventHandler(this.change_photo_button_Click);
            // 
            // elipse
            // 
            this.elipse.BorderRadius = 35;
            this.elipse.TargetControl = this;
            // 
            // change_photo_button_elipse
            // 
            this.change_photo_button_elipse.BorderRadius = 20;
            this.change_photo_button_elipse.TargetControl = this.change_photo_button;
            // 
            // ChangePhotoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.change_photo_button);
            this.Name = "ChangePhotoControl";
            this.Size = new System.Drawing.Size(320, 86);
            this.Load += new System.EventHandler(this.ChangePhotoControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button change_photo_button;
        private Guna.UI2.WinForms.Guna2Elipse elipse;
        private Guna.UI2.WinForms.Guna2Elipse change_photo_button_elipse;
    }
}
