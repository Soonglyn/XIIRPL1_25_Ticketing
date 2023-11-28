namespace XIIRPL1_25_Ticketing
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label3 = new Label();
            txtLinkLabel = new LinkLabel();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            textPassword = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(340, 377);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 15;
            label3.Text = "Belum punya akun ?";
            // 
            // txtLinkLabel
            // 
            txtLinkLabel.AutoSize = true;
            txtLinkLabel.Location = new Point(460, 377);
            txtLinkLabel.Name = "txtLinkLabel";
            txtLinkLabel.Size = new Size(96, 15);
            txtLinkLabel.TabIndex = 14;
            txtLinkLabel.TabStop = true;
            txtLinkLabel.Text = "Daftar Sekarang !";
            txtLinkLabel.LinkClicked += txtLinkLabel_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(508, 328);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 290);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 254);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 11;
            label1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(318, 251);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 23);
            txtUsername.TabIndex = 10;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(318, 290);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(300, 23);
            textPassword.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(149, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(503, 160);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtLinkLabel);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(textPassword);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private LinkLabel txtLinkLabel;
        private Button btnLogin;
        private Label label2;
        private Label label1;
        private TextBox txtUsername;
        private TextBox textPassword;
        private PictureBox pictureBox1;
    }
}