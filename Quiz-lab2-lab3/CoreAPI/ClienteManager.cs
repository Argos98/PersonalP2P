using DataAcess.Crud;
using Entities_POJO;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAPI
{
    class ClienteManager : BaseManager
    {
        private ClienteCrudFactory crudCliente;

        public ClienteManager()
        {
            crudCliente = new ClienteCrudFactory();
        }

        public void Create(Cliente cliente)
        {
            try
            {
                var c = crudCliente.Retrieve<Cliente>(cliente);
                if (c != null)
                {
                    throw new BussinessException(3);
                }

                crudCliente.Create(cliente);
            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);

            }

        }

        public List<Cliente> RetrieveAll()
        {
            return crudCliente.RetrieveAll<Cliente>();

        }

        public Cliente RetrieveById(Cliente cliente)
        {
            Cliente c = null;
            try
            {
                c = crudCliente.Retrieve<Cliente>(cliente);

                if (c == null)
                {
                    throw new BussinessException(4);
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
            }

            return c;
        }

        public void Update(Cliente cliente)
        {
            crudCliente.Update(cliente);
        }

        public void Delete(Cliente cliente)
        {
            crudCliente.Delete(cliente);
        }
    }
}
