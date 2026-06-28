using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

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
            todoPanel = new FlowLayoutPanel();
            completedPanel = new FlowLayoutPanel();
            label2 = new Label();
            Done = new Label();
            categoryFilter = new ComboBox();
            label3 = new Label();
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
            usernameLabel.Location = new Point(282, 92);
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
            label1.Location = new Point(161, -2);
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
            editAccountButton.Location = new Point(212, 621);
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
            // todoPanel
            // 
            todoPanel.AllowDrop = true;
            todoPanel.AutoScroll = true;
            todoPanel.BackColor = SystemColors.AppWorkspace;
            todoPanel.BorderStyle = BorderStyle.FixedSingle;
            todoPanel.FlowDirection = FlowDirection.TopDown;
            todoPanel.Location = new Point(12, 247);
            todoPanel.Name = "todoPanel";
            todoPanel.Size = new Size(350, 307);
            todoPanel.TabIndex = 21;
            todoPanel.WrapContents = false;
            // 
            // completedPanel
            // 
            completedPanel.AllowDrop = true;
            completedPanel.AutoScroll = true;
            completedPanel.BackColor = SystemColors.ActiveCaption;
            completedPanel.BorderStyle = BorderStyle.FixedSingle;
            completedPanel.FlowDirection = FlowDirection.TopDown;
            completedPanel.Location = new Point(429, 242);
            completedPanel.Name = "completedPanel";
            completedPanel.Size = new Size(350, 320);
            completedPanel.TabIndex = 22;
            completedPanel.WrapContents = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(117, 190);
            label2.Name = "label2";
            label2.Size = new Size(125, 44);
            label2.TabIndex = 23;
            label2.Text = "To Do";
            // 
            // Done
            // 
            Done.AutoSize = true;
            Done.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Done.ForeColor = SystemColors.InfoText;
            Done.Location = new Point(552, 190);
            Done.Name = "Done";
            Done.Size = new Size(107, 44);
            Done.TabIndex = 24;
            Done.Text = "Done";
            // 
            // categoryFilter
            // 
            categoryFilter.FormattingEnabled = true;
            categoryFilter.Location = new Point(316, 205);
            categoryFilter.Name = "categoryFilter";
            categoryFilter.Size = new Size(151, 28);
            categoryFilter.TabIndex = 25;
            categoryFilter.SelectedIndexChanged += categoryFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(282, 178);
            label3.Name = "label3";
            label3.Size = new Size(204, 24);
            label3.TabIndex = 26;
            label3.Text = "Filter by Category";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 666);
            Controls.Add(label3);
            Controls.Add(categoryFilter);
            Controls.Add(Done);
            Controls.Add(label2);
            Controls.Add(completedPanel);
            Controls.Add(todoPanel);
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
        private FlowLayoutPanel todoPanel;
        private FlowLayoutPanel completedPanel;
        private Label label2;
        private Label Done;
        private ComboBox categoryFilter;
        private Label label3;
    }
}