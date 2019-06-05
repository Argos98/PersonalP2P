using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Cliente : BaseEntity
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }

        public String Genero { get; set; }
        public String Estado { get; set; }
        public String Cedula { get; set; }

        public Cliente()
        {

        }
        public Cliente(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 5)
            {

                Nombre = infoArray[0];
                Apellido = infoArray[1];
                Genero = infoArray[2];
                Estado = infoArray[3];
                Cedula = infoArray[4];

            }
        }

    }
}
