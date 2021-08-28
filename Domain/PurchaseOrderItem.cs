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

    public class PurchaseOrderItem : IEntity
    {
       public int PurchaseOrderId { get; set; }
    
        public int PurchaseOrderItemId { get; set; }
        
        public double Quantity { get; set; }
        
        public double Amount { get; set; }
        
        public Product Product { get; set; }
        [Browsable(false)]
        public string SearchParametar { get; set; }

       



        [Browsable(false)]
        public string TableName => "PurchaseOrderItem";
        [Browsable(false)]
        public string InsertValues => $"{PurchaseOrderId},{PurchaseOrderItemId},{Quantity},{Amount},{Product.ProductId}";
        [Browsable(false)]
        public string IdName => "PurchaseOrderId";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "poi";
        [Browsable(false)]
        public string SelectValues => "poi.PurchaseOrderId popurchaseorderid, poi.PurchaseOrderItemId poipurchaseorderitemid, poi.Quantity poiquantity, poi.Amount poiamount, poi.ProductId poiproductId";
        [Browsable(false)]
        public string SetValues => "";
        [Browsable(false)]
        public string WhereSearchCondition => $"poi.PurchaseOrderId = {SearchParametar}";
        [Browsable(false)]
        public string WhereUpdateCondition => "";
        [Browsable(false)]
        public string InsertColums => "(PurchaseOrderId,PurchaseOrderItemId,Quantity,Amount,ProductId)";


        public List<IEntity> GetEntities(SqlDataReader reader)
        {
                List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {

                PurchaseOrderItem poi = new PurchaseOrderItem
                {
                    PurchaseOrderId = (int)reader["popurchaseorderid"],
                    PurchaseOrderItemId = (int)reader["poipurchaseorderitemid"],
                    Quantity = (double)reader["poiquantity"],
                    Amount = (double)reader["poiamount"],
                    Product = new Product() { ProductId = (int)reader["poiproductId"] }
                   
                };
                result.Add(poi);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{PurchaseOrderItemId} {Quantity} {Amount}";
        }
    }
}
