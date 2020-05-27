namespace SweetHouse_Project
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonOpenClient = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonApplication = new System.Windows.Forms.Button();
            this.buttonManager = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.labellabelHello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCensel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenClient
            // 
            this.buttonOpenClient.BackColor = System.Drawing.Color.MistyRose;
            this.buttonOpenClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenClient.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonOpenClient.Location = new System.Drawing.Point(54, 186);
            this.buttonOpenClient.Name = "buttonOpenClient";
            this.buttonOpenClient.Size = new System.Drawing.Size(133, 27);
            this.buttonOpenClient.TabIndex = 1;
            this.buttonOpenClient.Text = "Клиенты";
            this.buttonOpenClient.UseVisualStyleBackColor = false;
            this.buttonOpenClient.Click += new System.EventHandler(this.buttonOpenClient_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.MistyRose;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonOrder.Location = new System.Drawing.Point(54, 288);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(133, 27);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "Заказы";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonApplication
            // 
            this.buttonApplication.BackColor = System.Drawing.Color.MistyRose;
            this.buttonApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplication.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonApplication.Location = new System.Drawing.Point(54, 222);
            this.buttonApplication.Name = "buttonApplication";
            this.buttonApplication.Size = new System.Drawing.Size(133, 27);
            this.buttonApplication.TabIndex = 3;
            this.buttonApplication.Text = "Заказать товар";
            this.buttonApplication.UseVisualStyleBackColor = false;
            this.buttonApplication.Click += new System.EventHandler(this.buttonApplication_Click);
            // 
            // buttonManager
            // 
            this.buttonManager.BackColor = System.Drawing.Color.MistyRose;
            this.buttonManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManager.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonManager.Location = new System.Drawing.Point(54, 151);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(133, 27);
            this.buttonManager.TabIndex = 4;
            this.buttonManager.Text = "Менеджеры";
            this.buttonManager.UseVisualStyleBackColor = false;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.BackColor = System.Drawing.Color.MistyRose;
            this.buttonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonProduct.Location = new System.Drawing.Point(54, 257);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(133, 27);
            this.buttonProduct.TabIndex = 5;
            this.buttonProduct.Text = "Товары";
            this.buttonProduct.UseVisualStyleBackColor = false;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click_1);
            // 
            // labellabelHello
            // 
            this.labellabelHello.AutoSize = true;
            this.labellabelHello.Location = new System.Drawing.Point(51, 9);
            this.labellabelHello.Name = "labellabelHello";
            this.labellabelHello.Size = new System.Drawing.Size(48, 14);
            this.labellabelHello.TabIndex = 6;
            this.labellabelHello.Text = "Привет";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SweetHouse_Project.Properties.Resources._76525127_Cupcake_by_pai_thagoras;
            this.pictureBox1.Location = new System.Drawing.Point(54, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCensel
            // 
            this.buttonCensel.BackColor = System.Drawing.Color.MistyRose;
            this.buttonCensel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCensel.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonCensel.Location = new System.Drawing.Point(54, 321);
            this.buttonCensel.Name = "buttonCensel";
            this.buttonCensel.Size = new System.Drawing.Size(133, 27);
            this.buttonCensel.TabIndex = 12;
            this.buttonCensel.Text = "Выйти из системы";
            this.buttonCensel.UseVisualStyleBackColor = false;
            this.buttonCensel.Click += new System.EventHandler(this.buttonCensel_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(252, 360);
            this.Controls.Add(this.buttonCensel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labellabelHello);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.buttonManager);
            this.Controls.Add(this.buttonApplication);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonOpenClient);
            this.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenClient;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonApplication;
        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Label labellabelHello;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCensel;
    }
}

