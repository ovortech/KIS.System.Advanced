﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    class Contrato
    {
        public int ID_CONTRATO { get; set; }
        public int ID_PEDIDO_CONTRATO { get; set; }
        public int ID_CLIENTE_CONTRATO { get; set; }
        public int FATURADO_CONTRATO { get; set; }
    }
}