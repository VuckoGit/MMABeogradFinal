using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PurchaseOrder
{
    public class SearchPurchaseOrderSO: SystemOperationBase
    {
        public List<Domain.PurchaseOrder> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Domain.PurchaseOrder po = (Domain.PurchaseOrder)entity;

            Result = repository.Search(po).Cast<Domain.PurchaseOrder>().ToList();
        }
    }
}
