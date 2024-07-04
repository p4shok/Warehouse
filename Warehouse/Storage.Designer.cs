namespace Warehouse
{
    partial class Storage
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
            ID = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ShelfLife = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Issuance = new DataGridViewTextBoxColumn();
            AddProductBtn = new Button();
            RemoveAllProductsBtn = new Button();
            DeleteProductBtn = new Button();
            FilterTxtBox = new TextBox();
            SearchTxtBox = new TextBox();
            FilterBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            SearcthBtn = new Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            QuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Type, Quantity, ShelfLife, Price, Issuance });
            dataGridView1.Location = new Point(12, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(1124, 341);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 9;
            ID.Name = "ID";
            ID.Width = 175;
            // 
            // Type
            // 
            Type.HeaderText = "Тип";
            Type.MinimumWidth = 9;
            Type.Name = "Type";
            Type.Width = 175;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Количество";
            Quantity.MinimumWidth = 9;
            Quantity.Name = "Quantity";
            Quantity.Width = 175;
            // 
            // ShelfLife
            // 
            ShelfLife.HeaderText = "Срок хранения";
            ShelfLife.MinimumWidth = 9;
            ShelfLife.Name = "ShelfLife";
            ShelfLife.Width = 175;
            // 
            // Price
            // 
            Price.HeaderText = "Стоимость аренды";
            Price.MinimumWidth = 9;
            Price.Name = "Price";
            Price.Width = 175;
            // 
            // Issuance
            // 
            Issuance.HeaderText = "Выдача товара";
            Issuance.MinimumWidth = 9;
            Issuance.Name = "Issuance";
            Issuance.Width = 175;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(12, 368);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(209, 40);
            AddProductBtn.TabIndex = 1;
            AddProductBtn.Text = "Добавить товар";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // RemoveAllProductsBtn
            // 
            RemoveAllProductsBtn.Location = new Point(12, 482);
            RemoveAllProductsBtn.Name = "RemoveAllProductsBtn";
            RemoveAllProductsBtn.Size = new Size(209, 40);
            RemoveAllProductsBtn.TabIndex = 2;
            RemoveAllProductsBtn.Text = "Очистить таблицу";
            RemoveAllProductsBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteProductBtn
            // 
            DeleteProductBtn.Location = new Point(12, 424);
            DeleteProductBtn.Name = "DeleteProductBtn";
            DeleteProductBtn.Size = new Size(209, 40);
            DeleteProductBtn.TabIndex = 3;
            DeleteProductBtn.Text = "Удалить товар";
            DeleteProductBtn.UseVisualStyleBackColor = true;
            // 
            // FilterTxtBox
            // 
            FilterTxtBox.Location = new Point(295, 426);
            FilterTxtBox.Name = "FilterTxtBox";
            FilterTxtBox.Size = new Size(253, 35);
            FilterTxtBox.TabIndex = 4;
            // 
            // SearchTxtBox
            // 
            SearchTxtBox.Location = new Point(804, 429);
            SearchTxtBox.Name = "SearchTxtBox";
            SearchTxtBox.Size = new Size(253, 35);
            SearchTxtBox.TabIndex = 5;
            // 
            // FilterBtn
            // 
            FilterBtn.Location = new Point(295, 482);
            FilterBtn.Name = "FilterBtn";
            FilterBtn.Size = new Size(253, 74);
            FilterBtn.TabIndex = 6;
            FilterBtn.Text = "Фильтровать по стоимости";
            FilterBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(295, 579);
            button1.Name = "button1";
            button1.Size = new Size(253, 40);
            button1.TabIndex = 7;
            button1.Text = "Очистить фильтрацию";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(804, 579);
            button2.Name = "button2";
            button2.Size = new Size(253, 40);
            button2.TabIndex = 9;
            button2.Text = "Очистить поиск";
            button2.UseVisualStyleBackColor = true;
            // 
            // SearcthBtn
            // 
            SearcthBtn.Location = new Point(804, 482);
            SearcthBtn.Name = "SearcthBtn";
            SearcthBtn.Size = new Size(253, 74);
            SearcthBtn.TabIndex = 8;
            SearcthBtn.Text = "Найти товар по  типу";
            SearcthBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 378);
            label2.Name = "label2";
            label2.Size = new Size(167, 30);
            label2.TabIndex = 11;
            label2.Text = "Отфильтровать ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(887, 378);
            label3.Name = "label3";
            label3.Size = new Size(72, 30);
            label3.TabIndex = 12;
            label3.Text = "Поиск";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 661);
            label4.Name = "label4";
            label4.Size = new Size(224, 30);
            label4.TabIndex = 13;
            label4.Text = "Количество позиций: ";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Location = new Point(243, 662);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(0, 30);
            QuantityLabel.TabIndex = 14;
            // 
            // Storage
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 716);
            Controls.Add(QuantityLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(SearcthBtn);
            Controls.Add(button1);
            Controls.Add(FilterBtn);
            Controls.Add(SearchTxtBox);
            Controls.Add(FilterTxtBox);
            Controls.Add(DeleteProductBtn);
            Controls.Add(RemoveAllProductsBtn);
            Controls.Add(AddProductBtn);
            Controls.Add(dataGridView1);
            Name = "Storage";
            Text = "Товары";
            Load += Storage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ShelfLife;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Issuance;
        private Button AddProductBtn;
        private Button RemoveAllProductsBtn;
        private Button DeleteProductBtn;
        private TextBox FilterTxtBox;
        private TextBox SearchTxtBox;
        private Button FilterBtn;
        private Button button1;
        private Button button2;
        private Button SearcthBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label QuantityLabel;
    }
}