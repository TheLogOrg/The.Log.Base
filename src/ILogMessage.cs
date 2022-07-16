// ----------------------------------------------------------------------------
// <copyright file="ILogMessage.cs" company="TheLogOrg">
// Copyright (c) The.Log Project
// </copyright>
// ----------------------------------------------------------------------------

using System;

namespace The.Log.Base;

/// <summary>
/// A log message.
/// </summary>
public interface ILogMessage
{
    /// <summary>
    /// Gets the timestamp of the <see cref="ILogMessage"/>.
    /// </summary>
    /// <seealso cref="DateTime"/>
    DateTime Timestamp { get; }

    /// <summary>
    /// Gets the <see cref="ILogLevel"/> of the <see cref="ILogMessage"/>.
    /// </summary>
    /// <seealso cref="ILogMessage"/>
    ILogLevel LogLevel { get; }

    /// <summary>
    /// Gets the payload of the <see cref="ILogMessage"/>.
    /// </summary>
    object Payload { get; }

    /// <summary>
    /// Gets the sender of the <see cref="ILogMessage"/>.
    /// </summary>
    string Sender { get; }
}
