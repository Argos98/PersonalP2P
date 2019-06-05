using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Tarjeta : BaseEntity

    {
        String NumeroTarjeta { get; set; }
        String Fecha { get; set; }
        int CVV { get; set; }



        public Tarjeta()
        {

        }


    }
}
