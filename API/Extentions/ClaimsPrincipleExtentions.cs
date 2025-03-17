using System.Security.Claims;

namespace API.Extentions;

public static class ClaimsPrincipleExtentions
{
    public static string GetUsername(this ClaimsPrincipal user)
    {
        var username = user.FindFirstValue(ClaimTypes.NameIdentifier) 
            ?? throw new Exception("Cannot get username from token");
        return username;
    }
}

