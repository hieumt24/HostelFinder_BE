﻿namespace HostelFinder.Application.DTOs.Auths.Requests
{
    public class ResetPasswordRequest
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public string NewPassword { get; set; }
    }
}