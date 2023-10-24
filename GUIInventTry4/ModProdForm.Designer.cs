namespace GUIInventTry4
{
    partial class ModProdForm
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
            yeetPartfromProd = new Button();
            assocPart = new Button();
            label3 = new Label();
            label2 = new Label();
            search1 = new Button();
            searchBoxOne = new TextBox();
            IDtextBox = new TextBox();
            PriceTextBox = new TextBox();
            InventoryTextBox = new TextBox();
            partNametextbox = new TextBox();
            Cancel = new Button();
            Save = new Button();
            label1 = new Label();
            Max = new Label();
            Min = new Label();
            maxBox = new TextBox();
            minBox = new TextBox();
            Price = new Label();
            InventoryText = new Label();
            ProductName = new Label();
            ID = new Label();
            candPartGrid = new DataGridView();
            assocPartGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)candPartGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)assocPartGrid).BeginInit();
            SuspendLayout();
            // 
            // yeetPartfromProd
            // 
            yeetPartfromProd.Location = new Point(713, 402);
            yeetPartfromProd.Name = "yeetPartfromProd";
            yeetPartfromProd.Size = new Size(75, 23);
            yeetPartfromProd.TabIndex = 62;
            yeetPartfromProd.Text = "Delete";
            yeetPartfromProd.UseVisualStyleBackColor = true;
            yeetPartfromProd.Click += RemoveAssocPart_Clic;
            // 
            // assocPart
            // 
            assocPart.Location = new Point(713, 196);
            assocPart.Name = "assocPart";
            assocPart.Size = new Size(75, 23);
            assocPart.TabIndex = 61;
            assocPart.Text = "Add";
            assocPart.UseVisualStyleBackColor = true;
            assocPart.Click += AddParttoProd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 221);
            label3.Name = "label3";
            label3.Size = new Size(190, 15);
            label3.TabIndex = 59;
            label3.Text = "Parts Associated With This Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 8);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 57;
            label2.Text = "All Candidate Parts";
            // 
            // search1
            // 
            search1.Location = new Point(641, 4);
            search1.Name = "search1";
            search1.Size = new Size(60, 23);
            search1.TabIndex = 56;
            search1.Text = "Search";
            search1.UseVisualStyleBackColor = true;
            search1.Click += SearchParts_Click;
            // 
            // searchBoxOne
            // 
            searchBoxOne.Location = new Point(494, 4);
            searchBoxOne.Name = "searchBoxOne";
            searchBoxOne.Size = new Size(141, 23);
            searchBoxOne.TabIndex = 55;
            // 
            // IDtextBox
            // 
            IDtextBox.BackColor = SystemColors.InactiveCaption;
            IDtextBox.Location = new Point(129, 92);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.ReadOnly = true;
            IDtextBox.Size = new Size(100, 23);
            IDtextBox.TabIndex = 54;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(129, 179);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(100, 23);
            PriceTextBox.TabIndex = 53;
            // 
            // InventoryTextBox
            // 
            InventoryTextBox.Location = new Point(129, 153);
            InventoryTextBox.Name = "InventoryTextBox";
            InventoryTextBox.Size = new Size(100, 23);
            InventoryTextBox.TabIndex = 52;
            // 
            // partNametextbox
            // 
            partNametextbox.Location = new Point(129, 121);
            partNametextbox.Name = "partNametextbox";
            partNametextbox.Size = new Size(100, 23);
            partNametextbox.TabIndex = 51;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.FromArgb(255, 128, 128);
            Cancel.Location = new Point(123, 411);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 50;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += ExitAppButton_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(128, 255, 128);
            Save.Location = new Point(14, 411);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 49;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += SaveProd_Clic;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 48;
            label1.Text = "Modify Product";
            // 
            // Max
            // 
            Max.AutoSize = true;
            Max.Location = new Point(168, 218);
            Max.Name = "Max";
            Max.Size = new Size(30, 15);
            Max.TabIndex = 47;
            Max.Text = "Max";
            // 
            // Min
            // 
            Min.AutoSize = true;
            Min.Location = new Point(37, 218);
            Min.Name = "Min";
            Min.Size = new Size(28, 15);
            Min.TabIndex = 46;
            Min.Text = "Min";
            // 
            // maxBox
            // 
            maxBox.Location = new Point(226, 214);
            maxBox.Name = "maxBox";
            maxBox.Size = new Size(47, 23);
            maxBox.TabIndex = 45;
            // 
            // minBox
            // 
            minBox.Location = new Point(93, 214);
            minBox.Name = "minBox";
            minBox.Size = new Size(47, 23);
            minBox.TabIndex = 44;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(32, 183);
            Price.Name = "Price";
            Price.Size = new Size(33, 15);
            Price.TabIndex = 43;
            Price.Text = "Price";
            // 
            // InventoryText
            // 
            InventoryText.AutoSize = true;
            InventoryText.Location = new Point(32, 157);
            InventoryText.Name = "InventoryText";
            InventoryText.Size = new Size(57, 15);
            InventoryText.TabIndex = 42;
            InventoryText.Text = "Inventory";
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Location = new Point(32, 125);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(39, 15);
            ProductName.TabIndex = 41;
            ProductName.Text = "Name";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(32, 96);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 40;
            ID.Text = "ID";
            // 
            // candPartGrid
            // 
            candPartGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            candPartGrid.Location = new Point(349, 33);
            candPartGrid.Name = "candPartGrid";
            candPartGrid.RowTemplate.Height = 25;
            candPartGrid.Size = new Size(439, 157);
            candPartGrid.TabIndex = 64;
            // 
            // assocPartGrid
            // 
            assocPartGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assocPartGrid.Location = new Point(349, 239);
            assocPartGrid.Name = "assocPartGrid";
            assocPartGrid.RowTemplate.Height = 25;
            assocPartGrid.Size = new Size(439, 157);
            assocPartGrid.TabIndex = 65;
            // 
            // ModProdForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(assocPartGrid);
            Controls.Add(candPartGrid);
            Controls.Add(yeetPartfromProd);
            Controls.Add(assocPart);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(search1);
            Controls.Add(searchBoxOne);
            Controls.Add(IDtextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(InventoryTextBox);
            Controls.Add(partNametextbox);
            Controls.Add(Cancel);
            Controls.Add(Save);
            Controls.Add(label1);
            Controls.Add(Max);
            Controls.Add(Min);
            Controls.Add(maxBox);
            Controls.Add(minBox);
            Controls.Add(Price);
            Controls.Add(InventoryText);
            Controls.Add(ProductName);
            Controls.Add(ID);
            Name = "ModProdForm";
            Text = "ModProd";
            ((System.ComponentModel.ISupportInitialize)candPartGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)assocPartGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button yeetPartfromProd;
        private Button assocPart;
        private Label label3;
        private Label label2;
        private Button search1;
        private TextBox searchBoxOne;
        private TextBox IDtextBox;
        private TextBox PriceTextBox;
        private TextBox InventoryTextBox;
        private TextBox partNametextbox;
        private Button Cancel;
        private Button Save;
        private Label label1;
        private Label Max;
        private Label Min;
        private TextBox maxBox;
        private TextBox minBox;
        private Label Price;
        private Label InventoryText;
        private Label ProductName;
        private Label ID;
        private DataGridView candPartGrid;
        private DataGridView assocPartGrid;
    }
}