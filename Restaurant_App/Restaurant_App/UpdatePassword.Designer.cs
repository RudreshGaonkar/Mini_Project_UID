namespace Restaurant_App
{
    partial class UpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePassword));
            groupBox1 = new GroupBox();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            changepassword = new Button();
            confirmpassword = new TextBox();
            label4 = new Label();
            newpassword = new TextBox();
            label3 = new Label();
            Emailbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(changepassword);
            groupBox1.Controls.Add(confirmpassword);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(newpassword);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Emailbox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(243, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(448, 469);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 417);
            label5.Name = "label5";
            label5.Size = new Size(155, 20);
            label5.TabIndex = 9;
            label5.Text = "Create a new account!";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(255, 417);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(54, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign in";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // changepassword
            // 
            changepassword.BackColor = Color.FromArgb(128, 128, 255);
            changepassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changepassword.ForeColor = Color.White;
            changepassword.Location = new Point(124, 350);
            changepassword.Name = "changepassword";
            changepassword.Size = new Size(167, 51);
            changepassword.TabIndex = 7;
            changepassword.Text = "Change password";
            changepassword.UseVisualStyleBackColor = false;
            changepassword.Click += changepassword_Click;
            // 
            // confirmpassword
            // 
            confirmpassword.Location = new Point(45, 308);
            confirmpassword.Multiline = true;
            confirmpassword.Name = "confirmpassword";
            confirmpassword.Size = new Size(291, 36);
            confirmpassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 280);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // newpassword
            // 
            newpassword.Location = new Point(45, 222);
            newpassword.Multiline = true;
            newpassword.Name = "newpassword";
            newpassword.Size = new Size(291, 36);
            newpassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 194);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 3;
            label3.Text = "New Password";
            // 
            // Emailbox
            // 
            Emailbox.Location = new Point(45, 126);
            Emailbox.Multiline = true;
            Emailbox.Name = "Emailbox";
            Emailbox.Size = new Size(291, 36);
            Emailbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 98);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 23);
            label1.Name = "label1";
            label1.Size = new Size(251, 38);
            label1.TabIndex = 0;
            label1.Text = "Change Password";
            // 
            // UpdatePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(922, 545);
            Controls.Add(groupBox1);
            Name = "UpdatePassword";
            Text = "UpdatePassword";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label5;
        private LinkLabel linkLabel1;
        private Button changepassword;
        private TextBox confirmpassword;
        private Label label4;
        private TextBox newpassword;
        private Label label3;
        private TextBox Emailbox;
    }
}