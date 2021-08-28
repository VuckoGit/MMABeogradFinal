using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ReceptionList
{
    public class AddNewReceptionListSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Domain.ReceptionList rl = (Domain.ReceptionList)entity;
            repository.Save(rl);
            foreach (ReceptionListItem rli in rl.ReceptionListItems)
            {
               rli.ReceptionListId = repository.GetId(rl);
                repository.Save(rli);
            }
        }
    }
}
