using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SystemOperations.PurchaseOrder
{
    public class AddNewPurchaseOrderSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
           Domain.PurchaseOrder po = (Domain.PurchaseOrder)entity;
           repository.Save(po);
            foreach (PurchaseOrderItem p in po.PurchaseOrderItems)
            {
                p.PurchaseOrderId = repository.GetId(po);
                repository.Save(p);
            }
           
        }
    }
}
