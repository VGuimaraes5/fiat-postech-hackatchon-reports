using System.Security.Claims;
using Hackathon.Reports.Api.Domain.Interfaces.Services;

namespace Hackathon.Reports.Api.Services;

public class IdentityService : IIdentityService
{
    private readonly IHttpContextAccessor _context;

    public IdentityService(IHttpContextAccessor context)
    {
        _context = context;
    }

    public string GetUserIdentification()
    {
        var identification = _context.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (string.IsNullOrEmpty(identification)) throw new InvalidDataException("User identification not found!");

        return identification;
    }
}