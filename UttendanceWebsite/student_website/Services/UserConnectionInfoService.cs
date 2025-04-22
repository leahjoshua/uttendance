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
            var ip = _httpContextAccessor.HttpContext?.Connection?.RemoteIpAddress?.MapToIPv4().ToString();
            return new UserConnectionInfo { RemoteIpAddress = ip ?? "Unknown" };
        }
    }
}
