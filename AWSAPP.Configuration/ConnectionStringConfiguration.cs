using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWSAPP.Configuration
{
    public class ConnectionStringConfiguration
    {
        private readonly IConfiguration _config;

        public ConnectionStringConfiguration(IConfiguration config)
        {
            _config = config;
        }

        public string ConnectionString
        {
            get
            {
                return _config.GetConnectionString("DefaultConnection");
            }
        }
    }
}
