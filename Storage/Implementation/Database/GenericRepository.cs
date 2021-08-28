using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseBroker;
using Domain;

namespace Storage.Implementation.Database
{
    public class GenericRepository: IgenericRepository
    {
        private Broker broker = new Broker();
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }

     
        public List<IEntity> GetAll(IEntity entity)
        {
            return broker.GetAll(entity);
        }

        public int GetId(IEntity e)
        {
            return broker.GetId(e);
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public void Save(IEntity entity)
        {
            broker.Save(entity);
        }
        public List<IEntity> Search(IEntity entity)
        {
           return broker.Search(entity);
        }
        public void Edit(IEntity entity)
        {
            broker.Edit(entity);
        }
    }
}
