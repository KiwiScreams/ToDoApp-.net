namespace ToDoApp_final.Forms
{
    partial class RegisterForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            registerUsernameInput = new TextBox();
            registerPasswordInput = new TextBox();
            registerButton = new Button();
            SignInButton = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(210, 9);
            label1.Name = "label1";
            label1.Size = new Size(498, 108);
            label1.TabIndex = 0;
            label1.Text = "YourTask";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(326, 96);
            label2.Name = "label2";
            label2.Size = new Size(257, 64);
            label2.TabIndex = 1;
            label2.Text = "Sign Up";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(170, 175);
            label3.Name = "label3";
            label3.Size = new Size(229, 44);
            label3.TabIndex = 2;
            label3.Text = "Your Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.InfoText;
            label4.Location = new Point(170, 240);
            label4.Name = "label4";
            label4.Size = new Size(204, 44);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // registerUsernameInput
            // 
            registerUsernameInput.Location = new Point(447, 190);
            registerUsernameInput.Name = "registerUsernameInput";
            registerUsernameInput.Size = new Size(250, 27);
            registerUsernameInput.TabIndex = 4;
            // 
            // registerPasswordInput
            // 
            registerPasswordInput.Location = new Point(447, 255);
            registerPasswordInput.Name = "registerPasswordInput";
            registerPasswordInput.Size = new Size(250, 27);
            registerPasswordInput.TabIndex = 5;
            // 
            // registerButton
            // 
            registerButton.BackColor = SystemColors.MenuHighlight;
            registerButton.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerButton.ForeColor = SystemColors.ButtonFace;
            registerButton.Location = new Point(255, 327);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(368, 96);
            registerButton.TabIndex = 6;
            registerButton.Text = "Sign Up";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = SystemColors.ButtonHighlight;
            SignInButton.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignInButton.ForeColor = Color.RoyalBlue;
            SignInButton.Location = new Point(513, 429);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(110, 36);
            SignInButton.TabIndex = 17;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(255, 436);
            label5.Name = "label5";
            label5.Size = new Size(200, 24);
            label5.TabIndex = 16;
            label5.Text = "Already have an account?";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 553);
            Controls.Add(SignInButton);
            Controls.Add(label5);
            Controls.Add(registerButton);
            Controls.Add(registerPasswordInput);
            Controls.Add(registerUsernameInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox registerUsernameInput;
        private TextBox registerPasswordInput;
        private Button registerButton;
        private Button SignInButton;
        private Label label5;
    }
}