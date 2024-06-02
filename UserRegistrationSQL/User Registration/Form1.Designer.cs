namespace User_Registration
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
            label1 = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtPassword2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSignUp = new Button();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 49);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // txtFName
            // 
            txtFName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFName.Font = new Font("Segoe UI", 12F);
            txtFName.Location = new Point(236, 41);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(374, 29);
            txtFName.TabIndex = 1;
            txtFName.TextChanged += txtFName_TextChanged;
            // 
            // txtLName
            // 
            txtLName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLName.Font = new Font("Segoe UI", 12F);
            txtLName.Location = new Point(236, 96);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(374, 29);
            txtLName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(236, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(374, 29);
            txtEmail.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Font = new Font("Segoe UI", 12F);
            txtAddress.Location = new Point(236, 219);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(374, 89);
            txtAddress.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(236, 346);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(374, 29);
            txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(236, 405);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(374, 29);
            txtPassword.TabIndex = 11;
            // 
            // txtPassword2
            // 
            txtPassword2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword2.Font = new Font("Segoe UI", 12F);
            txtPassword2.Location = new Point(236, 470);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(374, 29);
            txtPassword2.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 44);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 0;
            label2.Text = "First Name";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 104);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 14;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(75, 160);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 15;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(68, 251);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 16;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(68, 349);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 17;
            label6.Text = "User Name";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(68, 408);
            label7.Name = "label7";
            label7.Size = new Size(82, 21);
            label7.TabIndex = 18;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(68, 473);
            label8.Name = "label8";
            label8.Size = new Size(148, 21);
            label8.TabIndex = 19;
            label8.Text = "Confirm Password";
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(280, 544);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(247, 40);
            btnSignUp.TabIndex = 20;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(628, 354);
            label9.Name = "label9";
            label9.Size = new Size(17, 21);
            label9.TabIndex = 21;
            label9.Text = "*";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(628, 408);
            label10.Name = "label10";
            label10.Size = new Size(17, 21);
            label10.TabIndex = 21;
            label10.Text = "*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 620);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnSignUp);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassword2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "User Registration Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtPassword2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSignUp;
        private Label label9;
        private Label label10;
    }
}
