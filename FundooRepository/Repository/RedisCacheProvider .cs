// --------------------------------------------------------------------------------------------------------------------
// <copyright file=RedisCacheProvider.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using Common.Models.NotesModels;
using FundooRepository.Interfaces.RedisCache;
using Microsoft.Extensions.Options;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepository.Repository
{
    /// <summary>
    /// Creating a class RedisCacheProvider implements ICacheProvider
    /// </summary>
    public class RedisCacheProvider : ICacheProvider
    {
        RedisEndpoint _endPoint;
        private readonly RedisSetting config;

        public RedisCacheProvider(IOptions<RedisSetting> _config)
        {
            config = _config.Value;
            _endPoint = new RedisEndpoint(config.host, config.port);

        }

        public void Set<T>(string key, T value)
        {
            this.Set(key, value, TimeSpan.FromMinutes(5));
        }

        public void Set<T>(string key, T value, TimeSpan timeout)
        {
            using (RedisClient client = new RedisClient(_endPoint))
            {
                client.As<T>().SetValue(key, value, timeout);
            }
        }

        public T Get<T>(string key)
        {
            T result = default(T);

            using (RedisClient client = new RedisClient(_endPoint))
            {
                var wrapper = client.As<T>();

                result = wrapper.GetValue(key);
            }

            return result;
        }

        public bool Remove(string key)
        {
            bool removed = false;

            using (RedisClient client = new RedisClient(_endPoint))
            {
                removed = client.Remove(key);
            }

            return removed;
        }

        public bool IsInCache(string key)
        {
            bool isInCache = false;

            using (RedisClient client = new RedisClient(_endPoint))
            {
                isInCache = client.ContainsKey(key);
            }

            return isInCache;
        }
    }
}
