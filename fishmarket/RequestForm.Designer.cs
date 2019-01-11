namespace fishmarket
{
    partial class RequestForm
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
            this.btProdPoCl = new System.Windows.Forms.Button();
            this.btImeTov = new System.Windows.Forms.Button();
            this.btTovars = new System.Windows.Forms.Button();
            this.btTovarPoTip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btProdPoCl
            // 
            this.btProdPoCl.Location = new System.Drawing.Point(12, 12);
            this.btProdPoCl.Name = "btProdPoCl";
            this.btProdPoCl.Size = new System.Drawing.Size(255, 23);
            this.btProdPoCl.TabIndex = 0;
            this.btProdPoCl.Text = "Продажи по клиентам";
            this.btProdPoCl.UseVisualStyleBackColor = true;
            this.btProdPoCl.Click += new System.EventHandler(this.btProdPoCl_Click);
            // 
            // btImeTov
            // 
            this.btImeTov.Location = new System.Drawing.Point(12, 41);
            this.btImeTov.Name = "btImeTov";
            this.btImeTov.Size = new System.Drawing.Size(255, 23);
            this.btImeTov.TabIndex = 1;
            this.btImeTov.Text = "Список имеющихся товаров";
            this.btImeTov.UseVisualStyleBackColor = true;
            this.btImeTov.Click += new System.EventHandler(this.btImeTov_Click);
            // 
            // btTovars
            // 
            this.btTovars.Location = new System.Drawing.Point(12, 70);
            this.btTovars.Name = "btTovars";
            this.btTovars.Size = new System.Drawing.Size(255, 23);
            this.btTovars.TabIndex = 2;
            this.btTovars.Text = "Список товаров";
            this.btTovars.UseVisualStyleBackColor = true;
            this.btTovars.Click += new System.EventHandler(this.btTovars_Click);
            // 
            // btTovarPoTip
            // 
            this.btTovarPoTip.Location = new System.Drawing.Point(12, 99);
            this.btTovarPoTip.Name = "btTovarPoTip";
            this.btTovarPoTip.Size = new System.Drawing.Size(255, 23);
            this.btTovarPoTip.TabIndex = 3;
            this.btTovarPoTip.Text = "Товары по типам";
            this.btTovarPoTip.UseVisualStyleBackColor = true;
            this.btTovarPoTip.Click += new System.EventHandler(this.btTovarPoTip_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 133);
            this.Controls.Add(this.btTovarPoTip);
            this.Controls.Add(this.btTovars);
            this.Controls.Add(this.btImeTov);
            this.Controls.Add(this.btProdPoCl);
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btProdPoCl;
        private System.Windows.Forms.Button btImeTov;
        private System.Windows.Forms.Button btTovars;
        private System.Windows.Forms.Button btTovarPoTip;
    }
}