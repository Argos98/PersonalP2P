using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Dao;
using Entities_POJO;

namespace DataAcess.Mapper
{
    class ProductoMapper : EntityMapper, ISqlStaments, IObjectMapper
    {


        private const  String BD_COL_Codigo = "Codigo";
        private const  String BD_COL_Nombre = "Nombre";
        private const  String BD_COL_Descripcion = "Descripcion";
        private const  String BD_COL_Fecha_Ingreso = "Fecha_Ingreso";
        private const  String BD_COL_Precio = "Precio";
       // private const  String BD_COL_Impuesto = "Impuesto";
        private const  String BD_COL_Estado = "Estado";

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {

            var p = new Producto {

                Codigo = GetStringValue(row,BD_COL_Codigo),
                Nombre = GetStringValue(row,BD_COL_Nombre),
                Descripcion= GetStringValue(row,BD_COL_Descripcion),
                FechaIngreso =GetStringValue(row,BD_COL_Fecha_Ingreso),
                Precio =GetDoubleValue (row,BD_COL_Precio),
              //  Impuesto = GetDoubleValue(row,BD_COL_Impuesto),
                Estado = GetStringValue(row, BD_COL_Estado)

            };

            return p;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var p = BuildObject(row);
                lstResults.Add(p);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_Producto" };

            var p = (Producto)entity;

            operation.AddVarcharParam(BD_COL_Codigo, p.Codigo);
            operation.AddVarcharParam(BD_COL_Nombre, p.Nombre);
            operation.AddVarcharParam(BD_COL_Descripcion, p.Descripcion);
            operation.AddVarcharParam(BD_COL_Fecha_Ingreso, p.FechaIngreso);
            operation.AddDoubleParam(BD_COL_Precio, p.Precio);
            //operation.AddDoubleParam(BD_COL_Impuesto, p.Impuesto);
            operation.AddVarcharParam(BD_COL_Estado, p.Estado);

            return operation;

        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_Producntos" };

            var c = (Producto)entity;
            operation.AddVarcharParam(BD_COL_Codigo, c.Codigo);
            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_Productos" };
            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_Producto" };

            var c = (Producto)entity;
            operation.AddVarcharParam(BD_COL_Codigo, c.Codigo);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_Producto" };

            var p = (Producto)entity;

            operation.AddVarcharParam(BD_COL_Codigo, p.Codigo);
            operation.AddVarcharParam(BD_COL_Nombre, p.Nombre);
            operation.AddVarcharParam(BD_COL_Descripcion, p.Descripcion);
            operation.AddVarcharParam(BD_COL_Fecha_Ingreso, p.FechaIngreso);
            operation.AddDoubleParam(BD_COL_Precio, p.Precio);
        //    operation.AddDoubleParam(BD_COL_Impuesto, p.Impuesto);
            operation.AddVarcharParam(BD_COL_Estado, p.Estado);

            return operation;
        }
    }
}
