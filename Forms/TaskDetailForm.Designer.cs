namespace ToDoApp_final.Forms
{
    partial class TaskDetailForm
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
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            titleBox = new Label();
            descBox = new Label();
            catBox = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.InfoText;
            label4.Location = new Point(109, 311);
            label4.Name = "label4";
            label4.Size = new Size(240, 44);
            label4.TabIndex = 21;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(109, 166);
            label3.Name = "label3";
            label3.Size = new Size(218, 44);
            label3.TabIndex = 20;
            label3.Text = "Task Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(138, 29);
            label1.Name = "label1";
            label1.Size = new Size(498, 108);
            label1.TabIndex = 19;
            label1.Text = "YourTask";
            // 
            // titleBox
            // 
            titleBox.AutoSize = true;
            titleBox.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleBox.ForeColor = SystemColors.MenuHighlight;
            titleBox.Location = new Point(385, 166);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(218, 44);
            titleBox.TabIndex = 22;
            titleBox.Text = "Task Title";
            // 
            // descBox
            // 
            descBox.AutoSize = true;
            descBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descBox.Location = new Point(108, 373);
            descBox.Name = "descBox";
            descBox.Size = new Size(76, 31);
            descBox.TabIndex = 23;
            descBox.Text = "label5";
            // 
            // catBox
            // 
            catBox.AutoSize = true;
            catBox.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            catBox.ForeColor = SystemColors.MenuHighlight;
            catBox.Location = new Point(385, 230);
            catBox.Name = "catBox";
            catBox.Size = new Size(218, 44);
            catBox.TabIndex = 25;
            catBox.Text = "Task Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(109, 230);
            label5.Name = "label5";
            label5.Size = new Size(194, 44);
            label5.TabIndex = 24;
            label5.Text = "Category";
            // 
            // TaskDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 640);
            Controls.Add(catBox);
            Controls.Add(label5);
            Controls.Add(descBox);
            Controls.Add(titleBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "TaskDetailForm";
            Text = "TaskDetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label1;
        private Label titleBox;
        private Label descBox;
        private Label catBox;
        private Label label5;
    }
}