
namespace DessertKoma_Employees.Controls
{
    partial class ChangeDessertTypeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeDessertTypeControl));
            this.info_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.logotype = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.error_label = new System.Windows.Forms.Label();
            this.save_button = new Guna.UI2.WinForms.Guna2Button();
            this.dessertDescriptionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.dessertTypeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.dessertDescriptionLabel = new System.Windows.Forms.Label();
            this.dessertTypeLabel = new System.Windows.Forms.Label();
            this.elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).BeginInit();
            this.SuspendLayout();
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
            this.info_panel.TabIndex = 28;
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
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(533, 414);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(178, 19);
            this.error_label.TabIndex = 75;
            this.error_label.Text = "!!! Не все поля заполнены";
            this.error_label.Visible = false;
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
            this.save_button.ImageSize = new System.Drawing.Size(50, 50);
            this.save_button.Location = new System.Drawing.Point(708, 366);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(80, 67);
            this.save_button.TabIndex = 73;
            this.save_button.UseTransparentBackground = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // dessertDescriptionTextBox
            // 
            this.dessertDescriptionTextBox.BorderRadius = 5;
            this.dessertDescriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dessertDescriptionTextBox.DefaultText = "";
            this.dessertDescriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dessertDescriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dessertDescriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dessertDescriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dessertDescriptionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dessertDescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dessertDescriptionTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.dessertDescriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dessertDescriptionTextBox.Location = new System.Drawing.Point(264, 203);
            this.dessertDescriptionTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.dessertDescriptionTextBox.MaxLength = 100;
            this.dessertDescriptionTextBox.Multiline = true;
            this.dessertDescriptionTextBox.Name = "dessertDescriptionTextBox";
            this.dessertDescriptionTextBox.PasswordChar = '\0';
            this.dessertDescriptionTextBox.PlaceholderText = "Введите описание десерта";
            this.dessertDescriptionTextBox.SelectedText = "";
            this.dessertDescriptionTextBox.Size = new System.Drawing.Size(388, 151);
            this.dessertDescriptionTextBox.TabIndex = 72;
            this.dessertDescriptionTextBox.TextChanged += new System.EventHandler(this.dessertDescriptionTextBox_TextChanged);
            // 
            // dessertTypeTextBox
            // 
            this.dessertTypeTextBox.BorderRadius = 5;
            this.dessertTypeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dessertTypeTextBox.DefaultText = "";
            this.dessertTypeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dessertTypeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dessertTypeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dessertTypeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dessertTypeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dessertTypeTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dessertTypeTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.dessertTypeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dessertTypeTextBox.Location = new System.Drawing.Point(264, 109);
            this.dessertTypeTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.dessertTypeTextBox.MaxLength = 50;
            this.dessertTypeTextBox.Name = "dessertTypeTextBox";
            this.dessertTypeTextBox.PasswordChar = '\0';
            this.dessertTypeTextBox.PlaceholderText = "Введите тип десерта";
            this.dessertTypeTextBox.SelectedText = "";
            this.dessertTypeTextBox.Size = new System.Drawing.Size(388, 42);
            this.dessertTypeTextBox.TabIndex = 71;
            this.dessertTypeTextBox.TextChanged += new System.EventHandler(this.dessertTypeTextBox_TextChanged);
            // 
            // dessertDescriptionLabel
            // 
            this.dessertDescriptionLabel.AutoSize = true;
            this.dessertDescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dessertDescriptionLabel.Location = new System.Drawing.Point(81, 203);
            this.dessertDescriptionLabel.Name = "dessertDescriptionLabel";
            this.dessertDescriptionLabel.Size = new System.Drawing.Size(174, 28);
            this.dessertDescriptionLabel.TabIndex = 70;
            this.dessertDescriptionLabel.Text = "Описание десерта";
            this.dessertDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dessertTypeLabel
            // 
            this.dessertTypeLabel.AutoSize = true;
            this.dessertTypeLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dessertTypeLabel.Location = new System.Drawing.Point(79, 113);
            this.dessertTypeLabel.Name = "dessertTypeLabel";
            this.dessertTypeLabel.Size = new System.Drawing.Size(179, 38);
            this.dessertTypeLabel.TabIndex = 69;
            this.dessertTypeLabel.Text = "Тип десерта";
            this.dessertTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elipse
            // 
            this.elipse.BorderRadius = 35;
            this.elipse.TargetControl = this;
            // 
            // ChangeDessertTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.dessertDescriptionTextBox);
            this.Controls.Add(this.dessertTypeTextBox);
            this.Controls.Add(this.dessertDescriptionLabel);
            this.Controls.Add(this.dessertTypeLabel);
            this.Controls.Add(this.info_panel);
            this.Name = "ChangeDessertTypeControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.info_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel info_panel;
        private Guna.UI2.WinForms.Guna2PictureBox logotype;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        private System.Windows.Forms.Label error_label;
        private Guna.UI2.WinForms.Guna2Button save_button;
        public Guna.UI2.WinForms.Guna2TextBox dessertDescriptionTextBox;
        public Guna.UI2.WinForms.Guna2TextBox dessertTypeTextBox;
        private System.Windows.Forms.Label dessertDescriptionLabel;
        private System.Windows.Forms.Label dessertTypeLabel;
        private Guna.UI2.WinForms.Guna2Elipse elipse;
    }
}
