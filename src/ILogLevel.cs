// ----------------------------------------------------------------------------
// <copyright file="ILogLevel.cs" company="AnyLog">
// Copyright (c) AnyLog Project
// </copyright>
// ----------------------------------------------------------------------------

using System;

namespace The.Log.Base;

/// <summary>
/// The log level.
/// </summary>
public interface ILogLevel : IComparable, IComparable<ILogLevel>, IEquatable<ILogLevel>
{
    /// <summary>
    /// Gets the name of the log level..
    /// </summary>
    ///
    string Name { get; }

    /// <summary>
    /// Gets the value of the log level.
    /// </summary>
    uint Value { get; }
}
