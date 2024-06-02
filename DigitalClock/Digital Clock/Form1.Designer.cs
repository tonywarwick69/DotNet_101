namespace Digital_Clock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTime = new Label();
            lblSec = new Label();
            lblDate = new Label();
            lblWDay = new Label();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.BackColor = SystemColors.ActiveCaptionText;
            lblTime.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = SystemColors.ControlLightLight;
            lblTime.Location = new Point(293, 160);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(234, 106);
            lblTime.TabIndex = 0;
            lblTime.Text = "22:22";
            lblTime.Click += label1_Click;
            // 
            // lblSec
            // 
            lblSec.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSec.AutoSize = true;
            lblSec.BackColor = SystemColors.ActiveCaptionText;
            lblSec.Font = new Font("Segoe UI", 30F);
            lblSec.ForeColor = SystemColors.ControlLightLight;
            lblSec.Location = new Point(533, 193);
            lblSec.Name = "lblSec";
            lblSec.Size = new Size(67, 54);
            lblSec.TabIndex = 1;
            lblSec.Text = "30";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.BackColor = SystemColors.ActiveCaptionText;
            lblDate.Font = new Font("Segoe UI", 20F);
            lblDate.ForeColor = SystemColors.ControlLightLight;
            lblDate.Location = new Point(358, 283);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(73, 37);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            // 
            // lblWDay
            // 
            lblWDay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblWDay.AutoSize = true;
            lblWDay.BackColor = SystemColors.ActiveCaptionText;
            lblWDay.Font = new Font("Segoe UI", 20F);
            lblWDay.ForeColor = SystemColors.ControlLightLight;
            lblWDay.Location = new Point(533, 283);
            lblWDay.Name = "lblWDay";
            lblWDay.Size = new Size(135, 37);
            lblWDay.TabIndex = 3;
            lblWDay.Text = "Week Day";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1010, 547);
            Controls.Add(lblWDay);
            Controls.Add(lblDate);
            Controls.Add(lblSec);
            Controls.Add(lblTime);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Label lblSec;
        private Label lblDate;
        private Label lblWDay;
        private System.Windows.Forms.Timer timer;
    }
}
