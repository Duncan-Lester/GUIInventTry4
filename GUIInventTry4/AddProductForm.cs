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
    public partial class AddProductForm : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        public AddProductForm()
        {
            InitializeComponent();

            var topT = new BindingSource();
            topT.DataSource = Inventory.AllParts;
            candPartGrid.DataSource = topT;

            var botT = new BindingSource();
            botT.DataSource = addedParts;
            assocPartGrid.DataSource = botT;
        }
        private void SaveProd_Clic(object sender, EventArgs e)

        {
            int invent;
            int min;
            int max;
            decimal price;

            try
            {
                min = int.Parse(minBox.Text);
                max = int.Parse(maxBox.Text);
                invent = int.Parse(InventoryTextBox.Text);
                price = decimal.Parse(PriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max, and Min fields must all be numeric values.");
                return;
            }

            string name = partNametextbox.Text;
            invent = int.Parse(InventoryTextBox.Text);
            price = decimal.Parse(PriceTextBox.Text);
            min = int.Parse(minBox.Text);
            max = int.Parse(maxBox.Text);

            if (min > max)
            {
                MessageBox.Show("Error: Min must be smaller than Max");
                return;
            }
            if (invent > max || invent < min)
            {
                MessageBox.Show("Error: Inventory must be between max and min, inclusive.");
                return;
            }

            Product prod = new Product(Inventory.Products.Count + 1, name, invent, price, min, max);
            Inventory.addProduct(prod);

            foreach (Part part in addedParts)
            {
                prod.addAssociatedPart(part);
            }
            Close();

        }

        private void AddParttoProd_Click(object sender, EventArgs e)
        {
            Part partAdding = (Part)candPartGrid.CurrentRow.DataBoundItem;
            addedParts.Add(partAdding);
        }
        private void SearchParts_Click(object sender, EventArgs e)
        {
            int pID = int.Parse(searchBoxOne.Text);
            Part matchPart = Inventory.lookupPart(pID);
            foreach (DataGridViewRow row in candPartGrid.Rows)
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
        private void RemoveAssocPart_Clic(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this part from this product? This cannot easily be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in assocPartGrid.SelectedRows)
                {
                    assocPartGrid.Rows.RemoveAt(row.Index);
                }

            }
            else return;
        }
        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
