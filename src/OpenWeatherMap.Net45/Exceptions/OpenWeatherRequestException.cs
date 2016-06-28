// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OpenWeatherMapException.cs" company="Joan Caron">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <author>Joan Caron, Tobias Raederscheidt</author>
// <summary>Implements the open weather map exception class</summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OpenWeatherMap
{
    using System;
    using System.Net.Http;

    /// <summary>
    ///     Class OpenWeatherMapException.
    /// </summary>
    /// <seealso cref="T:System.Exception"/>
    public class OpenWeatherRequestException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenWeatherMapException"/> class.
        /// </summary>
        /// <param name="response">The response.</param>
        internal OpenWeatherRequestException(string message, HttpResponseMessage response)
            : base(message)
        {
            this.Response = response;
        }

        /// <summary>
        ///     Gets the response message.
        /// </summary>
        /// <value>
        ///     The response.
        /// </value>
        public HttpResponseMessage Response { get; private set; }
    }
}
