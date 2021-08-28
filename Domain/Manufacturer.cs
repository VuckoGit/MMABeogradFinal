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
   public class Manufacturer: IEntity
    {
    
    [Browsable(false)]
        public int ManufacturerId { get; set; }
        public string Name { get; set; }
        public string TaxId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Account { get; set; }
        public string Address { get; set; }

        public string DisplayName
        {
          get
          {
           return $"{ManufacturerId}: {Name}";
          }
        }
            [Browsable(false)]
            public string TableName { get { return "Manufacturer"; } }
            [Browsable(false)]
            public string InsertValues => $"'{Name}','{TaxId}', '{Email}','{Phone}','{Account}','{Address}'";
            [Browsable(false)]
            public string IdName => "ManufacturerId";
            [Browsable(false)]
            public string JoinCondition => "";
            [Browsable(false)]
            public string JoinTable => "";
            [Browsable(false)]
            public string TableAlias => "m";
            [Browsable(false)]
            public string SelectValues => "m.ManufacturerId mmanufacturerId, m.Name mname, m.TaxId mtaxid, m.Email memail, m.Phone mphone, m.Account maccount, m.Address maddress";
            [Browsable(false)]
            public string WhereSearchCondition =>"";
            [Browsable(false)]
            public string WhereUpdateCondition => "";
            [Browsable(false)]
            public string SetValues => "";
            [Browsable(false)]
            public string InsertColums => "(Name, TaxId,Email , Phone , Account , Address )";


        public List<IEntity> GetEntities(SqlDataReader reader)
            {
                List<IEntity> result = new List<IEntity>();
                while (reader.Read())
                {
                    result.Add(new Manufacturer
                    {
                        ManufacturerId = (int)reader["mmanufacturerId"],
                        Name = (string)reader["mname"],
                        TaxId=(string)reader["mtaxid"],
                        Email=(string)reader["memail"],
                        Phone = (string)reader["mphone"],
                        Account = (string)reader["maccount"],
                        Address = (string)reader["maddress"]

                    });
                }
                return result;
            }

   public override string ToString()
        {
          return $"{ManufacturerId} {Name}";
        }

       
    }
}