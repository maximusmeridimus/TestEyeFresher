namespace EyeFresher
{
    partial class PreferenceForm
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
            this.tbOpacity = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbDelayTime = new MetroFramework.Controls.MetroTextBox();
            this.lbOpacityPercentage = new MetroFramework.Controls.MetroLabel();
            this.lbDimmingPercentage = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbDimming = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tgAutoRun = new MetroFramework.Controls.MetroToggle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOpacity
            // 
            this.tbOpacity.BackColor = System.Drawing.Color.Transparent;
            this.tbOpacity.Location = new System.Drawing.Point(150, 67);
            this.tbOpacity.Maximum = 30;
            this.tbOpacity.Name = "tbOpacity";
            this.tbOpacity.Size = new System.Drawing.Size(127, 23);
            this.tbOpacity.TabIndex = 0;
            this.tbOpacity.Text = "metroTrackBar1";
            this.tbOpacity.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbOpacity_Scroll);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Opacity";
            // 
            // tbDelayTime
            // 
            this.tbDelayTime.Location = new System.Drawing.Point(208, 136);
            this.tbDelayTime.Name = "tbDelayTime";
            this.tbDelayTime.Size = new System.Drawing.Size(32, 23);
            this.tbDelayTime.TabIndex = 2;
            this.tbDelayTime.Text = "60";
            this.tbDelayTime.Click += new System.EventHandler(this.tbDelayTime_Click);
            // 
            // lbOpacityPercentage
            // 
            this.lbOpacityPercentage.AutoSize = true;
            this.lbOpacityPercentage.Location = new System.Drawing.Point(111, 67);
            this.lbOpacityPercentage.Name = "lbOpacityPercentage";
            this.lbOpacityPercentage.Size = new System.Drawing.Size(32, 19);
            this.lbOpacityPercentage.TabIndex = 3;
            this.lbOpacityPercentage.Text = "10%";
            // 
            // lbDimmingPercentage
            // 
            this.lbDimmingPercentage.AutoSize = true;
            this.lbDimmingPercentage.Location = new System.Drawing.Point(111, 98);
            this.lbDimmingPercentage.Name = "lbDimmingPercentage";
            this.lbDimmingPercentage.Size = new System.Drawing.Size(32, 19);
            this.lbDimmingPercentage.TabIndex = 6;
            this.lbDimmingPercentage.Text = "10%";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 97);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Dimming";
            // 
            // tbDimming
            // 
            this.tbDimming.BackColor = System.Drawing.Color.Transparent;
            this.tbDimming.Location = new System.Drawing.Point(150, 98);
            this.tbDimming.Maximum = 30;
            this.tbDimming.Name = "tbDimming";
            this.tbDimming.Size = new System.Drawing.Size(127, 23);
            this.tbDimming.TabIndex = 4;
            this.tbDimming.Text = "metroTrackBar2";
            this.tbDimming.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbDimming_Scroll);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 136);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Delay time";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(246, 140);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(31, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "min";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EyeFresher.Properties.Resources.eye1;
            this.pictureBox1.Location = new System.Drawing.Point(131, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tgAutoRun
            // 
            this.tgAutoRun.AutoSize = true;
            this.tgAutoRun.Location = new System.Drawing.Point(168, 172);
            this.tgAutoRun.Name = "tgAutoRun";
            this.tgAutoRun.Size = new System.Drawing.Size(80, 17);
            this.tgAutoRun.TabIndex = 11;
            this.tgAutoRun.Text = "Off";
            this.tgAutoRun.UseVisualStyleBackColor = true;
            this.tgAutoRun.CheckedChanged += new System.EventHandler(this.tgAutoRun_CheckedChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 170);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(127, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Run at launching OS";
            // 
            // PreferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 320);
            this.Controls.Add(this.tgAutoRun);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lbDimmingPercentage);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tbDimming);
            this.Controls.Add(this.lbOpacityPercentage);
            this.Controls.Add(this.tbDelayTime);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbOpacity);
            this.Name = "PreferenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.PreferenceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTrackBar tbOpacity;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbDelayTime;
        private MetroFramework.Controls.MetroLabel lbOpacityPercentage;
        private MetroFramework.Controls.MetroLabel lbDimmingPercentage;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTrackBar tbDimming;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroToggle tgAutoRun;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}