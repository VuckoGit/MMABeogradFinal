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
    public class ReceptionList : IEntity
    {
       
        public int ReceptionListId { get; set; }
        public DateTime ReceptionDate { get; set; }
        public string Comment { get; set; }
        public double Total { get; set; }
        public string Canceled { get; set; }
        public List<ReceptionListItem> ReceptionListItems { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
      
        [Browsable(false)]
        public string SearchParametar { get; set; }

        [Browsable(false)]

        public string TableName => "ReceptionList";
        [Browsable(false)]
        public string InsertValues => $"'{ReceptionDate}','{Comment}',{Total},'{Canceled}',{Manufacturer.ManufacturerId},{PurchaseOrder.PurchaseOrderId}";
        [Browsable(false)]
        public string IdName => "ReceptionListId";
        [Browsable(false)]
        public string JoinCondition => "on (rl.ManufacturerID = m.ManufacturerId)";
        [Browsable(false)]
        public string JoinTable => "Join Manufacturer m";
        [Browsable(false)]
        public string TableAlias => "rl";
        [Browsable(false)]
        public string SelectValues => "rl.ReceptionListId rlreceptionlistid, rl.ReceptionDate rlreceptiondate, rl.Comment rlcomment, rl.Total rltotal, rl.Canceled rlcanceled, rl.ManufacturerID rlmanufactureriid, m.Name rlmanufacturername, rl.PurchaseOrderId rlPurchaseOrderId";
        [Browsable(false)]
        public string SetValues => $"rl.Canceled= 'Yes'";
        [Browsable(false)]
        public string WhereSearchCondition => $"rl.ReceptionListId like '%{SearchParametar}%' or FORMAT(rl.ReceptionDate,'dd/MM/yyyy hh:mm') like '%{SearchParametar}%' or FORMAT(rl.ReceptionDate,'MM/dd/yyyy hh:mm') like '%{SearchParametar}%' or rl.Total like '%{SearchParametar}%' or rl.Comment like '%{SearchParametar}%' or rl.Canceled like '%{SearchParametar}%' or rl.ManufacturerID like '%{SearchParametar}%' or rl.PurchaseOrderId like '%{SearchParametar}%'";
        [Browsable(false)]
        public string WhereUpdateCondition => $"rl.ReceptionListId = {ReceptionListId}";
        [Browsable(false)]
        public string InsertColums => $"(ReceptionDate,Comment,Total,Canceled,ManufacturerID,PurchaseOrderId)";


        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {

                ReceptionList rl = new ReceptionList
                {
                    ReceptionListId = (int)reader["rlreceptionlistid"],
                    ReceptionDate = (DateTime)reader["rlreceptiondate"],
                    Total = (double)reader["rltotal"],
                    Comment = (string)reader["rlcomment"],
                    Canceled = (string)reader["rlcanceled"],
                    Manufacturer = new Manufacturer() { ManufacturerId = (int)reader["rlmanufactureriid"],Name=(string)reader["rlmanufacturername"] },
                    PurchaseOrder = new PurchaseOrder() {PurchaseOrderId= (int)reader["rlPurchaseOrderId"] }

                };
                result.Add(rl);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{ReceptionListId} {ReceptionDate}";
        }
    }
}
