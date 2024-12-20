/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

using System.Linq.Expressions;
using YPHF.Core.Data;

namespace YPHF.Core.Orm.SqlSugar
{
    /// <summary>
    /// Class BaseDal. Implements the <see cref="YPHF.Core.Orm.IBaseDal{T}"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="YPHF.Core.Orm.IBaseDal{T}"/>
    public abstract class BaseDal<T> : IBaseDal<T> where T : BaseModel, new()
    {
        /// <summary>
        /// The client
        /// </summary>
        public readonly SqlSugarFactory Client;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDal{T}"/> class.
        /// </summary>
        public BaseDal()
        {
            Client = new SqlSugarFactory(DataBaseName);
        }

        /// <summary>
        /// Gets the DataBase.
        /// </summary>
        /// <value>The DataBase.</value>
        public abstract string DataBaseName { get; }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>A Task&lt;BaseResult&gt; representing the asynchronous operation.</returns>
        public virtual async Task<BaseResult> AddAsync(T model)
        {
            Client.Insert(model);
            return await Client.CommitAsync();
        }

        /// <summary>
        /// Edits the asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>A Task&lt;BaseResult&gt; representing the asynchronous operation.</returns>
        public virtual async Task<BaseResult> EditAsync(T model)
        {
            Client.Update(model);
            return await Client.CommitAsync();
        }

        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns>A Task&lt;T&gt; representing the asynchronous operation.</returns>
        public virtual async Task<T> GetAsync(Expression<Func<T, bool>> where)
        {
            var model = await Client.Query<T>().Where(where).FirstAsync();
            return model ?? default!;
        }

        /// <summary>
        /// Page as an asynchronous operation.
        /// </summary>
        /// <param name="args"></param>
        /// <returns>A Task&lt;List`1&gt; representing the asynchronous operation.</returns>
        public virtual async Task<List<T>> PageAsync(SearchArgs args)
        {
            var list = await Client.PageAsync<T>(args);
            return list ?? default!;
        }
    }
}