using System;
using System.Collections.Generic;
using System.Linq;
using ElasticBlog.Common;
using ElasticBlog.Dal.Models;
using Elasticsearch.Net;
using Microsoft.Extensions.Configuration;
using Nest;

namespace ElasticBlog.Dal
{
    public class ElasticConnect
    {
        public ElasticConnect(IConfiguration configuration, ConfigurationKeys configurationKeys)
        {
            var uris = configuration.GetSection(configurationKeys.ElasticConfig)
                .Get<ElasticConnectionSettings>().Uris.Select(uri => new Uri(uri));
            var connectionPool = new SniffingConnectionPool(uris);
            var settings = new ConnectionSettings(connectionPool);

            ElasticClient = new ElasticClient(settings);
        }

        public IElasticClient ElasticClient { get; }
    }
}