using FSH.API.Shared.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace FSH.API.Infrastructure.Auth.Permissions;

public class MustHavePermissionAttribute : AuthorizeAttribute
{
    public MustHavePermissionAttribute(string action, string resource) =>
        Policy = FSHPermission.NameFor(action, resource);
}