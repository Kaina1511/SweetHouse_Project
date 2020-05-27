namespace SweetHouse_Project
{
    partial class FormAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.buttonCensel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelТелефон = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelФИО = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCensel
            // 
            this.buttonCensel.BackColor = System.Drawing.Color.MistyRose;
            this.buttonCensel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCensel.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonCensel.Location = new System.Drawing.Point(133, 307);
            this.buttonCensel.Name = "buttonCensel";
            this.buttonCensel.Size = new System.Drawing.Size(87, 25);
            this.buttonCensel.TabIndex = 13;
            this.buttonCensel.Text = "Отмена";
            this.buttonCensel.UseVisualStyleBackColor = false;
            this.buttonCensel.Click += new System.EventHandler(this.buttonCensel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.MistyRose;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonOK.Location = new System.Drawing.Point(18, 307);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 25);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "Войти";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelТелефон
            // 
            this.labelТелефон.AutoSize = true;
            this.labelТелефон.Location = new System.Drawing.Point(15, 169);
            this.labelТелефон.Name = "labelТелефон";
            this.labelТелефон.Size = new System.Drawing.Size(213, 14);
            this.labelТелефон.TabIndex = 18;
            this.labelТелефон.Text = "Войдите под своей учетной записью";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(19, 257);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 14);
            this.label.TabIndex = 17;
            this.label.Text = "Пароль";
            // 
            // labelФИО
            // 
            this.labelФИО.AutoSize = true;
            this.labelФИО.Location = new System.Drawing.Point(26, 207);
            this.labelФИО.Name = "labelФИО";
            this.labelФИО.Size = new System.Drawing.Size(41, 14);
            this.labelФИО.TabIndex = 16;
            this.labelФИО.Text = "Логин";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxPassword.Location = new System.Drawing.Point(73, 254);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(116, 22);
            this.textBoxPassword.TabIndex = 15;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxLogin.Location = new System.Drawing.Point(73, 204);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(116, 22);
            this.textBoxLogin.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SweetHouse_Project.Properties.Resources._76525127_Cupcake_by_pai_thagoras;
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(237, 343);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelТелефон);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelФИО);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonCensel);
            this.Controls.Add(this.buttonOK);
            this.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAuthorization";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCensel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelТелефон;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelФИО;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}