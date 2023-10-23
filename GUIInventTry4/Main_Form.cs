using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIInventTry4
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            Inventory.StockParts();
            Inventory.StockProd();

            var partsTable = new BindingSource();
            partsTable.DataSource = Inventory.AllParts;
            partGrid.DataSource = partsTable;

            var prodsTable = new BindingSource();
            prodsTable.DataSource = Inventory.Products;
            prodGrid.DataSource = prodsTable;
        }
        private void AddPart_Click(object sender, EventArgs e)
        {
            new AddPartForm().ShowDialog();
            partGrid.Update();
            partGrid.Refresh();
        }
        private void ModPart_Click(object sender, EventArgs e)
        {
            if (partGrid.CurrentRow.DataBoundItem.GetType() == typeof(GUIInventTry4.Inhouse))
            {
                Inhouse inHouse = (Inhouse)partGrid.CurrentRow.DataBoundItem;
                new ModPartForm(inHouse).ShowDialog();
            }
            else
            {
                Outsourced outPart = (Outsourced)partGrid.CurrentRow.DataBoundItem;
                new ModPartForm(outPart).ShowDialog();
            }

        }

        private void deletePart_Click(object obj, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete part? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in partGrid.SelectedRows)
                {
                    partGrid.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }
        private void AddProduct_Click(object sender, EventArgs e)
        {
            new AddProductForm().ShowDialog();
        }

        private void ModProduct_Click(object sender, EventArgs e)
        {
            Product selectProd = (Product)prodGrid.CurrentRow.DataBoundItem;
            new ModProdForm(selectProd).ShowDialog();
        }
        private void deleteProd_Click(object obj, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete product? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product prod = (Product)prodGrid.CurrentRow.DataBoundItem;
                if (prod.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot Delete Product with more than 0 associated parts. Delete parts first and try again!");
                    return;
                }
                foreach (DataGridViewRow row in prodGrid.SelectedRows)
                {
                    prodGrid.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }
        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
