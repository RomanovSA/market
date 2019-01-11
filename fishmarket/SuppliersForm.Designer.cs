namespace fishmarket
{
    partial class SuppliersForm
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
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btDelCity = new System.Windows.Forms.Button();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.btDelRegion = new System.Windows.Forms.Button();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.bsSuppliers = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.btChange);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Location = new System.Drawing.Point(710, 415);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 46;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(710, 357);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 44;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btChange
            // 
            this.btChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btChange.Location = new System.Drawing.Point(710, 386);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(75, 23);
            this.btChange.TabIndex = 45;
            this.btChange.Text = "Изменить";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Область";
            // 
            // btDelCity
            // 
            this.btDelCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelCity.Image = global::fishmarket.Properties.Resources.del2;
            this.btDelCity.Location = new System.Drawing.Point(336, 74);
            this.btDelCity.Name = "btDelCity";
            this.btDelCity.Size = new System.Drawing.Size(20, 22);
            this.btDelCity.TabIndex = 50;
            this.btDelCity.UseVisualStyleBackColor = true;
            this.btDelCity.Click += new System.EventHandler(this.btDelCity_Click);
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(189, 74);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(141, 21);
            this.cbCity.TabIndex = 49;
            this.cbCity.TextChanged += new System.EventHandler(this.cbCity_TextChanged);
            // 
            // btDelRegion
            // 
            this.btDelRegion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelRegion.Image = global::fishmarket.Properties.Resources.del2;
            this.btDelRegion.Location = new System.Drawing.Point(163, 74);
            this.btDelRegion.Name = "btDelRegion";
            this.btDelRegion.Size = new System.Drawing.Size(20, 22);
            this.btDelRegion.TabIndex = 48;
            this.btDelRegion.UseVisualStyleBackColor = true;
            this.btDelRegion.Click += new System.EventHandler(this.btDelRegion_Click);
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(16, 74);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(141, 21);
            this.cbRegion.TabIndex = 47;
            this.cbRegion.TextChanged += new System.EventHandler(this.cbRegion_TextChanged);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Location = new System.Drawing.Point(16, 111);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.Size = new System.Drawing.Size(688, 327);
            this.dgvSuppliers.TabIndex = 43;
            // 
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDelCity);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.btDelRegion);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.panel1);
            this.Name = "SuppliersForm";
            this.Text = "SuppliersForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDelCity;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Button btDelRegion;
        private System.Windows.Forms.ComboBox cbRegion;
        public System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.BindingSource bsSuppliers;
    }
}