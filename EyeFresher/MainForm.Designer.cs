namespace EyeFresher
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tgDontDisturb = new MetroFramework.Controls.MetroToggle();
            this.tgStop1h = new MetroFramework.Controls.MetroToggle();
            this.tgStop2h = new MetroFramework.Controls.MetroToggle();
            this.lbTimer = new System.Windows.Forms.Label();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pbEyeinCorner = new System.Windows.Forms.PictureBox();
            this.btnShowSample = new MetroFramework.Controls.MetroButton();
            this.btnPreferences = new MetroFramework.Controls.MetroButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notificationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbEyeinCorner)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Do not disturb";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Stop for 1 hour";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Stop for 2 hours";
            // 
            // tgDontDisturb
            // 
            this.tgDontDisturb.AutoSize = true;
            this.tgDontDisturb.Location = new System.Drawing.Point(166, 77);
            this.tgDontDisturb.Name = "tgDontDisturb";
            this.tgDontDisturb.Size = new System.Drawing.Size(80, 17);
            this.tgDontDisturb.TabIndex = 3;
            this.tgDontDisturb.Text = "Off";
            this.tgDontDisturb.UseVisualStyleBackColor = true;
            this.tgDontDisturb.CheckedChanged += new System.EventHandler(this.tgDontDisturb_CheckedChanged);
            // 
            // tgStop1h
            // 
            this.tgStop1h.AutoSize = true;
            this.tgStop1h.Location = new System.Drawing.Point(166, 108);
            this.tgStop1h.Name = "tgStop1h";
            this.tgStop1h.Size = new System.Drawing.Size(80, 17);
            this.tgStop1h.TabIndex = 4;
            this.tgStop1h.Text = "Off";
            this.tgStop1h.UseVisualStyleBackColor = true;
            this.tgStop1h.CheckedChanged += new System.EventHandler(this.tgStop1h_CheckedChanged);
            // 
            // tgStop2h
            // 
            this.tgStop2h.AutoSize = true;
            this.tgStop2h.Location = new System.Drawing.Point(166, 137);
            this.tgStop2h.Name = "tgStop2h";
            this.tgStop2h.Size = new System.Drawing.Size(80, 17);
            this.tgStop2h.TabIndex = 5;
            this.tgStop2h.Text = "Off";
            this.tgStop2h.UseVisualStyleBackColor = true;
            this.tgStop2h.CheckedChanged += new System.EventHandler(this.tgStop2h_CheckedChanged);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTimer.Location = new System.Drawing.Point(267, 71);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(266, 65);
            this.lbTimer.TabIndex = 8;
            this.lbTimer.Text = "00:00:00:00";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(328, 135);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(136, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Time at the computer";
            // 
            // pbEyeinCorner
            // 
            this.pbEyeinCorner.Image = global::EyeFresher.Properties.Resources.eye1;
            this.pbEyeinCorner.Location = new System.Drawing.Point(357, 186);
            this.pbEyeinCorner.Name = "pbEyeinCorner";
            this.pbEyeinCorner.Size = new System.Drawing.Size(256, 256);
            this.pbEyeinCorner.TabIndex = 10;
            this.pbEyeinCorner.TabStop = false;
            // 
            // btnShowSample
            // 
            this.btnShowSample.Location = new System.Drawing.Point(23, 277);
            this.btnShowSample.Name = "btnShowSample";
            this.btnShowSample.Size = new System.Drawing.Size(223, 23);
            this.btnShowSample.TabIndex = 11;
            this.btnShowSample.Text = "Show notification sample";
            this.btnShowSample.Click += new System.EventHandler(this.btnShowSample_Click);
            // 
            // btnPreferences
            // 
            this.btnPreferences.Location = new System.Drawing.Point(24, 248);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Size = new System.Drawing.Size(222, 23);
            this.btnPreferences.TabIndex = 12;
            this.btnPreferences.Text = "Preferences";
            this.btnPreferences.Click += new System.EventHandler(this.btnPreferences_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // notificationTimer
            // 
            this.notificationTimer.Enabled = true;
            this.notificationTimer.Interval = 4000;
            this.notificationTimer.Tick += new System.EventHandler(this.notificationTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 320);
            this.Controls.Add(this.btnPreferences);
            this.Controls.Add(this.btnShowSample);
            this.Controls.Add(this.pbEyeinCorner);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.tgStop2h);
            this.Controls.Add(this.tgStop1h);
            this.Controls.Add(this.tgDontDisturb);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "EyeFresher 1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbEyeinCorner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroToggle tgDontDisturb;
        private MetroFramework.Controls.MetroToggle tgStop1h;
        private MetroFramework.Controls.MetroToggle tgStop2h;
        private System.Windows.Forms.Label lbTimer;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.PictureBox pbEyeinCorner;
        private MetroFramework.Controls.MetroButton btnShowSample;
        private MetroFramework.Controls.MetroButton btnPreferences;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer notificationTimer;
    }
}

