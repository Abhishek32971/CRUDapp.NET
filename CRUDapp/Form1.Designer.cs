namespace CRUDapp
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            InsertButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            UpdateButton = new Button();
            DeleteButton = new Button();
            SelectButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F);
            textBox1.Location = new Point(139, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 30);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12F);
            textBox2.Location = new Point(139, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 30);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 12F);
            textBox3.Location = new Point(139, 177);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(241, 30);
            textBox3.TabIndex = 2;
            // 
            // InsertButton
            // 
            InsertButton.Font = new Font("Segoe UI", 12F);
            InsertButton.Location = new Point(139, 241);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(94, 38);
            InsertButton.TabIndex = 3;
            InsertButton.Text = "Insert\r\n";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(574, 46);
            label1.TabIndex = 7;
            label1.Text = "Insert Update Delete Search in SQL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(40, 75);
            label2.Name = "label2";
            label2.Size = new Size(31, 28);
            label2.TabIndex = 8;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(40, 127);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 9;
            label3.Text = "NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(40, 177);
            label4.Name = "label4";
            label4.Size = new Size(47, 28);
            label4.TabIndex = 10;
            label4.Text = "Age";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(484, 75);
            button2.Name = "button2";
            button2.Size = new Size(180, 38);
            button2.TabIndex = 11;
            button2.Text = "check connection";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 316);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(513, 188);
            dataGridView1.TabIndex = 12;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.Gray;
            UpdateButton.Font = new Font("Segoe UI", 12F);
            UpdateButton.Location = new Point(264, 241);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 38);
            UpdateButton.TabIndex = 13;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Red;
            DeleteButton.Font = new Font("Segoe UI", 12F);
            DeleteButton.Location = new Point(385, 241);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 38);
            DeleteButton.TabIndex = 14;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SelectButton
            // 
            SelectButton.BackColor = Color.Yellow;
            SelectButton.Font = new Font("Segoe UI", 12F);
            SelectButton.Location = new Point(515, 241);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(94, 38);
            SelectButton.TabIndex = 15;
            SelectButton.Text = "Select";
            SelectButton.UseVisualStyleBackColor = false;
            SelectButton.Click += SelectButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(727, 560);
            Controls.Add(SelectButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(InsertButton);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.FromArgb(64, 64, 64);
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button InsertButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private DataGridView dataGridView1;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button SelectButton;
    }
}
