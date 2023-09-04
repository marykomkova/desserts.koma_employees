
namespace DessertKoma_Employees.Controls
{
    partial class MainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.imgPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DocIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPictureBox
            // 
            this.imgPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.imgPictureBox.BorderRadius = 5;
            this.imgPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imgPictureBox.Image")));
            this.imgPictureBox.ImageRotate = 0F;
            this.imgPictureBox.Location = new System.Drawing.Point(256, 123);
            this.imgPictureBox.Name = "imgPictureBox";
            this.imgPictureBox.Size = new System.Drawing.Size(609, 396);
            this.imgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPictureBox.TabIndex = 26;
            this.imgPictureBox.TabStop = false;
            // 
            // DocIcon
            // 
            this.DocIcon.BackColor = System.Drawing.Color.Transparent;
            this.DocIcon.BorderRadius = 5;
            this.DocIcon.Image = ((System.Drawing.Image)(resources.GetObject("DocIcon.Image")));
            this.DocIcon.ImageRotate = 0F;
            this.DocIcon.Location = new System.Drawing.Point(450, 525);
            this.DocIcon.Name = "DocIcon";
            this.DocIcon.Size = new System.Drawing.Size(229, 106);
            this.DocIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DocIcon.TabIndex = 25;
            this.DocIcon.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(249, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(616, 76);
            this.titleLabel.TabIndex = 24;
            this.titleLabel.Text = "Уважаемые сотрудники, будьте аккуратны \r\nпри изменении записей своих коллег!";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(96, 105);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(260, 259);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 82;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.imgPictureBox);
            this.Controls.Add(this.DocIcon);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1115, 657);
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox imgPictureBox;
        private Guna.UI2.WinForms.Guna2PictureBox DocIcon;
        private System.Windows.Forms.Label titleLabel;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}
