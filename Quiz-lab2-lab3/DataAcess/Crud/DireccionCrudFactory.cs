using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Dao;
using DataAcess.Mapper;
using Entities_POJO;

namespace DataAcess.Crud
{
  public  class DireccionCrudFactory : CrudFactory
    {
        DireccionMapper mapper;
        public DireccionCrudFactory() : base()
        {
            mapper = new DireccionMapper();
            dao = SqlDao.GetInstance();
        }

        public override void Create(BaseEntity entity)
        {
            var direccion = (Direccion)entity;
            var sqlOperation = mapper.GetCreateStatement(direccion);
            dao.ExecuteProcedure(sqlOperation);
        }

        public override void Delete(BaseEntity entity)
        {
            var direccion = (Direccion)entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(direccion));
        }

        public override T Retrieve<T>(BaseEntity entity)
        {
            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveStatement(entity));
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }

        public override List<T> RetrieveAll<T>()
        {
            var lstDireccion = new List<T>();

            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstDireccion.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return lstDireccion;
        }

        public override void Update(BaseEntity entity)
        {
            var direccion = (Direccion)entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(direccion));
        }
    }
}
