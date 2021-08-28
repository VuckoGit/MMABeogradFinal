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
    public class PurchaseOrder : IEntity
    {
        
        public int PurchaseOrderId { get; set; }
        public DateTime PurchaseOrderDate { get; set; }
        
        public string Comment { get; set; }
       
        public double Total { get; set; }
        
        
        public string Canceled { get; set; }
       
        public List<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        
        public Manufacturer Manufacturer { get; set; }
       
        [Browsable(false)]
        public string SearchParametar { get; set; }
     
        



        [Browsable(false)]
        public string TableName =>"PurchaseOrder";
        [Browsable(false)]
        public string InsertValues => $"'{PurchaseOrderDate}',{Total},'{Comment}','{Canceled}',{Manufacturer.ManufacturerId}";
        [Browsable(false)]
        public string IdName => "PurchaseOrderId";
        [Browsable(false)]
        public string JoinCondition => "on (po.ManufacturerID = m.ManufacturerId)";
        [Browsable(false)]
        public string JoinTable => "Join Manufacturer m";
        [Browsable(false)]
        public string TableAlias => "po";
        [Browsable(false)]
        public string SelectValues => "po.PurchaseOrderId popurchaseorderid, po.OrderDate poorderdate, po.Total pototal, po.Comment pocomment, po.Canceled pocanceled, po.ManufacturerID pomanufactureriid, m.Name pomanufacturername";
        [Browsable(false)]
        public string SetValues => $"po.Canceled= 'Yes'";
        [Browsable(false)]
        public string WhereSearchCondition => $"po.PurchaseOrderId like '%{SearchParametar}%' or FORMAT(po.OrderDate,'dd/MM/yyyy hh:mm') like '%{SearchParametar}%' or FORMAT(po.OrderDate,'MM/dd/yyyy hh:mm') like '%{SearchParametar}%' or po.Total like '%{SearchParametar}%' or po.Comment like '%{SearchParametar}%' or po.Canceled like '%{SearchParametar}%' or po.ManufacturerID like '%{SearchParametar}%'";
        [Browsable(false)]
        public string WhereUpdateCondition => $"po.PurchaseOrderId = {PurchaseOrderId}";
        [Browsable(false)]
        public string InsertColums => $"(OrderDate,Total,Comment,Canceled,ManufacturerID)";


        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                
                PurchaseOrder po = new PurchaseOrder
                {
                    PurchaseOrderId = (int)reader["popurchaseorderid"],
                    PurchaseOrderDate = (DateTime)reader["poorderdate"],
                    Total = (double)reader["pototal"],
                    Comment = (string)reader["pocomment"],
                    Canceled =(string)reader["pocanceled"],
                    Manufacturer = new Manufacturer() { ManufacturerId=(int)reader["pomanufactureriid"],
                    Name = (string)reader["pomanufacturername"]
                    }

            };
                result.Add(po);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{PurchaseOrderId}";
        }
    }
}
