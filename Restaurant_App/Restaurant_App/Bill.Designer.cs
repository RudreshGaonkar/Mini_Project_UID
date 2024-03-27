namespace Restaurant_App
{
    partial class Bill
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
            dataGridView2 = new DataGridView();
            Print_pdf = new Button();
            title = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(686, 93);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(56, 189);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(686, 201);
            dataGridView2.TabIndex = 1;
            // 
            // Print_pdf
            // 
            Print_pdf.BackColor = Color.Red;
            Print_pdf.ForeColor = Color.White;
            Print_pdf.Location = new Point(514, 396);
            Print_pdf.Name = "Print_pdf";
            Print_pdf.Size = new Size(165, 50);
            Print_pdf.TabIndex = 2;
            Print_pdf.Text = "Download";
            Print_pdf.UseVisualStyleBackColor = false;
            Print_pdf.Click += Print_pdf_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            title.Location = new Point(269, 9);
            title.Name = "title";
            title.Size = new Size(233, 54);
            title.TabIndex = 3;
            title.Text = "Bill Details";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.ForeColor = Color.White;
            button1.Location = new Point(315, 396);
            button1.Name = "button1";
            button1.Size = new Size(165, 50);
            button1.TabIndex = 4;
            button1.Text = "Order more";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(893, 486);
            Controls.Add(button1);
            Controls.Add(title);
            Controls.Add(Print_pdf);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Bill";
            Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button Print_pdf;
        private Label title;
        private Button button1;
    }
}