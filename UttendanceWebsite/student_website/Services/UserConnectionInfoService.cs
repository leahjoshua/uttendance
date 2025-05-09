/* Written by Judy Yang and Parisa Nawar for CS 4485.0w1, CS Project, starting April 22, 2025
 * NetID: JXY200013 and PXN210032
 * 
 * Service for IP Address.
 */
using student_website.Models;
using Microsoft.AspNetCore.Http;

namespace student_website.Services
{
    public class UserConnectionInfoService
    {
        // Written by Judy Yang
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserConnectionInfoService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        // Written by Parisa Nawar
        public UserConnectionInfo GetUserConnectionInfo()
        {
            var httpContext = _httpContextAccessor.HttpContext;
            string ip = null;

            if(httpContext?.Request.Headers.TryGetValue("X-Forwarded-For", out var forwardedFor) == true)
            {
                ip = forwardedFor.ToString().Split(',')[0].Trim();
            }

            if(string.IsNullOrEmpty(ip))
            {
                ip = httpContext?.Connection?.RemoteIpAddress?.MapToIPv4().ToString();
            }

            return new UserConnectionInfo
            {
                RemoteIpAddress = ip ?? "Unknown"
            };
        }
    }
}
