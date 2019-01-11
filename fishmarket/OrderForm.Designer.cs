namespace fishmarket
{
    partial class OrderForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btDelCourier = new System.Windows.Forms.Button();
            this.cbCourier = new System.Windows.Forms.ComboBox();
            this.btDelEmployee = new System.Windows.Forms.Button();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.btDelCustomer = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.bsOrder = new System.Windows.Forms.BindingSource(this.components);
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.bsEmployee = new System.Windows.Forms.BindingSource(this.components);
            this.bsCourier = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourier)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btDelCourier);
            this.panel1.Controls.Add(this.cbCourier);
            this.panel1.Controls.Add(this.btDelEmployee);
            this.panel1.Controls.Add(this.cbEmployee);
            this.panel1.Controls.Add(this.btDelCustomer);
            this.panel1.Controls.Add(this.cbCustomer);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btChange);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.dgvOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 389);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Курьер";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Сотрудник";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Клиент";
            this.label1.Visible = false;
            // 
            // btDelCourier
            // 
            this.btDelCourier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelCourier.Image = global::fishmarket.Properties.Resources.del2;
            this.btDelCourier.Location = new System.Drawing.Point(505, 49);
            this.btDelCourier.Name = "btDelCourier";
            this.btDelCourier.Size = new System.Drawing.Size(20, 22);
            this.btDelCourier.TabIndex = 39;
            this.btDelCourier.UseVisualStyleBackColor = true;
            this.btDelCourier.Visible = false;
            this.btDelCourier.Click += new System.EventHandler(this.btDelCourier_Click);
            // 
            // cbCourier
            // 
            this.cbCourier.FormattingEnabled = true;
            this.cbCourier.Location = new System.Drawing.Point(358, 49);
            this.cbCourier.Name = "cbCourier";
            this.cbCourier.Size = new System.Drawing.Size(141, 21);
            this.cbCourier.TabIndex = 38;
            this.cbCourier.Visible = false;
            this.cbCourier.TextChanged += new System.EventHandler(this.cbCourier_TextChanged);
            // 
            // btDelEmployee
            // 
            this.btDelEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelEmployee.Image = global::fishmarket.Properties.Resources.del2;
            this.btDelEmployee.Location = new System.Drawing.Point(332, 49);
            this.btDelEmployee.Name = "btDelEmployee";
            this.btDelEmployee.Size = new System.Drawing.Size(20, 22);
            this.btDelEmployee.TabIndex = 37;
            this.btDelEmployee.UseVisualStyleBackColor = true;
            this.btDelEmployee.Visible = false;
            this.btDelEmployee.Click += new System.EventHandler(this.btDelEmployee_Click);
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(185, 49);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(141, 21);
            this.cbEmployee.TabIndex = 35;
            this.cbEmployee.Visible = false;
            this.cbEmployee.TextChanged += new System.EventHandler(this.cbEmployee_TextChanged);
            // 
            // btDelCustomer
            // 
            this.btDelCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelCustomer.Image = global::fishmarket.Properties.Resources.del2;
            this.btDelCustomer.Location = new System.Drawing.Point(159, 49);
            this.btDelCustomer.Name = "btDelCustomer";
            this.btDelCustomer.Size = new System.Drawing.Size(20, 22);
            this.btDelCustomer.TabIndex = 33;
            this.btDelCustomer.UseVisualStyleBackColor = true;
            this.btDelCustomer.Visible = false;
            this.btDelCustomer.Click += new System.EventHandler(this.btDelCustomer_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(12, 49);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(141, 21);
            this.cbCustomer.TabIndex = 32;
            this.cbCustomer.Visible = false;
            this.cbCustomer.TextChanged += new System.EventHandler(this.cbCustomer_TextChanged);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Location = new System.Drawing.Point(706, 354);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 31;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btChange
            // 
            this.btChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btChange.Location = new System.Drawing.Point(706, 325);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(75, 23);
            this.btChange.TabIndex = 30;
            this.btChange.Text = "Изменить";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(706, 296);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 29;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(12, 86);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(688, 291);
            this.dgvOrder.TabIndex = 28;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.panel1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDelCourier;
        private System.Windows.Forms.ComboBox cbCourier;
        private System.Windows.Forms.Button btDelEmployee;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btDelCustomer;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btAdd;
        public System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.BindingSource bsOrder;
        private System.Windows.Forms.BindingSource bsCustomer;
        private System.Windows.Forms.BindingSource bsEmployee;
        private System.Windows.Forms.BindingSource bsCourier;
    }
}