using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class User : IEntity
    {
        public int  UserId { get; set; }
        public string Username { get; set; }
        [Browsable(false)]
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Browsable(false)]
        public string TableName => "[User]";
        [Browsable(false)]
        public string InsertValues => $"'{Username}', '{Password}','{FirstName}','{LastName}'";
        [Browsable(false)]
        public string IdName =>"UserId";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias =>"u";
        [Browsable(false)]
        public string SelectValues => "u.UserId uuserid, u.Username uusername, u.Password upassword, u.FirstName ufirstname, u.LastName ulastname";
        [Browsable(false)]
        public string WhereSearchCondition => $" u.Username= '{Username}' AND u.Password= '{Password}' ";
        [Browsable(false)]
        public string WhereUpdateCondition => "";
        [Browsable(false)]
        public string SetValues => "";
        [Browsable(false)]
        public string InsertColums => "";
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new User
                {
                    UserId = (int)reader["uuserid"],
                    Username = (string)reader["uusername"],
                    Password = (string)reader["upassword"],
                    FirstName = (string)reader["ufirstname"],
                    LastName= (string)reader["ulastname"]

                });
            }
            return result;
        }


    }
}
