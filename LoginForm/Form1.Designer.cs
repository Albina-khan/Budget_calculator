namespace LoginForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            username = new TextBox();
            password = new TextBox();
            loginBtn = new Button();
            exitBtn = new Button();
            reBtn = new Button();
            backTosignup = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 412);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(81, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(353, 51);
            label1.Name = "label1";
            label1.Size = new Size(150, 42);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 125);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 190);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "password";
            // 
            // username
            // 
            username.Location = new Point(353, 143);
            username.Name = "username";
            username.Size = new Size(199, 23);
            username.TabIndex = 3;
            // 
            // password
            // 
            password.Location = new Point(353, 208);
            password.Name = "password";
            password.Size = new Size(199, 23);
            password.TabIndex = 4;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(353, 313);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(60, 23);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(504, 313);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(48, 23);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // reBtn
            // 
            reBtn.Location = new Point(448, 313);
            reBtn.Name = "reBtn";
            reBtn.Size = new Size(52, 23);
            reBtn.TabIndex = 7;
            reBtn.Text = "refresh";
            reBtn.UseVisualStyleBackColor = true;
            reBtn.Click += reBtn_Click;
            // 
            // backTosignup
            // 
            backTosignup.AutoSize = true;
            backTosignup.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            backTosignup.Location = new Point(352, 250);
            backTosignup.Name = "backTosignup";
            backTosignup.Size = new Size(200, 13);
            backTosignup.TabIndex = 8;
            backTosignup.Text = "Don't have an account ? Sign up here";
            backTosignup.Click += backTosignup_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 411);
            Controls.Add(backTosignup);
            Controls.Add(reBtn);
            Controls.Add(exitBtn);
            Controls.Add(loginBtn);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username;
        private TextBox password;
        private Button loginBtn;
        private Button exitBtn;
        private Button reBtn;
        private Label backTosignup;
        private PictureBox pictureBox1;
    }
}
