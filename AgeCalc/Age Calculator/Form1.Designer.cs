namespace Age_Calculator
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
            label2 = new Label();
            datePicker_birthDate = new DateTimePicker();
            datePicker_currentDate = new DateTimePicker();
            btnCalcAge = new Button();
            btnCalcFullAge = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(45, 56);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 0;
            label1.Text = "Date of birth";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(45, 142);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 1;
            label2.Text = "Current date";
            // 
            // datePicker_birthDate
            // 
            datePicker_birthDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datePicker_birthDate.Font = new Font("Segoe UI", 12F);
            datePicker_birthDate.Location = new Point(263, 56);
            datePicker_birthDate.Name = "datePicker_birthDate";
            datePicker_birthDate.Size = new Size(247, 29);
            datePicker_birthDate.TabIndex = 2;
            datePicker_birthDate.ValueChanged += datePicker_birthDate_ValueChanged;
            // 
            // datePicker_currentDate
            // 
            datePicker_currentDate.AccessibleRole = AccessibleRole.TitleBar;
            datePicker_currentDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datePicker_currentDate.CalendarFont = new Font("Segoe UI", 12F);
            datePicker_currentDate.Location = new Point(263, 142);
            datePicker_currentDate.Name = "datePicker_currentDate";
            datePicker_currentDate.Size = new Size(247, 23);
            datePicker_currentDate.TabIndex = 3;
            datePicker_currentDate.ValueChanged += datePicker_currentDate_ValueChanged;
            // 
            // btnCalcAge
            // 
            btnCalcAge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCalcAge.Location = new Point(263, 238);
            btnCalcAge.Name = "btnCalcAge";
            btnCalcAge.Size = new Size(198, 30);
            btnCalcAge.TabIndex = 4;
            btnCalcAge.Text = "Calculate Age";
            btnCalcAge.UseVisualStyleBackColor = true;
            btnCalcAge.Click += button1_Click;
            // 
            // btnCalcFullAge
            // 
            btnCalcFullAge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCalcFullAge.Location = new Point(263, 295);
            btnCalcFullAge.Name = "btnCalcFullAge";
            btnCalcFullAge.Size = new Size(198, 30);
            btnCalcFullAge.TabIndex = 5;
            btnCalcFullAge.Text = "Calculate Detail Age";
            btnCalcFullAge.UseVisualStyleBackColor = true;
            btnCalcFullAge.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcFullAge);
            Controls.Add(btnCalcAge);
            Controls.Add(datePicker_currentDate);
            Controls.Add(datePicker_birthDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Age Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker datePicker_birthDate;
        private DateTimePicker datePicker_currentDate;
        private Button btnCalcAge;
        private Button btnCalcFullAge;
    }
}
