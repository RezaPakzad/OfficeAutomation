using Microsoft.AspNetCore.Http;


namespace OfficeAutomation.Infrastructure.Service
{
    public interface IClientIpService
    {
        string GetClientIp();
    }

    public class ClientIpService : IClientIpService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ClientIpService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetClientIp()
        {
            return _httpContextAccessor.HttpContext?.Connection?.RemoteIpAddress?.ToString() ?? string.Empty;
        }
    }
}
