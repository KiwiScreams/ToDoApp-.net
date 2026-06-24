namespace ToDoApp_final.Forms
{
    partial class EditAccount
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
            saveButton = new Button();
            registerPasswordInput = new TextBox();
            registerUsernameInput = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            registerEmailInput = new TextBox();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.MenuHighlight;
            saveButton.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.ForeColor = SystemColors.ButtonFace;
            saveButton.Location = new Point(209, 367);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(368, 96);
            saveButton.TabIndex = 26;
            saveButton.Text = "Save Changes";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // registerPasswordInput
            // 
            registerPasswordInput.Location = new Point(425, 286);
            registerPasswordInput.Name = "registerPasswordInput";
            registerPasswordInput.Size = new Size(250, 27);
            registerPasswordInput.TabIndex = 25;
            // 
            // registerUsernameInput
            // 
            registerUsernameInput.Location = new Point(425, 169);
            registerUsernameInput.Name = "registerUsernameInput";
            registerUsernameInput.Size = new Size(250, 27);
            registerUsernameInput.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.InfoText;
            label4.Location = new Point(126, 271);
            label4.Name = "label4";
            label4.Size = new Size(204, 44);
            label4.TabIndex = 23;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(126, 154);
            label3.Name = "label3";
            label3.Size = new Size(229, 44);
            label3.TabIndex = 22;
            label3.Text = "Your Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(218, 79);
            label2.Name = "label2";
            label2.Size = new Size(414, 64);
            label2.TabIndex = 21;
            label2.Text = "Edit Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(166, -12);
            label1.Name = "label1";
            label1.Size = new Size(498, 108);
            label1.TabIndex = 20;
            label1.Text = "YourTask";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.InfoText;
            label6.Location = new Point(126, 213);
            label6.Name = "label6";
            label6.Size = new Size(293, 44);
            label6.TabIndex = 27;
            label6.Text = "Email Address";
            // 
            // registerEmailInput
            // 
            registerEmailInput.Location = new Point(425, 228);
            registerEmailInput.Name = "registerEmailInput";
            registerEmailInput.Size = new Size(250, 27);
            registerEmailInput.TabIndex = 28;
            // 
            // EditAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 511);
            Controls.Add(registerEmailInput);
            Controls.Add(label6);
            Controls.Add(saveButton);
            Controls.Add(registerPasswordInput);
            Controls.Add(registerUsernameInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditAccount";
            Text = "EditAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private TextBox registerPasswordInput;
        private TextBox registerUsernameInput;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox registerEmailInput;
    }
}