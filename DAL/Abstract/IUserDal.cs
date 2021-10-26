using CORE.DataAccess;
using CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
