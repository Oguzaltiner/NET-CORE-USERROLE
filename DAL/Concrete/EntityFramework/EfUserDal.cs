using CORE.DataAccess.EntityFramework;
using CORE.Entities.Concrete;
using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NetCoreUserRoleContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NetCoreUserRoleContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
