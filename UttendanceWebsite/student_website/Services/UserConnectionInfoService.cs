//judy and parisa 
using student_website.Models;
using Microsoft.AspNetCore.Http;

namespace student_website.Services
{
    public class UserConnectionInfoService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserConnectionInfoService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

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
