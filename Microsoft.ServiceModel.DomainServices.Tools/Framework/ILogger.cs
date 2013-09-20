﻿
namespace Microsoft.ServiceModel.DomainServices.Tools
{
    /// <summary>
    /// Abstraction to permit code gen task to report errors
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Gets a value indicating whether any errors were logged.
        /// </summary>
        bool HasLoggedErrors
        {
            get;
        }

        /// <summary>
        /// Logs the given message as an error
        /// </summary>
        /// <param name="message">Message to log</param>
        void LogError(string message);

        /// <summary>
        /// Logs the given message as a warning
        /// </summary>
        /// <param name="message">Message to log</param>
        void LogWarning(string message);

        /// <summary>
        /// Logs the given message as information
        /// </summary>
        /// <param name="message">Message to log</param>
        void LogMessage(string message);
    }
}