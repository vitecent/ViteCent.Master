﻿namespace ViteCent.Core.Data;

/// <summary>
/// </summary>
/// <typeparam name="T"></typeparam>
public class KeyValue<T>
    where T : class
{
    /// <summary>
    /// </summary>
    public string Key { get; set; } = default!;

    /// <summary>
    ///     Gets or sets the value.
    /// </summary>
    /// <value>The value.</value>
    public T Value { get; set; } = default!;
}