using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ProductSO
{
    public class GetAllProductsSO : SystemOperationBase
    {
        public List<Product> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Product()).Cast<Product>().ToList();
        }
    }
}
