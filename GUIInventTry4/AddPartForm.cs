using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUIInventTry4
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }
        public void SavePart_Click(object sender, EventArgs e)
        {
            int minstock;
            int maxstock;
            int inventstock;
            decimal price;
            try
            {
                minstock = int.Parse(minBox.Text);
                maxstock = int.Parse(maxBox.Text);
                inventstock = int.Parse(InventoryTextBox.Text);
                price = decimal.Parse(PriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Max, Min, and Price must all contain numeric values.");
                return;
            }
            string name = partNametextbox.Text;
            price = decimal.Parse(PriceTextBox.Text);
            minstock = int.Parse(minBox.Text);
            maxstock = int.Parse(maxBox.Text);
            inventstock = int.Parse(InventoryTextBox.Text);

            if (minstock > maxstock)
            {
                MessageBox.Show("Max must be greater than min!");
                return;
            }
            if (inventstock > maxstock || inventstock < minstock)
            {
                MessageBox.Show("Inventory must be inside Min to Max Range, inclusive.");
                return;
            }

            if (radioButton1.Checked)
            {

                int machineID = int.Parse(textBox7.Text);
                Inhouse inhouse = new(findCount(), name, inventstock, price, minstock, maxstock, machineID);
                Inhouse inpart = inhouse;
                Inventory.addPart(inpart);
            }

            else if (radioButton2.Checked)
            {
                string company = textBox7.Text;
                Outsourced outpart = new(findCount(), name, inventstock, price, minstock, maxstock, company);
                Outsourced outp = outpart;
                Inventory.addPart(outp);
            }
            Close();
        }

        public void radiobutton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Machine ID";
        }
        public void radiobutton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Company Name";
        }
        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private int findCount()
        {
            int partCounter = Inventory.AllParts.Count + 1;
            return partCounter;
        }
    }

}
