namespace ToDoApp_final.Forms
{
    partial class LoginForm
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
            registerButton = new Button();
            registerPasswordInput = new TextBox();
            registerUsernameInput = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            SignUpButton = new Button();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.BackColor = SystemColors.MenuHighlight;
            registerButton.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerButton.ForeColor = SystemColors.ButtonFace;
            registerButton.Location = new Point(216, 336);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(368, 96);
            registerButton.TabIndex = 13;
            registerButton.Text = "Sign In";
            registerButton.UseVisualStyleBackColor = false;
            // 
            // registerPasswordInput
            // 
            registerPasswordInput.Location = new Point(408, 264);
            registerPasswordInput.Name = "registerPasswordInput";
            registerPasswordInput.Size = new Size(250, 27);
            registerPasswordInput.TabIndex = 12;
            // 
            // registerUsernameInput
            // 
            registerUsernameInput.Location = new Point(408, 199);
            registerUsernameInput.Name = "registerUsernameInput";
            registerUsernameInput.Size = new Size(250, 27);
            registerUsernameInput.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.InfoText;
            label4.Location = new Point(131, 249);
            label4.Name = "label4";
            label4.Size = new Size(204, 44);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(131, 184);
            label3.Name = "label3";
            label3.Size = new Size(229, 44);
            label3.TabIndex = 9;
            label3.Text = "Your Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(287, 105);
            label2.Name = "label2";
            label2.Size = new Size(242, 64);
            label2.TabIndex = 8;
            label2.Text = "Sign In";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(171, 18);
            label1.Name = "label1";
            label1.Size = new Size(498, 108);
            label1.TabIndex = 7;
            label1.Text = "YourTask";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(221, 435);
            label5.Name = "label5";
            label5.Size = new Size(183, 24);
            label5.TabIndex = 14;
            label5.Text = "Don't have an account?";
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = SystemColors.ButtonHighlight;
            SignUpButton.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUpButton.ForeColor = Color.RoyalBlue;
            SignUpButton.Location = new Point(462, 435);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(122, 36);
            SignUpButton.TabIndex = 15;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 538);
            Controls.Add(SignUpButton);
            Controls.Add(label5);
            Controls.Add(registerButton);
            Controls.Add(registerPasswordInput);
            Controls.Add(registerUsernameInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private TextBox registerPasswordInput;
        private TextBox registerUsernameInput;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button SignUpButton;
    }
}