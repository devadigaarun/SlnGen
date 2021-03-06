﻿// Copyright (c) Microsoft Corporation.
//
// Licensed under the MIT license.

using Microsoft.Build.Framework;
using System.Collections.Generic;

namespace SlnGen.Common
{
    /// <summary>
    /// Represents a logger.
    /// </summary>
    public interface ISlnGenLogger
    {
        bool HasLoggedErrors { get; }

        /// <summary>
        /// Logs an error.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="code">An optional error code.</param>
        void LogError(string message, string code = null);

        /// <summary>
        /// Logs a high importance message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">Optional format arguments for the message.</param>
        void LogMessageHigh(string message, params object[] args);

        /// <summary>
        /// Logs a low importance message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">Optional format arguments for the message.</param>
        void LogMessageLow(string message, params object[] args);

        /// <summary>
        /// Logs a message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="args">Optional format arguments for the message.</param>
        void LogMessageNormal(string message, params object[] args);

        /// <summary>
        /// Logs telemetry.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="properties">The properties of the event.</param>
        void LogTelemetry(string eventName, IDictionary<string, string> properties);

        /// <summary>
        /// Logs a warning.
        /// </summary>
        /// <param name="message">The warning message.</param>
        /// <param name="code">An optional warning code.</param>
        void LogWarning(string message, string code = null);
    }
}