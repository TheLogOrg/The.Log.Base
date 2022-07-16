// ----------------------------------------------------------------------------
// <copyright file="ILogSink.cs" company="AnyLog">
// Copyright (c) AnyLog Project
// </copyright>
// ----------------------------------------------------------------------------

using System.Threading.Tasks;

namespace The.Log.Base;

/// <summary>
/// A log sink.
/// </summary>
public interface ILogSink
{
    /// <summary>
    /// Writes the <paramref name="logMessage"/> to the sink.
    /// </summary>
    /// <param name="logMessage">The <see cref="ILogMessage"/> to write.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    Task WriteLogMessageAsync(ILogMessage logMessage);
}
