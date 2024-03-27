namespace Restaurant_App
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            loginEmail = new TextBox();
            loginPassword = new TextBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            errorLabel = new Label();
            button1 = new Button();
            back_to_sign_in = new LinkLabel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(568, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(588, 739);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 89);
            label1.Name = "label1";
            label1.Size = new Size(127, 54);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 223);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // loginEmail
            // 
            loginEmail.Cursor = Cursors.IBeam;
            loginEmail.Location = new Point(161, 210);
            loginEmail.Multiline = true;
            loginEmail.Name = "loginEmail";
            loginEmail.Size = new Size(253, 45);
            loginEmail.TabIndex = 3;
            // 
            // loginPassword
            // 
            loginPassword.Cursor = Cursors.IBeam;
            loginPassword.Location = new Point(161, 300);
            loginPassword.Multiline = true;
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(253, 45);
            loginPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 313);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Location = new Point(186, 367);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(228, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot your password? Click here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(438, 310);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 31);
            errorLabel.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(161, 483);
            button1.Name = "button1";
            button1.Size = new Size(245, 60);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // back_to_sign_in
            // 
            back_to_sign_in.AutoSize = true;
            back_to_sign_in.Cursor = Cursors.Hand;
            back_to_sign_in.Location = new Point(285, 610);
            back_to_sign_in.Name = "back_to_sign_in";
            back_to_sign_in.Size = new Size(54, 20);
            back_to_sign_in.TabIndex = 10;
            back_to_sign_in.TabStop = true;
            back_to_sign_in.Text = "Sign in";
            back_to_sign_in.LinkClicked += back_to_sign_in_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(146, 610);
            label6.Name = "label6";
            label6.Size = new Size(143, 20);
            label6.TabIndex = 11;
            label6.Text = "Don't have account?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 742);
            Controls.Add(label6);
            Controls.Add(back_to_sign_in);
            Controls.Add(button1);
            Controls.Add(errorLabel);
            Controls.Add(linkLabel1);
            Controls.Add(loginPassword);
            Controls.Add(label3);
            Controls.Add(loginEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox loginEmail;
        private TextBox loginPassword;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
        private Label errorLabel;
        private Button button1;
        private LinkLabel back_to_sign_in;
        private Label label6;
    }
}