using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ReceptionList
{
    public class LoadReceptionListItemsSO : SystemOperationBase
    {
        public List<Domain.ReceptionListItem> Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Domain.ReceptionListItem rli = (Domain.ReceptionListItem)entity;

            Result = repository.Search(rli).Cast<Domain.ReceptionListItem>().ToList();
        }
    }
}
