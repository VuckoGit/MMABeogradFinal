using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.UserSO
{
   public class LoginSO : SystemOperationBase
    {
        public User Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            
            User u = (User)entity;
          if(repository.Search(u).Count>0)
            Result = (User) repository.Search(u).First();
            else
            {
                Result = null;
            }
        }
    }
}
