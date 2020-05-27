namespace SweetHouse_Project
{
    partial class FormManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelТелефон = new System.Windows.Forms.Label();
            this.labelАдрес = new System.Windows.Forms.Label();
            this.labelФИО = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.listViewManager = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.MistyRose;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonEdit.Location = new System.Drawing.Point(427, 262);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(87, 25);
            this.buttonEdit.TabIndex = 23;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SweetHouse_Project.Properties.Resources._76525127_Cupcake_by_pai_thagoras;
            this.pictureBox1.Location = new System.Drawing.Point(2, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // labelТелефон
            // 
            this.labelТелефон.AutoSize = true;
            this.labelТелефон.Location = new System.Drawing.Point(9, 128);
            this.labelТелефон.Name = "labelТелефон";
            this.labelТелефон.Size = new System.Drawing.Size(55, 14);
            this.labelТелефон.TabIndex = 21;
            this.labelТелефон.Text = "Телефон";
            // 
            // labelАдрес
            // 
            this.labelАдрес.AutoSize = true;
            this.labelАдрес.Location = new System.Drawing.Point(9, 69);
            this.labelАдрес.Name = "labelАдрес";
            this.labelАдрес.Size = new System.Drawing.Size(96, 14);
            this.labelАдрес.TabIndex = 20;
            this.labelАдрес.Text = "Адрес (г., ул., д.)";
            // 
            // labelФИО
            // 
            this.labelФИО.AutoSize = true;
            this.labelФИО.Location = new System.Drawing.Point(9, 18);
            this.labelФИО.Name = "labelФИО";
            this.labelФИО.Size = new System.Drawing.Size(33, 14);
            this.labelФИО.TabIndex = 19;
            this.labelФИО.Text = "ФИО";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(353, 5);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(122, 14);
            this.label.TabIndex = 18;
            this.label.Text = "Список менеджеров";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxPhone.Location = new System.Drawing.Point(9, 145);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(116, 22);
            this.textBoxPhone.TabIndex = 17;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxAdres.Location = new System.Drawing.Point(9, 86);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(116, 22);
            this.textBoxAdres.TabIndex = 16;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxFIO.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxFIO.Location = new System.Drawing.Point(9, 36);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(116, 22);
            this.textBoxFIO.TabIndex = 15;
            // 
            // listViewManager
            // 
            this.listViewManager.BackColor = System.Drawing.Color.SeaShell;
            this.listViewManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewManager.FullRowSelect = true;
            this.listViewManager.GridLines = true;
            this.listViewManager.Location = new System.Drawing.Point(150, 23);
            this.listViewManager.MultiSelect = false;
            this.listViewManager.Name = "listViewManager";
            this.listViewManager.Size = new System.Drawing.Size(458, 233);
            this.listViewManager.TabIndex = 14;
            this.listViewManager.UseCompatibleStateImageBehavior = false;
            this.listViewManager.View = System.Windows.Forms.View.Details;
            this.listViewManager.SelectedIndexChanged += new System.EventHandler(this.listViewManager_SelectedIndexChanged);
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
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.MistyRose;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonDel.Location = new System.Drawing.Point(521, 262);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(87, 25);
            this.buttonDel.TabIndex = 13;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MistyRose;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonAdd.Location = new System.Drawing.Point(332, 262);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 25);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(615, 299);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelТелефон);
            this.Controls.Add(this.labelАдрес);
            this.Controls.Add(this.labelФИО);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.listViewManager);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManager";
            this.Text = "Менеджеры";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelТелефон;
        private System.Windows.Forms.Label labelАдрес;
        private System.Windows.Forms.Label labelФИО;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.ListView listViewManager;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
    }
}