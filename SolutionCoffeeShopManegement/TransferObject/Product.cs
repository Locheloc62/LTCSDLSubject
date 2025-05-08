using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public int purchasePrice { get; set; }
        public int sellingPrice { get; set; }
        public int categoryId { get; set; }
        public string supplierID { get; set; }
     
        public Product(string id, string name, int PP, int SP, int categoryID, string supplierID)
        {
            this.id = id;
            this.name = name;
            this.purchasePrice = PP;
            this.sellingPrice = SP;
            this.categoryId = categoryID;
            this.supplierID = supplierID;
        }

    }
}



