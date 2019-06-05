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

    }
}
