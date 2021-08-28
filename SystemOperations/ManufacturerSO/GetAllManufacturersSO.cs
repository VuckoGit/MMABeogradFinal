using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ManufacturerSO
{
    public class GetAllManufacturersSO:SystemOperationBase
    {
        public List<Manufacturer> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Manufacturer()).Cast<Manufacturer>().ToList();
        }
    }
}
