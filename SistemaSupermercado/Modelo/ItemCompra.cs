﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ItemCompra
    {
        private int idCompra;
        public int IdProduto { get; set; }
        public int Qtd { get; set; }
        public decimal Preco { get; set; }
        public void SetIdCompra(int i)
        {
            if (i > 0) idCompra = i;
        }
        public int GetIdCompra() { return idCompra; }
    }
}
