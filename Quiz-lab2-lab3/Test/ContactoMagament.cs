using DataAcess.Crud;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ContactoMagament  
    {

        private ContactoCrudFactory crudFactory;

        public ContactoMagament()
        {
            crudFactory = new ContactoCrudFactory();
        }

        public void Create(Contacto contacto)
        {

            crudFactory.Create(contacto);

        }
        
        public List<Contacto> RetrieveAll()
        {
            return crudFactory.RetrieveAll<Contacto>();
        }

        public Cliente RetrieveById(Contacto contacto)
        {
            return crudFactory.Retrieve<Cliente>(contacto);
        }

        internal void Update(Contacto contacto)
        {
            crudFactory.Update(contacto);
        }

        internal void Delete(Contacto contacto)
        {
            crudFactory.Delete(contacto);
        }


    }
}
