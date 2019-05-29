using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO

{
    public class Producto : BaseEntity
    {
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String FechaIngreso { get; set; }
        public double Precio { get; set; }
      //  public double Impuesto { get; set; }
        public String Estado { get; set; }

        public Producto()
        {

        }

        public Producto(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 7)
            {
                Codigo = infoArray[0];
                Nombre = infoArray[1];
                Descripcion = infoArray[2];
                FechaIngreso = infoArray[3];
                String temp1 = infoArray[4];
                Precio = Convert.ToDouble(temp1);
                String temp2 = infoArray[5];
             //   Impuesto = Convert.ToDouble(temp2);
                Estado = infoArray[6];

                //throw new Exception("All values are require[id,name,last_name,age]");


            }

        }
    }
}
