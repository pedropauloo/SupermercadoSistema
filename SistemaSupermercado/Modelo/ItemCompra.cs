﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ItemCompra
    {
        public int IdCompra { get; set; }
        public int IdProduto { get; set; }
        public int Qtd { get; set; }
        public decimal Preco { get; set; }
    }
}
