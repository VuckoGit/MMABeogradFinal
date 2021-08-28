using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ReceptionList
{
    public class SearchReceptionListSO : SystemOperationBase
    {
        public List<Domain.ReceptionList> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Domain.ReceptionList po = (Domain.ReceptionList)entity;

            Result = repository.Search(po).Cast<Domain.ReceptionList>().ToList();
        }
    }
}
