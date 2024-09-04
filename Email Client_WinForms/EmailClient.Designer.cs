namespace Email_Client_WinForms
{
    partial class EmailClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailClient));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Email_txtBox = new TextBox();
            Subject_txtBox = new TextBox();
            Message_txtBox = new TextBox();
            Send_btn = new Button();
            Close_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(74, 138);
            label1.Name = "label1";
            label1.Size = new Size(114, 22);
            label1.TabIndex = 1;
            label1.Text = "Send Email";
            // 
            // Email_txtBox
            // 
            Email_txtBox.BackColor = SystemColors.ControlLight;
            Email_txtBox.BorderStyle = BorderStyle.None;
            Email_txtBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email_txtBox.ForeColor = Color.Gray;
            Email_txtBox.Location = new Point(35, 200);
            Email_txtBox.Multiline = true;
            Email_txtBox.Name = "Email_txtBox";
            Email_txtBox.Size = new Size(202, 27);
            Email_txtBox.TabIndex = 2;
            Email_txtBox.Text = "Email";
            Email_txtBox.Enter += Email_txtBox_Enter;
            Email_txtBox.Leave += Email_txtBox_Leave;
            // 
            // Subject_txtBox
            // 
            Subject_txtBox.BackColor = SystemColors.ControlLight;
            Subject_txtBox.BorderStyle = BorderStyle.None;
            Subject_txtBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Subject_txtBox.ForeColor = Color.Gray;
            Subject_txtBox.Location = new Point(35, 251);
            Subject_txtBox.Multiline = true;
            Subject_txtBox.Name = "Subject_txtBox";
            Subject_txtBox.Size = new Size(202, 27);
            Subject_txtBox.TabIndex = 3;
            Subject_txtBox.Text = "Subject";
            Subject_txtBox.Enter += Subject_txtBox_Enter;
            Subject_txtBox.Leave += Subject_txtBox_Leave;
            // 
            // Message_txtBox
            // 
            Message_txtBox.BackColor = SystemColors.ControlLight;
            Message_txtBox.BorderStyle = BorderStyle.None;
            Message_txtBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Message_txtBox.ForeColor = Color.Gray;
            Message_txtBox.Location = new Point(35, 300);
            Message_txtBox.Multiline = true;
            Message_txtBox.Name = "Message_txtBox";
            Message_txtBox.Size = new Size(202, 81);
            Message_txtBox.TabIndex = 4;
            Message_txtBox.Text = "Message";
            Message_txtBox.Enter += Message_txtBox_Enter;
            Message_txtBox.Leave += Message_txtBox_Leave;
            // 
            // Send_btn
            // 
            Send_btn.BackColor = Color.Green;
            Send_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Send_btn.ForeColor = Color.White;
            Send_btn.Location = new Point(35, 387);
            Send_btn.Name = "Send_btn";
            Send_btn.Size = new Size(202, 34);
            Send_btn.TabIndex = 5;
            Send_btn.Text = "Send Email";
            Send_btn.UseVisualStyleBackColor = false;
            Send_btn.Click += Send_btn_Click;
            // 
            // Close_btn
            // 
            Close_btn.BackColor = Color.Green;
            Close_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_btn.ForeColor = Color.White;
            Close_btn.Location = new Point(222, 7);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(30, 30);
            Close_btn.TabIndex = 6;
            Close_btn.Text = "X";
            Close_btn.UseVisualStyleBackColor = false;
            Close_btn.Click += Close_btn_Click;
            // 
            // EmailClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(259, 461);
            Controls.Add(Close_btn);
            Controls.Add(Send_btn);
            Controls.Add(Message_txtBox);
            Controls.Add(Subject_txtBox);
            Controls.Add(Email_txtBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 9F);
            ForeColor = Color.Green;
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmailClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Email Application";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox Email_txtBox;
        private TextBox Subject_txtBox;
        private TextBox Message_txtBox;
        private Button Send_btn;
        private Button Close_btn;
    }
}
