﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
    public class Produto
    {
        public int ProdutoID { get; set; }

        public String Nome { get; set; }

        public String Descricao { get; set; }

        public Decimal Preco { get; set; }

        public String Categoria { get; set; }
    }
}
