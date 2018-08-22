﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Modelos
{
    class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [Required];
        [StringLength(30)];
        public int Nome { get; set; }
        public int Descricao { get; set; }

        //Relacionamento Categoria <--> Produto
        public virtual ICollection<Produto> _Produtos { get; set; }
    }
}
