using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Helper
{
    public class ConfigurationHelper
    {
        private readonly IConfiguration _configuration;

        public ConfigurationHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string? TokenAudience() => _configuration["TokenOptions:Audience"];
        public string? TokenIssuer() => _configuration["TokenOptions:Issuer"];
        public string? AccessTokenExpiration() => _configuration["TokenOptions:AccessTokenExpiration"];
        public string? RefreshTokenExpiration() => _configuration["TokenOptions:RefreshTokenExpiration"];
        public string? SecurityKey() => _configuration["TokenOptions:SecurityKey"];

    }
}
