namespace Restaurant_App
{
    partial class Order
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            label3 = new Label();
            groupBox1 = new GroupBox();
            Back_to_cart = new Button();
            Confirm_Order = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(639, 265);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(190, 38);
            label1.TabIndex = 1;
            label1.Text = "Order Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 421);
            label2.Name = "label2";
            label2.Size = new Size(216, 31);
            label2.TabIndex = 2;
            label2.Text = "Enter your Address";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(30, 454);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 52);
            textBox1.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Cursor = Cursors.Hand;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(39, 539);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(149, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cash On Delivery";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(232, 38);
            label3.TabIndex = 5;
            label3.Text = "Grand Total :     ";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(Back_to_cart);
            groupBox1.Controls.Add(Confirm_Order);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(689, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 430);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // Back_to_cart
            // 
            Back_to_cart.BackColor = Color.MistyRose;
            Back_to_cart.Cursor = Cursors.Hand;
            Back_to_cart.Location = new Point(11, 366);
            Back_to_cart.Name = "Back_to_cart";
            Back_to_cart.Size = new Size(321, 51);
            Back_to_cart.TabIndex = 7;
            Back_to_cart.Text = "Go back to cart";
            Back_to_cart.UseVisualStyleBackColor = false;
            Back_to_cart.Click += Back_to_cart_Click;
            // 
            // Confirm_Order
            // 
            Confirm_Order.BackColor = Color.FromArgb(255, 192, 192);
            Confirm_Order.Cursor = Cursors.Hand;
            Confirm_Order.Location = new Point(11, 287);
            Confirm_Order.Name = "Confirm_Order";
            Confirm_Order.Size = new Size(321, 51);
            Confirm_Order.TabIndex = 6;
            Confirm_Order.Text = "Confirm Order";
            Confirm_Order.UseVisualStyleBackColor = false;
            Confirm_Order.Click += Confirm_Order_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(1017, 672);
            button1.Name = "button1";
            button1.Size = new Size(10, 10);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1039, 694);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(radioButton1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Order";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private Label label3;
        private GroupBox groupBox1;
        private Button Back_to_cart;
        private Button Confirm_Order;
        private Button button1;
    }
}