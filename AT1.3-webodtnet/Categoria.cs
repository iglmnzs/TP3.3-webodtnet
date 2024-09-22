using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT1._3_webodtnet
{
    internal class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        // Um para muitos estabelecida por um Produto
        public ICollection<Produto> Produtos { get; set; } 
    }
}
