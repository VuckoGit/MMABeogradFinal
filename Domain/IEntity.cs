using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public interface IEntity
    {

        string TableName { get; }
        string InsertValues { get; }
        string IdName { get; }
        string JoinCondition { get; }
        string JoinTable { get; }
        string TableAlias { get; }
        string SelectValues { get; }
        string SetValues { get; }
        string WhereSearchCondition { get; }
        string WhereUpdateCondition { get; }
        string InsertColums { get; }

        List<IEntity> GetEntities(SqlDataReader reader);

    }
}
