/*
 *
 * 版权所有 ：易鹏航服
 * 作   者 : duhuifeng
 *
 */

#region

using SqlSugar;
using System.Linq.Expressions;
using YPHF.Core.Data;
using YPHF.Core.Enums;

#endregion

namespace YPHF.Core.Orm.SqlSugar;

/// <summary>
/// Class SqlSugarFactory. Implements the <see cref="YPHF.Core.Orm.IFactory" /> Implements the
/// <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="YPHF.Core.Orm.IFactory" />
/// <seealso cref="System.IDisposable" />
public class SqlSugarFactory : IFactory, IDisposable
{
    /// <summary>
    /// The client
    /// </summary>
    private readonly SqlSugarClient client = default!;

    /// <summary>
    /// The commands
    /// </summary>
    private readonly List<Command> commands = [];

    /// <summary>
    /// Initializes a new instance of the <see cref="SqlSugarFactory" /> class.
    /// </summary>
    /// <param name="dataBase">The DataBase.</param>
    /// <param name="log">if set to <c>true</c> [log].</param>
    public SqlSugarFactory(string dataBase, bool log = true)
    {
        var configuration = FactoryConfigExtensions.GetConfig(dataBase);

        var slaves = new List<SlaveConnectionConfig>();

        configuration.Slaves.ForEach(slave =>
        {
            slaves.Add(new SlaveConnectionConfig { HitRate = 10, ConnectionString = slave });
        });

        client = new SqlSugarClient(new ConnectionConfig
        {
            ConnectionString = configuration.Master,
            SlaveConnectionConfigs = slaves,
            DbType = GetDbType(configuration.DbType),
            InitKeyType = InitKeyType.Attribute,
            IsAutoCloseConnection = true
        });

        client.Ado.CommandTimeOut = 30;

        if (log)
            client.Aop.OnLogExecuted = (text, parameter) =>
            {
                foreach (var p in parameter)
                    if (p.DbType == System.Data.DbType.Int16 || p.DbType == System.Data.DbType.Int32
                                                             || p.DbType == System.Data.DbType.Int64 ||
                                                             p.DbType == System.Data.DbType.Decimal
                                                             || p.DbType == System.Data.DbType.Double ||
                                                             p.DbType == System.Data.DbType.Single
                                                             || p.DbType == System.Data.DbType.UInt16 ||
                                                             p.DbType == System.Data.DbType.UInt32
                                                             || p.DbType == System.Data.DbType.UInt64 ||
                                                             p.DbType == System.Data.DbType.VarNumeric)
                        text = text.Replace(p.ParameterName, p.Value == null ? "" : p.Value.ToString());
                    else
                        text = text.Replace(p.ParameterName, $"'{p.Value ?? default!}'");

                var sql = $"Time: {client.Ado.SqlExecutionTime.TotalMilliseconds} ms, SQL:{text}";
            };
    }

    /// <summary>
    /// Commits the asynchronous.
    /// </summary>
    /// <returns>A Task&lt;BaseResult&gt; representing the asynchronous operation.</returns>
    public async Task<BaseResult> CommitAsync()
    {
        if (commands.Count > 0)
        {
            client.BeginTran();
            try
            {
                await Task.Run(() =>
                {
                    commands.ForEach(x =>
                    {
                        if (x.DataType == DataEnum.SQL)
                            client.Ado.ExecuteCommand(x.SQL, x.Parameters);
                        else
                            switch (x.CommandType)
                            {
                                case CommandEnum.Insert:
                                    client.Insertable(x.Model).ExecuteCommand();
                                    break;

                                case CommandEnum.Update:
                                    if (x.DataType == DataEnum.Model)
                                        client.Updateable(x.Model).IgnoreColumns(true)
                                            .IsEnableUpdateVersionValidation().ExecuteCommand();
                                    else
                                        client.Updateable(x.Model).UpdateColumns(x.Where)
                                            .IgnoreColumns(ignoreAllNullColumns: true).IsEnableUpdateVersionValidation()
                                            .ExecuteCommand();
                                    break;

                                case CommandEnum.Delete:
                                    if (x.DataType == DataEnum.Model)
                                        client.Deleteable(x.Model).ExecuteCommand();
                                    else
                                        client.Deleteable(x.Where).ExecuteCommand();
                                    break;
                            }
                    });

                    client.CommitTran();
                });
            }
            catch (Exception e)
            {
                client.RollbackTran();
                return new BaseResult(500, e.Message);
            }
        }

        return new BaseResult();
    }

    /// <summary>
    /// Deletes the specified where.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="where">The where.</param>
    public void Delete<T>(Expression<Func<T, bool>> where) where T : class, new()
    {
        commands.Add(new Command { CommandType = CommandEnum.Delete, DataType = DataEnum.Where, Where = where });
    }

    /// <summary>
    /// Deletes the specified model.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="model">The model.</param>
    public void Delete<T>(T model) where T : class, new()
    {
        commands.Add(new Command { CommandType = CommandEnum.Delete, DataType = DataEnum.Model, Model = model });
    }

    /// <summary>
    /// Deletes the specified models.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="models">The models.</param>
    public void Delete<T>(List<T> models) where T : class, new()
    {
        commands.Add(new Command { CommandType = CommandEnum.Delete, DataType = DataEnum.Model, Model = models });
    }

    /// <summary>
    /// Deletes the specified SQL.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql">The SQL.</param>
    /// <param name="parameters">The parameters.</param>
    public void Delete<T>(string sql, object parameters = default!) where T : class, new()
    {
        commands.Add(new Command()
            { CommandType = CommandEnum.Delete, DataType = DataEnum.SQL, SQL = sql, Parameters = parameters });
    }

    /// <summary>
    /// Performs application-defined tasks associated with freeing, releasing, or resetting
    /// unmanaged resources.
    /// </summary>
    public void Dispose()
    {
        client?.Dispose();
    }

    /// <summary>
    /// Fastests this instance.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>IFastest&lt;T&gt;.</returns>
    public IFastest<T> Fastest<T>() where T : class, new()
    {
        return client.Fastest<T>();
    }

    /// <summary>
    /// Inserts the specified model.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="model">The model.</param>
    public void Insert<T>(T model) where T : class, new()
    {
        commands.Add(new Command { CommandType = CommandEnum.Insert, DataType = DataEnum.Model, Model = model });
    }

    /// <summary>
    /// Inserts the specified models.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="models">The models.</param>
    public void Insert<T>(List<T> models) where T : class, new()
    {
        commands.Add(new Command { CommandType = CommandEnum.Insert, DataType = DataEnum.Model, Model = models });
    }

    /// <summary>
    /// Inserts the specified SQL.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql">The SQL.</param>
    /// <param name="parameters">The parameters.</param>
    public void Insert<T>(string sql, object parameters = default!) where T : class, new()
    {
        commands.Add(new Command
            { CommandType = CommandEnum.Insert, DataType = DataEnum.SQL, SQL = sql, Parameters = parameters });
    }

    /// <summary>
    /// Pages the asynchronous.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="args"></param>
    /// <returns>A Task&lt;List`1&gt; representing the asynchronous operation.</returns>
    public async Task<List<T>> PageAsync<T>(SearchArgs args) where T : class, new()
    {
        if (args.Offset < 1) args.Offset = 1;

        if (args.Limit < 1) args.Limit = 10;

        var where = args.ToSQL();
        var query = client.Queryable<T>().Where(where.Item1, where.Item2);

        foreach (var order in args.Order)
            if (order.OrderType == OrderEnum.Asc)
                query = query.OrderByPropertyName(order.Field, OrderByType.Asc);
            else
                query = query.OrderByPropertyName(order.Field, OrderByType.Desc);

        RefAsync<int> total = 0;
        var list = await query.ToPageListAsync(args.Offset, args.Limit, total);
        args.Total = total;

        return list;
    }

    /// <summary>
    /// Queries this instance.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>ISugarQueryable&lt;T&gt;.</returns>
    public ISugarQueryable<T> Query<T>() where T : class, new()
    {
        return client.Queryable<T>();
    }

    /// <summary>
    /// Updates the specified model.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="model">The model.</param>
    public void Update<T>(T model) where T : class, new()
    {
        commands.Add(new Command { CommandType = CommandEnum.Update, DataType = DataEnum.Model, Model = model });
    }

    /// <summary>
    /// Updates the specified model.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="model">The model.</param>
    /// <param name="columns">The columns.</param>
    public void Update<T>(T model, Expression<Func<T, object>> columns) where T : class, new()
    {
        commands.Add(new Command
            { CommandType = CommandEnum.Update, DataType = DataEnum.Where, Model = model, Where = columns });
    }

    /// <summary>
    /// Updates the specified models.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="models">The models.</param>
    public void Update<T>(List<T> models) where T : class, new()
    {
        commands.Add(new Command { CommandType = CommandEnum.Update, DataType = DataEnum.Model, Model = models });
    }

    /// <summary>
    /// Updates the specified models.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="models">The models.</param>
    /// <param name="columns">The columns.</param>
    public void Update<T>(List<T> models, Expression<Func<T, object>> columns) where T : class, new()
    {
        commands.Add(new Command
            { CommandType = CommandEnum.Update, DataType = DataEnum.Where, Model = models, Where = columns });
    }

    /// <summary>
    /// Updates the specified SQL.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql">The SQL.</param>
    /// <param name="parameters">The parameters.</param>
    public void Update<T>(string sql, object parameters = default!) where T : class, new()
    {
        commands.Add(new Command
            { CommandType = CommandEnum.Update, DataType = DataEnum.SQL, SQL = sql, Parameters = parameters });
    }

    /// <summary>
    /// Gets the type of the DataBase.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <returns>DbType.</returns>
    private static DbType GetDbType(string type)
    {
        return type switch
        {
            "MySql" => DbType.MySql,
            "SqlServer" => DbType.SqlServer,
            "Sqlite" => DbType.Sqlite,
            "Oracle" => DbType.Oracle,
            "PostgreSQL" => DbType.PostgreSQL,
            "Dm" => DbType.Dm,
            "Kdbndp" => DbType.Kdbndp,
            "Oscar" => DbType.Oscar,
            _ => DbType.MySql
        };
    }
}