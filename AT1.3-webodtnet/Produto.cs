using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT1._3_webodtnet
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        
        // Chave estrangeira de Categoria
        public int CategoriaId { get; set; }

        // Muitos para um
        public Categoria Categoria { get; set; }  
    }
}
