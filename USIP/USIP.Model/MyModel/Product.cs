using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USIP.Model.MyModel
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdBrand { get; set; }
        public int IdCategory { get; set; }
        public int PurchasePrice { get; set; }
        public int SalePrice { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}
