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
    public partial class ModProdForm : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        Main_Form mainWindow = (Main_Form)Application.OpenForms["Main_Form"];
        public ModProdForm(Product Prod1)
        {
            InitializeComponent();

            // populate with selected prod
            IDtextBox.Text = Prod1.ProductID.ToString();
            partNametextbox.Text = Prod1.Name;
            InventoryTextBox.Text = Prod1.InStock.ToString();
            PriceTextBox.Text = Prod1.Price.Substring(1).ToString();
            maxBox.Text = Prod1.Max.ToString();
            minBox.Text = Prod1.Min.ToString();
            //populate top table with all products 
            var top = new BindingSource();
            top.DataSource = Inventory.AllParts;
            candPartGrid.DataSource = top;
            //populate bottom with linked parts
            foreach (Part part in Prod1.AssociatedParts)
            {
                addedParts.Add(part);
            }
            var bottom = new BindingSource();
            bottom.DataSource = addedParts;
            assocPartGrid.DataSource = bottom;
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
            int id = int.Parse(IDtextBox.Text);

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

            Product prod = new Product(id, name, invent, price, min, max);
            

            foreach (Part part in addedParts)
            {
                prod.addAssociatedPart(part);
            }
            Inventory.updateProduct(id, prod);
            Close();

            mainWindow.prodGrid.Update();
            mainWindow.prodGrid.Refresh();
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
    }
}
