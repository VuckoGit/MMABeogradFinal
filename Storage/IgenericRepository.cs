using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Storage
{
    public interface IgenericRepository
    {
        void Save(IEntity entity);
        List<IEntity> GetAll(IEntity e);
        int GetId(IEntity e);

        void OpenConnection();
        void Edit(IEntity entity);
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
        List<IEntity> Search(IEntity e);
        
    }
}
