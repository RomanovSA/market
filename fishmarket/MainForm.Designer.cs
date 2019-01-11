namespace fishmarket
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btTipe = new System.Windows.Forms.Button();
            this.btProducts = new System.Windows.Forms.Button();
            this.btOrders = new System.Windows.Forms.Button();
            this.btProviders = new System.Windows.Forms.Button();
            this.btRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTipe
            // 
            this.btTipe.Location = new System.Drawing.Point(49, 59);
            this.btTipe.Name = "btTipe";
            this.btTipe.Size = new System.Drawing.Size(91, 53);
            this.btTipe.TabIndex = 0;
            this.btTipe.Text = "Типы";
            this.btTipe.UseVisualStyleBackColor = true;
            this.btTipe.Click += new System.EventHandler(this.btTipe_Click);
            // 
            // btProducts
            // 
            this.btProducts.Location = new System.Drawing.Point(274, 59);
            this.btProducts.Name = "btProducts";
            this.btProducts.Size = new System.Drawing.Size(99, 53);
            this.btProducts.TabIndex = 1;
            this.btProducts.Text = "Товары";
            this.btProducts.UseVisualStyleBackColor = true;
            this.btProducts.Click += new System.EventHandler(this.btProducts_Click);
            // 
            // btOrders
            // 
            this.btOrders.Location = new System.Drawing.Point(60, 239);
            this.btOrders.Name = "btOrders";
            this.btOrders.Size = new System.Drawing.Size(91, 59);
            this.btOrders.TabIndex = 2;
            this.btOrders.Text = "Заказы";
            this.btOrders.UseVisualStyleBackColor = true;
            this.btOrders.Click += new System.EventHandler(this.btOrders_Click);
            // 
            // btProviders
            // 
            this.btProviders.Location = new System.Drawing.Point(274, 234);
            this.btProviders.Name = "btProviders";
            this.btProviders.Size = new System.Drawing.Size(101, 64);
            this.btProviders.TabIndex = 3;
            this.btProviders.Text = "Поставщики";
            this.btProviders.UseVisualStyleBackColor = true;
            this.btProviders.Click += new System.EventHandler(this.btProviders_Click);
            // 
            // btRequest
            // 
            this.btRequest.Location = new System.Drawing.Point(165, 161);
            this.btRequest.Name = "btRequest";
            this.btRequest.Size = new System.Drawing.Size(91, 52);
            this.btRequest.TabIndex = 6;
            this.btRequest.Text = "запросы";
            this.btRequest.UseVisualStyleBackColor = true;
            this.btRequest.Click += new System.EventHandler(this.btRequest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 367);
            this.Controls.Add(this.btRequest);
            this.Controls.Add(this.btProviders);
            this.Controls.Add(this.btOrders);
            this.Controls.Add(this.btProducts);
            this.Controls.Add(this.btTipe);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зоомагазин";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTipe;
        private System.Windows.Forms.Button btProducts;
        private System.Windows.Forms.Button btOrders;
        private System.Windows.Forms.Button btProviders;
        private System.Windows.Forms.Button btRequest;
    }
}

