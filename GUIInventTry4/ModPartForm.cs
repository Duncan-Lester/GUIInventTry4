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
    public partial class ModPartForm : Form
    {
        Main_Form MainWindow = (Main_Form)Application.OpenForms["MainForm"];
        public ModPartForm(Inhouse inPart)
        {
            InitializeComponent();
            IDtextBox.Text = inPart.PartID.ToString();
            partNametextbox.Text = inPart.Name;
            InventoryTextBox.Text = inPart.InStock.ToString();
            PriceTextBox.Text = inPart.Price.Substring(1).ToString();
            minBox.Text = inPart.Min.ToString();
            maxBox.Text = inPart.Max.ToString();
            textBox7.Text = inPart.MachineID.ToString();
        }

        public ModPartForm(Outsourced outPart)
        {
            InitializeComponent();
            IDtextBox.Text = outPart.PartID.ToString();
            partNametextbox.Text = outPart.Name;
            InventoryTextBox.Text = outPart.InStock.ToString();
            PriceTextBox.Text = outPart.Price.Substring(1).ToString();
            minBox.Text = outPart.Min.ToString();
            maxBox.Text = outPart.Max.ToString();
            textBox7.Text = outPart.CompanyName;
            radioButton2.Checked = true;
        }

        private void SavePart_Click(object sender, EventArgs e)
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
            int id = int.Parse(IDtextBox.Text);
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
                Inhouse inP = new Inhouse(id, name, inventstock, price, minstock, maxstock, int.Parse(textBox7.Text));
                Part oldPart = Inventory.lookupPart(id);
                Inventory.updatePart(oldPart, inP) ;
                radioButton1.Checked = true;
                Close();
            }
            if (radioButton2.Checked)
            {
                Outsourced outP = new Outsourced(id, name, inventstock, price, minstock, maxstock, textBox7.Text);
                Part oldPart = Inventory.lookupPart(id);
                Inventory.updatePart(oldPart, outP);
                radioButton2.Checked = true;
                Close();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e) { }
        private void AddPart_Load(object sender, EventArgs e)
        {

        }
        private void radiobutton1_Checked(object sender, EventArgs e)
        {
            label6.Text = "Machine ID";
        }

        private void radiobutton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Company Name";
        }
        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
