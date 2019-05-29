using DataAcess.Crud;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ClienteMagament
    {
        private ClienteCrudFactory crudFactory;

        public ClienteMagament()
        {
            crudFactory = new ClienteCrudFactory();
        }

        public void Create(Cliente cliente)
        {

            crudFactory.Create(cliente);

        }


        public List<Cliente> RetrieveAll()
        {
            return crudFactory.RetrieveAll<Cliente>();
        }

        public Cliente RetrieveById(Cliente cliente)
        {
            return crudFactory.Retrieve<Cliente>(cliente);
        }

        internal void Update(Cliente cliente)
        {
            crudFactory.Update(cliente);
        }

        internal void Delete(Cliente cliente)
        {
            crudFactory.Delete(cliente);
        }
                                                
    }
}
