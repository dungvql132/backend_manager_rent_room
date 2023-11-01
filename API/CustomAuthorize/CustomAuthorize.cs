using System;
using System.Security.Claims;
using Data.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CustomAuthorizetion
{
    public class CustomAuthorizeAttribute : TypeFilterAttribute
    {
        public CustomAuthorizeAttribute(params Role[] allowedRoles) : base(typeof(CustomAuthorizeFilter))
        {
            Arguments = new object[] { allowedRoles };
        }
    }

    public class CustomAuthorizeFilter : IAuthorizationFilter
    {
        private readonly List<Role> _allowedRoles;

        public CustomAuthorizeFilter(params Role[] allowedRoles)
        {
            _allowedRoles = new List<Role>(allowedRoles);
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            // Check if the user is authenticated
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            // Find the "Role" claim in the user's claims
            var roleClaim = context.HttpContext.User.FindFirst(ClaimTypes.Role);
            System.Console.WriteLine("Role -----------------: "+roleClaim.Value);

            if (roleClaim != null)
            {
                // Convert the user's role to the Role enum
                if (Enum.TryParse(roleClaim.Value, out Role userRole))
                {
                    // Check if the user's role matches any of the allowed roles
                    if (_allowedRoles.Contains(userRole))
                    {
                        return;
                    }
                }
            }

            context.Result = new ForbidResult();
        }
    }

}
