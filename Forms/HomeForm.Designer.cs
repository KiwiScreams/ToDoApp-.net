namespace ToDoApp_final.Forms
{
    partial class HomeForm
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
            logoutButton = new Button();
            usernameLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.BackColor = SystemColors.GradientInactiveCaption;
            logoutButton.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = SystemColors.MenuHighlight;
            logoutButton.Location = new Point(573, 481);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(184, 54);
            logoutButton.TabIndex = 18;
            logoutButton.Text = "Log out";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = SystemColors.InfoText;
            usernameLabel.Location = new Point(390, 126);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(229, 44);
            usernameLabel.TabIndex = 16;
            usernameLabel.Text = "Your Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(114, 110);
            label2.Name = "label2";
            label2.Size = new Size(270, 64);
            label2.TabIndex = 15;
            label2.Text = "Welcome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(171, 18);
            label1.Name = "label1";
            label1.Size = new Size(498, 108);
            label1.TabIndex = 14;
            label1.Text = "YourTask";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(499, 173);
            button1.Name = "button1";
            button1.Size = new Size(120, 33);
            button1.TabIndex = 19;
            button1.Text = "Edit Account";
            button1.UseVisualStyleBackColor = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 547);
            Controls.Add(button1);
            Controls.Add(logoutButton);
            Controls.Add(usernameLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HomeForm";
            Text = "HomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutButton;
        private Label usernameLabel;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}