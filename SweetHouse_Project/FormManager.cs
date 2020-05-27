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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
            ShowManager();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ManagerSet managerSet = new ManagerSet();
            managerSet.FIO = textBoxFIO.Text;
            managerSet.Adres = textBoxAdres.Text;
            managerSet.Phone = textBoxPhone.Text;
            Program.shDb.ManagerSet.Add(managerSet);
            Program.shDb.SaveChanges();
            ShowManager();
        }
        void ShowManager()
        {
            listViewManager.Items.Clear();
            foreach (ManagerSet managerSet in Program.shDb.ManagerSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    managerSet.Id.ToString(), managerSet.FIO, managerSet.Adres, managerSet.Phone
                });
                item.Tag = managerSet;
                listViewManager.Items.Add(item);
            }
            listViewManager.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewManager.SelectedItems.Count == 1)
            {
                ManagerSet managerSet = listViewManager.SelectedItems[0].Tag as ManagerSet;
                managerSet.FIO = textBoxFIO.Text;
                managerSet.Adres = textBoxAdres.Text;
                managerSet.Phone = textBoxPhone.Text;
                Program.shDb.SaveChanges();
                ShowManager();
            }
        }

        private void listViewManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewManager.SelectedItems.Count == 1)
            {
                ManagerSet managerSet = listViewManager.SelectedItems[0].Tag as ManagerSet;
                textBoxFIO.Text = managerSet.FIO;
                textBoxAdres.Text = managerSet.Adres;
                textBoxPhone.Text = managerSet.Phone;
            }
            else
            {
                textBoxFIO.Text = "";
                textBoxAdres.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewManager.SelectedItems.Count == 1)
                {
                    ManagerSet managerSet = listViewManager.SelectedItems[0].Tag as ManagerSet;
                    Program.shDb.ManagerSet.Remove(managerSet);
                    Program.shDb.SaveChanges();
                    ShowManager();
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
    }
    }


