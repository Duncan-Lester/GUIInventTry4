namespace GUIInventTry4
{
    partial class Main_Form
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            partGrid = new DataGridView();
            prodGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)partGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prodGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(413, 28);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management Graphic User Interface";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 95);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 99);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Products";
            // 
            // button1
            // 
            button1.Location = new Point(247, 91);
            button1.Name = "button1";
            button1.Size = new Size(55, 23);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(575, 92);
            button2.Name = "button2";
            button2.Size = new Size(60, 23);
            button2.TabIndex = 6;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(36, 362);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += AddPart_Click;
            // 
            // button4
            // 
            button4.Location = new Point(126, 362);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "Modify";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ModPart_Click;
            // 
            // button5
            // 
            button5.Location = new Point(227, 362);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 9;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += deletePart_Click;
            // 
            // button6
            // 
            button6.Location = new Point(369, 362);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 10;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            button6.Click += AddProduct_Click;
            // 
            // button7
            // 
            button7.Location = new Point(462, 362);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 11;
            button7.Text = "Modify";
            button7.UseVisualStyleBackColor = true;
            button7.Click += ModProduct_Click;
            // 
            // button8
            // 
            button8.Location = new Point(560, 362);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 12;
            button8.Text = "Delete";
            button8.UseVisualStyleBackColor = true;
            button8.Click += deleteProd_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Crimson;
            button9.ForeColor = SystemColors.Control;
            button9.Location = new Point(229, 415);
            button9.Name = "button9";
            button9.Size = new Size(178, 23);
            button9.TabIndex = 13;
            button9.Text = "Exit";
            button9.UseVisualStyleBackColor = false;
            button9.Click += ExitAppButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(429, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 23);
            textBox2.TabIndex = 15;
            // 
            // partGrid
            // 
            partGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partGrid.Location = new Point(6, 127);
            partGrid.Name = "partGrid";
            partGrid.RowTemplate.Height = 25;
            partGrid.Size = new Size(338, 212);
            partGrid.TabIndex = 16;
            // 
            // prodGrid
            // 
            prodGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prodGrid.Location = new Point(369, 127);
            prodGrid.Name = "prodGrid";
            prodGrid.RowTemplate.Height = 25;
            prodGrid.Size = new Size(419, 212);
            prodGrid.TabIndex = 17;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(prodGrid);
            Controls.Add(partGrid);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Main_Form";
            Text = "Main Inventory Screen";
            ((System.ComponentModel.ISupportInitialize)partGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)prodGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView partGrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView prodGrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}