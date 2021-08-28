using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PurchaseOrder
{

    public class LoadPurchaseOrderItemsSO:SystemOperationBase
    {
    public List<Domain.PurchaseOrderItem> Result { get; set; }

       
        protected override void ExecuteOperation(IEntity entity)
        {
           

            Domain.PurchaseOrderItem po = (Domain.PurchaseOrderItem)entity;

            Result = repository.Search(po).Cast<Domain.PurchaseOrderItem>().ToList();
        }
    }
}
