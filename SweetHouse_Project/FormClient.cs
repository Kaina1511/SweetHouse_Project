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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClientSet clientSet = new ClientSet();
            clientSet.FIO = textBoxFIO.Text;
            clientSet.Adres = textBoxAdres.Text;
            clientSet.Phone = textBoxPhone.Text;
            Program.shDb.ClientSet.Add(clientSet);
            Program.shDb.SaveChanges();
            ShowClient();
        }
        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (ClientSet clientSet in Program.shDb.ClientSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientSet.Id.ToString(), clientSet.FIO, clientSet.Adres, clientSet.Phone
                });
                item.Tag = clientSet;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count==1)
                {
                    ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                    Program.shDb.ClientSet.Remove(clientSet);
                    Program.shDb.SaveChanges();
                    ShowClient();
                }
                textBoxFIO.Text = "";
                textBoxAdres.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                clientSet.FIO= textBoxFIO.Text;
                clientSet.Adres= textBoxAdres.Text;
                clientSet.Phone = textBoxPhone.Text;
                Program.shDb.SaveChanges();
                ShowClient();
            }
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                textBoxFIO.Text = clientSet.FIO;
                textBoxAdres.Text = clientSet.Adres;
                textBoxPhone.Text = clientSet.Phone;
            }
            else
            {
                textBoxFIO.Text = "";
                textBoxAdres.Text = "";
                textBoxPhone.Text = "";
            }
        }
    }
}
