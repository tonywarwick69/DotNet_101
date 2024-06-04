namespace Login_App
{
    partial class frmMain
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
            lblWelcome = new Label();
            lblHello = new Label();
            loginControl1 = new LoginControl.LoginControl();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(201, 131);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(430, 50);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to Dashboard";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.Font = new Font("Segoe UI", 13F);
            lblHello.Location = new Point(596, 40);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(93, 25);
            lblHello.TabIndex = 1;
            lblHello.Text = "Hello User";
            lblHello.Click += lblHello_Click;
            // 
            // loginControl1
            // 
            loginControl1.AutoSize = true;
            loginControl1.Location = new Point(194, 292);
            loginControl1.MinimumSize = new Size(45, 22);
            loginControl1.Name = "loginControl1";
            loginControl1.Size = new Size(99, 22);
            loginControl1.TabIndex = 2;
            loginControl1.Text = "loginControl1";
            loginControl1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginControl1);
            Controls.Add(lblHello);
            Controls.Add(lblWelcome);
            Name = "frmMain";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblHello;
        private LoginControl.LoginControl loginControl1;
    }
}