using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Entities
{
    public class Login
    {
        public int LoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Usuario Usuario { get; set; }
    }
}
