using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIInventTry4
{
    public class Inhouse : Part
    {
        private int machineID;
        public int MachineID { get; set; }
        public Inhouse() { }
        public Inhouse(int partID, string name, int instock, decimal price, int min, int max, int machineID)
        {
            PartID = partID;
            Name = name;
            InStock = instock;
            Price = price.ToString();
            Max = max;
            Min = min;
            MachineID = machineID;
        }
    }
}
