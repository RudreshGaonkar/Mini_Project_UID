namespace Restaurant_App
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            label1 = new Label();
            progressBar = new ProgressBar();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            removeSelectedItems = new Button();
            removeAll = new Button();
            button3 = new Button();
            proceedOrder = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(378, 54);
            label1.TabIndex = 0;
            label1.Text = "Your cart is empty!";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(37, 101);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(277, 27);
            progressBar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(320, 108);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 2;
            label2.Text = "10% off";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(500, 337);
            dataGridView1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(810, 22);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            // 
            // removeSelectedItems
            // 
            removeSelectedItems.BackColor = Color.FromArgb(255, 128, 128);
            removeSelectedItems.Cursor = Cursors.Hand;
            removeSelectedItems.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            removeSelectedItems.ForeColor = Color.White;
            removeSelectedItems.Location = new Point(67, 574);
            removeSelectedItems.Name = "removeSelectedItems";
            removeSelectedItems.Size = new Size(403, 46);
            removeSelectedItems.TabIndex = 5;
            removeSelectedItems.Text = "Remove Item";
            removeSelectedItems.UseVisualStyleBackColor = false;
            removeSelectedItems.Click += removeSelectedItems_Click;
            // 
            // removeAll
            // 
            removeAll.BackColor = Color.FromArgb(255, 128, 128);
            removeAll.Cursor = Cursors.Hand;
            removeAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            removeAll.ForeColor = Color.White;
            removeAll.Location = new Point(67, 644);
            removeAll.Name = "removeAll";
            removeAll.Size = new Size(403, 42);
            removeAll.TabIndex = 6;
            removeAll.Text = "Remove All";
            removeAll.UseVisualStyleBackColor = false;
            removeAll.Click += removeAll_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(555, 642);
            button3.Name = "button3";
            button3.Size = new Size(238, 44);
            button3.TabIndex = 7;
            button3.Text = "Add More";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // proceedOrder
            // 
            proceedOrder.BackColor = Color.FromArgb(255, 128, 0);
            proceedOrder.Cursor = Cursors.Hand;
            proceedOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            proceedOrder.ForeColor = Color.White;
            proceedOrder.Location = new Point(799, 642);
            proceedOrder.Name = "proceedOrder";
            proceedOrder.Size = new Size(238, 44);
            proceedOrder.TabIndex = 8;
            proceedOrder.Text = "Proceed";
            proceedOrder.UseVisualStyleBackColor = false;
            proceedOrder.Click += proceedOrder_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 155);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 9;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1120, 735);
            Controls.Add(label4);
            Controls.Add(proceedOrder);
            Controls.Add(button3);
            Controls.Add(removeAll);
            Controls.Add(removeSelectedItems);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(progressBar);
            Controls.Add(label1);
            Name = "Cart";
            Text = "Cart";
            Load += Cart_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Button removeSelectedItems;
        private Button removeAll;
        private Button button3;
        private Button proceedOrder;
        private Label label4;
    }
}