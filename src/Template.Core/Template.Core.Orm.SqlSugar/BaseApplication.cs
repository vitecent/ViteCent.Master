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

namespace Template.Core.Orm.SqlSugar;

/// <summary>
///     Class BaseApplication. Implements the <see cref="Template.Core.Orm.IBaseApplication{T}" />
/// </summary>
/// <typeparam name="T"></typeparam>
/// <seealso cref="Template.Core.Orm.IBaseApplication{T}" />
public abstract class BaseApplication<T> : IBaseApplication<T> where T : IBaseEntity, new()
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="BaseApplication{T}" /> class.
    /// </summary>
    protected BaseApplication()
    {
    }

    /// <summary>
    ///     Gets the dal.
    /// </summary>
    /// <value>The dal.</value>
    public abstract IBaseDomain<T> DAL { get; }

    /// <summary>
    ///     Adds the asynchronous.
    /// </summary>
    /// <param name="Entity">The Entity.</param>
    /// <returns>A Task&lt;BaseResult&gt; representing the asynchronous operation.</returns>
    public virtual async Task<BaseResult> AddAsync(T Entity)
    {
        return await DAL.AddAsync(Entity);
    }

    /// <summary>
    ///     Edits the asynchronous.
    /// </summary>
    /// <param name="Entity">The Entity.</param>
    /// <returns>A Task&lt;BaseResult&gt; representing the asynchronous operation.</returns>
    public virtual async Task<BaseResult> EditAsync(T Entity)
    {
        return await DAL.EditAsync(Entity);
    }

    /// <summary>
    ///     Gets the asynchronous.
    /// </summary>
    /// <param name="where">The where.</param>
    /// <returns>A Task&lt;T&gt; representing the asynchronous operation.</returns>
    public virtual async Task<T> GetAsync(Expression<Func<T, bool>> where)
    {
        return await DAL.GetAsync(where);
    }

    /// <summary>
    ///     Page as an asynchronous operation.
    /// </summary>
    /// <param name="args"></param>
    /// <returns>A Task&lt;List`1&gt; representing the asynchronous operation.</returns>
    public virtual async Task<List<T>> PageAsync(SearchArgs args)
    {
        return await DAL.PageAsync(args);
    }
}