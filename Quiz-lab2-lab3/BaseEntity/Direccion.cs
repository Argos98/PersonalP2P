using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
  public  class Direccion : BaseEntity
    {
        public String Provincia { get; set; }
        public String Canton { get; set; }
        public String Distrito { get; set; }
        public String Senas { get; set; }
        public String Tipo { get; set; }
        public String CedulaCliente { get; set; }
        public Direccion()
        {

        }
        public Direccion(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 6)
            {
                Provincia = infoArray[0];
                Canton = infoArray[1];
                Distrito = infoArray[2];
                Senas = infoArray[3];
                Tipo = infoArray[4];
                CedulaCliente = infoArray[6];




            }
        }
    }
}