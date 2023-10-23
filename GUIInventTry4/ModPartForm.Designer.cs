namespace GUIInventTry4
{
    partial class ModPartForm
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            Save = new Button();
            Cancel = new Button();
            IDtextBox = new TextBox();
            partNametextbox = new TextBox();
            InventoryTextBox = new TextBox();
            PriceTextBox = new TextBox();
            minBox = new TextBox();
            label1 = new Label();
            ID = new Label();
            PartName = new Label();
            Inventory = new Label();
            Price = new Label();
            maxBox = new TextBox();
            textBox7 = new TextBox();
            label6 = new Label();
            Min = new Label();
            Max = new Label();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(115, 67);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(74, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "In-House";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radiobutton1_Checked;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(231, 67);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(87, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Outsourced";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radiobutton2_CheckedChanged;
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(128, 255, 128);
            Save.Location = new Point(162, 312);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 2;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.FromArgb(255, 128, 128);
            Cancel.Location = new Point(280, 312);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 3;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += ExitAppButton_Click;
            // 
            // IDtextBox
            // 
            IDtextBox.BackColor = SystemColors.InactiveCaption;
            IDtextBox.Location = new Point(162, 108);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.ReadOnly = true;
            IDtextBox.Size = new Size(100, 23);
            IDtextBox.TabIndex = 4;
            // 
            // partNametextbox
            // 
            partNametextbox.Location = new Point(162, 139);
            partNametextbox.Name = "partNametextbox";
            partNametextbox.Size = new Size(100, 23);
            partNametextbox.TabIndex = 5;
            // 
            // InventoryTextBox
            // 
            InventoryTextBox.Location = new Point(162, 170);
            InventoryTextBox.Name = "InventoryTextBox";
            InventoryTextBox.Size = new Size(100, 23);
            InventoryTextBox.TabIndex = 6;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(162, 201);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(100, 23);
            PriceTextBox.TabIndex = 7;
            // 
            // minBox
            // 
            minBox.Location = new Point(133, 232);
            minBox.Name = "minBox";
            minBox.Size = new Size(47, 23);
            minBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 9;
            label1.Text = "Modify Part";
            label1.Click += label1_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(82, 112);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 10;
            ID.Text = "ID";
            // 
            // PartName
            // 
            PartName.AutoSize = true;
            PartName.Location = new Point(72, 140);
            PartName.Name = "PartName";
            PartName.Size = new Size(39, 15);
            PartName.TabIndex = 11;
            PartName.Text = "Name";
            PartName.Click += label3_Click;
            // 
            // Inventory
            // 
            Inventory.AutoSize = true;
            Inventory.Location = new Point(63, 172);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(57, 15);
            Inventory.TabIndex = 12;
            Inventory.Text = "Inventory";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(60, 204);
            Price.Name = "Price";
            Price.Size = new Size(62, 15);
            Price.TabIndex = 13;
            Price.Text = "Price/Cost";
            // 
            // maxBox
            // 
            maxBox.Location = new Point(266, 232);
            maxBox.Name = "maxBox";
            maxBox.Size = new Size(47, 23);
            maxBox.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(162, 263);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 268);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 16;
            label6.Text = "MacID/Comp Name";
            label6.Click += label6_Click;
            // 
            // Min
            // 
            Min.AutoSize = true;
            Min.Location = new Point(77, 236);
            Min.Name = "Min";
            Min.Size = new Size(28, 15);
            Min.TabIndex = 17;
            Min.Text = "Min";
            // 
            // Max
            // 
            Max.AutoSize = true;
            Max.Location = new Point(208, 236);
            Max.Name = "Max";
            Max.Size = new Size(30, 15);
            Max.TabIndex = 18;
            Max.Text = "Max";
            Max.Click += label8_Click;
            // 
            // ModPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 360);
            Controls.Add(Max);
            Controls.Add(Min);
            Controls.Add(label6);
            Controls.Add(textBox7);
            Controls.Add(maxBox);
            Controls.Add(Price);
            Controls.Add(Inventory);
            Controls.Add(PartName);
            Controls.Add(ID);
            Controls.Add(label1);
            Controls.Add(minBox);
            Controls.Add(PriceTextBox);
            Controls.Add(InventoryTextBox);
            Controls.Add(partNametextbox);
            Controls.Add(IDtextBox);
            Controls.Add(Cancel);
            Controls.Add(Save);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "ModPartForm";
            Text = "Modify Part";
            Load += AddPart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button Save;
        private Button Cancel;
        private TextBox IDtextBox;
        private TextBox partNametextbox;
        private TextBox InventoryTextBox;
        private TextBox PriceTextBox;
        private TextBox minBox;
        private Label label1;
        private Label ID;
        private Label PartName;
        private Label Inventory;
        private Label Price;
        private TextBox maxBox;
        private TextBox textBox7;
        private Label label6;
        private Label Min;
        private Label Max;
    }
}