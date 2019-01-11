namespace fishmarket
{
    partial class TipeForm
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
            this.btDelOpisan = new System.Windows.Forms.Button();
            this.btDelCategory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOpisan = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.dgvTipe = new System.Windows.Forms.DataGridView();
            this.bsTipe = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDelOpisan);
            this.panel1.Controls.Add(this.btDelCategory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbOpisan);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btChange);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.dgvTipe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 305);
            this.panel1.TabIndex = 0;
            // 
            // btDelOpisan
            // 
            this.btDelOpisan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelOpisan.Image = global::fishmarket.Properties.Resources.del2;
            this.btDelOpisan.Location = new System.Drawing.Point(463, 32);
            this.btDelOpisan.Name = "btDelOpisan";
            this.btDelOpisan.Size = new System.Drawing.Size(20, 22);
            this.btDelOpisan.TabIndex = 12;
            this.btDelOpisan.UseVisualStyleBackColor = true;
            this.btDelOpisan.Visible = false;
            this.btDelOpisan.Click += new System.EventHandler(this.btDelOpisan_Click);
            // 
            // btDelCategory
            // 
            this.btDelCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelCategory.Image = global::fishmarket.Properties.Resources.del2;
            this.btDelCategory.Location = new System.Drawing.Point(207, 32);
            this.btDelCategory.Name = "btDelCategory";
            this.btDelCategory.Size = new System.Drawing.Size(20, 22);
            this.btDelCategory.TabIndex = 11;
            this.btDelCategory.UseVisualStyleBackColor = true;
            this.btDelCategory.Visible = false;
            this.btDelCategory.Click += new System.EventHandler(this.btDelCategory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Категория";
            // 
            // cbOpisan
            // 
            this.cbOpisan.FormattingEnabled = true;
            this.cbOpisan.Location = new System.Drawing.Point(266, 32);
            this.cbOpisan.Name = "cbOpisan";
            this.cbOpisan.Size = new System.Drawing.Size(191, 21);
            this.cbOpisan.TabIndex = 7;
            this.cbOpisan.TextChanged += new System.EventHandler(this.cbOpisan_TextChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(15, 32);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(186, 21);
            this.cbCategory.TabIndex = 6;
            this.cbCategory.TextChanged += new System.EventHandler(this.cbCategory_TextChanged);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Location = new System.Drawing.Point(537, 273);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btChange
            // 
            this.btChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btChange.Location = new System.Drawing.Point(537, 244);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(75, 23);
            this.btChange.TabIndex = 2;
            this.btChange.Text = "Изменить";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(537, 215);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dgvTipe
            // 
            this.dgvTipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipe.Location = new System.Drawing.Point(12, 81);
            this.dgvTipe.Name = "dgvTipe";
            this.dgvTipe.Size = new System.Drawing.Size(519, 212);
            this.dgvTipe.TabIndex = 0;
            // 
            // TipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 305);
            this.Controls.Add(this.panel1);
            this.Name = "TipeForm";
            this.Text = "TipeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btAdd;
        public System.Windows.Forms.DataGridView dgvTipe;
        private System.Windows.Forms.BindingSource bsTipe;
        private System.Windows.Forms.ComboBox cbOpisan;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDelCategory;
        private System.Windows.Forms.Button btDelOpisan;
    }
}