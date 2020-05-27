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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
            ShowManager();
            ShowApplication();
            ShowOrdeSet();
        }
        void ShowManager()
        {
            comboBoxManager.Items.Clear();
            foreach (ManagerSet managerSet in Program.shDb.ManagerSet)
            {
                string[] item = { managerSet.Id.ToString() + ".", managerSet.FIO };
                comboBoxManager.Items.Add(string.Join(" ", item));
            }
        }
        void ShowApplication()
        {
            comboBoxApplication.Items.Clear();
            foreach (ApplicationSet applicationSet in Program.shDb.ApplicationSet) 
            {
                string[] item = { applicationSet.Id.ToString() + ".", applicationSet.ClientSet.FIO };
                comboBoxApplication.Items.Add(string.Join(" ", item));
            }
        }
        void ShowOrdeSet()
        {
            listViewOrder.Items.Clear();
            foreach ( Order order in Program.shDb.Order)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    order.ID.ToString(),
                    order.ManagerSet.Id.ToString()+". "+ order.ManagerSet.FIO,
                    order.ApplicationSet.Id.ToString(),
                    order.ApplicationSet.ClientSet.Id.ToString()+". "+ order.ApplicationSet.ClientSet.FIO,
                    order.ApplicationSet.ProductSet.Id.ToString()+". "+order.ApplicationSet.ProductSet.Name,
                   order.ApplicationSet.ClientSet.Adres,
                   order.ApplicationSet.ClientSet.Phone,
                   order.ApplicationSet.ProductSet.Prise.ToString()+" р.",
                   order.ApplicationSet.Type.ToString()
                });
                item.Tag = order;
                listViewOrder.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxApplication.SelectedItem!=null && comboBoxManager.SelectedItem!=null)
            {
                Order order = new Order();
                order.IdApplication= Convert.ToInt32(comboBoxApplication.SelectedItem.ToString().Split('.')[0]);
                order.IdManager= Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                Program.shDb.Order.Add(order);
                Program.shDb.SaveChanges();
                ShowOrdeSet();
            }
            else MessageBox.Show("Данные не выбраны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count == 1)
            {
                Order order = listViewOrder.SelectedItems[0].Tag as Order;
                order.IdApplication = Convert.ToInt32(comboBoxApplication.SelectedItem.ToString().Split('.')[0]);
                order.IdManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                Program.shDb.SaveChanges();
                ShowOrdeSet();
            }
        }

        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count == 1)
            {
                Order order = listViewOrder.SelectedItems[0].Tag as Order;
                comboBoxApplication.SelectedIndex = comboBoxApplication.FindString(order.IdApplication.ToString());
                comboBoxManager.SelectedIndex = comboBoxManager.FindString(order.IdManager.ToString());
            }
            else
            {
                comboBoxApplication.SelectedItem = null;
               comboBoxManager.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

            try
            {
                if (listViewOrder.SelectedItems.Count == 1)
                {
                    Order order = listViewOrder.SelectedItems[0].Tag as Order;
                    Program.shDb.Order.Remove(order);
                    Program.shDb.SaveChanges();
                    ShowOrdeSet();
                }
                comboBoxApplication.SelectedItem = null;
                comboBoxManager.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
