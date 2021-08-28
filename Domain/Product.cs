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
    public class Product: IEntity
        {
        [Browsable(false)]
        public int ProductId { get; set; }
        
        public string Name { get; set; }
        [Browsable(false)]
        public double Price { get; set; }
        [Browsable(false)]
        public string Gender { get; set; }
        [Browsable(false)]
        public string Brand { get; set; }
        [Browsable(false)]
        public string SearchParametar { get; set; }
        public string DisplayName
            {
                get
                {
                    return $"{ProductId}: {Name} {Gender} {Price}";
                }
            }
         
             public Product Self { get { return this; } }
          
          
            [Browsable(false)]
            public string TableName => "[Product]";
            [Browsable(false)]
            public string InsertValues => $"'{Name}', '{Price}', '{Gender}','{Brand}'";
            [Browsable(false)]
            public string IdName => "ProductId";
            [Browsable(false)]
            public string JoinCondition => "";
            [Browsable(false)]
            public string JoinTable => "";
            [Browsable(false)]
            public string TableAlias => "p";
            [Browsable(false)]
            public string SelectValues => "p.ProductId pproductId, p.Name pname, p.Price pprice, p.Gender pgender, p.Brand pbrand";
            [Browsable(false)]
            public string WhereSearchCondition => $"p.ProductId like '%{SearchParametar}%' or p.Name like '%{SearchParametar}%' or p.Price like '%{SearchParametar}%' or p.Gender like '%{SearchParametar}%' or p.Brand like '%{SearchParametar}%'";
            [Browsable(false)]
            public string WhereUpdateCondition => $"p.ProductId = {ProductId}";
            [Browsable(false)]
            public string SetValues => $"p.Name = '{Name}', p.Price = {Price},p.Gender = '{Gender}',p.Brand = '{Brand}'";
            [Browsable(false)]
            public string InsertColums => "";

        public override string ToString()
        {
            return $"{ProductId} {Name}";
        }

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Product p = new Product
                {
                    ProductId = (int)reader["pproductId"],
                    Name = (string)reader["pname"],
                    Price = (double)reader["pprice"],
                    Gender = (string)reader["pgender"],
                    Brand = (string)reader["pbrand"]

                };
                result.Add(p);
            }
            return result;
        }


    }
}
