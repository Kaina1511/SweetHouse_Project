using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SweetHouse_Project
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "client") buttonManager.Visible = false;
            if (FormAuthorization.users.type == "client") buttonProduct.Visible = false;
            if (FormAuthorization.users.type == "client") buttonOrder.Visible = false;
            if (FormAuthorization.users.type == "client") buttonOpenClient.Visible = false;
            labellabelHello.Text = "Приветствую тебя, " + FormAuthorization.users.login;
        }
        private void buttonOpenClient_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }


        private void buttonManager_Click(object sender, EventArgs e)
        {
            Form formManager = new FormManager();
            formManager.Show();
        }

        private void buttonProduct_Click_1(object sender, EventArgs e)
        {
            Form formProduct = new FormProduct();
            formProduct.Show();
        }

        private void buttonApplication_Click(object sender, EventArgs e)
        {
            Form formApplication = new FormApplication();
            formApplication.Show();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Form formOrder = new FormOrder();
            formOrder.Show();
        }

        private void buttonCensel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
