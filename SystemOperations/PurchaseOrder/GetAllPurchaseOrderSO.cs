using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PurchaseOrder
{
    public class GetAllPurchaseOrderSO : SystemOperationBase
    {
        public List<Domain.PurchaseOrder> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
           
           Result = repository.GetAll(new Domain.PurchaseOrder()).Cast<Domain.PurchaseOrder>().ToList();
        }
   }
        
}
