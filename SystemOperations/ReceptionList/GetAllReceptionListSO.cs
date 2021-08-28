using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ReceptionList
{
    public class GetAllReceptionListSO : SystemOperationBase
    {
        public List<Domain.ReceptionList> Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Domain.ReceptionList()).Cast<Domain.ReceptionList>().ToList();

        }
    }
}
