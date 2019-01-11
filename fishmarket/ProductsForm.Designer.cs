namespace fishmarket
{
    partial class ProductsForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btDelAnimal = new System.Windows.Forms.Button();
            this.btDelCountry = new System.Windows.Forms.Button();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.btDelName = new System.Windows.Forms.Button();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.btDelManufacturer = new System.Windows.Forms.Button();
            this.cbManufacturer = new System.Windows.Forms.ComboBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btDelAnimal);
            this.panel1.Controls.Add(this.btDelCountry);
            this.panel1.Controls.Add(this.cbAnimal);
            this.panel1.Controls.Add(this.cbCountry);
            this.panel1.Controls.Add(this.btDelName);
            this.panel1.Controls.Add(this.cbName);
            this.panel1.Controls.Add(this.btDelManufacturer);
            this.panel1.Controls.Add(this.cbManufacturer);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btChange);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.dgvProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 374);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Животное";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Страна\r\nизготовления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Производитель";
            // 
            // btDelAnimal
            // 
            this.btDelAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelAnimal.Image = global::fishmarket.Properties.Resources.del2;
            this.btDelAnimal.Location = new System.Drawing.Point(678, 34);
            this.btDelAnimal.Name = "btDelAnimal";
            this.btDelAnimal.Size = new System.Drawing.Size(20, 22);
            this.btDelAnimal.TabIndex = 21;
            this.btDelAnimal.UseVisualStyleBackColor = true;
            this.btDelAnimal.Visible = false;
            this.btDelAnimal.Click += new System.EventHandler(this.btDelAnimal_Click);
            // 
            // btDelCountry
            // 
            this.btDelCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelCountry.Image = global::fishmarket.Properties.Resources.del2;
            this.btDelCountry.Location = new System.Drawing.Point(505, 34);
            this.btDelCountry.Name = "btDelCountry";
            this.btDelCountry.Size = new System.Drawing.Size(20, 22);
            this.btDelCountry.TabIndex = 23;
            this.btDelCountry.UseVisualStyleBackColor = true;
            this.btDelCountry.Visible = false;
            this.btDelCountry.Click += new System.EventHandler(this.btDelCountry_Click);
            // 
            // cbAnimal
            // 
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Location = new System.Drawing.Point(531, 34);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(141, 21);
            this.cbAnimal.TabIndex = 20;
            this.cbAnimal.TextChanged += new System.EventHandler(this.cbAnimal_TextChanged);
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(358, 34);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(141, 21);
            this.cbCountry.TabIndex = 22;
            this.cbCountry.TextChanged += new System.EventHandler(this.cbCountry_TextChanged);
            // 
            // btDelName
            // 
            this.btDelName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelName.Image = global::fishmarket.Properties.Resources.del2;
            this.btDelName.Location = new System.Drawing.Point(332, 34);
            this.btDelName.Name = "btDelName";
            this.btDelName.Size = new System.Drawing.Size(20, 22);
            this.btDelName.TabIndex = 21;
            this.btDelName.UseVisualStyleBackColor = true;
            this.btDelName.Visible = false;
            this.btDelName.Click += new System.EventHandler(this.btDelName_Click);
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(185, 34);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(141, 21);
            this.cbName.TabIndex = 20;
            this.cbName.TextChanged += new System.EventHandler(this.cbName_TextChanged);
            // 
            // btDelManufacturer
            // 
            this.btDelManufacturer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelManufacturer.Image = global::fishmarket.Properties.Resources.del2;
            this.btDelManufacturer.Location = new System.Drawing.Point(159, 34);
            this.btDelManufacturer.Name = "btDelManufacturer";
            this.btDelManufacturer.Size = new System.Drawing.Size(20, 22);
            this.btDelManufacturer.TabIndex = 19;
            this.btDelManufacturer.UseVisualStyleBackColor = true;
            this.btDelManufacturer.Visible = false;
            this.btDelManufacturer.Click += new System.EventHandler(this.btDelManufacturer_Click);
            // 
            // cbManufacturer
            // 
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.Location = new System.Drawing.Point(12, 34);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(141, 21);
            this.cbManufacturer.TabIndex = 17;
            this.cbManufacturer.TextChanged += new System.EventHandler(this.cbManufacturer_TextChanged);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Location = new System.Drawing.Point(706, 340);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 16;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btChange
            // 
            this.btChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btChange.Location = new System.Drawing.Point(706, 311);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(75, 23);
            this.btChange.TabIndex = 15;
            this.btChange.Text = "Изменить";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(706, 282);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 71);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(688, 292);
            this.dgvProducts.TabIndex = 13;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 374);
            this.Controls.Add(this.panel1);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDelManufacturer;
        private System.Windows.Forms.ComboBox cbManufacturer;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btAdd;
        public System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.BindingSource bsProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDelAnimal;
        private System.Windows.Forms.Button btDelCountry;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Button btDelName;
        private System.Windows.Forms.ComboBox cbName;
    }
}