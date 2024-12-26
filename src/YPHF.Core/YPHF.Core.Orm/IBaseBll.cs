/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using System.Linq.Expressions;
using YPHF.Core.Data;

#endregion

namespace YPHF.Core.Orm;

/// <summary>
/// Interface IBaseBll
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IBaseBll<T> where T : IBaseModel, new()
{
    /// <summary>
    /// Adds the asynchronous.
    /// </summary>
    /// <param name="model">The model.</param>
    /// <returns>Task&lt;BaseResult&gt;.</returns>
    Task<BaseResult> AddAsync(T model);

    /// <summary>
    /// Edits the asynchronous.
    /// </summary>
    /// <param name="model">The model.</param>
    /// <returns>Task&lt;BaseResult&gt;.</returns>
    Task<BaseResult> EditAsync(T model);

    /// <summary>
    /// Gets the asynchronous.
    /// </summary>
    /// <param name="where">The where.</param>
    /// <returns>Task&lt;T&gt;.</returns>
    Task<T> GetAsync(Expression<Func<T, bool>> where);

    /// <summary>
    /// Pages the asynchronous.
    /// </summary>
    /// <param name="args"></param>
    /// <returns>Task&lt;List&lt;T&gt;&gt;.</returns>
    Task<List<T>> PageAsync(SearchArgs args);
}