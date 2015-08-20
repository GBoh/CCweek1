using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithDictionary
{
    class Product
    {
        public int Id;
        public string Name;
        public decimal Price;
    }

    public class ProductCatalog
    {
        Dictionary<int, string> catalog = new Dictionary<int, string>();
        public string LookupId(int id)
        {


            return null;
        }

        public ProductCatalog()
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
