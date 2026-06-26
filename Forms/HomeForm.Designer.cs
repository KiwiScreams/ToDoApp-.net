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
            label1 = new Label();
            editAccountButton = new Button();
            addTaskBtn = new Button();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.BackColor = SystemColors.GradientInactiveCaption;
            logoutButton.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = SystemColors.MenuHighlight;
            logoutButton.Location = new Point(12, 600);
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
            usernameLabel.Location = new Point(281, 115);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(229, 44);
            usernameLabel.TabIndex = 16;
            usernameLabel.Text = "Your Name";
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
            // editAccountButton
            // 
            editAccountButton.BackColor = SystemColors.GradientInactiveCaption;
            editAccountButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editAccountButton.ForeColor = SystemColors.InfoText;
            editAccountButton.Location = new Point(499, 173);
            editAccountButton.Name = "editAccountButton";
            editAccountButton.Size = new Size(120, 33);
            editAccountButton.TabIndex = 19;
            editAccountButton.Text = "Edit Account";
            editAccountButton.UseVisualStyleBackColor = false;
            editAccountButton.Click += editAccountButton_Click;
            // 
            // addTaskBtn
            // 
            addTaskBtn.BackColor = SystemColors.MenuHighlight;
            addTaskBtn.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTaskBtn.ForeColor = SystemColors.Info;
            addTaskBtn.Location = new Point(694, 572);
            addTaskBtn.Name = "addTaskBtn";
            addTaskBtn.Size = new Size(88, 82);
            addTaskBtn.TabIndex = 20;
            addTaskBtn.Text = "+";
            addTaskBtn.UseVisualStyleBackColor = false;
            addTaskBtn.Click += addTaskBtn_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 666);
            Controls.Add(addTaskBtn);
            Controls.Add(editAccountButton);
            Controls.Add(logoutButton);
            Controls.Add(usernameLabel);
            Controls.Add(label1);
            Name = "HomeForm";
            Text = "HomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutButton;
        private Label usernameLabel;
        private Label label1;
        private Button editAccountButton;
        private Button addTaskBtn;
    }
}