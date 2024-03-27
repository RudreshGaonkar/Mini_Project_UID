namespace Restaurant_App
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            registerNameBox = new TextBox();
            registerEmailBox = new TextBox();
            registerPasswordBox = new TextBox();
            linkLabel1 = new LinkLabel();
            registerbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(589, 731);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(794, 115);
            label1.Name = "label1";
            label1.Size = new Size(153, 54);
            label1.TabIndex = 1;
            label1.Text = "Sign in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(626, 224);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(629, 307);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(626, 384);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // registerNameBox
            // 
            registerNameBox.Cursor = Cursors.IBeam;
            registerNameBox.Location = new Point(737, 209);
            registerNameBox.Multiline = true;
            registerNameBox.Name = "registerNameBox";
            registerNameBox.Size = new Size(264, 46);
            registerNameBox.TabIndex = 5;
            // 
            // registerEmailBox
            // 
            registerEmailBox.Cursor = Cursors.IBeam;
            registerEmailBox.Location = new Point(737, 293);
            registerEmailBox.Multiline = true;
            registerEmailBox.Name = "registerEmailBox";
            registerEmailBox.Size = new Size(264, 48);
            registerEmailBox.TabIndex = 6;
            // 
            // registerPasswordBox
            // 
            registerPasswordBox.Cursor = Cursors.IBeam;
            registerPasswordBox.Location = new Point(737, 370);
            registerPasswordBox.Multiline = true;
            registerPasswordBox.Name = "registerPasswordBox";
            registerPasswordBox.Size = new Size(264, 48);
            registerPasswordBox.TabIndex = 7;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Location = new Point(762, 634);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(211, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have a account? Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // registerbtn
            // 
            registerbtn.BackColor = Color.LightCoral;
            registerbtn.Cursor = Cursors.Hand;
            registerbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerbtn.ForeColor = Color.White;
            registerbtn.Location = new Point(737, 507);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(264, 59);
            registerbtn.TabIndex = 9;
            registerbtn.Text = "Sign in";
            registerbtn.UseVisualStyleBackColor = false;
            registerbtn.Click += registerbtn_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 736);
            Controls.Add(registerbtn);
            Controls.Add(linkLabel1);
            Controls.Add(registerPasswordBox);
            Controls.Add(registerEmailBox);
            Controls.Add(registerNameBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox registerNameBox;
        private TextBox registerEmailBox;
        private TextBox registerPasswordBox;
        private LinkLabel linkLabel1;
        private Button registerbtn;
    }
}