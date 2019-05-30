using DataAcess.Crud;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class DireccionMagament
    {
        private DireccionCrudFactory crudFactory;

        public DireccionMagament()
        {
            crudFactory = new DireccionCrudFactory();
        }

        public void Create(Direccion direccion)
        {

            crudFactory.Create(direccion);

        }

        public List<Direccion> RetrieveAll()
        {
            return crudFactory.RetrieveAll<Direccion>();
        }

        public Cliente RetrieveById(Direccion direccion)
        {
            return crudFactory.Retrieve<Cliente>(direccion);
        }

        internal void Update(Direccion direccion)
        {
            crudFactory.Update(direccion);
        }

        internal void Delete(Direccion direccion)
        {
            crudFactory.Delete(direccion);
        }

    }
}
