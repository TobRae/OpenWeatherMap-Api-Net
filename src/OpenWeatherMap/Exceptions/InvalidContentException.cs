// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OpenWeatherMapException.cs" company="Joan Caron">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <author>Joan Caron, Tobias Raederscheidt</author>
// <summary>Implements the open weather map exception class</summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OpenWeatherMap
{
    using System.Net.Http;

    /// <summary>
    ///     Class OpenWeatherMapException.
    /// </summary>
    /// <seealso cref="T:System.Exception"/>
    public sealed class InvalidContentException : OpenWeatherRequestException
    {
        public string Content { get; private set; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenWeatherMapException"/> class.
        /// </summary>
        /// <param name="response">The response.</param>
        internal InvalidContentException(HttpResponseMessage response, string content)
            : base(string.Format("Unable to parse content: {0}",content), response)
        {
            this.Content = content;
        }
    }
}