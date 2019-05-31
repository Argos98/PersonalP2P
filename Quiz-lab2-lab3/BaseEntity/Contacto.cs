using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Contacto : BaseEntity
    {
        public string TipoContacto { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public string Publicidad { get; set; }
        public string CedulaCliente { get; set; }

        public Contacto()
        {
        }



        public Contacto(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 6)
            {
                TipoContacto = infoArray[0];
                Valor = infoArray[1];
                Descripcion = infoArray[2];
                Publicidad = infoArray[3];
                CedulaCliente = infoArray[5];
            }
        }
    }
}
