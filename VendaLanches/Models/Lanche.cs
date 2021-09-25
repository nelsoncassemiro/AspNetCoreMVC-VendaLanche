using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaLanches.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public int DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool EmEstoque { get; set; }
        public bool CategoraId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
