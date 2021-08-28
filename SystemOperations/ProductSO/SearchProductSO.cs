using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ProductSO
{
    public class SearchProductSO : SystemOperationBase
    {
        public List<Product> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Product p = (Product)entity;
         
            Result = repository.Search(p).Cast<Product>().ToList();
            
        }
    }
}
