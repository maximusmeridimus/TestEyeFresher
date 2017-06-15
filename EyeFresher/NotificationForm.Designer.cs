namespace EyeFresher
{
    partial class NotificationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_MainText = new System.Windows.Forms.Label();
            this.label_SecondaryText = new System.Windows.Forms.Label();
            this.pbCoffee = new System.Windows.Forms.PictureBox();
            this.label_PresstheCup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // label_MainText
            // 
            this.label_MainText.AutoSize = true;
            this.label_MainText.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_MainText.Location = new System.Drawing.Point(137, 37);
            this.label_MainText.Name = "label_MainText";
            this.label_MainText.Size = new System.Drawing.Size(279, 33);
            this.label_MainText.TabIndex = 4;
            this.label_MainText.Text = "You are sitting too long...";
            // 
            // label_SecondaryText
            // 
            this.label_SecondaryText.AutoSize = true;
            this.label_SecondaryText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SecondaryText.Location = new System.Drawing.Point(138, 70);
            this.label_SecondaryText.Name = "label_SecondaryText";
            this.label_SecondaryText.Size = new System.Drawing.Size(140, 30);
            this.label_SecondaryText.TabIndex = 5;
            this.label_SecondaryText.Text = "Have a break!";
            // 
            // pbCoffee
            // 
            this.pbCoffee.Image = global::EyeFresher.Properties.Resources.coffee_cup;
            this.pbCoffee.Location = new System.Drawing.Point(23, 28);
            this.pbCoffee.Name = "pbCoffee";
            this.pbCoffee.Size = new System.Drawing.Size(96, 96);
            this.pbCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCoffee.TabIndex = 0;
            this.pbCoffee.TabStop = false;
            this.pbCoffee.Click += new System.EventHandler(this.pbCoffee_Click);
            this.pbCoffee.MouseEnter += new System.EventHandler(this.pbCoffee_MouseEnter);
            this.pbCoffee.MouseLeave += new System.EventHandler(this.pbCoffee_MouseLeave);
            // 
            // label_PresstheCup
            // 
            this.label_PresstheCup.AutoSize = true;
            this.label_PresstheCup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PresstheCup.Location = new System.Drawing.Point(140, 107);
            this.label_PresstheCup.Name = "label_PresstheCup";
            this.label_PresstheCup.Size = new System.Drawing.Size(149, 17);
            this.label_PresstheCup.TabIndex = 6;
            this.label_PresstheCup.Text = "Press a cup to close this";
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(441, 147);
            this.Controls.Add(this.label_PresstheCup);
            this.Controls.Add(this.label_SecondaryText);
            this.Controls.Add(this.label_MainText);
            this.Controls.Add(this.pbCoffee);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationForm";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbCoffee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCoffee;
        private System.Windows.Forms.Label label_MainText;
        private System.Windows.Forms.Label label_SecondaryText;
        private System.Windows.Forms.Label label_PresstheCup;
    }
}