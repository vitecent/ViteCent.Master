/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using System.Linq.Expressions;
using YPHF.Core.Data;

namespace YPHF.Core.Orm
{
    /// <summary>
    /// Interface IFactory
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Commits the asynchronous.
        /// </summary>
        /// <returns>Task&lt;BaseResult&gt;.</returns>
        Task<BaseResult> CommitAsync();

        /// <summary>
        /// Deletes the specified where.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="where">The where.</param>
        void Delete<T>(Expression<Func<T, bool>> where) where T : class, new();

        /// <summary>
        /// Deletes the specified models.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="models">The models.</param>
        void Delete<T>(List<T> models) where T : class, new();

        /// <summary>
        /// Deletes the specified SQL.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">The SQL.</param>
        /// <param name="parameters">The parameters.</param>
        void Delete<T>(string sql, object parameters = default!) where T : class, new();

        /// <summary>
        /// Deletes the specified model.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model">The model.</param>
        void Delete<T>(T model) where T : class, new();

        /// <summary>
        /// Inserts the specified models.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="models">The models.</param>
        void Insert<T>(List<T> models) where T : class, new();

        /// <summary>
        /// Inserts the specified SQL.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">The SQL.</param>
        /// <param name="parameters">The parameters.</param>
        void Insert<T>(string sql, object parameters = default!) where T : class, new();

        /// <summary>
        /// Inserts the specified model.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model">The model.</param>
        void Insert<T>(T model) where T : class, new();

        /// <summary>
        /// Pages the asynchronous.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="args"></param>
        /// <returns>Task&lt;List&lt;T&gt;&gt;.</returns>
        Task<List<T>> PageAsync<T>(SearchArgs args) where T : class, new();

        /// <summary>
        /// Updates the specified models.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="models">The models.</param>
        void Update<T>(List<T> models) where T : class, new();

        /// <summary>
        /// Updates the specified models.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="models">The models.</param>
        /// <param name="columns">The columns.</param>
        void Update<T>(List<T> models, Expression<Func<T, object>> columns) where T : class, new();

        /// <summary>
        /// Updates the specified SQL.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">The SQL.</param>
        /// <param name="parameters">The parameters.</param>
        void Update<T>(string sql, object parameters = default!) where T : class, new();

        /// <summary>
        /// Updates the specified model.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model">The model.</param>
        void Update<T>(T model) where T : class, new();

        /// <summary>
        /// Updates the specified model.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model">The model.</param>
        /// <param name="columns">The columns.</param>
        void Update<T>(T model, Expression<Func<T, object>> columns) where T : class, new();
    }
}