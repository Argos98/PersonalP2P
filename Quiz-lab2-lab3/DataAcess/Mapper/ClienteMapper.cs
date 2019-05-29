using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Dao;
using Entities_POJO;

namespace DataAcess.Mapper
{
    class ClienteMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const String BD_COL_Nombre= "Nombre";
        private const String BD_COL_Apellido= "Apellido";
        private const String BD_COL_FechaInicio= "Fecha_Inicio";
        private const String BD_COL_Genero = "Genero";
        private const String BD_COL_Estado = "Estado";
        private const String BD_COL_Cedula = "Cedula";
                             
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {

            var c = new Cliente
            {
                Nombre = GetStringValue(row,BD_COL_Nombre),
                Apellido = GetStringValue(row,BD_COL_Apellido),
                FechaInicio = GetStringValue(row,BD_COL_FechaInicio),
                Genero =GetStringValue(row,BD_COL_Genero),
                Estado =GetStringValue(row,BD_COL_Estado),
                Cedula=GetStringValue(row,BD_COL_Cedula)
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
            var operation = new SqlOperation { ProcedureName = "CRE_Clientes" };

            var c = (Cliente)entity;
            operation.AddVarcharParam(BD_COL_Nombre, c.Nombre);
            operation.AddVarcharParam(BD_COL_Apellido, c.Apellido);
            operation.AddVarcharParam(BD_COL_FechaInicio, c.Genero);
            operation.AddVarcharParam(BD_COL_Estado, c.Estado);
            operation.AddVarcharParam(BD_COL_Cedula, c.Cedula);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_Cliente" };
            var c = (Cliente)entity;
            operation.AddVarcharParam(BD_COL_Cedula, c.Cedula);
            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_Clientes" };
            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_Cliente" };

            var c = (Cliente)entity;
            operation.AddVarcharParam(BD_COL_Cedula, c.Cedula);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_Clientes" };

            var c = (Cliente)entity;
            operation.AddVarcharParam(BD_COL_Nombre, c.Nombre);
            operation.AddVarcharParam(BD_COL_Apellido, c.Apellido);
            operation.AddVarcharParam(BD_COL_FechaInicio, c.Genero);
            operation.AddVarcharParam(BD_COL_Estado, c.Estado);
            operation.AddVarcharParam(BD_COL_Cedula, c.Cedula);

            return operation;
        }
    }
}
