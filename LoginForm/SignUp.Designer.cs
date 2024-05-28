namespace LoginForm
{
    partial class SignUp
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
            backToLogin = new Label();
            reBtn = new Button();
            exitBtn = new Button();
            loginBtn = new Button();
            addpass = new TextBox();
            adduser = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            rewritepass = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // backToLogin
            // 
            backToLogin.AutoSize = true;
            backToLogin.Location = new Point(356, 272);
            backToLogin.Name = "backToLogin";
            backToLogin.Size = new Size(192, 15);
            backToLogin.TabIndex = 17;
            backToLogin.Text = "Account already exists ? Login here";
            backToLogin.Click += backToLogin_Click;
            // 
            // reBtn
            // 
            reBtn.Location = new Point(442, 326);
            reBtn.Name = "reBtn";
            reBtn.Size = new Size(52, 23);
            reBtn.TabIndex = 16;
            reBtn.Text = "refresh";
            reBtn.UseVisualStyleBackColor = true;
            reBtn.Click += reBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(500, 326);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(48, 23);
            exitBtn.TabIndex = 15;
            exitBtn.Text = "exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(349, 326);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(60, 23);
            loginBtn.TabIndex = 14;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // addpass
            // 
            addpass.Location = new Point(349, 189);
            addpass.Name = "addpass";
            addpass.Size = new Size(199, 23);
            addpass.TabIndex = 13;
            // 
            // adduser
            // 
            adduser.Location = new Point(349, 123);
            adduser.Name = "adduser";
            adduser.Size = new Size(199, 23);
            adduser.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 171);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 11;
            label3.Text = "password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(349, 35);
            label1.Name = "label1";
            label1.Size = new Size(122, 42);
            label1.TabIndex = 9;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 105);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 10;
            label2.Text = "username";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 412);
            panel1.TabIndex = 18;
            // 
            // rewritepass
            // 
            rewritepass.Location = new Point(349, 235);
            rewritepass.Name = "rewritepass";
            rewritepass.Size = new Size(199, 23);
            rewritepass.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 217);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 19;
            label5.Text = "password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fingerprint1;
            pictureBox1.Location = new Point(57, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 411);
            Controls.Add(rewritepass);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(backToLogin);
            Controls.Add(reBtn);
            Controls.Add(exitBtn);
            Controls.Add(loginBtn);
            Controls.Add(addpass);
            Controls.Add(adduser);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label backToLogin;
        private Button reBtn;
        private Button exitBtn;
        private Button loginBtn;
        private TextBox addpass;
        private TextBox adduser;
        private Label label3;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox rewritepass;
        private Label label5;
        private PictureBox pictureBox1;
    }
}