﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VendaLanches.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string DescricaoCurta { get; set; }
        [StringLength(255)]
        public int DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        [StringLength(200)]
        public string ImagemUrl { get; set; }
        [StringLength(200)]
        public string ImagemThumbnailUrl { get; set; }
        public bool EmEstoque { get; set; }
        public bool CategoraId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
