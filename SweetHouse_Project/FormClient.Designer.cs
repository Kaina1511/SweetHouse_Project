namespace SweetHouse_Project
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.labelФИО = new System.Windows.Forms.Label();
            this.labelАдрес = new System.Windows.Forms.Label();
            this.labelТелефон = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MistyRose;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonAdd.Location = new System.Drawing.Point(337, 268);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 25);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.MistyRose;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonDel.Location = new System.Drawing.Point(526, 268);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(87, 25);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewClient
            // 
            this.listViewClient.BackColor = System.Drawing.Color.SeaShell;
            this.listViewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewClient.FullRowSelect = true;
            this.listViewClient.GridLines = true;
            this.listViewClient.Location = new System.Drawing.Point(163, 27);
            this.listViewClient.MultiSelect = false;
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(457, 233);
            this.listViewClient.TabIndex = 2;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.Details;
            this.listViewClient.SelectedIndexChanged += new System.EventHandler(this.listViewClient_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 29;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО";
            this.columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Адрес";
            this.columnHeader3.Width = 178;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Телефон";
            this.columnHeader4.Width = 110;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxFIO.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxFIO.Location = new System.Drawing.Point(14, 40);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(116, 22);
            this.textBoxFIO.TabIndex = 3;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxAdres.Location = new System.Drawing.Point(14, 90);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(116, 22);
            this.textBoxAdres.TabIndex = 4;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxPhone.Location = new System.Drawing.Point(14, 141);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(116, 22);
            this.textBoxPhone.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(320, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(104, 14);
            this.label.TabIndex = 6;
            this.label.Text = "Список клиентов";
            // 
            // labelФИО
            // 
            this.labelФИО.AutoSize = true;
            this.labelФИО.Location = new System.Drawing.Point(14, 23);
            this.labelФИО.Name = "labelФИО";
            this.labelФИО.Size = new System.Drawing.Size(33, 14);
            this.labelФИО.TabIndex = 7;
            this.labelФИО.Text = "ФИО";
            // 
            // labelАдрес
            // 
            this.labelАдрес.AutoSize = true;
            this.labelАдрес.Location = new System.Drawing.Point(14, 73);
            this.labelАдрес.Name = "labelАдрес";
            this.labelАдрес.Size = new System.Drawing.Size(143, 14);
            this.labelАдрес.TabIndex = 8;
            this.labelАдрес.Text = "Адрес (город, р-н, ул., д.)";
            // 
            // labelТелефон
            // 
            this.labelТелефон.AutoSize = true;
            this.labelТелефон.Location = new System.Drawing.Point(14, 124);
            this.labelТелефон.Name = "labelТелефон";
            this.labelТелефон.Size = new System.Drawing.Size(55, 14);
            this.labelТелефон.TabIndex = 9;
            this.labelТелефон.Text = "Телефон";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SweetHouse_Project.Properties.Resources._76525127_Cupcake_by_pai_thagoras;
            this.pictureBox1.Location = new System.Drawing.Point(7, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.MistyRose;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonEdit.Location = new System.Drawing.Point(431, 268);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(87, 25);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(625, 305);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelТелефон);
            this.Controls.Add(this.labelАдрес);
            this.Controls.Add(this.labelФИО);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.listViewClient);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClient";
            this.Text = "Клиенты";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelФИО;
        private System.Windows.Forms.Label labelАдрес;
        private System.Windows.Forms.Label labelТелефон;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonEdit;
    }
}