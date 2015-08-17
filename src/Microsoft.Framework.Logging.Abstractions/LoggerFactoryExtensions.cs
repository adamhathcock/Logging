// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Framework.Internal;

namespace Microsoft.Framework.Logging
{
    /// <summary>
    /// ILoggerFactory extension methods for common scenarios.
    /// </summary>
    public static class LoggerFactoryExtensions
    {
        /// <summary>
        /// Creates a new ILogger instance using the full name of the given type.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="factory">The factory.</param>
        public static ILogger CreateLogger<T>([NotNull] this ILoggerFactory factory)
        {
            return factory.CreateLogger(typeof(T));
        }
        /// <summary>
        /// Creates a new ILogger instance using the full name of the given type.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <param name="type">The type.</param>
        public static ILogger CreateLogger([NotNull] this ILoggerFactory factory, Type type)
        {
            return factory.CreateLogger(TypeNameHelper.GetTypeDisplayName(type, fullName: true));
        }
    }
        
}