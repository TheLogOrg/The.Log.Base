// ----------------------------------------------------------------------------
// <copyright file="ILogger.cs" company="AnyLog">
// Copyright (c) AnyLog Project
// </copyright>
// ----------------------------------------------------------------------------

using System;
using System.Threading.Tasks;

namespace The.Log.Base;

/// <summary>
/// A log.
/// </summary>
public interface ILogger
{
    // ┌────────────────────────────────────────────────────────────────┐
    // │ PUBLIC Properties                                              │
    // └────────────────────────────────────────────────────────────────┘

    /// <summary>
    /// Gets the name of the logger.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets or sets the minimum <see cref="LogLevel"/>.
    /// </summary>
    ILogLevel MinimumLogLevel { get; set; }

    // ┌────────────────────────────────────────────────────────────────┐
    // │ PUBLIC Methods                                                 │
    // └────────────────────────────────────────────────────────────────┘

    /// <summary>
    /// Creates a new log message with <paramref name="logLevel"/> and <paramref name="payload"/>.
    /// </summary>
    /// <param name="logLevel">The <see cref="ILogLevel"/>.</param>
    /// <param name="payload">The payload.</param>
    /// <returns>This <see cref="ILogger"/>.</returns>
    ILogger Log(ILogLevel logLevel, object payload);

    /// <summary>
    /// Creates a new log message with <see cref="LogLevel.Debug"/> and <paramref name="payload"/>.
    /// </summary>
    /// <param name="payload">The payload.</param>
    /// <returns>This <see cref="ILogger"/>.</returns>
    ILogger Debug(object payload);

    /// <summary>
    /// Creates a new log message with <see cref="LogLevel.Info"/> and <paramref name="payload"/>.
    /// </summary>
    /// <param name="payload">The payload.</param>
    /// <returns>This <see cref="ILogger"/>.</returns>
    ILogger Info(object payload);

    /// <summary>
    /// Creates a new log message with <see cref="LogLevel.Warning"/> and <paramref name="payload"/>.
    /// </summary>
    /// <param name="payload">The payload.</param>
    /// <returns>This <see cref="ILogger"/>.</returns>
    ILogger Warning(object payload);

    /// <summary>
    /// Creates a new log message with <see cref="LogLevel.Error"/> and <paramref name="payload"/>.
    /// </summary>
    /// <param name="payload">The payload.</param>
    /// <returns>This <see cref="ILogger"/>.</returns>
    ILogger Error(object payload);

    /// <summary>
    /// Creates a new log message with <see cref="LogLevel.Fatal"/> and <paramref name="payload"/>.
    /// </summary>
    /// <param name="payload">The payload.</param>
    /// <returns>This <see cref="ILogger"/>.</returns>
    ILogger Fatal(object payload);

    /// <summary>
    /// Returns the sub logger with the specified <paramref name="name"/>.
    /// </summary>
    /// <param name="name">The name of the sub logger.</param>
    /// <returns>The sub logger.</returns>
    ILogger GetLog(string name);

    /// <summary>
    /// Attaches the <paramref name="logSink"/> to this <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logSink">The <see cref="ILogSink"/> to attach.</param>
    void AttachLogSink(ILogSink logSink);

    /// <summary>
    /// Attaches the <paramref name="logSink"/> to this <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logSink">The <see cref="ILogSink"/> to detach.</param>
    void DetachLogSink(ILogSink logSink);

    /// <summary>
    /// Flushes the logger.
    /// </summary>
    void Flush();

    /// <summary>
    /// Flushes the logger asynchronously.
    /// </summary>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    Task FlushAsync();

    /// <summary>
    /// Adds the <paramref name="filter"/> to the list of filters.
    /// </summary>
    /// <param name="filter">The filter <see cref="Predicate{T}"/> to add.</param>
    void AddFilter(Predicate<ILogMessage> filter);

    /// <summary>
    /// Removes the <paramref name="filter"/> from the list of filters.
    /// </summary>
    /// <param name="filter">The filter <see cref="Predicate{T}"/> to remove.</param>
    void RemoveFilter(Predicate<ILogMessage> filter);

    /// <summary>
    /// Get
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    ILogger GetLogger(string name);
}
