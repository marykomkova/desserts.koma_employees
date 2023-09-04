
namespace DessertKoma_Employees.Controls
{
    partial class DessertsInOrderControl
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
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label dessertLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DessertsInOrderControl));
            this.form_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.info_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.logotype = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.dessertsInOrderHeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ordersPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.to_next_button = new Guna.UI2.WinForms.Guna2Button();
            this.to_previous_button = new Guna.UI2.WinForms.Guna2Button();
            countLabel = new System.Windows.Forms.Label();
            dessertLabel = new System.Windows.Forms.Label();
            this.info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).BeginInit();
            this.dessertsInOrderHeaderPanel.SuspendLayout();
            this.ordersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            countLabel.Location = new System.Drawing.Point(553, 13);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(103, 23);
            countLabel.TabIndex = 94;
            countLabel.Text = "Количество";
            // 
            // dessertLabel
            // 
            dessertLabel.AutoSize = true;
            dessertLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dessertLabel.Location = new System.Drawing.Point(31, 13);
            dessertLabel.Name = "dessertLabel";
            dessertLabel.Size = new System.Drawing.Size(65, 23);
            dessertLabel.TabIndex = 80;
            dessertLabel.Text = "Десерт";
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
            this.info_panel.Location = new System.Drawing.Point(-10, -8);
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
            // dessertsInOrderHeaderPanel
            // 
            this.dessertsInOrderHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dessertsInOrderHeaderPanel.BorderRadius = 50;
            this.dessertsInOrderHeaderPanel.Controls.Add(countLabel);
            this.dessertsInOrderHeaderPanel.Controls.Add(dessertLabel);
            this.dessertsInOrderHeaderPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.dessertsInOrderHeaderPanel.Location = new System.Drawing.Point(3, 77);
            this.dessertsInOrderHeaderPanel.Name = "dessertsInOrderHeaderPanel";
            this.dessertsInOrderHeaderPanel.Size = new System.Drawing.Size(794, 47);
            this.dessertsInOrderHeaderPanel.TabIndex = 68;
            // 
            // ordersPanel
            // 
            this.ordersPanel.Controls.Add(this.to_next_button);
            this.ordersPanel.Controls.Add(this.to_previous_button);
            this.ordersPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ordersPanel.Location = new System.Drawing.Point(3, 130);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(794, 317);
            this.ordersPanel.TabIndex = 69;
            // 
            // to_next_button
            // 
            this.to_next_button.BackColor = System.Drawing.Color.Transparent;
            this.to_next_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
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
            this.to_next_button.Location = new System.Drawing.Point(722, 274);
            this.to_next_button.Name = "to_next_button";
            this.to_next_button.Size = new System.Drawing.Size(63, 40);
            this.to_next_button.TabIndex = 66;
            this.to_next_button.UseTransparentBackground = true;
            this.to_next_button.Visible = false;
            this.to_next_button.Click += new System.EventHandler(this.to_next_button_Click);
            // 
            // to_previous_button
            // 
            this.to_previous_button.BackColor = System.Drawing.Color.Transparent;
            this.to_previous_button.CheckedState.FillColor = System.Drawing.Color.Transparent;
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
            this.to_previous_button.Location = new System.Drawing.Point(9, 274);
            this.to_previous_button.Name = "to_previous_button";
            this.to_previous_button.Size = new System.Drawing.Size(63, 40);
            this.to_previous_button.TabIndex = 65;
            this.to_previous_button.UseTransparentBackground = true;
            this.to_previous_button.Visible = false;
            this.to_previous_button.Click += new System.EventHandler(this.to_previous_button_Click);
            // 
            // DessertsInOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.ordersPanel);
            this.Controls.Add(this.dessertsInOrderHeaderPanel);
            this.Controls.Add(this.info_panel);
            this.Name = "DessertsInOrderControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.DessertsInOrderControl_Load);
            this.info_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logotype)).EndInit();
            this.dessertsInOrderHeaderPanel.ResumeLayout(false);
            this.dessertsInOrderHeaderPanel.PerformLayout();
            this.ordersPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse form_elipse;
        private Guna.UI2.WinForms.Guna2ShadowPanel info_panel;
        private Guna.UI2.WinForms.Guna2PictureBox logotype;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        private Guna.UI2.WinForms.Guna2Panel dessertsInOrderHeaderPanel;
        private Guna.UI2.WinForms.Guna2Panel ordersPanel;
        public Guna.UI2.WinForms.Guna2Button to_previous_button;
        public Guna.UI2.WinForms.Guna2Button to_next_button;
    }
}
