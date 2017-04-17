namespace Alarm_Clock
{
    partial class AlarmClockForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmClockForm));
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.currentTimeLbl2 = new System.Windows.Forms.Label();
            this.wakeUpTime = new System.Windows.Forms.TextBox();
            this.alarmSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hiddenLbl = new System.Windows.Forms.Label();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Location = new System.Drawing.Point(97, 36);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(70, 13);
            this.CurrentTimeLabel.TabIndex = 0;
            this.CurrentTimeLabel.Text = "Current Time:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // currentTimeLbl2
            // 
            this.currentTimeLbl2.AutoSize = true;
            this.currentTimeLbl2.Location = new System.Drawing.Point(118, 63);
            this.currentTimeLbl2.Name = "currentTimeLbl2";
            this.currentTimeLbl2.Size = new System.Drawing.Size(0, 13);
            this.currentTimeLbl2.TabIndex = 1;
            // 
            // wakeUpTime
            // 
            this.wakeUpTime.Location = new System.Drawing.Point(85, 105);
            this.wakeUpTime.Name = "wakeUpTime";
            this.wakeUpTime.Size = new System.Drawing.Size(100, 20);
            this.wakeUpTime.TabIndex = 2;
            // 
            // alarmSet
            // 
            this.alarmSet.Location = new System.Drawing.Point(100, 140);
            this.alarmSet.Name = "alarmSet";
            this.alarmSet.Size = new System.Drawing.Size(75, 23);
            this.alarmSet.TabIndex = 3;
            this.alarmSet.Text = "Set Alarm";
            this.alarmSet.UseVisualStyleBackColor = true;
            this.alarmSet.Click += new System.EventHandler(this.alarmSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // hiddenLbl
            // 
            this.hiddenLbl.AutoSize = true;
            this.hiddenLbl.Location = new System.Drawing.Point(13, 129);
            this.hiddenLbl.Name = "hiddenLbl";
            this.hiddenLbl.Size = new System.Drawing.Size(0, 13);
            this.hiddenLbl.TabIndex = 5;
            this.hiddenLbl.Visible = false;
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(72, 224);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(145, 36);
            this.axShockwaveFlash1.TabIndex = 7;
            this.axShockwaveFlash1.Visible = false;
            // 
            // AlarmClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Controls.Add(this.hiddenLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alarmSet);
            this.Controls.Add(this.wakeUpTime);
            this.Controls.Add(this.currentTimeLbl2);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Name = "AlarmClockForm";
            this.Text = "Alarm Clock";
            this.Load += new System.EventHandler(this.AlarmClockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label currentTimeLbl2;
        private System.Windows.Forms.TextBox wakeUpTime;
        private System.Windows.Forms.Button alarmSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hiddenLbl;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
    }
}

