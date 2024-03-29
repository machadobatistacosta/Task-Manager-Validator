﻿using Shared;
using Entities;
using System.Security.Claims;

namespace DataAccessLayer.Interfaces
{
    public interface ITokenDAO
    {
        Task<SingleResponse<Funcionario>> InsertRefreshToken(string email, string refreshToken);
        Task<Response> DeleteRefreshToken(string email, string refreshToken);
        Task<SingleResponse<Funcionario>> GetRefreshToken(string email);
    }
}
