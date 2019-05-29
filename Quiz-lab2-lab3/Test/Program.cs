using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;
using System.Configuration;

namespace Testing
{
    class Program
    {


        static void Main(string[] args)
        {

            DoIt();

        }

        public static void DoIt()
        {
            try
            {
                var mng = new ProductoMagament();
                var producto = new Producto();

                Console.WriteLine("Customers CRUD options");
                Console.WriteLine("1.CREATE");
                Console.WriteLine("2.RETRIEVE ALL");
                Console.WriteLine("3.RETRIEVE BY ID");
                Console.WriteLine("4.UPDATE");
                Console.WriteLine("5.DELETE");

                Console.WriteLine("Choose an option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("***************************");
                        Console.WriteLine("*****     CREATE    *******");
                        Console.WriteLine("***************************");
                        Console.WriteLine("Type the Codigo, Nombre, Descripcion, Fecha_Ingreso, Precio, Estado separated by comma");
                        var info = Console.ReadLine();
                        var infoArray = info.Split(',');

                        producto = new Producto(infoArray);
                        mng.Create(producto);

                        Console.WriteLine("Customer was created");

                        break;

                    case "2":
                        Console.WriteLine("***************************");
                        Console.WriteLine("*****  RETRIEVE ALL   *****");
                        Console.WriteLine("***************************");

                        var lstCustomers = mng.RetrieveAll();
                        var count = 0;

                        foreach (var c in lstCustomers)
                        {
                            count++;
                            Console.WriteLine(count + " ==> " + c.GetEntityInformation());
                        }

                        break;
                    case "3":
                        Console.WriteLine("Type the producto id:");
                        producto.Codigo = Console.ReadLine();
                        producto = mng.RetrieveById(producto);

                        if (producto != null)
                        {
                            Console.WriteLine(" ==> " + producto.GetEntityInformation());
                        }

                        break;
                    case "4":
                        Console.WriteLine("***************************");
                        Console.WriteLine("******  UPDATE  *******");
                        Console.WriteLine("***************************");

                        Console.WriteLine("Type the producto Code:");
                        producto.Codigo = Console.ReadLine();
                        producto = mng.RetrieveById(producto);

                        if (producto != null)
                        {
                            Console.WriteLine(" ==> " + producto.GetEntityInformation());
                            Console.WriteLine("Type a new name, actual value is " + producto.Nombre);
                            producto.Nombre = Console.ReadLine();
                            Console.WriteLine("Type a new description actual value is " + producto.Descripcion);
                            producto.Descripcion = Console.ReadLine();
                            Console.WriteLine("Type a new Admission date, actual value is " + producto.FechaIngreso);
                            producto.FechaIngreso = Console.ReadLine();
                            Console.WriteLine("Type a new Admission Precio, actual value is " + producto.Precio);
                            String precio1 = Console.ReadLine();
                            producto.Precio = Convert.ToDouble(precio1);



                            //Console.WriteLine("Type a new Admission Impuesto, actual value is " + producto.Precio);
                            //String Impuesto1 = Console.ReadLine();
                            //producto.Impuesto = Convert.ToDouble(Impuesto1);

                            Console.WriteLine("Type a new Admission Estado, actual value is " + producto.FechaIngreso);
                            producto.FechaIngreso = Console.ReadLine();



                            mng.Update(producto);
                            Console.WriteLine("Producto was updated");
                        }
                        else
                        {
                            throw new Exception("Producto not registered");
                        }

                        break;

                    case "5":
                        Console.WriteLine("Type the producto id:");
                        producto.Codigo = Console.ReadLine();
                        producto = mng.RetrieveById(producto);

                        if (producto != null)
                        {
                            Console.WriteLine(" ==> " + producto.GetEntityInformation());

                            Console.WriteLine("Delete? Y/N");
                            var delete = Console.ReadLine();

                            if (delete.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                            {
                                mng.Delete(producto);
                                Console.WriteLine("Producto was deleted");
                            }
                        }
                        else
                        {
                            throw new Exception("Producto not registered");
                        }

                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("***************************");
                Console.WriteLine("ERROR: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("***************************");
            }
            finally
            {
                Console.WriteLine("Continue? Y/N");
                var moreActions = Console.ReadLine();

                if (moreActions.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                    DoIt();
            }


        }
    }
}
