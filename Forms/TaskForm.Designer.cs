namespace ToDoApp_final.Forms
{
    partial class TaskForm
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
            saveBtn = new Button();
            descInput = new TextBox();
            titleInput = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            isDone = new CheckBox();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.BackColor = SystemColors.MenuHighlight;
            saveBtn.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = SystemColors.ButtonFace;
            saveBtn.Location = new Point(142, 520);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(405, 96);
            saveBtn.TabIndex = 20;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // descInput
            // 
            descInput.Location = new Point(142, 280);
            descInput.Multiline = true;
            descInput.Name = "descInput";
            descInput.Size = new Size(516, 100);
            descInput.TabIndex = 19;
            // 
            // titleInput
            // 
            titleInput.Location = new Point(408, 182);
            titleInput.Name = "titleInput";
            titleInput.Size = new Size(250, 27);
            titleInput.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.InfoText;
            label4.Location = new Point(131, 233);
            label4.Name = "label4";
            label4.Size = new Size(240, 44);
            label4.TabIndex = 17;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(131, 167);
            label3.Name = "label3";
            label3.Size = new Size(218, 44);
            label3.TabIndex = 16;
            label3.Text = "Task Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(160, 30);
            label1.Name = "label1";
            label1.Size = new Size(498, 108);
            label1.TabIndex = 14;
            label1.Text = "YourTask";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(380, 412);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 28);
            comboBox1.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(142, 396);
            label5.Name = "label5";
            label5.Size = new Size(194, 44);
            label5.TabIndex = 22;
            label5.Text = "Category";
            // 
            // isDone
            // 
            isDone.AutoSize = true;
            isDone.Font = new Font("Snap ITC", 19.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isDone.Location = new Point(270, 468);
            isDone.Name = "isDone";
            isDone.Size = new Size(224, 46);
            isDone.TabIndex = 24;
            isDone.Text = "Completed";
            isDone.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = SystemColors.GradientActiveCaption;
            cancelBtn.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = SystemColors.ActiveCaptionText;
            cancelBtn.Location = new Point(553, 520);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(96, 96);
            cancelBtn.TabIndex = 25;
            cancelBtn.Text = "X";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 731);
            Controls.Add(cancelBtn);
            Controls.Add(isDone);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(saveBtn);
            Controls.Add(descInput);
            Controls.Add(titleInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "TaskForm";
            Text = "TaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveBtn;
        private TextBox descInput;
        private TextBox titleInput;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox comboBox1;
        private Label label5;
        private CheckBox isDone;
        private Button cancelBtn;
    }
}