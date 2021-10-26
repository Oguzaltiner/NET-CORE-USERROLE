using Core.Utilities.Security.JWT;
using CORE.Entities.Concrete;
using CORE.Utilities.Results.Abstract;
using ENTITIES.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
