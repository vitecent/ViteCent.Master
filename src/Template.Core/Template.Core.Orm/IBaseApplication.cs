/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using System.Linq.Expressions;
using Template.Core.Data;

#endregion

namespace Template.Core.Orm;

/// <summary>
///     Interface IBaseApplication
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IBaseApplication<T> where T : IBaseEntity, new()
{
    /// <summary>
    ///     Adds the asynchronous.
    /// </summary>
    /// <param name="Entity">The Entity.</param>
    /// <returns>Task&lt;BaseResult&gt;.</returns>
    Task<BaseResult> AddAsync(T Entity);

    /// <summary>
    ///     Edits the asynchronous.
    /// </summary>
    /// <param name="Entity">The Entity.</param>
    /// <returns>Task&lt;BaseResult&gt;.</returns>
    Task<BaseResult> EditAsync(T Entity);

    /// <summary>
    ///     Gets the asynchronous.
    /// </summary>
    /// <param name="where">The where.</param>
    /// <returns>Task&lt;T&gt;.</returns>
    Task<T> GetAsync(Expression<Func<T, bool>> where);

    /// <summary>
    ///     Pages the asynchronous.
    /// </summary>
    /// <param name="args"></param>
    /// <returns>Task&lt;List&lt;T&gt;&gt;.</returns>
    Task<List<T>> PageAsync(SearchArgs args);
}