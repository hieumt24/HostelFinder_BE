﻿using HostelFinder.Domain.Entities;
using HostelFinder.Domain.Enums;

namespace HostelFinder.Application.Interfaces.IServices
{
    public interface ITokenService
    {
        string GenerateJwtToken(User user, UserRole role);

        int? ValidateToken(string token);

        Task<string> GenerateResetPasswordToken(User user);

        Task<bool> ValidateResetPasswordToken(User user, string token);
    }
}