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
    public sealed class UnsuccessfulRequestException : OpenWeatherRequestException
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="OpenWeatherMapException"/> class.
        /// </summary>
        /// <param name="response">The response.</param>
        internal UnsuccessfulRequestException(HttpResponseMessage response)
            : base(string.Format("Request was unsuccessful. Code: {0} Reason: {1}", response.StatusCode, response.ReasonPhrase), response)
        {
        }
    }
}