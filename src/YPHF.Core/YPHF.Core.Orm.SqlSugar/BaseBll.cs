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

namespace YPHF.Core.Orm.SqlSugar;

/// <summary>
/// Class BaseBll. Implements the <see cref="YPHF.Core.Orm.IBaseBll{T}" />
/// </summary>
/// <typeparam name="T"></typeparam>
/// <seealso cref="YPHF.Core.Orm.IBaseBll{T}" />
public abstract class BaseBll<T> : IBaseBll<T> where T : IBaseModel, new()
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseBll{T}" /> class.
    /// </summary>
    protected BaseBll()
    {
    }

    /// <summary>
    /// Gets the dal.
    /// </summary>
    /// <value>The dal.</value>
    public abstract IBaseDal<T> DAL { get; }

    /// <summary>
    /// Adds the asynchronous.
    /// </summary>
    /// <param name="model">The model.</param>
    /// <returns>A Task&lt;BaseResult&gt; representing the asynchronous operation.</returns>
    public virtual async Task<BaseResult> AddAsync(T model)
    {
        return await DAL.AddAsync(model);
    }

    /// <summary>
    /// Edits the asynchronous.
    /// </summary>
    /// <param name="model">The model.</param>
    /// <returns>A Task&lt;BaseResult&gt; representing the asynchronous operation.</returns>
    public virtual async Task<BaseResult> EditAsync(T model)
    {
        return await DAL.EditAsync(model);
    }

    /// <summary>
    /// Gets the asynchronous.
    /// </summary>
    /// <param name="where">The where.</param>
    /// <returns>A Task&lt;T&gt; representing the asynchronous operation.</returns>
    public virtual async Task<T> GetAsync(Expression<Func<T, bool>> where)
    {
        return await DAL.GetAsync(where);
    }

    /// <summary>
    /// Page as an asynchronous operation.
    /// </summary>
    /// <param name="args"></param>
    /// <returns>A Task&lt;List`1&gt; representing the asynchronous operation.</returns>
    public virtual async Task<List<T>> PageAsync(SearchArgs args)
    {
        return await DAL.PageAsync(args);
    }
}