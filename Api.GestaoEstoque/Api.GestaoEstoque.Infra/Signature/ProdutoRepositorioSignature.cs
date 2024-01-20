﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.Infra.Signature
{
    public class ProdutoRepositorioSignature
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int FornecedorId { get; set; }
        public int Quantidade { get; set; }
        public decimal Compra { get; set; }
    }
}
