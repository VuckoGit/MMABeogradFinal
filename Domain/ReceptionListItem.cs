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
    public class ReceptionListItem : IEntity
    {
        
        public int ReceptionListId { get; set; }
       
        public int ReceptionListItemId { get; set; }
       
        public double Quantity { get; set; }
       
        public double Amount { get; set; }
       
        public Product Product { get; set; }
      
        [Browsable(false)]
        public string SearchParametar { get; set; }

        [Browsable(false)]
        public string DisplayName
        {
            get
            {
                return $"{ReceptionListId} {ReceptionListItemId} {Quantity} {Amount} {Product}";
            }
        }

        [Browsable(false)]
        public string TableName => "ReceptionListItem";
        [Browsable(false)]
        public string InsertValues => $"{ReceptionListId},{ReceptionListItemId},{Quantity},{Amount},{Product.ProductId}";
        [Browsable(false)]
        public string IdName => "ReceptionListId";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "rli";
        [Browsable(false)]
        public string SelectValues => "rli.ReceptionListId rlreceptionlistid, rli.ReceptionListItemId rlireceptionlistitemid, rli.Quantity rliquantity, rli.Amount rliamount, rli.ProductId rliproductId";
        [Browsable(false)]
        public string SetValues => "";
        [Browsable(false)]
        public string WhereSearchCondition => $"rli.ReceptionListId = {SearchParametar}";
        [Browsable(false)]
        public string WhereUpdateCondition => "";
        [Browsable(false)]
        public string InsertColums => "(ReceptionListId,ReceptionListItemId,Quantity,Amount,ProductId)";


        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {

                ReceptionListItem rli = new ReceptionListItem
                {
                    ReceptionListId = (int)reader["rlreceptionlistid"],
                    ReceptionListItemId = (int)reader["rlireceptionlistitemid"],
                    Quantity = (double)reader["rliquantity"],
                    Amount = (double)reader["rliamount"],
                    Product = new Product() { ProductId = (int)reader["rliproductId"] }

                };
                result.Add(rli);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{ReceptionListItemId} {Quantity} {Amount}";
        }
    }
}


