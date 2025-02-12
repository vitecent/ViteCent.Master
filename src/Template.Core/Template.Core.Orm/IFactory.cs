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
///     Interface IFactory
/// </summary>
public interface IFactory
{
    /// <summary>
    ///     Commits the asynchronous.
    /// </summary>
    /// <returns>Task&lt;BaseResult&gt;.</returns>
    Task<BaseResult> CommitAsync();

    /// <summary>
    ///     Deletes the specified where.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="where">The where.</param>
    void Delete<T>(Expression<Func<T, bool>> where) where T : class, new();

    /// <summary>
    ///     Deletes the specified Entitys.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Entitys">The Entitys.</param>
    void Delete<T>(List<T> Entitys) where T : class, new();

    /// <summary>
    ///     Deletes the specified SQL.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql">The SQL.</param>
    /// <param name="parameters">The parameters.</param>
    void Delete<T>(string sql, object parameters = default!) where T : class, new();

    /// <summary>
    ///     Deletes the specified Entity.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Entity">The Entity.</param>
    void Delete<T>(T Entity) where T : class, new();

    /// <summary>
    ///     Inserts the specified Entitys.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Entitys">The Entitys.</param>
    void Insert<T>(List<T> Entitys) where T : class, new();

    /// <summary>
    ///     Inserts the specified SQL.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql">The SQL.</param>
    /// <param name="parameters">The parameters.</param>
    void Insert<T>(string sql, object parameters = default!) where T : class, new();

    /// <summary>
    ///     Inserts the specified Entity.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Entity">The Entity.</param>
    void Insert<T>(T Entity) where T : class, new();

    /// <summary>
    ///     Pages the asynchronous.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="args"></param>
    /// <returns>Task&lt;List&lt;T&gt;&gt;.</returns>
    Task<List<T>> PageAsync<T>(SearchArgs args) where T : class, new();

    /// <summary>
    ///     Updates the specified Entitys.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Entitys">The Entitys.</param>
    void Update<T>(List<T> Entitys) where T : class, new();

    /// <summary>
    ///     Updates the specified Entitys.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Entitys">The Entitys.</param>
    /// <param name="columns">The columns.</param>
    void Update<T>(List<T> Entitys, Expression<Func<T, object>> columns) where T : class, new();

    /// <summary>
    ///     Updates the specified SQL.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql">The SQL.</param>
    /// <param name="parameters">The parameters.</param>
    void Update<T>(string sql, object parameters = default!) where T : class, new();

    /// <summary>
    ///     Updates the specified Entity.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Entity">The Entity.</param>
    void Update<T>(T Entity) where T : class, new();

    /// <summary>
    ///     Updates the specified Entity.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Entity">The Entity.</param>
    /// <param name="columns">The columns.</param>
    void Update<T>(T Entity, Expression<Func<T, object>> columns) where T : class, new();
}