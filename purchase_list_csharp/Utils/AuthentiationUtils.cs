using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace purchase_list_csharp.Utils
{
    public class AuthentiationUtils
    {

        public static string GetCurrentUserLoginByContext(HttpContext context)
        {
            return context.User.Claims.FirstOrDefault(_claim => _claim.Type == ClaimTypes.Name)?.Value;
        }
    }
}
