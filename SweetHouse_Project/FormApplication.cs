using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SweetHouse_Project
{
    public partial class FormApplication : Form
    {
        public FormApplication()
        {
            InitializeComponent();
            ShowProducts();
            ShowClients();
            ShowApplicationSet();
        }

        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientSet clientSet in Program.shDb.ClientSet)
            {
                string[] item = { clientSet.Id.ToString() + ".", clientSet.FIO };
                comboBoxClients.Items.Add(string.Join("", item));
            }
        }
        void ShowProducts()
        {
            comboBoxProducts.Items.Clear();
            foreach (ProductSet productSet in Program.shDb.ProductSet)
            {
                string[] item = { productSet.Id.ToString() + ".", productSet.Name + " ", productSet.Prise.ToString() + " р." };
                comboBoxProducts.Items.Add(string.Join("", item));
            }
        }


        void ShowApplicationSet()
        {
            listViewApplication.Items.Clear();
            foreach (ApplicationSet application in Program.shDb.ApplicationSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    application.Id.ToString(),
                    application.ClientSet.Id.ToString(),
                    application.ClientSet.FIO+", "+application.ClientSet.Adres+", тел. "+application.ClientSet.Phone+".",
                    application.ProductSet.Id.ToString(),
                    application.ProductSet.Name,
                    application.ProductSet.Prise.ToString()+" р.",
                    application.Type.ToString(),
                });
                item.Tag = application;
                listViewApplication.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewApplication.SelectedItems.Count == 1)
            {
                ApplicationSet application = listViewApplication.SelectedItems[0].Tag as ApplicationSet;
                application.IdProduct = Convert.ToInt32(comboBoxProducts.SelectedItem.ToString().Split('.')[0]);
                application.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                application.Type = Convert.ToInt32(comboBoxType.SelectedItem.ToString().Split('.')[0]);
                
                Program.shDb.SaveChanges();
                ShowApplicationSet();
            }
        }

        private void listViewApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewApplication.SelectedItems.Count == 1)
            {
                ApplicationSet application = listViewApplication.SelectedItems[0].Tag as ApplicationSet;
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(application.IdClient.ToString());
                comboBoxProducts.SelectedIndex = comboBoxProducts.FindString(application.IdProduct.ToString());
                comboBoxType.SelectedIndex = comboBoxType.FindString(application.Type.ToString());
            }
            else
            {
                comboBoxClients.SelectedItem = null;
                comboBoxProducts.SelectedItem = null;
                comboBoxType.SelectedItem = null; 
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewApplication.SelectedItems.Count == 1)
                {
                    ApplicationSet application = listViewApplication.SelectedItems[0].Tag as ApplicationSet;
                    Program.shDb.ApplicationSet.Remove(application);
                    Program.shDb.SaveChanges();
                    ShowApplicationSet();
                }
                comboBoxClients.SelectedItem = null;
                comboBoxProducts.SelectedItem = null;
                comboBoxType.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClients.SelectedItem != null && comboBoxProducts.SelectedItem != null)
            {
                ApplicationSet application = new ApplicationSet();
                application.IdProduct = Convert.ToInt32(comboBoxProducts.SelectedItem.ToString().Split('.')[0]);
                application.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                if (comboBoxType.SelectedIndex == 0)
                {
                    application.Type = 0;
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    application.Type = 1;
                }
                else
                {
                    application.Type = 2;
                }
                Program.shDb.ApplicationSet.Add(application);
                Program.shDb.SaveChanges();
                ShowApplicationSet();
            }
            else MessageBox.Show("Данные не выбраны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}

