﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class Produto
    {
        public int ID_PRODUTO { get; set; }
        public string CODIGO_PRODUTO { get; set; }
        public string NOME_PRODUTO { get; set; }
        public string SERVICO_PRODUTO { get; set; }
        public float VALOR_PRODUTO { get; set; }
        
    }
}