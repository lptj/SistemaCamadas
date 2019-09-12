using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Produto
    {
        public int CdProduto { get; set; }
        public string DsProduto { get; set; }
        public decimal VlUnitario { get; set; }
        public int CdCategoria { get; set; }
    }
}
