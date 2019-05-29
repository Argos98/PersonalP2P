using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Dao;
using Entities_POJO;

namespace DataAcess.Mapper
{
    class ContactoMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const String BD_COL_TipoContacto = "Tipo_Contacto";
        private const String BD_COL_Valor = "Valor";
        private const String BD_COL_Descripcion = "Descripcion";
        private const String BD_COL_Publicidad = "IND_PUBLICIDAD";
        private const String BD_COL_CedulaCliente = "Cedula_Cliente";

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var c = new Contacto
            {
              TipoContacto = GetStringValue(row, BD_COL_TipoContacto),
              Valor = GetStringValue(row, BD_COL_Valor),
              Descripcion = GetStringValue(row,BD_COL_Descripcion),
              Publicidad =GetStringValue(row,BD_COL_Publicidad),
              CedulaCliente=GetStringValue(row,BD_COL_CedulaCliente)
              
            };

            return c;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var c = BuildObject(row);
                lstResults.Add(c);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {

            var operation = new SqlOperation { ProcedureName = "CRE_Contacto" };

            var p = (Contacto)entity;

            operation.AddVarcharParam(BD_COL_TipoContacto, p.TipoContacto);
            operation.AddVarcharParam(BD_COL_Valor, p.Valor);
            operation.AddVarcharParam(BD_COL_Descripcion, p.Descripcion);
            operation.AddVarcharParam(BD_COL_Publicidad, p.Publicidad);
            operation.AddVarcharParam(BD_COL_CedulaCliente, p.CedulaCliente);
            

            return operation;
                                 
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_Contactos" };
            var c = (Contacto)entity;
            operation.AddVarcharParam(BD_COL_CedulaCliente, c.CedulaCliente);
            return operation;
               
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_Contactos" };
            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_Contactos" };

            var c = (Contacto)entity;
            operation.AddVarcharParam(BD_COL_CedulaCliente, c.CedulaCliente);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_Contactos" };

            var p = (Contacto)entity;

            operation.AddVarcharParam(BD_COL_TipoContacto, p.TipoContacto);
            operation.AddVarcharParam(BD_COL_Valor, p.Valor);
            operation.AddVarcharParam(BD_COL_Descripcion, p.Descripcion);
            operation.AddVarcharParam(BD_COL_Publicidad, p.Publicidad);
            operation.AddVarcharParam(BD_COL_CedulaCliente, p.CedulaCliente);


            return operation;
        }
    }
}
