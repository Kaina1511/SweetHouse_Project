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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            ShowProduct();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ProductSet productSet = new ProductSet();
            productSet.Name = textBoxName.Text;
            productSet.Prise = Convert.ToInt32(textBoxPrise.Text);
            
            Program.shDb.ProductSet.Add(productSet);
            Program.shDb.SaveChanges();
            ShowProduct();
        }
        void ShowProduct()
        {
            listViewProduct.Items.Clear();
            foreach (ProductSet productSet in Program.shDb.ProductSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    productSet.Id.ToString(), productSet.Name, productSet.Prise.ToString()+" р."
                });
                item.Tag = productSet;
                listViewProduct.Items.Add(item);
            }
            listViewProduct.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        

        private void listViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 1)
            {
                ProductSet productSet = listViewProduct.SelectedItems[0].Tag as ProductSet;
                textBoxName.Text = productSet.Name;
                textBoxPrise.Text = productSet.Prise.ToString();
                
            }
            else
            {
                textBoxName.Text = "";
                textBoxPrise.Text = "";
                
            }
        }

        

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 1)
            {
                ProductSet productSet = listViewProduct.SelectedItems[0].Tag as ProductSet;
                productSet.Name = textBoxName.Text;
                productSet.Prise = Convert.ToInt32(textBoxPrise.Text);

                Program.shDb.SaveChanges();
                ShowProduct();
            }
        }

        private void buttonDel_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (listViewProduct.SelectedItems.Count == 1)
                {
                    ProductSet productSet = listViewProduct.SelectedItems[0].Tag as ProductSet;
                    Program.shDb.ProductSet.Remove(productSet);
                    Program.shDb.SaveChanges();
                    ShowProduct();
                }
                textBoxName.Text = "";
                textBoxPrise.Text = "";

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
