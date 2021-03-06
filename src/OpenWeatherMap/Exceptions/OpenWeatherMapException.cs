﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OpenWeatherMapException.cs" company="Joan Caron">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Joan Caron</author>
// <summary>Implements the open weather map exception class</summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OpenWeatherMap
{
    using System;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    ///     Class OpenWeatherMapException.
    /// </summary>
    /// <seealso cref="T:System.Exception"/>
    public sealed class OpenWeatherMapException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenWeatherMapException"/> class.
        /// </summary>
        internal OpenWeatherMapException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenWeatherMapException"/> class.
        /// </summary>
        /// <param name="ex">The ex.</param>
        internal OpenWeatherMapException(Exception ex)
            : base("OpenWeatherMap : an error occurred", ex)
        {
        }
    }
}
