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

        }
        private void SaveProd_Clic(object sender, EventArgs e)

        {

        }

        private void AddParttoProd_Click(object sender, EventArgs e)
        {

        }
        private void SearchParts_Click(object sender, EventArgs e)
        {

        }
        private void RemoveAssocPart_Clic(object sender, EventArgs e)
        {

        }
        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
