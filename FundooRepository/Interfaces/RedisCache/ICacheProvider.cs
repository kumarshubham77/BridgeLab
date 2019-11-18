// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ICacheProvider.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kumar Shubham"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepository.Interfaces.RedisCache
{
    /// <summary>
    /// Making an interface of ICacheProvider
    /// </summary>
    public interface ICacheProvider
    {
        /// <summary>
        /// Sets the specified key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        void Set<T>(string key, T value);

        /// <summary>
        /// Sets the specified key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <param name="timeout">The timeout.</param>
        void Set<T>(string key, T value, TimeSpan timeout);

        /// <summary>
        /// Gets the specified key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        T Get<T>(string key);

        /// <summary>
        /// Removes the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        bool Remove(string key);

        /// <summary>
        /// Determines whether [is in cache] [the specified key].
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        ///   <c>true</c> if [is in cache] [the specified key]; otherwise, <c>false</c>.
        /// </returns>
        bool IsInCache(string key);
    }
}
