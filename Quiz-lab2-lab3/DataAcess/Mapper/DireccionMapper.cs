using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Dao;
using Entities_POJO;

namespace DataAcess.Mapper
{
    class DireccionMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const String BD_COL_Provincia = "Provincia";
        private const String BD_COL_Canton = "Canton";
        private const String BD_COL_Distrito = "Distrito";
        private const String BD_COL_Senas = "Senas";
        private const String BD_COL_Tipo = "Tipo";
        private const String BD_COL_CedulaCliente = "Cedula_Cliente";
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {


            var d = new Direccion
            {
                Provincia=GetStringValue(row,BD_COL_Provincia),
                Canton=GetStringValue(row,BD_COL_Canton),
                Distrito=GetStringValue(row,BD_COL_Distrito),
                Senas=GetStringValue(row,BD_COL_Senas),
                Tipo=GetStringValue(row,BD_COL_Tipo),
                CedulaCliente=GetStringValue(row,BD_COL_CedulaCliente),
                
            };

            return d;

        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var d = BuildObject(row);
                lstResults.Add(d);
            }

            return lstResults;

        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_Direcciones" };

            var d = (Direccion)entity;

            operation.AddVarcharParam(BD_COL_Provincia, d.Provincia);
            operation.AddVarcharParam(BD_COL_Canton, d.Canton);
            operation.AddVarcharParam(BD_COL_Distrito, d.Distrito);
            operation.AddVarcharParam(BD_COL_Senas, d.Senas);
            operation.AddVarcharParam(BD_COL_Tipo, d.Tipo);
            operation.AddVarcharParam(BD_COL_CedulaCliente, d.CedulaCliente);

            return operation;

               

        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "Del_Direcciones" };
            var c = (Direccion)entity;
            operation.AddVarcharParam(BD_COL_CedulaCliente, c.CedulaCliente);
            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_Direcciones" };

           
            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_Direcciones" };

            var c = (Direccion)entity;
            operation.AddVarcharParam(BD_COL_CedulaCliente, c.CedulaCliente);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_Direcciones" };

            var d = (Direccion)entity;

            operation.AddVarcharParam(BD_COL_Provincia, d.Provincia);
            operation.AddVarcharParam(BD_COL_Canton, d.Canton);
            operation.AddVarcharParam(BD_COL_Distrito, d.Distrito);
            operation.AddVarcharParam(BD_COL_Senas, d.Senas);
            operation.AddVarcharParam(BD_COL_Tipo, d.Tipo);
            operation.AddVarcharParam(BD_COL_CedulaCliente, d.CedulaCliente);

            return operation;
        }
    }
}
