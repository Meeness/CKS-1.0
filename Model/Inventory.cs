using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model
{
    public class Inventory{

        public List<Item> Items {get;set;}
        public Inventory()
        {
            Items = new List<Item>();
        }
    }
}