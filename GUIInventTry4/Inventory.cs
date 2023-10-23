using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIInventTry4
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void addProduct(Product prod)
        {
            Products.Add(prod);
        }
        public static bool removeProduct(int prodID)
        {
            bool success = false;
            foreach (Product prod in Products)
            {
                if (prodID == prod.ProductID)
                {
                    Products.Remove(prod);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("ERROR: Removal failed due to product not existing.");
                    return success = false;
                }
            }
            return success;
        }

        public static Product lookupProduct(int prodID)
        {
            foreach (Product prod in Products)
            {
                if (prodID == prod.ProductID)
                {
                    return prod;
                }
            }
            Product emptyProd = new Product();
            return emptyProd;
        }

        public static void updateProduct(int prodID, Product updatedProd)
        {
            foreach (Product currProd in Products)
            {
                if (currProd.ProductID == prodID)
                {
                    currProd.Name = updatedProd.Name;
                    currProd.InStock = updatedProd.InStock;
                    currProd.Price = updatedProd.Price;
                    currProd.Min = updatedProd.Min;
                    currProd.Max = updatedProd.Max;
                    currProd.AssociatedParts = updatedProd.AssociatedParts;
                    return;
                }
            }
        }

        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool deletePart(Part partToDel)
        {
            if (partToDel == null) return false;
            else
            {
                AllParts.Remove(partToDel);
                return true;
            }
        }

        public static Part lookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID) return part;
            }
            Part emptyPart = new Inhouse();
            return emptyPart;
        }

        public static void updatePart(int partID, Part part)
        {
            deletePart(part);
            addPart(part);
        }

        public static void StockParts()
        {
            Part example1 = new Inhouse(1, "example part 1", 10, 50000m, 5, 10, 008);
            Part example2 = new Outsourced(2, "example part 2", 44, 1.0m, 10, 45, "Test Comp");
            addPart(example1);
            addPart(example2);
        }
        public static void StockProd()
        {
            Product prod1 = new Product(1, "ex prod 1", 2, 5m, 1, 10);
            addProduct(prod1); ;
        }
    }
}
