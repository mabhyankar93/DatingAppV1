using System;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace API.DTOs;

public class RegisterDto
{
    public required string username { get; set; }
    public required string password { get; set; }

}
