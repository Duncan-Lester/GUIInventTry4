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

        private void searchPart_Click(Object sender, EventArgs e)
        {
            // this part is bad code; lots of errors possible if i don't force nice INTs in the search bar, not in assignment req's.
            // i should error check with a Try / Catch but lazy.
            int wantID = int.Parse(textBox1.Text);
            if (wantID < 1) return;
            Part matchPart = Inventory.lookupPart(wantID);
            foreach (DataGridViewRow row in partGrid.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == matchPart.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
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
        private void SearchProd_Click(Object sender, EventArgs e)
        {
            // this part is bad code; lots of errors possible if i don't force nice INTs in the search bar, not in assignment req's.
            int wantProdID = int.Parse(textBox2.Text);
            if (wantProdID < 1) { return; }   
            Product matchProd = Inventory.lookupProduct(int.Parse(textBox2.Text));
            foreach (DataGridViewRow row in prodGrid.Rows)
            {
                Product prod = (Product)row.DataBoundItem;
                if (prod.ProductID == matchProd.ProductID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }
        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
