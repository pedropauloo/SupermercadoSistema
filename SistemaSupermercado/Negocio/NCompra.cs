﻿using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCompra
    {
        List<Compra> compras;
        public void Insert(Compra c)
        {
            PCompra pC = new PCompra();
            compras = pC.Open();
            int id = 1;
            if (compras.Count > 0) id = compras.Max(x => x.Id) + 1;
            c.Id = id;
            compras.Add(c);
            pC.Save(compras);
        }
        
        public void Delete(Compra c)
        {
            PItemCompra pIC = new PItemCompra();
            NItemCompra nIC = new NItemCompra();
            List<ItemCompra> lIC = pIC.Open();
            foreach (ItemCompra i in lIC) if (i.IdCompra == c.Id) nIC.Delete(i);
            
            PCompra pC = new PCompra();
            compras = pC.Open();

            for (int i = 0; i < compras.Count; i++)
                if (compras[i].Id == c.Id)
                {
                    compras.RemoveAt(i);
                    break;
                }
            pC.Save(compras);
        }
    }
}
