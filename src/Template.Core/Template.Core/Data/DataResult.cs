/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

namespace Template.Core.Data;

/// <summary>
///     Class DataResult. Implements the <see cref="Template.Core.Data.BaseResult" />
/// </summary>
/// <typeparam name="T"></typeparam>
/// <seealso cref="Template.Core.Data.BaseResult" />
public class DataResult<T> : BaseResult
    where T : class
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DataResult{T}" /> class.
    /// </summary>
    public DataResult()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="DataResult{T}" /> class.
    /// </summary>
    /// <param name="Entity">The Entity.</param>
    public DataResult(T Entity)
    {
        Data = Entity;
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="DataResult{T}" /> class.
    /// </summary>
    /// <param name="code">The code.</param>
    /// <param name="message">The message.</param>
    public DataResult(int code, string message) : base(code, message)
    {
        Data = default!;
    }

    /// <summary>
    ///     Gets or sets the data.
    /// </summary>
    /// <value>The data.</value>
    public T Data { get; set; } = default!;
}