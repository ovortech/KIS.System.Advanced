﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class Despesa : ExclusaoLogica
    {
        public int ID_DESPESA { get; set; }
        public int ID_TIPO_DESPESA { get; set; }
        public string DESC_DESPESA { get; set; }
        public double VALOR_DESPESA { get; set; }
        public DateTime DATA_DESPESA { get; set; }
        public int ID_LOGIN_DESPESA { get; set; }

    }
}
