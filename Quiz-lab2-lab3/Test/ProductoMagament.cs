using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Crud;
using Entities_POJO;

namespace Test
{
    class ProductoMagament
    {
        private ProductoCrudFactory crudFactory;

        public ProductoMagament()
        {
            crudFactory = new ProductoCrudFactory();
        }

        public void Create(Producto producto)
        {

            crudFactory.Create(producto);

        }


        public List<Producto> RetrieveAll()
        {
            return crudFactory.RetrieveAll<Producto>();
        }

        public Producto RetrieveById(Producto producto)
        {
            return crudFactory.Retrieve<Producto>(producto);
        }

        internal void Update(Producto producto)
        {
            crudFactory.Update(producto);
        }

        internal void Delete(Producto producto)
        {
            crudFactory.Delete(producto);
        }
    }
}
